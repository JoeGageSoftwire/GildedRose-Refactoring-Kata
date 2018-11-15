using System;
using System.Collections.Generic;

namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var app = new GildedRose();

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                var gildedRoseItems = app.Items;
                foreach (var item in gildedRoseItems)
                {
                    System.Console.WriteLine(item);
                }
                Console.WriteLine("");
                app.UpdateStock();
            }
        }
    }
}
