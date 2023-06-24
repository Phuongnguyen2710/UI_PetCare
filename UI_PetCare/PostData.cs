using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_PetCare
{
    internal class PostData
    {
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
        public bool isAdopted { get; set; }
    }
}
