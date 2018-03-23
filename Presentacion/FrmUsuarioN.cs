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
    public partial class FrmUsuarioN : Form
    {
        public FrmUsuarioN()
        {
            InitializeComponent();
        }
        string estado="";
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtpassc.Text == "" || txtpass.Text == "" || txtuser.Text == "")
            {
                MessageBox.Show("Asegurece de llenar todos los campos","Importante",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            if (swestado.Value == true) { estado = "A"; } else { estado = "B"; }
            if (txtpass.Text == txtpassc.Text)
            {
                try
                {
                    Entidades.EUsuario insertarUsuario = new Entidades.EUsuario();
                    insertarUsuario.Idperfil = Convert.ToInt32(1);
                    insertarUsuario.Name_User = txtuser.Text.Trim();
                    insertarUsuario.Key_User = txtpass.Text.Trim();
                    insertarUsuario.Estado = estado;
                    Negocio.NUsuario negocioCliente = new Negocio.NUsuario();
                    negocioCliente.GuardarNuevo(insertarUsuario);
                    MessageBox.Show("Se han guardado correctamente los datos", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiartextbox();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Limpiartextbox();
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
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
        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
