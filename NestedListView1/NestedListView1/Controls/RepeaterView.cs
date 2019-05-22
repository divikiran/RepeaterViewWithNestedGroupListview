using System;
using System.Collections;
using Xamarin.Forms;

namespace NestedListView1.Controls
{
    public class RepeaterView : StackLayout
    {
        public static readonly BindableProperty ItemTemplateProperty = BindableProperty.Create(
            nameof(ItemTemplate),
            typeof(DataTemplate),
            typeof(RepeaterView),
            default(DataTemplate));

        public static readonly BindableProperty ItemsSourceProperty = BindableProperty.Create(
            nameof(ItemsSource),
            typeof(ICollection),
            typeof(RepeaterView),
            null,
            BindingMode.OneWay,
            propertyChanged: ItemsChanged);

        public RepeaterView()
        {
            Spacing = 0;
        }

        public ICollection ItemsSource
        {
            get => (ICollection)GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        public DataTemplate ItemTemplate
        {
            get => (DataTemplate)GetValue(ItemTemplateProperty);
            set => SetValue(ItemTemplateProperty, value);
        }

        protected virtual View ViewFor(object item)
        {
            try
            {
                View view = null;

                if (ItemTemplate != null)
                {
                    var content = ItemTemplate.CreateContent();

                    view = content is View ? content as View : ((ViewCell)content).View;

                    view.BindingContext = item;
                }

                return view;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void ItemsChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (!(bindable is RepeaterView control)) return;

            control.Children.Clear();

            var items = (ICollection)newValue;

            if (items == null) return;

            foreach (var item in items)
            {
                control.Children.Add(control.ViewFor(item));
            }
        }
    }
}
