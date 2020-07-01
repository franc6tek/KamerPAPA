using System;
using System.Collections.Generic;
using System.Text;

namespace AfrikExotic.Models
{
    public class Article
    {
        private Guid idArticle;
        public Guid IdArticle
        {
            get { return idArticle; }
            set
            {
                idArticle = value;
            }
        }

        private string nomArticle;
        public string NomArticle
        {
            get { return nomArticle; }
            set
            {
                nomArticle = value;
            }
        }

        private int prix;
        public int Prix
        {
            get { return prix; }
            set
            {
                prix = value;
            }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
            }
        }

        private string categorie;
        public string Categorie
        {
            get { return categorie; }
            set
            {
                categorie = value;
            }
        }

        private string photo;
        public string Photo
        {
            get { return photo; }
            set
            {
                photo = value;
            }
        }
    }
}
