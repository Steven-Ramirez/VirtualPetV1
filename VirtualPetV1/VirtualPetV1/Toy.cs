using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualPetV1
{
    public class Toy : Items
    {


        public Toy()
        {

        }

        public void toyList()
        {
            Items.items.Add(new Items { loyaltyPoints = 10, happinessPoints = 10 });
        }
    }
}