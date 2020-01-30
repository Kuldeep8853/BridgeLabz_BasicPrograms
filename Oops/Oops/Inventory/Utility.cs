using System;
using System.IO;
using Newtonsoft.Json;

namespace Oops.Inventory{
    class Utility{
        public static Inventory ReadJsonFile()
        {
            if (File.Exists(@"D:\Oops\Oops\Inventory\InventoryItems.json"))
            {
                string files = File.ReadAllText(@"D:\Oops\Oops\Inventory\InventoryItems.json");
                Inventory array = JsonConvert.DeserializeObject<Inventory>(files);
                return array;
            }
            else
            {
                Console.WriteLine("path does not found");
                return new Inventory();
            }
        }

        /// <summary>
        /// Writes the json file.
        /// </summary>
        /// <param name="file">The file.</param>
        public static void WriteJsonFile(Inventory file)
        {
            string json = JsonConvert.SerializeObject(file);
            File.WriteAllText(@"D:\Oops\Oops\Inventory\InventoryItems.json", json);
        }

    }
}

