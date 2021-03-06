﻿using AfrikExotic.ViewModels;
using AfrikExotic.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AfrikExotic
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BindingContext = new MainViewModel();
            InitializeComponent();
        }

        async void OnSignInOutClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignInPage(new SignInViewModel()));
        }

        private void OnOpenChariotPageClicked(object sender, EventArgs e)
        {

        }
    }
}
