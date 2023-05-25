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
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace UI_PetCare
{
    public partial class Form_Register : Form
    {
        public Form_Register()
        {
            InitializeComponent();
        }
        IFirebaseConfig config = new FirebaseConfig
        {

            AuthSecret = "BFp0TAb8sUuV5tkaRZDWlk5NzOdrFLJWr2NkqPxt",
            BasePath = "https://registerandlogin-31e76-default-rtdb.firebaseio.com/"

        };

        IFirebaseClient client;

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Register

            if (string.IsNullOrEmpty(guna2TextBox1.Text) || string.IsNullOrEmpty(guna2TextBox2.Text)
                || string.IsNullOrEmpty(guna2TextBox3.Text) || string.IsNullOrEmpty(guna2TextBox4.Text))
            {
                //Check all textbox if some are Empty.
                MessageBox.Show("Please Specify All Data Needed.");
            }
            else
            {

                //The Register Class
                var register = new register
                {

                    username = guna2TextBox1.Text,
                    password = guna2TextBox2.Text,
                    email = guna2TextBox3.Text,
                    phone = guna2TextBox4.Text,

                };

                //but if you want to have like a unique key use Push not Set.
                FirebaseResponse response = client.Set("Users/" + guna2TextBox1.Text, register);

                register res = response.ResultAs<register>();
                MessageBox.Show("Register Account Successfully");
                guna2TextBox1.Text = string.Empty;
                guna2TextBox2.Text = string.Empty;
                guna2TextBox3.Text = string.Empty;
                guna2TextBox4.Text = string.Empty;

            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Form_Register_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Focus();
            textBox1.Hide();

        }

        private void guna2TextBox1_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Focus();
            textBox1.Hide();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            guna2TextBox2.Focus();
            textBox2.Hide();
        }

        private void guna2TextBox2_Click(object sender, EventArgs e)
        {
            guna2TextBox2.Focus();
            textBox2.Hide();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            guna2TextBox3.Focus();
            textBox3.Hide();
        }

        private void guna2TextBox3_Click(object sender, EventArgs e)
        {
            guna2TextBox3.Focus();
            textBox3.Hide();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            guna2TextBox4.Focus();
            textBox4.Hide();
        }

        private void guna2TextBox4_Click(object sender, EventArgs e)
        {
            guna2TextBox4.Focus();
            textBox4.Hide();
        }
    }
}
