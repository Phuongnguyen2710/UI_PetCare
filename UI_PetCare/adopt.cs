using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_PetCare
{
    public partial class adopt : Form
    {
        public adopt()
        {
            InitializeComponent();
        }
        PostData obj;
        private int num_id;
        private int copy_num_id;
        private int current_num_id;

        IFirebaseConfig config = new FirebaseConfig

        {
            AuthSecret = "CNajl8mZ9JukaBqYhjcpuBLWmo69j4NiXaM5nQf9",
            BasePath = "https://doannhom7-a71b2-default-rtdb.firebaseio.com/"

        };

        public static Image Base64StringIntoImage(string base64String)
        {
            byte[] imgBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imgBytes))
            {
                Image image = Image.FromStream(ms);
                return new Bitmap(image);
            }
        }


        IFirebaseClient client;

        private async void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            if (num_id == 0) num_id = copy_num_id;
            current_num_id = num_id;
            FirebaseResponse response = await client.GetTaskAsync("Post/" + num_id.ToString());
            PostData obj = response.ResultAs<PostData>();
            num_id--;
            if(obj.isAdopted == false)
            {
                PetName.Text = obj.PetName;
                PetBirth.Text = obj.PetDob;
                PetSex.Text = obj.PetSex;
                PetType.Text = obj.PetSubtype;
                label2.Text = obj.DatePost;
                label1.Text = obj.NameClient;
                string imagestring = obj.imgstr;
                Image image = Base64StringIntoImage(imagestring);
                petImage.Image = image;
                petImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            
        }

        private async void adopt_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse resp = await client.GetTaskAsync("Couter/Node");
            CounterClass get = resp.ResultAs<CounterClass>();
            num_id = Int32.Parse(get.id);
            copy_num_id = num_id;
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(current_num_id.ToString());
            FirebaseResponse response = await client.GetTaskAsync("Post/" + current_num_id.ToString());
            PostData obj = response.ResultAs<PostData>();
            PostData postData = new PostData();
            postData = obj;
            postData.isAdopted = true;

            FirebaseResponse res = await client.UpdateTaskAsync("Post/" + current_num_id.ToString(), postData);
            PostData reusult = res.ResultAs<PostData>();
            MessageBox.Show("This Pet Adopted", "Congart");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
