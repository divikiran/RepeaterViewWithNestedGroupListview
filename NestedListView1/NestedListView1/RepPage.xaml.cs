using System;
using System.Collections.Generic;
using NestedListView1.ViewModels;
using Xamarin.Forms;

namespace NestedListView1
{
    public partial class RepPage : ContentPage
    {
        public MainViewModel ViewModel { get; set; }
        public RepPage()
        {
            InitializeComponent();
            ViewModel = new MainViewModel();
            ViewModel.BuildData();
            BindingContext = ViewModel;

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

        }
    }
}
