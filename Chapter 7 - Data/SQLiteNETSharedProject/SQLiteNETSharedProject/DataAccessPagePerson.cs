using System;
using System.Collections.Generic;
using SQLite;
using System.Linq;
using Xamarin.Forms;

// Uses ItemDatabaseRepository instantiated in ItenDatabaseRepository

namespace SQLiteNETSharedProject
{
    public class DataAccessPagePerson : ContentPage
    {
		public DataAccessPagePerson()
        {
			var label = new Label { Text = "Database Created Using SQLite.NET\n" };

			label.Text += " Now Accessing the Person Table\n\n";

			App.Repository.DeleteAllItems (); // clear out the table to start fresh
			App.Repository.DeleteAllPeople (); // clear out the table to start fresh

			var person = new Person { FirstName = "Joe" , LastName = "First"};
			App.Repository.SavePerson (person);

			var id = 1;
			person = App.Repository.GetPerson (id);
			label.Text += person.FirstName + " at ID " + id.ToString () + "\n\n";

			App.Repository.DeletePerson (id);
			label.Text += "Deleted item at ID " + id.ToString () + "\n\n";

			person = new Person { FirstName = "Joe" , LastName = "First"};
			App.Repository.SavePerson (person);
			person = new Person { FirstName = "Pam" , LastName = "Second"};
			App.Repository.SavePerson (person);
			person = new Person { FirstName = "Dino" , LastName = "Furd"};
			App.Repository.SavePerson (person);

			var people = App.Repository.GetPeople ();
			foreach (var i in people) {
				label.Text += i.FirstName + " " + i.LastName + "\n";
			}

			label.Text += "\n Oops, I meant: ";

			person.LastName = "Third";
			App.Repository.SavePerson(person);

			id = 4;
			person = App.Repository.GetPerson(id);
			label.Text += person.FirstName + " " + person.LastName + "\n";

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
