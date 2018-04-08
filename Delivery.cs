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
    public partial class Delivery : Form
    {
        public Delivery()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            label12.Text = "Delivery timelines vary depending on your city and your selected product.";
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            var home = new Form1();
            home.Closed += (s, args) => this.Close();
            home.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            label13.Text = "Estimated delivery times depend on the location of the seller.";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label14.Text = "Yes! Your parcel can be delivered to any address convenient for you.";
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            label16.Text = "We will send you regular updates about the status of your order via emails and SMS.";
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            label15.Text = "We accept Cash on Delivery in all cities across Pakistan.";
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            label17.Text = "You can request for your order to be delivered to a different address within the same region or city before your order is shipped.";
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            label18.Text = "No need to worry. We will help you replace your order at no extra cost.";
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void Delivery_Load(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
