using System;
using Xamarin.Forms;

// Chapter 5 - Xamarin.Forms ListView Examples from 
// Xamarin Mobile Application Development
// a book by Dan Hermes
//
// Published by Apress and available on Amazon: http://www.amazon.com/Xamarin-Mobile-Application-Development-Cross-Platform/dp/1484202155
// Dan's blog with Xamarin tips and book updates: http://www.mobilecsharpcafe.com

namespace NavigationExamples
{
    class DrilldownTableView : ContentPage
    {
        public DrilldownTableView()
        {
            Command<Type> navigateCommand = 
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await this.Navigation.PushAsync(page);
                });

            this.Title = "Drilldown List Using TableView";
            this.Content = new TableView
                {
                    Intent = TableIntent.Menu,
                    Root = new TableRoot
                    {
                        new TableSection("Hindi")
                        {
                            new TextCell
                            {
                                Text = "Prathama",
                                Command = navigateCommand,
                                CommandParameter = typeof(FirstPage)
                            },

                            new TextCell
                            {
                                Text = "Dūsarā",
                                Command = navigateCommand,
                                CommandParameter = typeof(SecondPage)
                            },

                            new TextCell
                            {
                                Text = "Tīsarā",
                                Command = navigateCommand,
                                CommandParameter = typeof(ThirdPage)
                            }
                        },
                        
                        new TableSection("Español")
                        {
                            new TextCell
                            {
                                Text = "Primero",
                                Command = navigateCommand,
                                CommandParameter = typeof(FirstPage)
                            },

                            new TextCell
                            {
                                Text = "Segundo",
                                Command = navigateCommand,
                                CommandParameter = typeof(SecondPage)
                            },

                            new TextCell
                            {
                                Text = "Tercera",
                                Command = navigateCommand,
                                CommandParameter = typeof(ThirdPage)
                            }
                        },
                        
                        new TableSection("English")
                        {
                            new TextCell
                            {
                                Text = "First",
                                Command = navigateCommand,
                                CommandParameter = typeof(FirstPage)
                            },

                            new TextCell
                            {
                                Text = "Second",
                                Command = navigateCommand,
                                CommandParameter = typeof(SecondPage)
                            },

                            new TextCell
                            {
                                Text = "Third",
                                Command = navigateCommand,
                                CommandParameter = typeof(ThirdPage)
                            }
                        }

                    }
                };
        }
    }
}
