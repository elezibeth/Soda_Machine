﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    abstract class Can
    {
        //Member Variables (Has A)
        protected double price;
        public string name;

        public double Price
        { 
            get 
            {
                return price;
            }
        }
        //Constructor (Spawner)
        public Can()
        {

        }

        //Member Methods (Can Do)
    }
}
