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

        public string ConvertLowerCase(string message) => message.ToLower();
       
    }
}
