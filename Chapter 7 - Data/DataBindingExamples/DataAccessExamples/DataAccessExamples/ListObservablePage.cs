using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace DataBindingExamples
{
    class ListObservablePage : ContentPage
    {
        public ListObservablePage()
        {
            var listView = new ListView();
            var items = new ObservableCollection<Item> { 
				new Item {Title = "First", Description="1st item"}, 
				new Item {Title = "Second", Description="2nd item"},
				new Item {Title = "Third", Description="3rd item"} 
			};
            listView.ItemsSource = items;
            listView.ItemTemplate = new DataTemplate(typeof(TextCell));
            listView.ItemTemplate.SetBinding(TextCell.TextProperty, "Title");
            listView.ItemTemplate.SetBinding(TextCell.DetailProperty, "Description");

            listView.ItemTapped += async (sender, e) =>
            {
                Item item = (Item)e.Item;
                await DisplayAlert("Tapped", item.Title.ToString() + " was selected.", "OK");
                ((ListView)sender).SelectedItem = null;
            };

            Button buttonDelete = new Button
            {
                Text = "Delete Row ",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
            };

            buttonDelete.Clicked += async (sender, args) =>
            {
                items.RemoveAt(0);
                await DisplayAlert("Item Object", "Row deleted", "OK");
            };

            Content = new StackLayout
            {
                Children = { buttonDelete, listView }
            };

            this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

        }
    }

}
