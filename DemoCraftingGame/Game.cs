using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static DemoCraftingGame.Utility;

namespace DemoCraftingGame
{
    public class Game
    {
        public void Run()
        {

     


            //Items

            Item redDye = new Item();
            redDye.Price = 3.5f;
            redDye.Name = "Red Dye";
            WriteLine($"{redDye.Name} is {redDye.Price.ToString("c")} per vial.");

            Item blueDye = new Item();
            blueDye.Price = 2.5f;
            blueDye.Name = "Blue Dye";
            WriteLine($"{blueDye.Name} is {blueDye.Price.ToString("c")} per vial.");

            Item purpleDye = new Item();
            purpleDye.Price = 15f;
            purpleDye.Name = "Purple Dye";
            WriteLine($"{purpleDye.Name} is {purpleDye.Price.ToString("c")} per vial.");

            Item yellowDye = new Item();
            yellowDye.Price = 3f;
            yellowDye.Name = "Yellow Dye";
            WriteLine($"{yellowDye.Name} is {yellowDye.Price.ToString("c")} per vial.");

            Item greenDye = new Item();
            greenDye.Price = 12f;
            greenDye.Name = "Green Dye";
            WriteLine($"{greenDye.Name} is {greenDye.Price.ToString("c")} per vial.");

            Item orangeDye = new Item();
            orangeDye.Price = 2.5f;
            orangeDye.Name = "Orange Dye";
            WriteLine($"{orangeDye.Name} is {orangeDye.Price.ToString("c")} per vial.");


            //Utility.Pause();
            Pause();
        }

        private void SetUpGame()
        {
            Person Player = new Person();
            Player.Name = "Anonymous Player";

            Title = "Crafting System Demo!";

        }

        private void ShowWelcome()
        {
            //concatenation
            //WriteLine("Welcome " + Player.Name);

            //composite formatting
            //WriteLine("Welcome {0}", Player.Name);

            //interpolation formatting
            //WriteLine($"Welcome {Player.Name}");

            //greet player and get name
            Print("Welcome Player! What would you like to be called?");
            Player.Name = ReadLine();
            if (Player.Name == string)
            {
                Print($"Welcome {Player.Name}");
            }
            else
            {
                Print("Please enter your name to continue.");
            }
            Pause();
        }
    }

    
}