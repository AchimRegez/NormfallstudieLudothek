using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormfallstudieLudothek
{
    class Wishlist
    {
        public void GenerateWishlist()
        {
            var inList = new List<object>();
            int budget = 120;


            var wishList = new[]
                {
                    new {name = "Stratego", price = 49.90},
                    new {name = "Monopoly", price = 69.90},
                    new {name = "UNO", price = 13.50},
                    new {name = "Halli Galli Junior", price = 23.90}
                };

            double amount = 0;

            foreach (var item in wishList)
            {
                if ((amount + item.price) <= budget)
                {
                    amount += item.price;
                    inList.Add(item);
                    Console.WriteLine("Neues Spiel hinzugefügt: " + item.name);
                }
                else
                {
                    Console.WriteLine("Nicht genug Budget vorhanden!");
                }
                Console.WriteLine("Name: " + item.name + " --- Preis: " + item.price);
            }

            foreach (var item in inList)
            {
                Console.WriteLine("Im Archiv: " + item.GetType().GetProperty("name").GetValue(item) + " " + item.GetType().GetProperty("price").GetValue(item));
            }
            
        }
    }
}
