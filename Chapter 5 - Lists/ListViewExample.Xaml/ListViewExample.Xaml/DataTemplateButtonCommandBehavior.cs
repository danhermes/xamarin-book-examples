using System;
using Xamarin.Forms;

namespace ListViewExample.Xaml
{
    public class DataTemplateButtonCommandBehavior
        : Behavior<Button>
    {

        public static readonly BindableProperty ButtonCommandProperty = BindableProperty.Create<DataTemplateButtonCommandBehavior, Command<object>>( p => p.ButtonCommand, null );

        public Command<object> ButtonCommand
        {
            get 
            { 
                return (Command<object>)GetValue(ButtonCommandProperty); 
            }
            set 
            {
                SetValue(ButtonCommandProperty, value); 
            }
        }
            
        protected override void OnAttachedTo(Button bindable)
        {
            base.OnAttachedTo(bindable);

            bindable.Command = ButtonCommand;
        }

        protected override void OnDetachingFrom(Button bindable)
        {
            base.OnDetachingFrom(bindable);

            bindable.Command = null;
        }
    }
}

