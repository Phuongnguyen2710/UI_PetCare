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
using System.Security.Cryptography;
using System.IO;

namespace UI_PetCare
{
    public partial class fLogin : Form
    { 
        public fLogin() => InitializeComponent();

        //Configure FirebaseConfig
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "BFp0TAb8sUuV5tkaRZDWlk5NzOdrFLJWr2NkqPxt",
            BasePath = "https://registerandlogin-31e76-default-rtdb.firebaseio.com/"
        };

        //Firebase Client
        IFirebaseClient client;
        string avatarimg = "";//lay avater tu firebase
        string email, phone;


        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            // Login

            if (string.IsNullOrEmpty(guna2TextBox1.Text) || string.IsNullOrEmpty(guna2TextBox2.Text))
            {
                // Check if textbox is Empty
                MessageBox.Show("Please Put Username or Password.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    await Task.Run(() =>
                    {
                        FirebaseResponse response = client.Get("Users/");
                        Dictionary<string, User> result = response.ResultAs<Dictionary<string, User>>();

                        bool login = false;
                        bool check = true; // check islogin
                        foreach (var get in result)
                        {
                            string user_result = get.Value.username;
                            string pass_result = get.Value.password;
                            avatarimg = get.Value.avatar;
                            email = get.Value.email;
                            phone = get.Value.phone;
                            string hashPass = ComputeSha256Hash(guna2TextBox2.Text);
                            if (guna2TextBox1.Text == user_result && hashPass == pass_result )
                            {
                                if (get.Value.islogin != true)
                                {
                                    login = true;
                                    check = true;
                                    get.Value.islogin = true;
                                    var updateResponse = client.Update("Users/" + get.Key, get.Value);
                                    break;
                                }
                                else
                                {
                                    MessageBox.Show("You have already login!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    check = false;
                                    break;
                                }

                            }
                        }

                        Invoke(new Action(() =>
                        {
                            if (login)
                            {
                                MessageBox.Show("Welcome " + guna2TextBox1.Text, "Login sucessfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ShareVariable.Username = guna2TextBox1.Text;
                                ShareVariable.Phone = phone;
                                ShareVariable.Email = email;
                                this.Hide();
                                Form2 f2 = new Form2();
                                f2.guna2TextBox1.Text = this.guna2TextBox1.Text;
                                f2.ShowDialog();
                            }
                            else if (check)
                            {
                                MessageBox.Show("Incorrect username or password.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }));
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Show password using Checkbox
            if (checkBox1.Checked)
            {
                guna2TextBox2.PasswordChar = '\0';
            }
            else
            {
                guna2TextBox2.PasswordChar = '*';
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_FgtPass form_FgtPass = new Form_FgtPass();
            form_FgtPass.ShowDialog();
        }


    }
}
