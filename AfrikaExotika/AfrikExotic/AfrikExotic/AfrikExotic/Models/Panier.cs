using System;
using System.Collections.Generic;
using System.Text;

namespace AfrikExotic.Models
{
    public class Panier
    {
        private Guid idPanier;
        public Guid IdPanier
        {
            get { return idPanier; }
            set
            {
                idPanier = value;
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

        private int quantiteArticle;
        public int QuantiteArticle
        {
            get { return quantiteArticle; }
            set
            {
                quantiteArticle = value;
            }
        }
    }
}
