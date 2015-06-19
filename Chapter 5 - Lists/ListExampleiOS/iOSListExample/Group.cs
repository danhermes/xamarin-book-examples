using System;
using System.Collections.Generic;

namespace iOSListExample
{
	public class Group : List<ListItem>
	{
		public String Key { get; private set; }

		public Group(String key, List<ListItem> items)
		{
			Key = key;
			foreach (var item in items)
				this.Add(item);
		}

	}

}

