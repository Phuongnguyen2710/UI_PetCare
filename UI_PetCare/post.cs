﻿using System;
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
using Guna.UI2.WinForms;

namespace UI_PetCare
{
    public partial class post : Form
    {
        public post()
        {
            InitializeComponent();
        }
        private static Random random = new Random();
        private static List<int> usedIds = new List<int>();
        private void post_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string ImageIntoBase64String(PictureBox pbox)
        {
            MemoryStream ms = new MemoryStream();
            pbox.Image.Save(ms, pbox.Image.RawFormat);
            return Convert.ToBase64String(ms.ToArray());
        }

        public static Image Base64StringIntoImage(string str4)
        {
            byte[] img = Convert.FromBase64String(str4);
            MemoryStream ms = new MemoryStream();
            return Image.FromStream(ms);
        }

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

        private void PostButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PetNameTextBox.Text) || string.IsNullOrEmpty(PetSubtypeTextBox.Text) ||
                string.IsNullOrEmpty(PetColorTextBox.Text)|| string.IsNullOrEmpty(PetDofTextBox.Text)||
                string.IsNullOrEmpty(PetSexTextBox.Text)|| string.IsNullOrEmpty(NameClientTextBox.Text)||
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
                        imgstr = ImageIntoBase64String(picturepet)
                    };
                    string Id = Convert.ToString(GenerateUniqueId());
                    var set = client.Set("Post/" + Id, pd);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}