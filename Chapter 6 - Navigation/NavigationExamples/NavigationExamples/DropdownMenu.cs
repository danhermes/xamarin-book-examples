using System;
using Xamarin.Forms;

namespace NavigationExamples
{
    class DropdownMenu: ContentPage
    {
        public DropdownMenu()  
        {
            Title = "Dropdown Using ToolbarItems";

            ToolbarItems.Clear();
            ToolbarItems.Add(new ToolbarItem {
                    Text = "Home",
                    Order = ToolbarItemOrder.Secondary,
                    Command = new Command(() => Navigation.PushAsync(new NavigationPage1()))
            });
            ToolbarItems.Add(new ToolbarItem {
                Text = "Second",
                Order = ToolbarItemOrder.Secondary,
                Command = new Command(() => Navigation.PushAsync(new NavigationPage2()))
            });
        }
    }
}
