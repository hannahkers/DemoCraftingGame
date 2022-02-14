using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static DemoCraftingGame.Utility;
using static System.Console;
using static DemoCraftingGame.Utilities.Display;
using static DemoCraftingGame.Game;

namespace DemoCraftingGame
{
    public class NPC
    {
        static int Choice;
        public string Name;
        public List<Item> Inventory = new List<Item>();

        //Items
        //toadstool, feather, seaweed, ichor, newt tail, drake blood, frog leg, water, mandrake root, phoenix feather, nector, cuttlefish tenticles, rose petals, dragon egg, obsidian. paprika, honey, gamer tears, cricket wing, lotus

        //public List<Item> Inventory = new List<Item>()
        //{
        //    new Item()
        //    {
        //        Name = "Toadstool",
        //        Price = 2.29f,
        //        Quantity = 2
        //    },
        //    new Item()
        //    {
        //        Name = "Feather",
        //        Price = 1.09f,
        //        Quantity = 2
        //    },
        //    new Item()
        //    {
        //        Name = "Ichor",
        //        Price = 5.49f,
        //        Quantity = 2
        //    },
        //    new Item()
        //    {
        //        Name = "Newt Tail",
        //        Price = 7.89f,
        //        Quantity = 2
        //    },
        //    new Item()
        //    {
        //        Name = "Drake Blood",
        //        Price = 4.49f,
        //        Quantity = 2
        //    },
        //    new Item()
        //    {
        //        Name = "Frog Leg",
        //        Price = 2.19f,
        //        Quantity = 2
        //    },
        //    new Item()
        //    {
        //        Name = "Seaweed",
        //        Quantity = 3
        //    }
        //};


        public void Sell()
        {
            Print("Welcome to my shop");
            Print(ShowAllItemsInList(Inventory));
            Pause();

            Print("Would you like to buy anything? 1)Yes 2)No");
            Choice = Convert.ToInt32(ReadLine());
            if (Choice == 1)
            {

            }
            else
            {
                
                
            }
           
        }
    }
}