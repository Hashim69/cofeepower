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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            txtusuario.Focus();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                ValidarLogin();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
            int cont = 0;
        public void ValidarLogin()
        {
            if (txtusuario.Text != "" && txtcontraseña.Text != "")
            {
                if (cont < 3)
                {
                    try
                    {
                        Entidades.EUsuario usuario = new Entidades.EUsuario();
                        usuario.Name_User = txtusuario.Text.Trim();
                        usuario.Key_User = txtcontraseña.Text.Trim();
                        Negocio.NUsuario validar = new Negocio.NUsuario();
                        validar.Validarusuario(usuario);
                        if (usuario.Exist == 1)
                        {
                            if (usuario.Estado == "A")
                            {
                                DOTA Logged = DOTA.Instance();
                                Logged.IdUser = usuario.IdUser;
                                Logged.Name_User = txtusuario.Text;
                                this.Hide();
                                FrmPrincipal pr = new FrmPrincipal();
                                pr.Show();
                            }
                            else if (usuario.Estado == "B")
                            {
                                MessageBox.Show("El usuario que ah ingresado esta bloqueado", "Intento fallido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Cursor.Current = Cursors.Default;
                            }
                            else
                            {
                                cont+=1;
                                MessageBox.Show("Los datos ingresados no coinciden", "Intento fallido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Cursor.Current = Cursors.Default;
                            }
                        }
                        else
                        {
                            MessageBox.Show("El usuario ingresado no existe", "Intento fallido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Cursor.Current = Cursors.Default;
                        }
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.ToString());
                    }
                    txtcontraseña.Text = ""; txtusuario.Text = ""; txtusuario.Focus();
                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    if (cont == 3)
                    {
                        MessageBox.Show("AGOTO SUS INTENTOS PERMITIDOS, INTENTELO MAS TARDE.");
                        Application.Exit();
                    }

                }
            }
        }

        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (txtusuario.Text == "")
                {
                    e.Handled = true;
                    SendKeys.Send("{TAB}");
                    txtusuario.Focus();
                    linetickpass.LineThickness = 2;
                    linetickpass.LineColor = Color.DimGray;
                    linetickuser.LineThickness = 3;
                    linetickuser.LineColor = Color.FromArgb(0, 141, 247);
                }
                else
                { ValidarLogin(); }
            }
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                if (txtcontraseña.Text == "")
                {
                    e.Handled = true;
                    SendKeys.Send("{TAB}");
                    txtcontraseña.Focus();
                    linetickuser.LineThickness = 2;
                    linetickuser.LineColor = Color.DimGray;
                    linetickpass.LineThickness = 3;
                    linetickpass.LineColor = Color.FromArgb(0, 141, 247);
                }
                else
                {
                    ValidarLogin();
                }
            }
        }

        private void txtcontraseña_MouseClick(object sender, MouseEventArgs e)
        {
            linetickuser.LineThickness = 2;
            linetickuser.LineColor = Color.DimGray;
            linetickpass.LineThickness = 3;
            linetickpass.LineColor = Color.FromArgb(0, 141, 247);
        }

        private void txtusuario_MouseClick(object sender, MouseEventArgs e)
        {
            linetickpass.LineThickness = 2;
            linetickpass.LineColor = Color.DimGray;
            linetickuser.LineThickness = 3;
            linetickuser.LineColor = Color.FromArgb(0, 141, 247);
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
