using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public bool canFly { get; set; }
        public string colors { get; set; }
        public string birdSong { get; set; }
        public void SingSong ()
        {
            Console.WriteLine($"{birdSong}");
        }
    } 

}
