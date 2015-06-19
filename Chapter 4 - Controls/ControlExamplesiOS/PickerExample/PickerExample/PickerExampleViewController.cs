using System;
using System.Drawing;
using System.Collections.Generic;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace PickerExample
{
	public partial class PickerExampleViewController : UIViewController
	{
		public PickerExampleViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			string selectedColor = "";

			PickerModel model = new PickerModel();
			model.ValueChanged += (sender, e) => {
				selectedColor = model.SelectedItem;
			};

			UIPickerView picker = new UIPickerView();
			picker.ShowSelectionIndicator = false;
			picker.BackgroundColor = UIColor.White;
			picker.Model = model;

			this.color.Text = model.SelectedItem;

			UIToolbar toolbar = new UIToolbar();
			toolbar.BarStyle = UIBarStyle.Default;
			toolbar.Translucent = true;
			toolbar.SizeToFit();

			UIBarButtonItem doneButton = new UIBarButtonItem("Done", UIBarButtonItemStyle.Done,
				(s, e) => {
					this.color.Text = selectedColor;
					this.color.ResignFirstResponder();
				});
			toolbar.SetItems(new UIBarButtonItem[]{doneButton}, true);

			this.color.InputView = picker;

			this.color.InputAccessoryView = toolbar;
		}

		public class PickerModel : UIPickerViewModel
		{
			private readonly IList<string> items = new List<string>
			{
				"Red",
				"Blue",
				"Green",
				"Yellow",
				"Black"
			};

			public event EventHandler<EventArgs> ValueChanged;

			protected int selectedIndex = 0;

			public PickerModel() 
			{

			}

			public string SelectedItem
			{
				get { return items[selectedIndex]; }
			}

			public override int GetComponentCount (UIPickerView picker)
			{
				return 1;
			}

			public override int GetRowsInComponent (UIPickerView picker, int component)
			{
				return items.Count;
			}

			public override string GetTitle (UIPickerView picker, int row, int component)
			{
				return items[row];
			}

			public override float GetRowHeight (UIPickerView picker, int component)
			{
				return 40f;
			}

			public override void Selected (UIPickerView picker, int row, int component)
			{
				selectedIndex = row;
				if (this.ValueChanged != null)
				{
					this.ValueChanged (this, new EventArgs ());
				}
			}

		}
	}
}

