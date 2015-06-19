using System;
using System.IO;
using SQLiteNetPCL;
using SQLiteNetPCL.Droid;
using Xamarin.Forms;
using SQLite;

[assembly: Dependency(typeof(Database_Android))]
namespace SQLiteNetPCL.Droid
{
    public class Database_Android : IDatabase
    {
        public Database_Android() { }
        public SQLiteConnection DBConnect()
        {
            var filename = "ItemsSQLite.db3";
            string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(folder, filename);
            var connection = new SQLiteConnection(path);
            return connection;
        }
    }

}