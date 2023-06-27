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
    public partial class Form_HealthPetInfo : Form
    {

        private HealthPet healthPetInfo;
        public Form_HealthPetInfo(HealthPet currentHealthPet)
        {
            InitializeComponent();
            healthPetInfo = currentHealthPet;

        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(heighttextbox.Text, out double height))
            {
                healthPetInfo.Height = height + "cm";
            }
            else
            {
                // Hiển thị thông báo lỗi cho người dùng
                MessageBox.Show("Please enter a valid height value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (double.TryParse(weighttextbox.Text, out double weight))
            {
                healthPetInfo.Weight = weight + "kg";
            }
            else
            {
                // Hiển thị thông báo lỗi cho người dùng
                MessageBox.Show("Please enter a valid weight value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            healthPetInfo.Vaccinations = Vaccinationstextbox.Text;
            healthPetInfo.PreviousOwner = previousBoss.Text;
            healthPetInfo.FavoriteFood = FavoriteFoodtextbox.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        public HealthPet gethealthpet()
        {
            return healthPetInfo;
        }

        private void Form_HealthPetInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
