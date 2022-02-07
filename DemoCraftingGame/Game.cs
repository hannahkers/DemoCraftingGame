using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static DemoCraftingGame.Utility;
using static DemoCraftingGame.Utilities.LoadExternalData;

namespace DemoCraftingGame
{
    public class Game
    {
        //new instances
        static int Choice;
        Person Player = new Person();
        NPC Trader = new NPC();
        Recipe ChamomileTea = new Recipe();
        Recipe SleepingPotion = new Recipe();
        public void Run()
        {
            SetUpGame();
            ShowWelcome();

            RecipeMenu();
            
            //Print("This is what is in your inventory...");
            //Print(ShowAllItemsInList(Player.Inventory));
            //Pause();
            //Print("This is what our Trader has...");
            //Print(ShowAllItemsInList(Trader.Inventory));
            //Pause();
            //Print("How to make Chamomile Tea...");
            //Print(ShowAllItemsInList(ChamomileTea.Ingredients));
            //Pause();
            //Print("How to make Sleeping Potion...");
            //Print(ShowAllItemsInList(SleepingPotion.Ingredients));
            //Pause();
            ////MakePurchase();
            //Pause();


        }
        public void MakePurchase()
        {
            Print("Would you like to make a purchase today?");

        }

        private void SetUpGame()
        {
            
            Player.Name = "Anonymous Player";

            Title = "Crafting System Demo!";

        }

        public void ShowWelcome()
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
            Print($"Welcome {Player.Name}");

            //pull welcome txt from external file
            Print(LoadTextFromFile("../../Data/welcome.txt"));

            //pull in instructions from external file
            Print(LoadTextFromFile("../../Data/instructions.txt"));

            Player.Inventory = LoadLinesFromFile("../../Data/defaultPlayerItems.txt");

            Trader.Inventory = LoadLinesFromFile("../../Data/defaultTraderItems.txt");

            ChamomileTea.Ingredients = LoadLinesFromFile("../../Data/ChamomileTea.txt");

            SleepingPotion.Ingredients = LoadLinesFromFile("../../Data/ChamomileTea.txt");





        }

        public void RecipeMenu()
        {

            Print("What would you like to make?");
            Print("1) Chamomile Tea 2) Sleeping Potion 3) Nothing");
            Choice = Convert.ToInt32(ReadLine());
            if (Choice == 3)
            {
                Print("Changed your mind? Goodbye!");
                Pause();
            }
            else
            {
                switch (Choice)
                {
                    case 1:
                        Print("How to make Chamomile Tea...");
                        Print(ShowAllItemsInList(ChamomileTea.Ingredients));
                        Pause();
                        break;
                    case 2:
                        Print("How to make Sleeping Potion");
                        Print(ShowAllItemsInList(SleepingPotion.Ingredients));
                        break;
                    default:
                        Print("Please make a valid choice.");
                        Pause();
                        RecipeMenu();
                        break;



                }
            }

        }
    }

    
}