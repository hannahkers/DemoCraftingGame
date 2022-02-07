using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DemoCraftingGame
{
    class Utility
    {

        public static void Pause()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        public static string ShowAllItemsInList(List<Item> items)
        {
            string output = "";

            foreach(Item i in items)
            {
                output += $"{i.Name} ({i.Quantity}) ({i.Price}) {Environment.NewLine}";
            }


            return output;
        }
        public string ConvertLowerCase(string message) => message.ToLower();
       
    }
}
