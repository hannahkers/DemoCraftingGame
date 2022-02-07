using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoCraftingGame
{
    public class Item
    {
        public string Name;
        public string Description;
        public float Quantity = 1;
        public Recipe Formula;
        public float Price;
        //public string AmountType = "cup(s)";

    }
}

//Items

//Item redDye = new Item();
//redDye.Price = 3.5f;
//redDye.Name = "Red Dye";
//WriteLine($"{redDye.Name} is {redDye.Price.ToString("c")} per vial.");

//Item blueDye = new Item();
//blueDye.Price = 2.5f;
//blueDye.Name = "Blue Dye";
//WriteLine($"{blueDye.Name} is {blueDye.Price.ToString("c")} per vial.");

//Item purpleDye = new Item();
//purpleDye.Price = 15f;
//purpleDye.Name = "Purple Dye";
//WriteLine($"{purpleDye.Name} is {purpleDye.Price.ToString("c")} per vial.");

//Item yellowDye = new Item();
//yellowDye.Price = 3f;
//yellowDye.Name = "Yellow Dye";
//WriteLine($"{yellowDye.Name} is {yellowDye.Price.ToString("c")} per vial.");

//Item greenDye = new Item();
//greenDye.Price = 12f;
//greenDye.Name = "Green Dye";
//WriteLine($"{greenDye.Name} is {greenDye.Price.ToString("c")} per vial.");

//Item orangeDye = new Item();
//orangeDye.Price = 2.5f;
//orangeDye.Name = "Orange Dye";
//WriteLine($"{orangeDye.Name} is {orangeDye.Price.ToString("c")} per vial.");