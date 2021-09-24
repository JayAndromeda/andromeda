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
            Items items = new Items();
            string filePath = @"C:\Users\Jennifer\source\repos\Andromeda\magicItems.json";


            using (StreamReader reader = new StreamReader(filePath))
            {
                string json = reader.ReadToEnd();
                items = JsonConvert.DeserializeObject<Items>(json);
            }

            Random random = new Random();
            

            int numOfItems = Int32.Parse(args[0]);

            for (int i = 0; i <= numOfItems -1; i++)
            {
                int randomItem = random.Next(0, items.magicItems.Length);
                Console.WriteLine(items.magicItems[randomItem].toString());
            }
        }
    }
}
