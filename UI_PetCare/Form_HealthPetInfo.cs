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

            healthPetInfo.Height = heighttextbox.Text + "cm";
            healthPetInfo.Weight = weighttextbox.Text + "kg";
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
