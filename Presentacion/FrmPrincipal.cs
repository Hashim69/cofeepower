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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            Cursor.Current = Cursors.Default;
        }
        private void AddFormInPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                Invoke(new Action(() => this.panelContenedor.Controls.RemoveAt(0)));
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            Invoke(new Action(() => this.panelContenedor.Controls.Add(fh)));
            this.panelContenedor.Tag = fh;
            Invoke(new Action(() => fh.Show()));
        }
        public void shrink()
        {
            pnlherramientas.Height = -1; pnlventas.Height = -1;pnlcaja.Height = -1;pnlcompra.Height = -1;pnladmin.Height = -1; pnlgestion.Height = -1;
        }
        private void btncerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir de la aplicacion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { }
            else { Application.Exit(); }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir de la aplicacion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { }
            else { Application.Exit(); }
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new FrmAdministracion());
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            AddFormInPanel(new FrmFondo());
            shrink();
        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            shrink();
            pnlventas.Height = 67;
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            AddFormInPanel(new FrmClientes());
            Cursor.Current = Cursors.Default;
        }
    }
}
