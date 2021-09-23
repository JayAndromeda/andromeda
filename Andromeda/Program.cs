using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Andromeda
{
    class Application
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string filePath = @"C:\Users\Jennifer\source\repos\Andromeda\magicItemsShort.json";
            using (StreamReader reader = new StreamReader(filePath))
            {
                string json = reader.ReadToEnd();
                reader.Close();
                List<MagicItem> items = JsonConvert.DeserializeObject<List<MagicItem>>(json);
            }
        }
    }
}
