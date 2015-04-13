using System;
using Xamarin.Forms;

namespace LayoutExample
{
	class FrameExample : ContentPage
	{
        public FrameExample()
		{
            this.Padding = 20;
            this.Content = new Frame {
                Content = new Label { Text = "Framed", FontSize = 40 },
              OutlineColor = Color.Red
            };

        }
    }
}
