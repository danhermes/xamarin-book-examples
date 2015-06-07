using System;
using Xamarin.Forms;

// Chapter 7 - Xamarin.Forms Data Binding examples from 
// Xamarin Mobile Application Development
// a book by Dan Hermes
//
// Published by Apress and available on Amazon: http://www.amazon.com/Xamarin-Mobile-Application-Development-Cross-Platform/dp/1484202155
// Dan's blog with Xamarin tips and book updates: http://www.mobilecsharpcafe.com

namespace DataBindingExamples
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

            this.Title = "Xamarin.Forms Data Binding";
            this.Content = new TableView
                {
                    Intent = TableIntent.Menu,
                    Root = new TableRoot
                    {
                        new TableSection("Chapter 7 examples")
                        {
                            new TextCell
                            {
                                Text = "Trivial Data Binding",
                                Command = navigateCommand,
                                CommandParameter = typeof(ItemPage)
                            },

                            new TextCell
                            {
                                Text = "Nontrivial Data Binding",
                                Command = navigateCommand,
                                CommandParameter = typeof(ItemPageUsingTitleViewModel)
                            },

                            new TextCell
                            {
                                Text = "View Model Implementing INotifyPropertyChanged",
                                Command = navigateCommand,
                                CommandParameter = typeof(ItemPageUsingItemViewModel)
                            },

                            new TextCell
                            {
                                Text = "Data Model Implementing INotifyPropertyChanged",
                                Command = navigateCommand,
                                CommandParameter = typeof(ItemPageUsingItemBindable)
                            },

                            new TextCell
                            {
                                Text = "Data Binding to a ListView",
                                Command = navigateCommand,
                                CommandParameter = typeof(ListViewPage)
                            },

                            new TextCell
                            {
                                Text = "Deleting Rows from a ListView",
                                Command = navigateCommand,
                                CommandParameter = typeof(ListObservablePage)
                            },

                            new TextCell
                            {
                                Text = "Editing Properties in a ListView",
                                Command = navigateCommand,
                                CommandParameter = typeof(ListPropertiesPage)
                            },

                            new TextCell
                            {
                                Text = "Edtiable ListView Bound to a View Model",
                                Command = navigateCommand,
                                CommandParameter = typeof(ListPageUsingListViewModel)
                            }   
                        }

                    }
                };
        }
    }
}
