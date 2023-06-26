using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        IFirebaseClient client;
        //Configure FirebaseConfig
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "BFp0TAb8sUuV5tkaRZDWlk5NzOdrFLJWr2NkqPxt",
            BasePath = "https://registerandlogin-31e76-default-rtdb.firebaseio.com/"
        };

        public static System.Drawing.Image Base64StringIntoImage(string base64String)
        {
            byte[] imgBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imgBytes))
            {
                System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                return new Bitmap(image);
            }
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
            panel1.Location = new Point(370, 54);
            OpenChildForm(new adopt());
        }

        private void label5_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(465, 54);
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(610, 54);
            OpenChildForm(new Form_post());

        }


        private void label3_Click(object sender, EventArgs e)
        {

            panel1.Location = new Point(228, 54);
            panel2.Controls.Clear();

        }



        private async void Form3_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            FirebaseResponse response = await client.GetTaskAsync("Users/" + maskedTextBox1.Text);
            User user = response.ResultAs<User>();
            if (user.avatar != null)
            {
                AvatarPic.Image = Base64StringIntoImage(user.avatar);
               
            }
  
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_ChatBox());
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new setting());
        }
    }
}
