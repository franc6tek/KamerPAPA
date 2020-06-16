using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KamerPAP.Models
{
	public class Annonce
	{
		public int AnnonceId { get; set; }
		public string Titre { get; set; }
		public string Description { get; set; }
		public DateTime DateCreation { get; set; }
		public string Ville { get; set; }
		public int Prix { get; set; }
		public string Telephone { get; set; }
    }
}
