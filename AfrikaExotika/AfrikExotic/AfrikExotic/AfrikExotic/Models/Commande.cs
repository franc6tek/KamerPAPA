using System;
using System.Collections.Generic;
using System.Text;

namespace AfrikExotic.Models
{
    public class Commande
    {
        private Guid idCommande;
        public Guid IdCommande
        {
            get { return idCommande; }
            set
            {
                idCommande = value;
            }
        }

        private Guid idArticle;
        public Guid IdArticle
        {
            get { return idArticle; }
            set
            {
                idArticle = value;
            }
        }

        private Guid idClient;
        public Guid IdClient
        {
            get { return idClient; }
            set
            {
                idClient = value;
            }
        }

        private DateTime dateCommande;
        public DateTime DateCommande
        {
            get { return dateCommande; }
            set
            {
                dateCommande = value;
            }
        }

        private int quantite;
        public int Quantite
        {
            get { return quantite; }
            set
            {
                quantite = value;
            }
        }

        private string adresseLivraison;
        public string AdresseLivraison
        {
            get { return adresseLivraison; }
            set
            {
                adresseLivraison = value;
            }
        }
    }
}
