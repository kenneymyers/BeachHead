using System;
using System.Collections.Generic;
using BeachHead.ViewModels;
using Xamarin.Forms;

namespace BeachHead.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
    }
}
