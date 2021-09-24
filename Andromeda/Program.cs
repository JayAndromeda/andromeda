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
            Console.WriteLine("Hello World!");
            string filePath = @"C:\Users\Jennifer\source\repos\Andromeda\magicItems.json";

            using (StreamReader reader = new StreamReader(filePath))
            {
                string json = reader.ReadToEnd();
                Items items = JsonConvert.DeserializeObject<Items>(json);
                Console.WriteLine(items.magicItems[0].Name);
            }
            
        }
    }
}
