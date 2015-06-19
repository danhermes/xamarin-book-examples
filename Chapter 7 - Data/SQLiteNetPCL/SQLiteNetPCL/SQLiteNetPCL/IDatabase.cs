using System;
using SQLite;

namespace SQLiteNetPCL
{
    public interface IDatabase
    {
        SQLiteConnection DBConnect();
    }

}
