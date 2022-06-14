using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool isColdBlooded { get; set; }
        public bool isAquatic { get; set; }
        public string colors { get; set; } 
        public int numberOfLegs { get; set; }
    }
}
