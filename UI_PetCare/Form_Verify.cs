using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace UI_PetCare
{
    public partial class Form_Verify : Form
    {
        public Form_Verify()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(ShareVariable.OTP == guna2TextBox2.Text.ToString())
            {
                Form_ResetPass rp = new Form_ResetPass();
                this.Hide();
                rp.ShowDialog();

            }
            else
            {
                MessageBox.Show("Your code is wrong!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_FgtPass form = new Form_FgtPass();
            form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
