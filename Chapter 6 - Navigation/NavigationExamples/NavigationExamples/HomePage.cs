using System;
using Xamarin.Forms;

// Chapter 6 - Xamarin.Forms Navigation Examples from 
// Xamarin Mobile Application Development
// a book by Dan Hermes
//
// Published by Apress and available on Amazon: http://www.amazon.com/Xamarin-Mobile-Application-Development-Cross-Platform/dp/1484202155
// Dan's blog with Xamarin tips and book updates: http://www.mobilecsharpcafe.com

namespace NavigationExamples
{
    class HomePage : ContentPage
    {
        public HomePage()
        {
            Command<Type> navigateCommand = 
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await this.Navigation.PushAsync(page);
                });
            this.Title = "Xamarin.Forms Navigation";
            this.Content = new TableView
                {
                    Intent = TableIntent.Menu,
                    Root = new TableRoot
                    {
                        new TableSection("Chapter 6 examples")
                        {
                            new TextCell
                            {
                                Text = "Hierarchical Navigation Using NavigationPage",
                                Command = navigateCommand,
                                CommandParameter = typeof(NavigationPage1)
                            },

                            new TextCell
                            {
                                Text = "Dropdown Menu Using ToolbarItems",
                                Command = navigateCommand,
                                CommandParameter = typeof(DropdownMenu)
                            },

                            new TextCell
                            {
                                Text = "Modal Navigation Using NavigationPage",
                                Command = navigateCommand,
                                CommandParameter = typeof(ModalPage)
                            },
                            
                            new TextCell
                            {
                                Text = "Alerts Using DisplayAlert",
                                Command = navigateCommand,
                                CommandParameter = typeof(Alerts)
                            },

                            new TextCell
                            {
                                Text = "Drilldown Using ListView by Item",
                                Command = navigateCommand,
                                CommandParameter = typeof(DrilldownListViewByItem)
                            },

                            new TextCell
                            {
                                Text = "Drilldown Using ListView by Page",
                                Command = navigateCommand,
                                CommandParameter = typeof(DrilldownListViewByPage)
                            },

                            new TextCell
                            {
                                Text = "Drilldown TableView for Grouping",
                                Command = navigateCommand,
                                CommandParameter = typeof(DrilldownTableView)
                            },

                            new TextCell
                            {
                                Text = "Popup Menu Using ActionSheet",
                                Command = navigateCommand,
                                CommandParameter = typeof(PopupMenu)
                            },

                            new TextCell
                            {
                                Text = "Disk Persistence Using the Properties Dictionary",
                                Command = navigateCommand,
                                CommandParameter = typeof(PropertiesPage1)
                            },

                            new TextCell
                            {
                                Text = "Using a Static Global Class",
                                Command = navigateCommand,
                                CommandParameter = typeof(GlobalPage1)
                            },

                            new TextCell
                            {
                                Text = "Drilldown Using ListView by Page",
                                Command = navigateCommand,
                                CommandParameter = typeof(DrilldownListViewByPage)
                            },

                            new TextCell
                            {
                                Text = "Drilldown Using TableView",
                                Command = navigateCommand,
                                CommandParameter = typeof(DrilldownTableView)
                            },

                            new TextCell
                            {
                                Text = "Tabs Using TabbedPage",
                                Command = navigateCommand,
                                CommandParameter = typeof(TabPage)
                            },

                            new TextCell
                            {
                                Text = "Data-bound Tabs Using TabbedPage",
                                Command = navigateCommand,
                                CommandParameter = typeof(TabPageDatabound)
                            },

                            new TextCell
                            {
                                Text = "Springboard Using Grid",
                                Command = navigateCommand,
                                CommandParameter = typeof(Springboard)
                            },
                            new TextCell
                            {
                                Text = "Carousel Using CarouselPage",
                                Command = navigateCommand,
                                CommandParameter = typeof(Carousel)
                            }

                        }

                    }
                };

        }
    }
}
