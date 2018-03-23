using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//referencias para exportar a excel
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;

namespace Presentacion
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
            //Cpptura el evento cuando cierra el formulario de insertar cliente, para actualizar el datagrid
            this.client.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmClient_FormClosed);
            //Cpptura el evento cuando cierra el formulario de Editar cliente, para actualizar el datagrid
            this.nclient.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmClient_FormClosed);
        }

        //Se llama la entidad cliente para guardar los doatos seleccionados en el datagrid, para guardar temporalmente y desbloquear las opciones de eliminar o editar un cliente
        public Entidades.ECliente datos = new Entidades.ECliente();
        //se usara para agregar un nuevo cliente
        private FrmCliente client = new FrmCliente();
        //se udara en el caso de editar un cliente
        private FrmCliente nclient = new FrmCliente();

        //se guardan los datos de la fila seleccionada en el grid en la clase Ecliente
        private void GVCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btneditar.Enabled = true;//se habilita la opcion de editar cliente
            btneliminar.Enabled = true;//se habilita la opcion de eliminar cliente
            //se guardan los datos en las variables temporalmente en lacapa  entidad de clientes, hasta ser usados
            datos.IdCliente = Convert.ToInt32(GVCliente.Rows[e.RowIndex].Cells["IdCliente"].Value.ToString());
            datos.Nombres = GVCliente.Rows[e.RowIndex].Cells["Nombres"].Value.ToString();
            datos.Apellidos = GVCliente.Rows[e.RowIndex].Cells["Apellidos"].Value.ToString();
            datos.Cedula = GVCliente.Rows[e.RowIndex].Cells["Cedula"].Value.ToString();
            datos.Direccion = GVCliente.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
            datos.Telefono = Convert.ToInt32(GVCliente.Rows[e.RowIndex].Cells["Telefono"].Value.ToString());
            datos.Fechaingreso = Convert.ToDateTime(GVCliente.Rows[e.RowIndex].Cells["Fechaingreso"].Value.ToString());
            datos.observaciones = GVCliente.Rows[e.RowIndex].Cells["observaciones"].Value.ToString();
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            //se manda a abrir el formulario para ingresar cliente
            nclient.ShowDialog();
        }
        //al capturar el cierre del formulario se realizara lo siguiente
        private void FrmClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            //se deshabilita tanto elimoinar como editar
            btneditar.Enabled = false; btneliminar.Enabled = false;
            //se actualiza el datagrid
            CargarGrid();
        }
        private void btneditar_Click(object sender, EventArgs e)
        {
            //se envia al formulario de cliente para saber que la accoin sera editar y no agregar uno nuevo
            datos.op = "E";
            //se transfieren todos los datos de la fila seleccionada en el datagrid al formulario cliente
            client._datos = datos;
            // se muestra el formulario
            client.ShowDialog();
        }

        // metodo para cargar el datagrid 
        private void CargarGrid()
        {
            try
            {
                Negocio.NCliente negocioCliente = new Negocio.NCliente();
                List<Entidades.ECliente> lista = negocioCliente.ObtenerListaCliente();
                var resulta = (from e in lista
                               select new { e.IdCliente, e.Nombres, e.Apellidos, e.Cedula, e.Direccion, e.Telefono, e.Fechaingreso, e.observaciones }).ToList();
                GVCliente.DataSource = null;
                GVCliente.DataSource = resulta;
                GVCliente.Columns["IdCliente"].Visible = false;//se oculta el campo IdCliente, para no ser visible en el datagrid
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Seguro que desea eliminar los datos?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Entidades.ECliente EliminarCliente = new Entidades.ECliente();
                    EliminarCliente.IdCliente = datos.IdCliente;
                    Negocio.NCliente negocioCliente = new Negocio.NCliente();
                    negocioCliente.Eliminar(EliminarCliente);
                    CargarGrid();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btneditar.Enabled = false; btneliminar.Enabled = false;
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            exporta_a_excel();
            Cursor.Current = Cursors.Default;
        }
        public void exporta_a_excel()
        {
            try
            { 
                if (progressbar != null)
                {
                    progressbar.MaximumValue = GVCliente.RowCount;
                    progressbar.Value = 0;
                    if (!progressbar.Visible) progressbar.Visible = true;
                }
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);
                int ColumnIndex = 0;
                foreach (DataGridViewColumn col in GVCliente.Columns)
                {
                    ColumnIndex++;
                    excel.Cells[1, ColumnIndex] = col.Name;
                }
                int rowIndex = 0;
                foreach (DataGridViewRow row in GVCliente.Rows)
                {
                    rowIndex++;
                    ColumnIndex = 0;
                    foreach (DataGridViewColumn col in GVCliente.Columns)
                    {
                        ColumnIndex++;
                        excel.Cells[rowIndex + 1, ColumnIndex] = row.Cells[col.Name].Value;
                    }
                        progressbar.Value += 1;
                }
                excel.Visible = true;
                Excel.Worksheet worksheet = (Excel.Worksheet)excel.ActiveSheet;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            finally
            {
                if (progressbar != null)
                {
                    progressbar.Value = 0;
                    progressbar.Visible = false;
                }
            }
        }
        public void ExportToExcel(DataGridView dgView, ns1.BunifuProgressBar pBar)
        {

            try
            {
                if (pBar != null)
                {
                    pBar.MaximumValue = dgView.RowCount;
                    pBar.Value = 0;
                    if (!pBar.Visible) pBar.Visible = true;
                }
                string sFont = "Verdana";
                int iSize = 8;
                //CREACIÓN DE LOS OBJETOS DE EXCEL
                Excel.Application xlsApp = new Excel.Application();
                Excel.Worksheet xlsSheet;
                Excel.Workbook xlsBook;
                //AGREGAMOS EL LIBRO Y HOJA DE EXCEL
                xlsBook = xlsApp.Workbooks.Add(true);
                xlsSheet = (Excel.Worksheet)xlsBook.ActiveSheet;
                //ESPECIFICAMOS EL TIPO DE LETRA Y TAMAÑO DE LA LETRA DEL LIBRO
                xlsSheet.Rows.Cells.Font.Size = iSize;
                xlsSheet.Rows.Cells.Font.Name = sFont;
                //AGREGAMOS LOS ENCABEZADOS
                int iFil = 0, iCol = 0;
                foreach (DataGridViewColumn column in dgView.Columns)
                    if (column.Visible)
                        xlsSheet.Cells[1, ++iCol] = column.HeaderText;
                //MARCAMOS LAS CELDAS DEL ENCABEZADO EN NEGRITA Y EN COLOR DE RELLENO GRIS
                xlsSheet.get_Range(xlsSheet.Cells[1, 1], xlsSheet.Cells[1, dgView.ColumnCount]).Font.Bold = true;
                xlsSheet.get_Range(xlsSheet.Cells[1, 1], xlsSheet.Cells[1, dgView.ColumnCount]).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Silver);
                //RECORRIDO DE LAS FILAS Y COLUMNAS (PINTADO DE CELDAS) 
                Excel.Range r;
                Color c;
                for (iFil = 0; iFil < dgView.RowCount; iFil++)
                {
                    for (iCol = 0; iCol < dgView.ColumnCount; iCol++)
                    {
                        xlsSheet.Cells[iFil + 2, iCol + 1] = dgView.Rows[iFil].Cells[iCol].Value.ToString();
                        c = dgView.Rows[iFil].Cells[iCol].Style.BackColor;
                        if (!c.IsEmpty)
                        {// COMPARAMOS SI ESTÁ PINTADA LA CELDA (SI ES VERDADERO PINTAMOS LA CELDA)
                            r = (Excel.Range)xlsSheet.Cells[iFil + 2, iCol + 1];
                            xlsSheet.get_Range(r, r).Interior.Color = System.Drawing.ColorTranslator.ToOle(dgView.Rows[iFil].Cells[iCol].Style.BackColor);
                        }
                    }
                    pBar.Value += 1;
                }
                xlsSheet.Columns.AutoFit();
                xlsSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape;
                xlsSheet.PageSetup.PaperSize = Excel.XlPaperSize.xlPaperLetter;
                xlsSheet.PageSetup.Zoom = 80;

                Excel.Range rango = xlsSheet.get_Range(xlsSheet.Cells[1, 1], xlsSheet.Cells[dgView.RowCount + 1, dgView.ColumnCount]);
                rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                rango.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);
                //rango.Cells.AutoFormat(Excel.XlRangeAutoFormat.xlRangeAutoFormatList1, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                xlsApp.Visible = true;
            }
            catch(Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            finally
            {
                if (pBar != null)
                {
                    pBar.Value = 0;
                    pBar.Visible = false;
                }
            }
        }
    }
}
