using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Response;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace UI_PetCare
{
    public partial class Form_FgtPass : Form
    {
        string randomCode;
        public static string to;
        public Form_FgtPass()
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(guna2TextBox1.Text)) MessageBox.Show("Please input your Email!");
            else
            {
                bool verifyemail = false;
                FirebaseResponse response = client.Get("Users/");
                Dictionary<string, User> result = response.ResultAs<Dictionary<string, User>>();
                foreach (var get in result)
                {
                    string usr_email = get.Value.email;
                    if (usr_email == guna2TextBox1.Text)
                    {
                        verifyemail = true;
                        ShareVariable.Email = usr_email;
                        break;
                    }
                }
                if (verifyemail == false) MessageBox.Show("Can not find email!");
                else
                {
                    string from, pass, messbody;
                    Random random = new Random();
                    randomCode = (random.Next(999999)).ToString();
                    if (randomCode.Length != 6)
                    {
                        randomCode = new string('0', 6 - randomCode.Length) + randomCode;
                    }
                    ShareVariable.OTP = randomCode;
                    MailMessage message = new MailMessage();
                    to = guna2TextBox1.Text.ToString();
                    from = "adoptionpet818@gmail.com";
                    pass = "nqrhurlflgaphvqr";
                    messbody = $"Your Password Reset Code is {randomCode}";
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messbody;
                    message.Subject = "Password Reset Code";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);
                    try
                    {
                        smtp.Send(message);
                        MessageBox.Show("Code Successfully Sent");
                        this.Hide();
                        Form_Verify form_Verify = new Form_Verify();
                        form_Verify.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
                   
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            fLogin f1 = new fLogin();
            f1.Show();
        }

       
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form_FgtPass_Load(object sender, EventArgs e)
        {
             client = new FireSharp.FirebaseClient(config);
        }

        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                guna2Button1_Click(this, new EventArgs());
        }
    }
}
