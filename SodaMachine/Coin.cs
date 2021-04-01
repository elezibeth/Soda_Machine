using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Coin
    {
        //Member Variables (Has A)
        protected double value;
        protected string name;

        public double Value
        {
            get
            {
                return value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        // As a developer, I want my Coin classes to have a read-only property for double value(public property & protected field for member variable double value).

        //Constructor (Spawner)
        public Coin()
        {

        }

        //Member Methods (Can Do)
    }
}
