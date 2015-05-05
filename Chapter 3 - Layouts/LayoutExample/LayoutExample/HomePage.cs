using System;
using Xamarin.Forms;

// Chapter 3 - Xamarin.Forms Layout Examples from 
// Xamarin Mobile Application Development
// a book by Dan Hermes
//
// Published by Apress and available on Amazon: http://www.amazon.com/Xamarin-Mobile-Application-Development-Cross-Platform/dp/1484202155
// Dan's blog with Xamarin tips and book updates: http://www.mobilecsharpcafe.com

namespace LayoutExample
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

            this.Title = "Xamarin.Forms Layouts";
            this.Content = new TableView
                {
                    Intent = TableIntent.Menu,
                    Root = new TableRoot
                    {
                        new TableSection("Chapter 3 examples")
                        {
                            new TextCell
                            {
                                Text = "StackLayout Horizontal",
                                Command = navigateCommand,
								CommandParameter = typeof(StackLayoutHorizontal)
                            },

							new TextCell
							{
								Text = "StackLayout Vertical",
								Command = navigateCommand,
								CommandParameter = typeof(StackLayoutVertical)
							},

                            new TextCell
                            {
                                Text = "RelativeLayout",
                                Command = navigateCommand,
								CommandParameter = typeof(RelativeLayoutExample)
                            },

                            new TextCell
                            {
                                Text = "AbsoluteLayout",
                                Command = navigateCommand,
                                CommandParameter = typeof(AbsoluteLayoutExample)
                            },

                            new TextCell
                            {
                                Text = "Grid",
                                Command = navigateCommand,
                                CommandParameter = typeof(GridExample1)
                            },

                            new TextCell
                            {
							Text = "Grid Using GridUnitType.Absolute",
                                Command = navigateCommand,
								CommandParameter = typeof(GridExample2)
                            },

                            new TextCell
                            {
							Text = "Grid using GridUnitType.Star",
                                Command = navigateCommand,
                                CommandParameter = typeof(GridExample3)
                            },

                            new TextCell
                            {
								Text = "ContentView",
                                Command = navigateCommand,
                                CommandParameter = typeof(ContentViewExample)
                            },

                            new TextCell
                            {
                                Text = "Frame",
                                Command = navigateCommand,
                                CommandParameter = typeof(FrameExample)
                            }
                        }

                    }
                };
        }
    }
}
