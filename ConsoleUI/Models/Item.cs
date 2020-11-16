using JsonDB;
using System.Collections.Generic;

namespace ConsoleUI.Models
{
    public class Item : IDbEntity
    {
        public int EntityId { get; set; }
        public string ItemName { get; set; }
        public List<DbReference<Purchase>> Purchases { get; set; } = new List<DbReference<Purchase>>();
    }
}
