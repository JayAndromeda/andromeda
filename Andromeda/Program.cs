using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Andromeda
{
    class Application
    {
        static void Main(string[] args)
        {  
            List<MagicItem> magicItems = new List<MagicItem>();   
         
            string rarity = args[0];
            int numOfItems = Int32.Parse(args[1]);


            magicItems = ReadFromJson().toList();
            
            PrintItems(magicItems, numOfItems, rarity);
        }

        private static Items ReadFromJson()
        {
            Items items = new Items();
            string filePath = @"\magicItems.json";

            using (StreamReader reader = new StreamReader(filePath))
            {
                string json = reader.ReadToEnd();
                items = JsonConvert.DeserializeObject<Items>(json);
            }
            return items;
        }

        private static void PrintItems(List<MagicItem> items, int numOfItems, string rarity) {
            Random random = new Random();
            var itemsToPrint = new List<MagicItem>();

            foreach (MagicItem item in items) {
                if (string.Equals(rarity, item.Rarity, StringComparison.OrdinalIgnoreCase)) {
                    itemsToPrint.Add(item);
                }
            }

            for (int i = 0; i <= numOfItems - 1; i++)
            {
                int randomItem = random.Next(0, itemsToPrint.Count);
                Console.WriteLine(itemsToPrint[randomItem].ToString());
            }
        }
    }
}
