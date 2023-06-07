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
    public partial class OutGoing : UserControl
    {
        public OutGoing()
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
    }
}
