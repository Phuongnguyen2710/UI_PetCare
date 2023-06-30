using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using System.Timers;
using Guna.UI2.WinForms;
using static System.Windows.Forms.DataFormats;

namespace UI_PetCare
{
    public partial class Form2 : Form
    {
        private System.Windows.Forms.Timer timer;
        public Form2()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000;
            timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            this.Hide();

            Form3 form3 = new Form3();
            form3.maskedTextBox1.Text = guna2TextBox1.Text;

            form3.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer.Start();   
            guna2TextBox1.SelectionStart = 0;
            guna2TextBox1.SelectionLength = 0;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
