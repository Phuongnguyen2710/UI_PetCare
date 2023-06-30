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
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Guna.UI2.WinForms;

namespace UI_PetCare
{
    public partial class Form_post : Form
    {
        public Form_post()
        {
            InitializeComponent();
        }
        private static Random random = new Random();
        private static List<int> usedIds = new List<int>();
        private static bool isadopted;
        private static bool isfinded;
        private static HealthPet healthPet = new HealthPet();
        public static string ImageIntoBase64String(PictureBox pbox)
        {
            MemoryStream ms = new MemoryStream();
            pbox.Image.Save(ms, pbox.Image.RawFormat);
            return Convert.ToBase64String(ms.ToArray());
        } //chuyen hinh sang base64


        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "CNajl8mZ9JukaBqYhjcpuBLWmo69j4NiXaM5nQf9",
            BasePath = "https://doannhom7-a71b2-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private int GenerateUniqueId()
        {
            int id = random.Next(1, 10000); // Tạo số ngẫu nhiên trong khoảng từ 1000 đến 9999

            while (usedIds.Contains(id))
            {
                id = random.Next(1, 10000); // Nếu số đã được sử dụng, tạo lại số ngẫu nhiên khác
            }

            usedIds.Add(id); // Đánh dấu số đã được sử dụng
            return id;
        }
        private void Form_post_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            NameClientTextBox.Text = ShareVariable.Username;
            EmailTextBox.Text = ShareVariable.Email;
            PhoneTextBox.Text = ShareVariable.Phone;

            NameClientTextBox.Enabled = false;
            EmailTextBox.Enabled = false;
            PhoneTextBox.Enabled = false;
            bttMoreDetail.Enabled = false;
        }

        private void btt_Click_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picturepet.Load(openFileDialog.FileName);
                picturepet.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private async void PostButton_Click(object sender, EventArgs e)
        {
            FirebaseResponse resp = await client.GetTaskAsync("Couter/Node");
            CounterClass get = resp.ResultAs<CounterClass>();
           
            DateTime currentDate = DateTime.Now;
            string dateString = currentDate.ToString("dd/MM/yyyy");

            if (string.IsNullOrEmpty(PetNameTextBox.Text) || string.IsNullOrEmpty(PetSubtypeTextBox.Text) ||
            string.IsNullOrEmpty(PetColorTextBox.Text) || string.IsNullOrEmpty(PetDofTextBox.Text) ||
            string.IsNullOrEmpty(PetSexTextBox.Text) || string.IsNullOrEmpty(NameClientTextBox.Text) ||
            string.IsNullOrEmpty(EmailTextBox.Text) || string.IsNullOrEmpty(PhoneTextBox.Text) ||
            picturepet.Image == null)
            {
                // Check if textbox is Empty
                MessageBox.Show("Please Put Full Information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    PostData pd = new PostData()
                    {
                        PetName = PetNameTextBox.Text,
                        PetSubtype = PetSubtypeTextBox.Text,
                        PetColor = PetColorTextBox.Text,
                        PetDob = PetDofTextBox.Text,
                        PetSex = PetSexTextBox.Text,
                        NameClient = NameClientTextBox.Text,
                        Email = EmailTextBox.Text,
                        Phone = PhoneTextBox.Text,
                        DatePost = dateString,
                        isAdopted = isadopted,
                        isFinded = isfinded,
                        Health_Pet = healthPet,
                        id = Convert.ToInt32(get.id) + 1,
                        imgstr = ImageIntoBase64String(picturepet)
                    };
                    int Id = Convert.ToInt32(get.id) + 1;

                    var set = client.Set("Post/" + Id, pd);
                    MessageBox.Show("Post Successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    //Clear all info
                    PetNameTextBox.Clear();
                    PetSubtypeTextBox.Clear();
                    PetColorTextBox.Clear();
                    PetDofTextBox.Clear();
                    NameClientTextBox.Clear();
                    EmailTextBox.Clear();
                    PhoneTextBox.Clear();
                    picturepet.Image = null;
                    PetSexTextBox.Clear();

                    var obj = new CounterClass
                    {
                        id = Id.ToString()
                    };

                    SetResponse response = await client.SetTaskAsync("Couter/Node", obj);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }

        }

        private void status_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Post for adopting pet
            if (status.SelectedItem.ToString() == "Post for adopting pet")
            {
                isadopted = false;
                isfinded = true;
                bttMoreDetail.Enabled = true;
            }
            else
            {
                isfinded = false;
                isadopted = true;
                bttMoreDetail.Enabled = false;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Hiển thị Form_HealthPetInfo để lấy thông tin về HealthPet
            Form_HealthPetInfo healthPetForm = new Form_HealthPetInfo(healthPet);
            DialogResult result = healthPetForm.ShowDialog();

            // Kiểm tra xem người dùng có nhấn nút OK hay không
            if (result == DialogResult.OK)
            {
                // Lấy thông tin HealthPet từ Form_HealthPetInfo
                healthPet = healthPetForm.gethealthpet();
            }
        }
    }
}
