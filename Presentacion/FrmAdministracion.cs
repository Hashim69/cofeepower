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
    public partial class FrmAdministracion : Form
    {
        public FrmAdministracion()
        {
            InitializeComponent();
        }

        private void btnusuario_Click(object sender, EventArgs e)
        {
            FrmUsuarioN user = new FrmUsuarioN();
            user.ShowDialog();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
