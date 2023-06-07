using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

namespace UI_PetCare
{
    public partial class Form_ChatBox : Form
    {
        public Form_ChatBox()
        {
            InitializeComponent();
        }
        string UserInbox;
        int ID = 0;
        string ChatIDrcv = "";
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "BFp0TAb8sUuV5tkaRZDWlk5NzOdrFLJWr2NkqPxt",
            BasePath = "https://registerandlogin-31e76-default-rtdb.firebaseio.com/"
        };

        //Firebase Client
        IFirebaseClient client;
        /* private void UserItem()
         {
             flowLayoutPanel1.Controls.Clear();
             FirebaseResponse response = client.Get("Users/");
             Dictionary<string, User> result = response.ResultAs<Dictionary<string, User>>();
             int count = 0;
             foreach (var get in result)
             {
                 count++;
             }
             if(count > 0)
             {
                 UserControl1[] usercontrols = new UserControl1[count];
                 for(int i=0;i<1;i++)
                 { 
                     foreach (var item in result)
                     {
                         string usr_username = item.Value.username;
                         usercontrols[i] = new UserControl1();
                         usercontrols[i].Title = usr_username;
                         if (usercontrols[i].Title == ShareVariable.Username)
                         {
                             continue;
                         }
                         else
                         {
                             flowLayoutPanel1.Controls.Add(usercontrols[i]);
                         }
                         usercontrols[i].Click += userControl11_Click;
                     }
                 }
             }
         }*/
        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_ChatBox_Load(object sender, EventArgs e)
        {

            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = client.Get("Users/");
            Dictionary<string, User> result = response.ResultAs<Dictionary<string, User>>();
            foreach (var get in result)
            {
                string usr_username = get.Value.username;
                if (usr_username == ShareVariable.Username) continue;
                ListViewItem listViewItem = new ListViewItem(usr_username);
                listView1.Items.Add(listViewItem);
            }
            guna2Panel1.Visible = false;
            guna2Panel2.Visible = false;
            guna2Panel3.Visible = false;
                
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            guna2Panel4.Controls.Clear();
            String Name = listView1.SelectedItems[0].Text;
            label1.Text = Name;
            UserInbox = Name;
            guna2Panel1.Visible = true;
            guna2Panel2.Visible = true;
            guna2Panel3.Visible = true;
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text != "")
            {
                ID++;
                var chat = new Chat()
                {
                    username1 = ShareVariable.Username,
                    username2 = UserInbox,
                    message = guna2TextBox1.Text,
                    chatid = ID.ToString(),
                };
                FirebaseResponse response = client.Set("Chat/" + UserInbox, chat);
                addOutgoing(guna2TextBox1.Text);
                guna2TextBox1.Text = "";

            }
        }
        void addOutgoing(string message)
        {
            var bubble = new OutGoing();
            guna2Panel4.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Message = message;
            guna2Panel4.ScrollControlIntoView(bubble);
        }
        void addIncoming(string message)
        {
            var bubble = new InComming();
            guna2Panel4.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Message = message;
            bubble.Avatar = guna2CirclePictureBox1.Image;
            guna2Panel4.ScrollControlIntoView(bubble);
           
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            FirebaseResponse response = client.Get("Chat/");
            if (response .Body == "null" ) 
            {
                //MessageBox.Show("K có dữ liệu");
                return;
            }
            else
            {
                Dictionary<string, Chat> result = response.ResultAs<Dictionary<string, Chat>>();
                string mess = "";
                string id = "";
                foreach (var get in result)
                {
                    string usr1 = get.Value.username1;
                    string usr2 = get.Value.username2;
                    if (usr1 == UserInbox && usr2 == ShareVariable.Username)
                    {
                        id = get.Value.chatid;
                        //MessageBox.Show(id.ToString());
                        mess = get.Value.message;
                        break;
                    }
                }
                if (ChatIDrcv != id)
                {
                    addIncoming(mess);

                    ChatIDrcv = id;

                }

            }
        }

        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                guna2PictureBox1_Click(this, new EventArgs());
        }
    }
}
