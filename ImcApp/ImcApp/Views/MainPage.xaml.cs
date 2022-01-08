using System;
using Xamarin.Forms;
using ImcApp.Models;
using ImcApp.ViewModels;

namespace ImcApp.Views
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel viewModel;

        public MainPage()
        {
            InitializeComponent();
            viewModel = new MainPageViewModel();
            BindingContext = viewModel;
        }
    }
}
