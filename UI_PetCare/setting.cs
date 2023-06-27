using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class setting : Form
    {
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
                try
                {
                    await Task.Run(() =>
                    {
                        FirebaseResponse response = client.Get("Users/" + ShareVariable.Username);
                        Dictionary<string, User> result = response.ResultAs<Dictionary<string, User>>();

                        foreach (var get in result)
                        {

                            //update du lieu len firebase

                            
                        }


                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void setting_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }
    }
}
