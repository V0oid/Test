using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Database
    {
        public SQLiteAsyncConnection database;
        public Database(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
        }

        public async Task<bool> isEmailUnique(string email)
        {
            var result = await database.Table<User>().Where(u=>u.Email == email).FirstAsync();
            return result == null ? true : false; 
        }

        public async Task<int> Register(User user)
        {
            return await database.InsertAsync(user);
        }
        public async Task<User> Login(string email, string password)
        {
            var result = await database.Table<User>().Where(u => u.Email == email
            && u.Password == password).FirstAsync();
            return result;
        }
    }
}
