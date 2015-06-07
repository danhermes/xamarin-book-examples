using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace DataBindingExamples
{
    class ListPageUsingListViewModel : ContentPage
    {
        public ListPageUsingListViewModel()
        {
            var listView = new ListView();

            var items = new ListViewModel();
            listView.ItemsSource = items.Items;

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
                items.Items[0].Title = "First Edited";
                await DisplayAlert("Edited", "First row edited", "OK");
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
                items.Items.RemoveAt(0);
                await DisplayAlert("Delete", "Row deleted", "OK");
            };

            Button buttonReplace= new Button
            {
                Text = "Replace List",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
            };

            buttonReplace.Clicked += async (sender, args) =>
            {
                items.Replace();
                await DisplayAlert("Replace", "List replaced con Español", "OK");
                listView.ItemsSource = items.Items;
            };

            Content = new StackLayout
            {
                Children = { buttonEdit, buttonDelete, buttonReplace, listView }
            };

            this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

        }
    }

}
