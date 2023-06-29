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
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Guna.UI2.WinForms;

namespace UI_PetCare
{
    public partial class setting : Form
    {
        bool isClickedUpload = false;
        public setting()
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

        private async void saveButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(usernametextbox.Text) || string.IsNullOrEmpty(emailtextbox.Text))
            {
                // Check if textbox is Empty
                MessageBox.Show("Please Put Username or Password.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (passtextbox.Text != cfpasstextbox.Text) MessageBox.Show("Password does not match!");
                string hashPass = ComputeSha256Hash(cfpasstextbox.Text);
                try
                {
                    FirebaseResponse res = await client.GetTaskAsync("Users/" + ShareVariable.Username);
                    User usr = res.ResultAs<User>();
                    string usr_avatar = usr.avatar.ToString();
                    if (isClickedUpload)
                    {
                        var user = new User
                        {

                            username = usernametextbox.Text,
                            password = hashPass,
                            email = emailtextbox.Text,
                            phone = phonetextbox.Text,
                            location = locationtextbox.Text,
                            avatar = ImageIntoBase64String(newavatarpic),

                        };
                        FirebaseResponse response2 = await client.UpdateTaskAsync("Users/" + usernametextbox.Text, user);
                    }
                    else
                    {
                        var user = new User
                        {

                            username = usernametextbox.Text,
                            password = hashPass,
                            email = emailtextbox.Text,
                            phone = phonetextbox.Text,
                            location = locationtextbox.Text,
                            avatar = usr_avatar,

                        };
                        
                        isClickedUpload = false;
                    FirebaseResponse response2 = await client.UpdateTaskAsync("Users/" + usernametextbox.Text, user);
                    }
                    MessageBox.Show("Update data successfully!");
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
    

        private async void setting_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse res = await client.GetTaskAsync("Users/" + ShareVariable.Username);
            User usr = res.ResultAs<User>();
            usernametextbox.Text = usr.username;
            emailtextbox.Text = usr.email;
            locationtextbox.Text = usr.location;
            phonetextbox.Text = usr.phone;
            if(usr.avatar != null)
            newavatarpic.Image = Base64StringIntoImage(usr.avatar);
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                newavatarpic.Load(openFileDialog.FileName);
                newavatarpic.SizeMode = PictureBoxSizeMode.StretchImage;
                isClickedUpload = true;
            }
        }
        public static string ImageIntoBase64String(PictureBox pbox)
        {
            MemoryStream ms = new MemoryStream();
            pbox.Image.Save(ms, pbox.Image.RawFormat);
            return Convert.ToBase64String(ms.ToArray());
        } //chuyen hinh sang base64
        public static System.Drawing.Image Base64StringIntoImage(string base64String)
        {
            byte[] imgBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imgBytes))
            {
                System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                return new Bitmap(image);
            }
        }
    }
}
