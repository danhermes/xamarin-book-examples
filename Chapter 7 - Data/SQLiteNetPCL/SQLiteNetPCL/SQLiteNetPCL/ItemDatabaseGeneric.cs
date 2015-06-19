using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using SQLite;
using Xamarin.Forms;

namespace SQLiteNetPCL
{
	public class ItemDatabaseGeneric
	{
		static object locker = new object ();

		SQLiteConnection database;

		public ItemDatabaseGeneric()
		{
            database = DependencyService.Get<IDatabase>().DBConnect();
			database.CreateTable<Item>();
			database.CreateTable<Person>();
		}

		public IEnumerable<T> GetObjects<T> () where T : IObject, new () 
		{
			lock (locker) {
				return (from i in database.Table<T>() select i).ToList();
			}
		}

		public IEnumerable<T> GetFirstObjects<T> () where T : IObject, new () 
		{
			lock (locker) {
				return database.Query<T>("SELECT * FROM Item WHERE Name = 'First'");
			}
		}

		public T GetObject<T> (int id) where T : IObject, new ()
		{
			lock (locker) {
				return database.Table<T>().FirstOrDefault(x => x.ID == id);
			}
		}

		public int SaveObject<T> (T obj) where T : IObject
		{
			lock (locker) {
				if (obj.ID != 0) {
					database.Update(obj);
					return obj.ID;
				} else {
					return database.Insert(obj);
				}
			}
		}

		public int DeleteObject<T> (int id) where T : IObject, new ()
		{
			lock (locker) {
				return database.Delete<T> (id); 
			}
		}

		public void DeleteAllObjects<T> ()
		{
			lock (locker) {
				database.DropTable<T>();
				database.CreateTable<T>();
			}
		}
			
	}

}

