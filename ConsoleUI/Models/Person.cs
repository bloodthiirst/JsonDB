using JsonDB;
using System.Collections.Generic;

namespace ConsoleUI.Models
{
    public class Person : IDbEntity
    {
        public int EntityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<DbReference<Purchase>> Purchases { get; set; } = new List<DbReference<Purchase>>();
        public List<DbReference<Account>> Accounts { get; set; } = new List<DbReference<Account>>();
    }
}
