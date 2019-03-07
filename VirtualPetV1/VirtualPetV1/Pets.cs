using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualPetV1
{
    public abstract class Pets
    {
        public int loyalty;
        public int happiness;
        public int hunger;
        public string name;

        protected int baseStats = 100;

        public abstract string Stats();

        public Pets()
        {

        }

        

    }
}