using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LayoutExample.Xaml.Views
{
    public partial class Choices : ContentPage
    {
        public Choices()
        {
            InitializeComponent();
        }

        async void HandleChoice (object sender, EventArgs e)
        {
            var button = sender as Button;

            var typeName = string.Format("LayoutExample.Xaml.Views.{0}", button.Text.Replace(" ", ""));

            var type = Type.GetType(typeName);

            var view = Activator.CreateInstance(type) as Page;

            await Navigation.PushAsync(view);

        }

    }
}

