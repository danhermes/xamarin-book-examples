using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using CustomRenderer;
using CustomRenderer.Droid;

[assembly: ExportRenderer (typeof (CustomButton), typeof (CustomButtonRenderer))]

namespace CustomRenderer.Droid
{
	public class CustomButtonRenderer : ButtonRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Button> e)
		{
			base.OnElementChanged (e);

			if (Control != null) {
				Control.SetBackgroundColor (global::Android.Graphics.Color.Chocolate);
			}
		}
	}
}