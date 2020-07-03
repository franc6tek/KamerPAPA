using System;
using System.Collections.Generic;
using System.Text;

namespace AfrikExotic.Models
{
    public class Utilisateur
    {
        private Guid idClient;
        public Guid IdClient
        {
            get { return idClient; }
            set
            {
                idClient = value;
            }
        }

        private Guid nomUtilisateur;
        public Guid NomUtilisateur
        {
            get { return nomUtilisateur; }
            set
            {
                nomUtilisateur = value;
            }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }

        private string adresse;
        public string Adresse
        {
            get { return adresse; }
            set
            {
                adresse = value;
            }
        }

        private string codePostal;
        public string CodePostal
        {
            get { return codePostal; }
            set
            {
                codePostal = value;
            }
        }

        private string phone;
        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
            }
        }

        private bool isAdmin;
        public bool IsAdmin
        {
            get { return isAdmin; }
            set
            {
                isAdmin = value;
            }
        }
    }
}
