using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DoumaZone
{
    public partial class welcome_page : Form
    {
        public welcome_page()
        {
            InitializeComponent();
        }

        private void welcome_page_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                admin_login admin = new admin_login();
                admin.Show();
                this.Hide();
            }

            else if (radioButton2.Checked)
            {
                event_co_login eventco = new event_co_login();
                eventco.Show();
                this.Hide();
            }


            else
                MessageBox.Show("Please select one of the options above before submitting.");
        }
    }
}
