using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bus_ticketing_sysytem
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Username and password is correct ");
            this.Hide();
            home f2 =new home();
            f2.ShowDialog();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl61.BringToFront();
            userControl61.Show();

        }

        private void loginform_Load(object sender, EventArgs e)
        {
            groupBox1.Show();
            pictureBox1.Show();
            userControl71.Hide();
            userControl71.Hide();
            userControl61.Hide();
            userControl61.Hide();
        }
    }
}
