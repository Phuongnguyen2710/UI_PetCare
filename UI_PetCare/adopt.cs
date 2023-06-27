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
        //PostData obj;
        private int total_id;
        private int current_num_id = 0;
        private int id_petAdopt = 0;
        private bool isCheck;
        private List<PostData> listPost = new List<PostData>();

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

        public async void curentListPetnotAdopted()
        {
            
            for (int i = 1; i <= total_id; i++)
            {
                FirebaseResponse response = await client.GetTaskAsync("Post/" + i.ToString());
                PostData obj = response.ResultAs<PostData>();
                if (obj.isAdopted == false)
                {
                    listPost.Add(obj);
                }
            }
        }
        public void testOn()
        {
            while (true)
            {
                if (isCheck) curentListPetnotAdopted();
                break;
            }
        }
        private async void next_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                
                MessageBox.Show("Phan tu trong listPost" + listPost.Count);
                if (current_num_id > listPost.Count-1) current_num_id = 0;

                PostData obj = listPost[current_num_id];
                PetName.Text = obj.PetName;
                PetBirth.Text = obj.PetDob;
                PetSex.Text = obj.PetSex;
                PetType.Text = obj.PetSubtype;
                Height.Text = obj.Health_Pet.Height;
                Weight.Text = obj.Health_Pet.Weight;
                Vaccine.Text = obj.Health_Pet.Vaccinations;
                preOwner.Text = obj.Health_Pet.PreviousOwner;
                label2.Text = obj.DatePost;
                label1.Text = obj.NameClient;
                string imagestring = obj.imgstr;
                Image image = Base64StringIntoImage(imagestring);
                petImage.Image = image;
                petImage.SizeMode = PictureBoxSizeMode.StretchImage;
                id_petAdopt = obj.id;
                current_num_id++;
            } catch { }
           
        }

        private async void adopt_Load(object sender, EventArgs e)
        {
            
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse resp = await client.GetTaskAsync("Couter/Node");
            CounterClass get = resp.ResultAs<CounterClass>();
            total_id = Int32.Parse(get.id);
            curentListPetnotAdopted();

        }

        private async void Adopt_ButtonClick(object sender, EventArgs e)
        {
            
            MessageBox.Show("ID = " + id_petAdopt.ToString());
            FirebaseResponse response = await client.GetTaskAsync("Post/" + id_petAdopt.ToString());
            PostData obj = response.ResultAs<PostData>();
            PostData postData = new PostData();
            postData = obj;
            postData.isAdopted = true;
            FirebaseResponse res = await client.UpdateTaskAsync("Post/" + id_petAdopt.ToString(), postData);
            PostData reusult = res.ResultAs<PostData>();
            isCheck = true;
            listPost.Clear();
            testOn();
            isCheck = false;
            MessageBox.Show("This Pet Adopted", "Congarts");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
