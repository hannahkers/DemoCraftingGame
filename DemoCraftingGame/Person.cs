using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoCraftingGame
{

    //protect data at first, make public if needed
    public class Person
    {
        //field
        private string name;

        //property
        public string Name;
        public float Currency;
        public List<Item> Inventory = new List<Item>();










        //C# properties have some method qualities


        //object initialization
        //everyone who starts the game will have these items to start
        //public List<Item> Inventory = new List<Item>()
        //{
        //    new Item()
        //    {
        //        Name = "Toadstool",
        //        Quantity = 2
        //    },
        //    new Item()
        //    {
        //        Name = "Feather",
        //        Description = "Deceptively normal looking feather.",
        //        Quantity = 10
        //    },
        //    new Item()
        //    {
        //        Name = "Seaweed",
        //        Quantity = 3
        //    }
        //};





        //toadstool, feathe, seaweed, ichor, newt tail, drake blood, frog leg, water, mandrake root, phoenix feather, nector, cuttlefish tenticles, rose petals, dragon egg, obsidian. paprika, honey, gamer tears, cricket wing, lotus

        //potions
        //health, stamina, transformation, defense, flying, love, power up, mana, invisibility, underwater breathing, fire, defense

        //declarative sentence - player crafts a potion
        //public void Craft(Recipe recipe)
        //{
        //    could return a potion as a new item
        //    or could add a potion to inventory

        //    what are the steps needed? Could those be separate methods ?


        //}


    }
}