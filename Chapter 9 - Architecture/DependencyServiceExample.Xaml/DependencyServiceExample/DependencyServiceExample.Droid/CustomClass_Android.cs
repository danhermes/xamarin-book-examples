using System;
using DependencyServiceExample.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(CustomClass_Android))]

namespace DependencyServiceExample.Droid
{
    class CustomClass_Android : CustomClass
    {
        public CustomClass_Android() { }

        public string GoNative(string param)
        {
            return "Android " + param;
        }
    }
}