using System;
using System.Collections.Generic;
using SQLite;
using Xamarin.Forms;

// Uses ItemDatabase repository instantiated in the App class

namespace SQLiteNetPCL
{
    public class DataAccessPageStatic : ContentPage 
    {
		public DataAccessPageStatic()
        {

			var label = new Label { Text = "Database Created Using SQLite.NET\n" };

			label.Text += " Using a Static Standalone Repository\n\n";

			ItemDatabaseStatic.DeleteAllItems (); // clear out the table to start fresh

			var item = new Item { Name = "First" , Description = "This is the first item"};
			ItemDatabaseStatic.SaveItem (item);

			var items = ItemDatabaseStatic.GetFirstItem();
			label.Text += items[0].Name + " item added.\n";

			var id = 1;
			item = ItemDatabaseStatic.GetItem (id);
			label.Text += item.Name + " item at ID " + id.ToString () + "\n\n";

			ItemDatabaseStatic.DeleteItem(id);
			label.Text += "Deleted item at ID " + id.ToString () + "\n\n";

			item = new Item { Name = "First" , Description = "This is the first item"};
			ItemDatabaseStatic.SaveItem (item);
			item = new Item { Name = "Second" , Description = "This is the second item"};
			ItemDatabaseStatic.SaveItem (item);
			item = new Item { Name = "Third" , Description = "This is the furd item"};
			ItemDatabaseStatic.SaveItem (item);

			items = ItemDatabaseStatic.GetItems ();
			foreach (var i in items) {
				label.Text += i.Name + ": " + i.Description + "\n";
			}

			label.Text += "\n Oops, I meant: ";

			item.Description = "This is the third item";
			ItemDatabaseStatic.SaveItem(item);

			id = 4;
			item = ItemDatabaseStatic.GetItem (id);
			label.Text += item.Name + ": " + item.Description + "\n";

            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            Content = new StackLayout
            {
                Children = {
					label
				}
            };
        }
    }
}
