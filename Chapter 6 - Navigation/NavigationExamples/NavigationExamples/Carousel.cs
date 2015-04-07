using System;
using Xamarin.Forms;

namespace NavigationExamples
{
    class Carousel :CarouselPage
    {
            public Carousel()
            {
                Title = "Carousel Using CarouselPage";

                this.Children.Add(new FirstPage());
                this.Children.Add(new SecondPage());
                this.Children.Add(new ThirdPage());

            }
    }
}
