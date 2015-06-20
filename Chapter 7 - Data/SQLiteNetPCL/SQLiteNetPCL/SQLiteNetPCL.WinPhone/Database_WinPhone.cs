using System;
using System.IO;
using Windows.Storage;
using Xamarin.Forms;
using SQLiteNetPCL.WinPhone;
using SQLite;

[assembly: Dependency(typeof(Database_WinPhone))]
namespace SQLiteNetPCL.WinPhone
{
    public class Database_WinPhone : IDatabase
    {
        public Database_WinPhone() { }
        public SQLiteConnection DBConnect()
        {
            var filename = "ItemsSQLite.db3";
            string folder =
                ApplicationData.Current.LocalFolder.Path;
            var path = Path.Combine(folder, filename);
            var connection = new SQLiteConnection(path);
            return connection;
        }
    }
}

