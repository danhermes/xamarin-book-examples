using System;
using System.Windows.Media;
using Xamarin.Forms.Platform.WinPhone;
using Xamarin.Forms;
using CustomRenderer;
using CustomRenderer.WinPhone;

[assembly: ExportRenderer(typeof(CustomButton), typeof(CustomButtonRenderer))]

namespace CustomRenderer.WinPhone
{
    public class CustomButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                var customButton = (System.Windows.Controls.Button)Control;
                customButton.Background = new SolidColorBrush(Colors.Orange);
            }
        }
    }
}
