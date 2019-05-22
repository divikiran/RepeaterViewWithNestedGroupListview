using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NestedListView1.ViewModels;
using Xamarin.Forms;

namespace NestedListView1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainViewModel ViewModel { get; set; }
        public MainPage()
        {
            InitializeComponent();
            BindingContext = ViewModel = new MainViewModel();
            ViewModel.BuildData();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

        }
    }
}
