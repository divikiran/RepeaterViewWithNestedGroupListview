using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using NestedListView1.ViewModels;

namespace NestedListView1.Models
{
    public class Owner : BaseViewModel

    {
        private bool isVisible;

        public bool IsVisible { get => isVisible; set => SetProperty(ref isVisible, value); }
        public string Name { get; set; }
        public ObservableCollection<Hotel> Hotels { get; set; }

        public Owner()
        {
            Hotels = new ObservableCollection<Hotel>();
        }
    }
}
