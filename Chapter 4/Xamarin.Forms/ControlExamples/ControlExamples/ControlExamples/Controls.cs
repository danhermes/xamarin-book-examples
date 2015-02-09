using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ControlExamples
{	
	public partial class Controls : ContentPage
	{	
		Label label;
        Label label2;

       //  Note that there are a couple of options for retrieving the selection value for 
       //  many of these views and those options will be placed in each of the two Label 
       //  views’ Text properties.

        public Controls()
		{
			label = new Label();
			label.Text = "Label";
            label2 = new Label();
            label2.Text = "Label2";


            Picker picker = new Picker
            {
                Title = "Option",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            var options = new List<string> { "First", "Second", "Third", "Fourth" };

            foreach (string optionName in options)
            {
                picker.Items.Add(optionName);
            }

            picker.SelectedIndexChanged += (sender, args) =>
            {
                label.Text = picker.Items[picker.SelectedIndex];
            }; 


			DatePicker datePicker = new DatePicker
			{
				Format = "D",
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			datePicker.DateSelected += (object sender, DateChangedEventArgs e) => 
            {
                label.Text = e.NewDate.ToString();
                label2.Text = datePicker.Date.ToString();
            };


			TimePicker timePicker = new TimePicker
			{
				Format = "T",
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

            // no built-in TimeSelected event so use data-binding PropertyChanged event
            timePicker.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
                {
                    label.Text = timePicker.Time.ToString();
                }
            };

            // Stepper stepper = new Stepper(0 ,10 ,0 , 1);  // alternative declaration
			Stepper stepper = new Stepper
			{
				Minimum = 0,
				Maximum = 10,
				Increment = 0.1,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
            stepper.ValueChanged += (sender, e) =>
            {
                label.Text = String.Format("Stepper value is {0:F1}", e.NewValue);
                label2.Text = stepper.Value.ToString();
            };

            // Slider  slider = new Slider  (0 ,100 ,50); // alternative declaration
			Slider slider = new Slider
			{
				Minimum = 0,
				Maximum = 100,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

            slider.ValueChanged += (sender, e) =>
            {
                label.Text = String.Format("Slider value is {0:F1}", e.NewValue);
                label2.Text = slider.Value.ToString();
            };


			Switch switcher = new Switch
			{
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

            switcher.Toggled += (sender, e) =>
            {
       			label.Text = String.Format("Switch is now {0}", e.Value);
                label2.Text = switcher.IsToggled.ToString();
            };


			this.Content = new StackLayout {
				HorizontalOptions = LayoutOptions.Center,
				Children = {
					label,
   					label2,
                    picker,
					datePicker,
					timePicker,
					stepper,
					slider,
					switcher
				}
			};
		}
	}
}



