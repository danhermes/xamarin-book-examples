using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ControlExamples
{	
	public partial class Controls : ContentPage
	{	
		Label eventValue;
        Label pageValue;

       //  Note that there are a couple of options for retrieving the selection value for 
       //  many of these views and those options will be placed in each of the two Label 
       //  views’ Text properties.

        public Controls()
		{
			eventValue = new Label();
			eventValue.Text = "Value in Event";
            pageValue = new Label();
            pageValue.Text = "Value in Page";


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
                pageValue.Text = picker.Items[picker.SelectedIndex];
            }; 


			DatePicker datePicker = new DatePicker
			{
				Format = "D",
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			datePicker.DateSelected += (object sender, DateChangedEventArgs e) => 
            {
                eventValue.Text = e.NewDate.ToString();
                pageValue.Text = datePicker.Date.ToString();
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
                    pageValue.Text = timePicker.Time.ToString();
                }
            };

            // Stepper stepper = new Stepper(0 ,10 ,0 , 1);  // alternative declaration
			Stepper stepper = new Stepper
			{
				Minimum = 0,
				Maximum = 10,
				Increment = 1,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
            stepper.ValueChanged += (sender, e) =>
            {
                eventValue.Text = String.Format("Stepper value is {0:F1}", e.NewValue);
                pageValue.Text = stepper.Value.ToString();
            };

            // Slider  slider = new Slider  (0 ,100 ,50); // alternative declaration
			Slider slider = new Slider
			{
                Minimum = 0,
                Maximum = 100,
                Value = 50,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                WidthRequest = 300

			};

            slider.ValueChanged += (sender, e) =>
            {
                eventValue.Text = String.Format("Slider value is {0:F1}", e.NewValue);
                pageValue.Text = slider.Value.ToString();
            };


			Switch switcher = new Switch
			{
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

            switcher.Toggled += (sender, e) =>
            {
       			eventValue.Text = String.Format("Switch is now {0}", e.Value);
                pageValue.Text = switcher.IsToggled.ToString();
            };

            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

			this.Content = new StackLayout {
				HorizontalOptions = LayoutOptions.Center,
				Children = {
					eventValue,
   					pageValue,
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



