using System;
using DependencyServiceExample.WinPhone;

[assembly: Xamarin.Forms.Dependency(typeof(CustomClass_WindowsPhone))]

namespace DependencyServiceExample.WinPhone
{
    class CustomClass_WindowsPhone : CustomClass
    {
        public CustomClass_WindowsPhone() { }

        public string GoNative(string param)
        {
            return "Windows Phone " + param;
        }
    }
}

