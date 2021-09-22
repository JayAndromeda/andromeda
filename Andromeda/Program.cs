using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Andromeda
{
    class NewBaseType
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string filePath = @"C:\Users\Jennifer\source\repos\Andromeda\magicItemsShort.json";
            using (StreamReader reader = new StreamReader(filePath))
            {
                string json = reader.ReadToEnd();
                List<MagicItem> items = JsonConvert.DeserializeObject<List<MagicItem>>(json);
            }
        }
    }
}
