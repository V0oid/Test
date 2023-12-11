using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Database
    {
        public SQLiteAsyncConnection database;
        public Database(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
        }
    }
}
