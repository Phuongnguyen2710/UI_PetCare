using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace UI_PetCare
{
    public partial class find : Form
    {
        public find() => InitializeComponent();

        private int total_id;
        private int current_num_id = 0;
        private int id_petFind = 0;
        private bool isCheck;
        private List<PostData> listPost = new List<PostData>();

        IFirebaseClient client;
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

        private async void next_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (current_num_id > listPost.Count - 1) current_num_id = 0;

                PostData obj = listPost[current_num_id];
                PetName.Text = obj.PetName;
                PetBirth.Text = obj.PetDob;
                PetSex.Text = obj.PetSex;
                PetType.Text = obj.PetSubtype;
                petHeight.Text = obj.Health_Pet.Height;
                Weight.Text = obj.Health_Pet.Weight;
                Vaccine.Text = obj.Health_Pet.Vaccinations;
                preOwner.Text = obj.Health_Pet.PreviousOwner;
                label2.Text = obj.DatePost;
                label1.Text = obj.NameClient;
                string imagestring = obj.imgstr;
                Image image = Base64StringIntoImage(imagestring);
                petImage.Image = image;
                petImage.SizeMode = PictureBoxSizeMode.StretchImage;
                id_petFind = obj.id;
                current_num_id++;
            }
            catch { }
            Adopt_Button.Enabled = true;
        }

        public async void curentListPetnotFound()
        {
            for (int i = 1; i <= total_id; i++)
            {
                FirebaseResponse response = await client.GetTaskAsync("Post/" + i.ToString());
                PostData obj = response.ResultAs<PostData>();
                if (obj.isFinded == false)
                    listPost.Add(obj);
            }
        }

        private async void find_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse resp = await client.GetTaskAsync("Couter/Node");
            CounterClass get = resp.ResultAs<CounterClass>();
            total_id = Int32.Parse(get.id);
            curentListPetnotFound();
        }

        private async void Find_ButtonClick(object sender, EventArgs e)
        {

            //MessageBox.Show("ID = " + id_petAdopt.ToString());
            FirebaseResponse response = await client.GetTaskAsync("Post/" + id_petFind.ToString());
            PostData obj = response.ResultAs<PostData>();
            PostData postData = new PostData();
            postData = obj;
            postData.isFinded = true;
            FirebaseResponse res = await client.UpdateTaskAsync("Post/" + id_petFind.ToString(), postData);
            PostData result = res.ResultAs<PostData>();
            isCheck = true;
            listPost.Clear();
            testOn();
            isCheck = false;
            MessageBox.Show("You have found your lost pet, congrats!", "Congarts");

            string postEmail = result.Email;
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "BFp0TAb8sUuV5tkaRZDWlk5NzOdrFLJWr2NkqPxt",
                BasePath = "https://registerandlogin-31e76-default-rtdb.firebaseio.com/"
            };
            IFirebaseClient Client;
            Client = new FireSharp.FirebaseClient(config);
            MailMessage message = new MailMessage();
            string from, pass, messbody;
            from = "adoptionpet818@gmail.com";
            pass = "nqrhurlflgaphvqr";
            string to = postEmail;
            string petName = PetName.Text;
            string user = ShareVariable.Username;
            FirebaseResponse response1 = await Client.GetTaskAsync("Users/" + user);
            User usr = response1.ResultAs<User>();
            string usremail = usr.email;
            string usrphone = usr.phone;
            string usrlocation = usr.location;
            messbody = $"The pet named {petName} in your post was found by its owner.\nHere is the owner's information\n     Name: {user}\n     Email: {usremail}\n     Phone number: {usrphone}\n     Location: {usrlocation}";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messbody;
            message.Subject = "Pet Found";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Your info has been sent to the post user");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Adopt_Button.Enabled = false;
        }

        public void testOn()
        {
            while (true)
            {
                if (isCheck) curentListPetnotFound();
                break;
            }
        }
    }
}
