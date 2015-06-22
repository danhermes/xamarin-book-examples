using System;
using System.Data;
using Mono.Data.Sqlite;
using System.IO;

using Xamarin.Forms;

namespace ADOdotNETexample
{
	public class ConnectionPage : ContentPage
	{
		public ConnectionPage ()
		{
			var dbName = "ItemsSQLite.db3";

			#if __IOS__
			string folder = Environment.GetFolderPath (Environment.SpecialFolder.Personal); 
			folder = Path.Combine (folder, "..", "Library"); 
			var databasePath = Path.Combine(folder, dbName);
			#else
			#if __ANDROID__
			string folder = Environment.GetFolderPath (Environment.SpecialFolder.Personal); 
			var databasePath = Path.Combine(folder, dbName);
			#else // Windows Phone
			var databasePath = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, dbName);
			#endif
			#endif

			Mono.Data.Sqlite.SqliteConnection.CreateFile (databasePath);
			var connection = new SqliteConnection ("Data Source=" + databasePath);

			connection.Open();
			using (var command = connection.CreateCommand ()) {
				command.CommandText = "CREATE TABLE [Items] ([ID] INTEGER" + " PRIMARY KEY AUTOINCREMENT, [Name] ntext, [Description] ntext)";
				var rowcount = command.ExecuteNonQuery ();
			}
			connection.Close();

			var label = new Label { Text = "Database Created Using ADO.NET\n" };


			connection.Open ();
			var sqlStatements = new [] {
				"INSERT INTO [Items] ([Name], [Description]) VALUES ('First', 'The first row')",
				"INSERT INTO [Items] ([Name], [Description]) VALUES ('Second', 'the second row')",
				"INSERT INTO [Items] ([Name], [Description]) VALUES ('Third', 'the third row')"
			};
			foreach (var sqlStatement in sqlStatements) {
				using (var command = connection.CreateCommand ()) {
					command.CommandText = sqlStatement;
					var rowcount = command.ExecuteNonQuery ();
				}
			}
			connection.Close ();
		
			label.Text += "Rows added to database\n";


			var rows = "SQL query result:\n";

			connection.Open ();
			using (var command = connection.CreateCommand ()) {
				command.CommandText = "SELECT [ID], [Name], [Description] from [Items]";
				var results = command.ExecuteReader();
				while (results.Read ())
					rows += String.Format ("\t ID={0}\t Name={1}\t Desc={2}\n",
						results ["ID"].ToString (),
						results ["Name"].ToString (),
						results ["Description"].ToString ());
			}
			connection.Close ();

			label.Text += rows;

			var count = "";
			connection.Open ();
			using (var command = connection.CreateCommand ()) {
				command.CommandText = "SELECT COUNT(*) FROM [Items]";
				count = "There are " + command.ExecuteScalar().ToString() + " rows.";
			}
			connection.Close ();

			label.Text += count;

			this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

			Content = label;
		}
	}
}


