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
    public partial class CMS : Form
    {
        public CMS()
        {
            InitializeComponent();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CMS_Load(object sender, EventArgs e)
        {

        }

   

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void change(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Parent.BackColor = Color.Gainsboro;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void CMS_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Parent.BackColor = Color.Transparent;
        }

    }
}
