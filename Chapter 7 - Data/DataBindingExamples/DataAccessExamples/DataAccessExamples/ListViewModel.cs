using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;

namespace DataBindingExamples
{
    class ListViewModel
    {
        ObservableCollection<ObservableItem> items;

        public ListViewModel()
        {
            items = new ObservableCollection<ObservableItem> { 
            new ObservableItem {Title = "First", Description="1st item"}, 
            new ObservableItem {Title = "Second", Description="2nd item"},
            new ObservableItem {Title = "Third", Description="3rd item"} 
            };
        }

        public ObservableCollection<ObservableItem> Items
        {
            set
            {
                if ( value != items)
                {
                    items = value;
                }
            }
            get
            {
                return items;
            }
        }

        public void Replace()
        {
            Items = new ObservableCollection<ObservableItem> { 
				new ObservableItem {Title = "Primero", Description="First"}, 
				new ObservableItem {Title = "Segundo", Description="Second"},
				new ObservableItem {Title = "Tercero", Description="Third"} 
			   };
        }

    }

}
