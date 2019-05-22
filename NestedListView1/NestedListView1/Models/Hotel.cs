using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using NestedListView1.ViewModels;

namespace NestedListView1.Models
{
    public class Hotel : BaseViewModel
    {
        public string Name { get; set; }
        private bool isVisible;

        public bool IsVisible { get => isVisible; set => SetProperty(ref isVisible, value); }
        public ObservableCollection<Room> Room { get; set; }

        public Hotel()
        {
            Room = new ObservableCollection<Room>();
        }
    }
}
