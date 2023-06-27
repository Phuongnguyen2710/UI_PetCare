using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Microsoft.Win32;

namespace UI_PetCare
{
    public partial class Form_Register : Form
    {
        public Form_Register()
        {
            InitializeComponent();
        }

        public static string ImageIntoBase64String(PictureBox pbox)
        {
            MemoryStream ms = new MemoryStream();
            pbox.Image.Save(ms, pbox.Image.RawFormat);
            return Convert.ToBase64String(ms.ToArray());
        } //chuyen hinh sang base64


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
                || string.IsNullOrEmpty(guna2TextBox3.Text) || string.IsNullOrEmpty(guna2TextBox4.Text) 
                || Avatar.Image == null)
            {
                //Check all textbox if some are Empty.
                MessageBox.Show("Please specify all data needed.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                string hashPass = ComputeSha256Hash(guna2TextBox2.Text);

                //The User Class
                var user = new User
                {

                    username = guna2TextBox1.Text,
                    password = hashPass,
                    email = guna2TextBox3.Text,
                    phone = guna2TextBox4.Text,
                    location = guna2TextBox5.Text,
                    avatar = ImageIntoBase64String(Avatar),
                    islogin = false,
                };
                if(!id_Leave())
                {

                    //but if you want to have like a unique key use Push not Set.
                    FirebaseResponse response = client.Set("Users/" + guna2TextBox1.Text, user);

                    MessageBox.Show("Register Account Successfully");
                    this.Close();
                    fLogin f1 = new fLogin();
                    f1.Show();
                }

            }
        }

        private bool id_Leave()
        {
            //Identifying if the name is existed or not.
            // From looping it using foreach.

            FirebaseResponse response = client.Get("Users/");
            Dictionary<string, User> getSameId = response.ResultAs<Dictionary<string, User>>();
            foreach (var sameID in getSameId)
            {
                string getsame = sameID.Value.username;
                if (guna2TextBox1.Text == getsame)
                {
                    MessageBox.Show("Name is Already Taken.");
                    guna2TextBox1.Text = string.Empty;
                    return true;
                }

            }

            return false;
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            fLogin f1 = new fLogin();
            f1.Show();
        }

        private void Form_Register_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Focus();

        }

        private void guna2TextBox1_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Focus();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            guna2TextBox2.Focus();
        }

        private void guna2TextBox2_Click(object sender, EventArgs e)
        {
            guna2TextBox2.Focus();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            guna2TextBox3.Focus();

        }

        private void guna2TextBox3_Click(object sender, EventArgs e)
        {
            guna2TextBox3.Focus();

        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            guna2TextBox4.Focus();

        }

        private void guna2TextBox4_Click(object sender, EventArgs e)
        {
            guna2TextBox4.Focus();

        }



        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Avatar.Load(openFileDialog.FileName);
                Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
