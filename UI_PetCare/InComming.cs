using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_PetCare
{
    public partial class InComming : UserControl
    {
        public InComming()
        {
            InitializeComponent();
        }
        public string Message
        {
            get
            {
                return guna2TextBox1.Text;
            }
            set
            {
                guna2TextBox1.Text = value;
            }

        }
        public Image Avatar
        {
            get
            {
                return guna2CirclePictureBox1.Image;
            }
            set
            {
                guna2CirclePictureBox1.Image = value;
            }
        }
    }
}
