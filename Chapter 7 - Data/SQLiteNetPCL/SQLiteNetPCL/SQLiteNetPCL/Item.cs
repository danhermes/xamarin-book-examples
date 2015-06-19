using System;
using SQLite;


namespace SQLiteNetPCL
{
    public class Item : IObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [MaxLength(15)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }

    }

}
