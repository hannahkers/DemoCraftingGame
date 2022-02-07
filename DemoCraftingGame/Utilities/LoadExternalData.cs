using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DemoCraftingGame.Utilities
{
    class LoadExternalData
    {
        //expression body method
        public static string LoadTextFromFile(string path) => File.ReadAllText(path);
       //same thing as 
       //public static string LoadTextFromFile(string path)
       // {
       //    return File.ReadAllText(path);
       // }

        public static List<Item> LoadLinesFromFile(string path)
        {
            //string output = "";
            List<Item> items = new List<Item>();

            foreach (string s in File.ReadAllLines(path))
            {
                items.Add(new Item() { Name = s });
               // Utility.Print(s);
            }
            return items;
        }

    }
}
