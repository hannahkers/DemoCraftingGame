using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static DemoCraftingGame.Utility;

namespace DemoCraftingGame
{
    class Program
        //all classes inherit from Object class in C# (polymorphism)
    {
        static void Main()
        {
            Game game = new Game();
            game.Run();

        }
    }
}
