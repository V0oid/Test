using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    [Table("user")]
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public Sex sex { get; set; }
        public string Address { get; set; }
        public string Job { get; set; }
        public string School { get; set; }
        public string OriginCity { get; set; }
        public MartialStatus MartialStatus { get; set; }
    }
}
