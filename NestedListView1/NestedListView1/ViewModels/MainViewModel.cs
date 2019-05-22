using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using NestedListView1.Models;
using Xamarin.Forms;

namespace NestedListView1.ViewModels
{
    public class MainViewModel : BaseViewModel
    {

        private ObservableCollection<Owner> items;
        public ObservableCollection<Owner> Items
        {
            get => items;
            set => SetProperty(ref items, value);
        }
        public Command ShowHideStack { get; set; }
        public MainViewModel()
        {
            Items = new ObservableCollection<Owner>();
            ShowHideStack = new Command(async (obj) =>
            {
                var a = obj as Owner;
                if(a != null)
                {
                    a.IsVisible = !a.IsVisible;
                }

                var b = obj as Hotel;
                if (b != null)
                {
                    b.IsVisible = !b.IsVisible;
                }
            });
        }

        public void BuildData()
        {
            Room r1 = new Room() { Name = "Room 1" };
            Room r2 = new Room() { Name = "Room 2" };
            Room r3 = new Room() { Name = "Room 3" };

            Hotel h1 = new Hotel { Name = "Hotel 1" };
            h1.Room.Add(r1);
            h1.Room.Add(r2);
            h1.Room.Add(r3);

            Hotel h2 = new Hotel { Name = "Hotel 2" };
            h2.Room.Add(r1);
            h2.Room.Add(r2);
            h2.Room.Add(r3);

            Hotel h3 = new Hotel { Name = "Hotel 3" };
            h3.Room.Add(r1);
            h3.Room.Add(r2);
            h3.Room.Add(r3);

            Owner o1 = new Owner() { Name = "Owner 1" };
            o1.Hotels.Add(h1);
            o1.Hotels.Add(h2);
            o1.Hotels.Add(h3);

            Owner o2 = new Owner() { Name = "Owner 2" };
            o2.Hotels.Add(h1);
            o2.Hotels.Add(h2);
            o2.Hotels.Add(h3);

            Owner o3 = new Owner() { Name = "Owner 3" };
            o3.Hotels.Add(h1);
            o3.Hotels.Add(h2);
            o3.Hotels.Add(h3);

            Owner o4 = new Owner() { Name = "Owner 4" };
            o4.Hotels.Add(h1);
            o4.Hotels.Add(h2);
            o4.Hotels.Add(h3);

            Items.Add(o1);
            Items.Add(o2);
            Items.Add(o3);
            Items.Add(o4);
        }
    }
}
