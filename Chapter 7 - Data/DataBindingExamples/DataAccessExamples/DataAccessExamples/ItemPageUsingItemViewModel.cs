using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace DataBindingExamples
{
    public class ItemPageUsingItemViewModel : ContentPage
    {
        public ItemPageUsingItemViewModel()
        {
            var itemViewModel = new ItemViewModel();
            itemViewModel.Title = "First";
            this.BindingContext = itemViewModel;

            var titleEntry = new Entry()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            titleEntry.SetBinding(Entry.TextProperty, new Binding("Title"));

            Button buttonDisplay = new Button
            {
                Text = "Display Item Value",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
            };

            buttonDisplay.Clicked += async (sender, args) =>
            {
                await DisplayAlert("Item Object", "Title property:" + itemViewModel.Title.ToString(), "OK");
            };

            Button buttonUpdate = new Button
            {
                Text = "Update the Data Model",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
            };

            buttonUpdate.Clicked += async (sender, args) =>
            {
                itemViewModel.Title = "Updating the data model!";
                await DisplayAlert("Item Object", "Title property:" + itemViewModel.Title.ToString(), "OK");
            };


            Content = new StackLayout
            {
                Children = { titleEntry, buttonDisplay, buttonUpdate }
            };

        }
    }
}
