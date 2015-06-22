using System;
using System.Collections.Generic;
using SQLite;

namespace SQLiteNETSharedProject
{
	public class ItemRepository {
		ItemDatabaseGeneric itemDatabase = null;

		public ItemRepository()
		{
			itemDatabase = new ItemDatabaseGeneric();
		}

		public Item GetItem(int id)
		{
			return itemDatabase.GetObject<Item>(id);
		}

		public IEnumerable<Item> GetFirstItems ()
		{
			return itemDatabase.GetObjects<Item>();
		}

		public IEnumerable<Item> GetItems ()
		{
			return itemDatabase.GetObjects<Item>();
		}

		public int SaveItem (Item item)
		{
			return itemDatabase.SaveObject<Item>(item);
		}

		public int DeleteItem(int id)
		{
			return itemDatabase.DeleteObject<Item>(id);
		}

		public void DeleteAllItems()
		{
			itemDatabase.DeleteAllObjects<Item>();
		}


		public Person GetPerson(int id)
		{
			return itemDatabase.GetObject<Person>(id);
		}

		public IEnumerable<Person> GetPeople ()
		{
			return itemDatabase.GetObjects<Person>();
		}

		public int SavePerson (Person person)
		{
			return itemDatabase.SaveObject<Person>(person);
		}

		public int DeletePerson(int id)
		{
			return itemDatabase.DeleteObject<Person>(id);
		}

		public void DeleteAllPeople()
		{
			itemDatabase.DeleteAllObjects<Person>();
		}

	}

}

