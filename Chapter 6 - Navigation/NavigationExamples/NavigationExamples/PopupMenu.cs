using System;
using Xamarin.Forms;

namespace NavigationExamples
{
    class PopupMenu : ContentPage
    {

       public PopupMenu() {

         Title = "Popup Menu Using ActionSheet";
        
         Button button = new Button { Text = "Show ActionSheet" };

         Label label = new Label 
         { 
             Text = "",
             FontSize = 20
         };

         button.Clicked += async (sender, e) =>
         {
             String action = await DisplayActionSheet("Options", "Cancel", null, "Here", "There", "Everywhere");
             label.Text = "Action is :" + action;
         };

         StackLayout stackLayout = new StackLayout
         {
             Children = { button, label }

         };

         this.Content = stackLayout;

       }
    
    }
}
