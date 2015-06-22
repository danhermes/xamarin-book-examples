using System;
using DependencyServiceExample.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(CustomClass_iOS))]

namespace DependencyServiceExample.iOS
{
	class CustomClass_iOS : ICustomClass
	{
		public CustomClass_iOS() { }

		public string GoNative(string param)
		{
			return "iOS " + param;
		}
	}
}

