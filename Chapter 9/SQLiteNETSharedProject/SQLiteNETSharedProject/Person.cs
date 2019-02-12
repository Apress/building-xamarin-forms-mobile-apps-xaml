﻿using System;
using SQLite;


namespace SQLiteNETSharedProject
{
    public class Person : IObject
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [MaxLength(25)]
        public string FirstName { get; set; }
        [MaxLength(25)]
        public string LastName { get; set; }

    }

}
