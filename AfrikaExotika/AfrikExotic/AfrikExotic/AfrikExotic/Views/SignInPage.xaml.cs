using AfrikExotic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AfrikExotic.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignInPage : ContentPage
    {
        public SignInPage(SignInViewModel SignInViewModel)
        {
            this.BindingContext = SignInViewModel;
            InitializeComponent();
        }

        void RegisterLabel_Tapped(object sender, EventArgs args)
        {
            registerStackLayout.IsVisible = true;
            loginStackLayout.IsVisible = false;
        }

        void LoginLabel_Tapped(object sender, EventArgs args)
        {
            registerStackLayout.IsVisible = false;
            loginStackLayout.IsVisible = true;
        }
    }
}