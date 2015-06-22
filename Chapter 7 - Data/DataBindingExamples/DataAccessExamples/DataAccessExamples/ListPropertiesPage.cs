using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace DataBindingExamples
{
    class ListPropertiesPage : ContentPage
    {
        public ListPropertiesPage()
        {
            var listView = new ListView();
            var items = new List<ObservableItem> { 
				new ObservableItem {Title = "First", Description="1st item"}, 
				new ObservableItem {Title = "Second", Description="2nd item"},
				new ObservableItem {Title = "Third", Description="3rd item"} 
			};
            listView.ItemsSource = items;
            listView.ItemTemplate = new DataTemplate(typeof(TextCell));
            listView.ItemTemplate.SetBinding(TextCell.TextProperty, "Title");
            listView.ItemTemplate.SetBinding(TextCell.DetailProperty, "Description");

            listView.ItemTapped += async (sender, e) =>
            {
                ObservableItem item = (ObservableItem)e.Item;
                await DisplayAlert("Tapped", item.Title.ToString() + " was selected.", "OK");
                ((ListView)sender).SelectedItem = null;
            };

            Button buttonEdit = new Button
            {
                Text = "Edit Row ",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
            };

            buttonEdit.Clicked += async (sender, args) =>
            {
                items[0].Title = "First Edited";
                await DisplayAlert("Item Object", "First row edited", "OK");
            };

            Content = new StackLayout
            {
                Children = { buttonEdit, listView }
            };

            this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

        }
    }

}
