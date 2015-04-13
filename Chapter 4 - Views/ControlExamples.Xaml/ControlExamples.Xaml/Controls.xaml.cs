using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.ComponentModel;

namespace ControlExamples.Xaml
{
    public partial class Controls : ContentPage
    {
        public Controls()
        {
            InitializeComponent();

        }

        void SwitchToggled (object sender, ToggledEventArgs e)
        {
            Label1.Text = String.Format("Switch is now {0}", e.Value ? "On" : "Off");
            Label2.Text = TheSwitch.IsToggled.ToString();
        }

        void SliderValueChanged (object sender, ValueChangedEventArgs e)
        {
            Label1.Text = String.Format("Slider value is {0:F1}", e.NewValue);
            Label2.Text = TheSlider.Value.ToString();
        }

       
        void StepperValueChanged (object sender, ValueChangedEventArgs e)
        {
            Label1.Text = String.Format("Stepper value is {0:F1}", e.NewValue);
            Label2.Text = TheStepper.Value.ToString();
        }

        void TimePickerPropertyChanged (object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
            {
                Label1.Text = TheTimePicker.Time.ToString();
            }
        }

        void DatePickerDateSelected (object sender, DateChangedEventArgs e)
        {
            Label1.Text = e.NewDate.ToString();
            Label2.Text = TheDatePicker.Date.ToString();
        }

        void PickerSelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = ThePicker.Items[ThePicker.SelectedIndex];
        }
    }
}

