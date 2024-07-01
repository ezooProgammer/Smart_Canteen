using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SmartCanteen
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int starting = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            starting += 1;
            progressBar1.Value = starting;
            Percentage.Text = "" + starting;
            if (progressBar1.Value == 50)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                login l = new login();
                this.Hide();
                l.Show();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
