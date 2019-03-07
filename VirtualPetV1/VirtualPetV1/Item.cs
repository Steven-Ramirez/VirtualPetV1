using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualPetV1
{
    public abstract class Items : Pets
    {
        public int loyaltyPoints;
        public int happinessPoints;
        public int hungerPoints;

        public abstract string ItemList();

        public Items()
        {

        }


    }
}