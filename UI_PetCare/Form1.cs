using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace UI_PetCare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Configure FirebaseConfig
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "BFp0TAb8sUuV5tkaRZDWlk5NzOdrFLJWr2NkqPxt",
            BasePath = "https://registerandlogin-31e76-default-rtdb.firebaseio.com/"

        };
        //Firebase Client
        IFirebaseClient client;

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Login

            if (string.IsNullOrEmpty(guna2TextBox1.Text) || string.IsNullOrEmpty(guna2TextBox2.Text))
            {
                // Check if textbox is Empty
                MessageBox.Show("Please Put Username or Password.");
            }
            else
            {
                try
                {
                    //Looping to get the match data using foreach
                    FirebaseResponse response = client.Get("Users/");
                    Dictionary<string, register> result = response.ResultAs<Dictionary<string, register>>();

                    foreach (var get in result)
                    {
                        string userresult = get.Value.username;
                        string passresult = get.Value.password;

                        if (guna2TextBox1.Text == userresult)
                        {

                            if (guna2TextBox2.Text == passresult)
                            {

                                MessageBox.Show("Welcome " + guna2TextBox1.Text);
                                //Declare some public string so you can pass the data to the another Frame.
                                this.Hide();
                                Form2 f2 = new Form2();
                                f2.guna2TextBox1.Text = this.guna2TextBox1.Text;
                                f2.ShowDialog();

                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
                this.Hide();
                Form_Register f3 = new Form_Register();
                f3.ShowDialog();
            }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void guna2TextBox1_Click(object sender, EventArgs e)
        {
            textBox1.Hide();
        }

        private void guna2TextBox2_Click(object sender, EventArgs e)
        {
            textBox2.Hide();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Focus();
            textBox1.Hide();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            guna2TextBox2.Focus();
            textBox2.Hide();
        }
    }
}
