using JsonDB;

namespace ConsoleUI.Models
{
    public class Account : IDbEntity
    {
        public int EntityId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DbReference<Person> Person { get; set; } = new DbReference<Person>();

    }
}
