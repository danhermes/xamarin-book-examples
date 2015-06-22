using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SQLite;
using Xamarin.Forms;

namespace SQLiteNETSharedProject
{
    public class ItemDatabaseBasic 
    {
		protected static object locker = new object ();

		protected SQLiteConnection database; 

		public ItemDatabaseBasic()
        {
			database = new SQLite.SQLiteConnection(databasePath); 
			database.CreateTable<Item>();
        }

		protected string databasePath {
			get { 
				var dbName = "ItemsSQLite.db3";
				#if __IOS__
				string folder = Environment.GetFolderPath (Environment.SpecialFolder.Personal); 
				folder = Path.Combine (folder, "..", "Library"); 
				var databasePath = Path.Combine(folder, dbName);
				#else
				#if __ANDROID__
				string folder = Environment.GetFolderPath (Environment.SpecialFolder.Personal); 
				var databasePath = Path.Combine(folder, dbName);
				#else  // WinPhone
				var databasePath = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, dbName);
				#endif
				#endif

				return databasePath;
			}
		}
			
		public IEnumerable<Item> GetItems ()
        {
            lock (locker) {
                return (from i in database.Table<Item>() select i).ToList();
            }
        }

		public IEnumerable<Item> GetFirstItems ()
        {
            lock (locker) {
                return database.Query<Item>("SELECT * FROM Item WHERE Name = 'First'");
            }
        }

		public Item GetItem(int id) 
        {
            lock (locker) {
                return database.Table<Item>().FirstOrDefault(x => x.ID == id);
            }
        }

		public int SaveItem(Item item) 
        {
            lock (locker) {
                if (item.ID != 0) {
                    database.Update(item);
                    return item.ID;
                } else {
                    return database.Insert(item);
                }
            }
        }

		public int DeleteItem(int id)
        {
            lock (locker) {
                return database.Delete<Item>(id);
            }
        }

		public void DeleteAllItems()
		{
			lock (locker) {
				database.DropTable<Item>();
				database.CreateTable<Item>();
			}
		}
    }

}
