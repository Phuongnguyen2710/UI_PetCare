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

namespace UI_PetCare
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private Form CurrentFormChild;
        private void OpenChildForm(Form ChildForm)
        {
            if (CurrentFormChild != null)
            {
                CurrentFormChild.Close();
            }

            CurrentFormChild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(ChildForm);
            panel2.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLogin f1 = new fLogin();
            f1.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            int x = 477; // 477, 64
            int y = 64;
            panel1.Location = new Point(x, y);

            OpenChildForm(new Form_Adopt());
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //623, 64
            panel1.Location = new Point(623, 64);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //797, 64
            panel1.Location = new Point(791, 64);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Hide();
            guna2TextBox1.Focus();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Hide();
            guna2TextBox1.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            int x = 306; // 306, 65
            int y = 65;
            panel1.Location = new Point(x, y);

            
        }
    }
}
