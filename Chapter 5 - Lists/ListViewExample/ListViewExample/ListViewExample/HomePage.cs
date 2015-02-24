using System;
using Xamarin.Forms;

// Chapter 5 - Xamarin.Forms ListView Examples from 
// Xamarin Mobile Application Development
// a book by Dan Hermes
//
// Published by Apress and available on Amazon: http://www.amazon.com/Xamarin-Mobile-Application-Development-Cross-Platform/dp/1484202155
// Dan's blog with Xamarin tips and book updates: http://www.mobilecsharpcafe.com

namespace ListViewExample
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

            this.Title = "Xamarin.Forms ListView";
            this.Content = new TableView
                {
                    Intent = TableIntent.Menu,
                    Root = new TableRoot
                    {
                        new TableSection("Chapter 5 examples")
                        {
                            new TextCell
                            {
                                Text = "List of Strings",
                                Command = navigateCommand,
                                CommandParameter = typeof(ListViewStrings)
                            },

                            new TextCell
                            {
                                Text = "Data Model",
                                Command = navigateCommand,
                                CommandParameter = typeof(ListViewDataModel)
                            },

                            new TextCell
                            {
                                Text = "Add Image",
                                Command = navigateCommand,
                                CommandParameter = typeof(ListViewImageCell)
                            },

                            new TextCell
                            {
                                Text = "Customize ListView",
                                Command = navigateCommand,
                                CommandParameter = typeof(ListViewCustom)
                            },

                            new TextCell
                            {
                                Text = "Custom with Image",
                                Command = navigateCommand,
                                CommandParameter = typeof(ListViewCustomWithImage)
                            },

                            new TextCell
                            {
                                Text = "Custom with Button",
                                Command = navigateCommand,
                                CommandParameter = typeof(ListViewButton)
                            },

                            new TextCell
                            {
                                Text = "Context Actions",
                                Command = navigateCommand,
                                CommandParameter = typeof(ListViewContextAction)
                            },

                            new TextCell
                            {
                                Text = "Grouping Headers",
                                Command = navigateCommand,
                                CommandParameter = typeof(ListViewGrouped)
                            },

                            new TextCell
                            {
                                Text = "Custom Grouping Headers",
                                Command = navigateCommand,
                                CommandParameter = typeof(ListViewGroupingTemplate)
                            },

                            new TextCell
                            {
                                Text = "Scroll the List",
                                Command = navigateCommand,
                                CommandParameter = typeof(ListViewScroll)
                            },

                            new TextCell
                            {
                                Text = "Optimize Performance",
                                Command = navigateCommand,
                                CommandParameter = typeof(ListViewPerformance)
                            }
                        }

                    }
                };
        }
    }
}
