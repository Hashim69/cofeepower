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
    public partial class FrmPreload : Form
    {
        public FrmPreload()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuProgressBar1.Value += 1; if (bunifuProgressBar1.Value == 200)
            {
                this.timer1.Stop();
                FrmLogin l = new FrmLogin();
                l.Show();
                this.Hide();
            }
        }

        private void FrmPreload_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
