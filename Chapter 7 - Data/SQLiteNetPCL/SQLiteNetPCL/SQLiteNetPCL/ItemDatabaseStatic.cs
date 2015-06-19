using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SQLite;
using Xamarin.Forms;

namespace SQLiteNetPCL
{
    public class ItemDatabaseStatic 
    {
		protected static object locker = new object ();

		protected static SQLiteConnection database; 

		static ItemDatabaseStatic()
        {
            database = DependencyService.Get<IDatabase>().DBConnect();
			database.CreateTable<Item>();
        }

		public static List<Item> GetItems ()
        {
            lock (locker) {
                return (from i in database.Table<Item>() select i).ToList();
            }
        }

		public static List<Item> GetFirstItem ()
        {
            lock (locker) {
                return database.Query<Item>("SELECT * FROM Item WHERE Name = 'First'");
            }
        }

		public static Item GetItem(int id) 
        {
            lock (locker) {
                return database.Table<Item>().FirstOrDefault(x => x.ID == id);
            }
        }

		public static int SaveItem(Item item) 
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

		public static int DeleteItem(int id)
        {
            lock (locker) {
                return database.Delete<Item>(id);
            }
        }

		public static void DeleteAllItems()
		{
			lock (locker) {
				database.DropTable<Item>();
				database.CreateTable<Item>();
			}
		}
    }

}
