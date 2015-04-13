using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LayoutExample.Xaml.Views
{
    public partial class RelativeLayoutExample : ContentPage
    {
        public RelativeLayoutExample()
        {
            InitializeComponent();

            Label below = new Label
                {
                    Text = "Below Upper Left",
                    FontSize = 15
                };

            LayoutContainer.Children.Add(below,
                Constraint.Constant(0),
                Constraint.RelativeToView(UpperLeft, (parent, sibling) =>
                    {
                        return sibling.Y + sibling.Height;
                    })
            );
        }
    }
}

