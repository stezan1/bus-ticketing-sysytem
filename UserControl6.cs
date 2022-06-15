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
    public partial class UserControl6 : UserControl
    {
        public UserControl6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("enter 6 digit code sent to your email");

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
