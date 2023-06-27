using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_PetCare
{
    internal class PostData
    {
        public PostData() { }
        public PostData(PostData tmp)
        {
            this.PetName = tmp.PetName;
            this.PetSubtype = tmp.PetSubtype;
            this.PetColor = tmp.PetColor;
            this.PetDob = tmp.PetDob;
            this.PetSex = tmp.PetSex;
            this.NameClient = tmp.NameClient;
            this.Email = tmp.Email;
            this.Phone = tmp.Phone;
            this.imgstr = tmp.imgstr;
            this.DatePost = tmp.DatePost;
            this.isAdopted = tmp.isAdopted;
            this.id = tmp.id;
            this.Health_Pet = tmp.Health_Pet;
        }

        public string PetName { get; set; }
        public string PetSubtype { get; set; }
        public string PetColor { get; set; }
        public string PetDob { get; set; }
        public string PetSex { get; set; }
        public string NameClient { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string imgstr { get; set; }
        public string DatePost { get; set; }
        public int id { get; set; }

        public bool isAdopted { get; set; }
        public bool isFinded { get; set;}
        public HealthPet Health_Pet { get; set; }
    }
}
