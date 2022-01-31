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

        //C# properties have some method qualities

        //property
        public List<Item> Inventory = new List<Item>();

        //declarative sentence - player crafts a potion
        public void Craft()
        {



        }

      
    }
}