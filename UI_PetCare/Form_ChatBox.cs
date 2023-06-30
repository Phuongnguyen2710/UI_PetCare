using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
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
            CheckForIllegalCrossThreadCalls = false;//tránh việc đụng độ khi sử dụng tài nguyên giữa các thread
            Connect();
        }
        IPEndPoint IP;
        Socket Client;

        //kết nối đến server
        void Connect()
        {
            //IP là địa chỉ của server.Khởi tạo địa chỉ IP và socket để kết nối
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            //bắt đầu kết nôi. Nếu ko kết nối được thì hiện thông báo
            try
            {
                Client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //tạo luồng lắng nghe server khi vừa kết nối tới
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        //đóng kết nối đến server
        void Close()
        {
            Client.Close();
        }

        //gửi dữ liệu
        void Send()
        {
            string text = ShareVariable.Username + ": " + guna2TextBox2.Text;
            //nếu textboc khác rỗng thì mới gửi tin
            if (guna2TextBox2.Text != string.Empty)
            {
                Client.Send(Serialize(text));
                ListViewItem item = new ListViewItem("");
                item.SubItems.Add(guna2TextBox2.Text);
                listView2.Items.Add(item);
                guna2TextBox2.Text = string.Empty;
            }
        }

        //nhận dữ liệu
        void Receive()
        {
            try
            {
                while (true)
                {
                    //khai báo mảng byte để nhận dữ liệu dưới mảng byte
                    byte[] data = new byte[1024 * 5000];
                    Client.Receive(data);
                    //chuyển data từ dạng byte sang dạng string
                    string message = (string)Deseriliaze(data);
                    ListViewItem item = new ListViewItem(message);
                    item.SubItems.Add("");
                    listView2.Items.Add(item);
                }
            }
            catch
            {
                Close();
            }
        }

        //Hàm phân mảnh dữ liệu cần gửi từ dạng string sang dạng byte để gửi đi
        byte[] Serialize(object obj)
        {
            //khởi tạo stream để lưu các byte phân mảnh
            MemoryStream stream = new MemoryStream();
            //khởi tạo đối tượng BinaryFormatter để phân mảnh dữ liệu sang kiểu byte
            BinaryFormatter formatter = new BinaryFormatter();
            //phân mảnh rồi ghi vào stream
            formatter.Serialize(stream, obj);
            //từ stream chuyển các các byte thành dãy rồi cbi gửi đi
            return stream.ToArray();
        }

        //Hàm gom mảnh các byte nhận được rồi chuyển sang kiểu string để hiện thị lên màn hình
        object Deseriliaze(byte[] data)
        {
            //khởi tạo stream đọc kết quả của quá trình phân mảnh 
            MemoryStream stream = new MemoryStream(data);
            //khởi tạo đối tượng chuyển đổi
            BinaryFormatter formatter = new BinaryFormatter();
            //chuyển đổi dữ liệu và lưu lại kết quả 
            return formatter.Deserialize(stream);
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
            guna2Panel5.Visible = false;
            panel1.Visible = false;
        }


        private void guna2Panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            guna2Panel4.Controls.Clear();
            label3.Visible = false;
            label1.Visible = true;
            String Name = listView1.SelectedItems[0].Text;
            label1.Text = Name;
            UserInbox = Name;
            guna2Panel1.Visible = true;
            guna2Panel2.Visible = true;
            guna2Panel3.Visible = true;
            guna2Panel4.Visible = true;
            guna2Panel5.Visible = false;
            guna2CirclePictureBox1.Visible = true;
            panel1.Visible=false;
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
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

        private void label2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            guna2Panel2.Visible = true;
            guna2Panel5.Visible = true;
            guna2CirclePictureBox1.Visible = false;
            guna2Panel3.Visible = false;
            guna2Panel4.Visible = false;
            label3.Visible = true;
            label1.Visible = false;
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            columnHeader2.Text = string.Empty;
            columnHeader3.Text = string.Empty;
            columnHeader2.Width = 350;
            columnHeader3.Width = 400;
            columnHeader3.TextAlign = HorizontalAlignment.Right;
            listView2.Columns.Add(columnHeader2);
            listView2.Columns.Add(columnHeader3);
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void guna2TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                guna2PictureBox2_Click(this, new EventArgs());
        }

        private void Form_ChatBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close();
        }
    }
}
