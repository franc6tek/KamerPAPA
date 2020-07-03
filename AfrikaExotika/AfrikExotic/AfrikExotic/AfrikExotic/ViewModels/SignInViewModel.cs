using AfrikExotic.Models;
using AfrikExotic.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AfrikExotic.ViewModels
{
    public class SignInViewModel : ViewModelBase
    {
        public Utilisateur Utilisateur { get; set; }

        private Guid idClient;
        public Guid IdClient
        {
            get { return idClient; }
            set
            {
                Set(ref idClient, value);
            }
        }

        private string nomUtilisateur;
        public string NomUtilisateur
        {
            get { return nomUtilisateur; }
            set
            {
                Set(ref nomUtilisateur, value);
                RaisePropertyChanged("CanRegister");
            }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                Set(ref email, value);
                RaisePropertyChanged("CanLogin");
                RaisePropertyChanged("CanRegister");
            }
        }

        private string adresse;
        public string Adresse
        {
            get { return adresse; }
            set
            {
                Set(ref adresse, value);
                RaisePropertyChanged("CanRegister");
            }
        }

        private string codePostal;
        public string CodePostal
        {
            get { return codePostal; }
            set
            {
                Set(ref codePostal, value);
                RaisePropertyChanged("CanRegister");
            }
        }

        private string phone;
        public string Phone
        {
            get { return phone; }
            set
            {
                Set(ref phone, value);
                RaisePropertyChanged("CanRegister");
            }
        }

        private bool isAdmin;
        public bool IsAdmin
        {
            get { return isAdmin; }
            set
            {
                Set(ref isAdmin, value);
            }
        }

        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                Set(ref password, value);
                RaisePropertyChanged("CanLogin");
                RaisePropertyChanged("CanRegister");
            }
        }

        private string confirmPassword;
        public string ConfirmPassword
        {
            get
            {
                return confirmPassword;
            }
            set
            {
                Set(ref confirmPassword, value);
                RaisePropertyChanged("CanRegister");
            }
        }

        public bool CanLogin
        {
            get
            {
                return !string.IsNullOrEmpty(Email) 
                    && !string.IsNullOrEmpty(Password);
            }
        }

        public bool CanRegister
        {
            get
            {
                return !string.IsNullOrEmpty(Email) && 
                    !string.IsNullOrEmpty(Password) && 
                    !string.IsNullOrEmpty(ConfirmPassword) && 
                    !string.IsNullOrEmpty(nomUtilisateur) &&
                    !string.IsNullOrEmpty(Phone) && 
                    !string.IsNullOrEmpty(adresse) && 
                    !string.IsNullOrEmpty(CodePostal);
            }
        }

        public ICommand LoginCommand { get; set; }
        public ICommand RegisterCommand { get; set; }

        public SignInViewModel()
        {
            LoginCommand = new RelayCommand(() => Task.Run(ExecuteLoginCommandAsync));
            RegisterCommand = new RelayCommand(() => Task.Run(ExecuteRegisterCommandAsync));
            Utilisateur = new Utilisateur();
        }

        private bool LoginCanExecute()
        {
            return CanLogin;
        }

        private bool RegisterCanExecute()
        {
            return CanRegister;
        }

        private async Task ExecuteLoginCommandAsync()
        {
            bool result = true; // TODO: actually login
            if (result)
            {
                var service = DependencyService.Get<IAuthentificationService>();
                string token = await service.Login(Email, Password);
                // await DisplayAlert("Login", token);
                await Application.Current.MainPage.Navigation.PopAsync();
            }
        }

        private async Task ExecuteRegisterCommandAsync()
        {

            if (ConfirmPassword != Password)
                await App.Current.MainPage.DisplayAlert("Error", "Passwords do not match", "Ok");
            else
            {
                bool result = true; // TODO: actually register
                if (result)
                {
                    var service = DependencyService.Get<IAuthentificationService>();
                    string token = await service.Register(Email, Password);
                    // await DisplayAlert("Login", token, ok);
                    await Application.Current.MainPage.Navigation.PopAsync();
                }
            }
        }
    }
}
