using System;
using Xamarin.Forms;

namespace NavigationExamples
{
class TabPage : TabbedPage
{
    public TabPage()
    {
        this.Title = "Tabs Using TabbedPage";
        this.Children.Add(new FirstPage());
        this.Children.Add (new SecondPage());
        this.Children.Add(new ThirdPage());
    }
}

}
