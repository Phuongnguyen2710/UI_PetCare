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

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Login

            if (string.IsNullOrEmpty(guna2TextBox1.Text) || string.IsNullOrEmpty(guna2TextBox2.Text))
            {
                // Check if textbox is Empty
                MessageBox.Show("Please Put Username or Password.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    //Looping to get the match data using foreach
                    FirebaseResponse response = client.Get("Users/");
                    Dictionary<string, User> result = response.ResultAs<Dictionary<string, User>>();

                    bool login = false;
                    foreach (var get in result)
                    {
                        string user_result = get.Value.username;
                        string pass_result = get.Value.password;

                        string hashPass = ComputeSha256Hash(guna2TextBox2.Text);
                        if (guna2TextBox1.Text == user_result && hashPass == pass_result)
                        {
                            login = true;
                            break;
                        }
                    }
                    if (login)
                    {
                        MessageBox.Show("Welcome " + guna2TextBox1.Text);
                        //Declare some public string so you can pass the data to the another Frame.
                        this.Hide();
                        Form2 f2 = new Form2();
                        f2.guna2TextBox1.Text = this.guna2TextBox1.Text;
                        f2.ShowDialog();
                    }
                    else MessageBox.Show("Incorrect username or password.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_FgtPass form_FgtPass = new Form_FgtPass();
            form_FgtPass.ShowDialog();
        }
    }
}
