using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
            dpfecha.Value = DateTime.Now;
        }
        //se reciben los datos por herencia
        public Entidades.ECliente _datos = new Entidades.ECliente();

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_datos.op != "E")//si la opcion recibida no es E (Editar) se guardar un nuevo cliente
                {
                    Entidades.ECliente insertarCliente = new Entidades.ECliente();
                    insertarCliente.Nombres = txtnombre.Text;
                    insertarCliente.Apellidos = txtapellidos.Text;
                    insertarCliente.Cedula = txtcedula.Text;
                    insertarCliente.Direccion = txtdireccion.Text;
                    insertarCliente.Telefono = Convert.ToInt32(txttelefono.Text);
                    insertarCliente.Fechaingreso = Convert.ToDateTime(dpfecha.Value);
                    insertarCliente.observaciones = txtobservaciones.Text;
                    Negocio.NCliente negocioCliente = new Negocio.NCliente();
                    negocioCliente.GuardarNuevo(insertarCliente);
                    if (
                       MessageBox.Show("Se han guardado correctamente los datos ¿Desea Continuar ingresando datos?", "Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    { Limpiartextbox(); txtcedula.Clear(); }else{ this.Close();}
                }
                else
                {
                    Entidades.ECliente modificarCliente = new Entidades.ECliente();
                    modificarCliente.IdCliente = Convert.ToInt32(txtnombre.Tag);
                    modificarCliente.Nombres = txtnombre.Text;
                    modificarCliente.Apellidos = txtapellidos.Text;
                    modificarCliente.Cedula = txtcedula.Text;
                    modificarCliente.Direccion = txtdireccion.Text;
                    modificarCliente.Telefono = Convert.ToInt32(txttelefono.Text);
                    modificarCliente.Fechaingreso = Convert.ToDateTime(dpfecha.Value);
                    modificarCliente.observaciones = txtobservaciones.Text;
                    Negocio.NCliente modificar = new Negocio.NCliente();
                    modificar.Modificar(modificarCliente);
                    MessageBox.Show("Se modifico correctamente los datos");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //metodo para limpiar todos los textbox
        public void Limpiartextbox()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Clear();
                }
            }
        }
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            if (_datos.op == "E")//Si la variable recibida es igual a E(Editar) Se cargaran los campos con sus 
                //respectivos datos para poder modificarlos
            {
                header.color = System.Drawing.Color.Orange;
                lblcliente.Text = "Editar Cliente";
                txtnombre.Tag = _datos.IdCliente;
                txtnombre.Text = _datos.Nombres;
                txtapellidos.Text = _datos.Apellidos;
                txtcedula.Text = _datos.Cedula;
                txtdireccion.Text = _datos.Direccion;
                txttelefono.Text = _datos.Telefono.ToString();
                dpfecha.Value = _datos.Fechaingreso;
                txtobservaciones.Text = _datos.observaciones;
            }
            else
            {
                txtcedula.Clear();
                Limpiartextbox();
            }
            txtnombre.Focus();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            txtcedula.Clear();
            Limpiartextbox();
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
