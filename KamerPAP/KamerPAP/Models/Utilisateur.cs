using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KamerPAP.Models
{
    public class Utilisateur
    {
        public int Id {get;set;}

        public string Email{get;set;}

        public string PassWord { get; set; }

        public string NomUtilisateur { get; set; }

        public bool IsAdmin { get; set; }

    }
}
