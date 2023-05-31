using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Guna.UI2.WinForms;

namespace UI_PetCare
{
    public partial class Form_ResetPass : Form
    {
        //Configure FirebaseConfig
        public Form_ResetPass()
        {
            InitializeComponent();
        }
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "BFp0TAb8sUuV5tkaRZDWlk5NzOdrFLJWr2NkqPxt",
            BasePath = "https://registerandlogin-31e76-default-rtdb.firebaseio.com/"
        };

        //Firebase Client
        IFirebaseClient client;

        private void Form_ResetPass_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if(!guna2TextBox2.UseSystemPasswordChar) guna2TextBox2.UseSystemPasswordChar = true;
            if(!guna2TextBox3.UseSystemPasswordChar) guna2TextBox3.UseSystemPasswordChar = true;
            pictureBox6.Show();
            pictureBox7.Show();
            pictureBox3.Hide();
            pictureBox8.Hide();
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(guna2TextBox2.Text))
            {
                MessageBox.Show("Please input your password!");
            }
            else
            {
                if (guna2TextBox2.Text != guna2TextBox3.Text)
                    MessageBox.Show("Password is not match!");
                else
                {
                    string hashPass = ComputeSha256Hash(guna2TextBox2.Text);
                    try
                    {
                        FirebaseResponse response = client.Get("Users/");
                        Dictionary<string, User> result = response.ResultAs<Dictionary<string, User>>();
                        foreach (var get in result)
                        {
                            string usr_email = get.Value.email;
                            string usr_username = get.Value.username;
                            string usr_phonenumber = get.Value.phone;
                            if (usr_email == ShareVariable.Email)
                            {
                                var user = new User
                                {

                                    username = usr_username,
                                    password = hashPass,
                                    email = usr_email,
                                    phone = usr_phonenumber,

                                };
                                FirebaseResponse response2 = await client.UpdateTaskAsync("Users/" + usr_username, user);
                                User result2 = response2.ResultAs<User>();
                                MessageBox.Show("Reset password successfully. Please back to log in!");
                                this.Hide();
                                fLogin lg = new fLogin();
                                lg.Show();
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }


            }
        }

        private static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_FgtPass form = new Form_FgtPass();
            form.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            guna2TextBox2.UseSystemPasswordChar = true;
            pictureBox3.Hide();
            pictureBox6.Show();
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            guna2TextBox2.UseSystemPasswordChar = false;
            pictureBox6.Hide();
            pictureBox3.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            
           guna2TextBox3.UseSystemPasswordChar = true;
           pictureBox8.Hide();
           pictureBox7.Show();
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
          
                guna2TextBox3.UseSystemPasswordChar = false;
                pictureBox7.Hide();
                pictureBox8.Show();
            
        }
    }
}
