using System;
using Xamarin.Forms;

namespace SQLiteNETSharedProject
{
    public class App : Application
	{

		// USE THIS

		static ItemDatabaseBasic database;  			//  basic respository (database class only)
		public static ItemDatabaseBasic Database {
			get { 
				if (database == null) {
					database = new ItemDatabaseBasic ();
				}
				return database; 
			}
		}

		// OR THIS (but not both)

		static ItemRepository repository;  				//  advanced respository (repository and generic database class)
		public static ItemRepository Repository {
			get { 
				if (repository == null) {
					repository = new ItemRepository ();
				}
				return repository; 
			}
		}

		public App()
        {
			MainPage = new NavigationPage(new HomePage());
        }
			
    }
}
