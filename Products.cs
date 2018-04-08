using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            var home = new Form1();
            home.Closed += (s, args) => this.Close();
            home.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
        }
    }
}
