using AfrikExotic.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AfrikExotic.ViewModels
{
    class MainViewModel : ViewModelBase
    {

        private string testText;
        public string TestText
        {
            get { return testText; }
            set
            { 
                Set(ref testText, value);
            }
        }

        private List<Article> articles;
        public List<Article> Articles
        {
            get { return articles; }
            set 
            { 
                Set(ref articles, value);
            }
        }

        public ICommand SignInCommand { get; set; }

        public MainViewModel()
        {
            SignInCommand = new RelayCommand(ExecuteSignInCommand);
            this.articles = new List<Article>
            {
                new Article{NomArticle = "Plantain", Categorie = "Alimentaire",
                    Description = "Banane plantain en provenance d'afrique. Vendu en Carton de 24 kg",
                Prix = 25, Photo = "AfrikExotic.Images.Plantain.png", IdArticle = Guid.NewGuid()},
                new Article{NomArticle = "Taro", Categorie = "Alimentaire",
                    Description = "Taro en provenance d'amerique du sud. Vendu par lot de 10 kg",
                Prix = 20, Photo = "", IdArticle = Guid.NewGuid()},
                 new Article{NomArticle = "Poivre Blanc", Categorie = "Alimentaire",
                    Description = "Poivre blanc en provenance du Cameroun vendu par lot de 5 kg",
                Prix = 20, Photo = "", IdArticle = Guid.NewGuid()}
            };

        }

        private void ExecuteSignInCommand()
        {
          
        }
    }
}
