using ConsoleUI.Models;
using JsonDB;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonDb db = JsonDb.Create();

            db.AddType<Person>();
            db.AddType<Account>();
            db.AddType<Item>();
            db.AddType<Purchase>();

            Person person = new Person()
            {
                FirstName = "Blood",
                LastName = "Thirst"
            };
            db.Add(person);
            
            Account acc = new Account()
            {
                Username = "myusername",
                Password = "mypass",
                Person = 1
            };
            db.Add(acc);

            Item item = new Item()
            {
                ItemName = "Dildo"
            };
            db.Add(item);

            Purchase purchase = new Purchase()
            {
                Amount = 3,
                PurchaseDate = DateTime.Now,
                Item = item,
                Person = person,
            };
            db.Add(purchase);

            db.Remove(acc);

            string json = db.Save();

            File.WriteAllText("D:/jsonDb.txt", json);

            JsonDb loaded = JsonDb.Open(json);
        }
    }
}
