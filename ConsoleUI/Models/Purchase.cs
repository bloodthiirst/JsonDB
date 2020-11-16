using JsonDB;
using System;

namespace ConsoleUI.Models
{
    public class Purchase : IDbEntity
    {
        public int EntityId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Amount { get; set; }
        public DbReference<Person> Person { get; set; } = new DbReference<Person>();
        public DbReference<Item> Item { get; set; } = new DbReference<Item>();
    }
}
