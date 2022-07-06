using System;
using System.Collections.Generic;
using System.Text;

namespace Enum_Struct_Upcasting_Downcasting.Models
{
    public class Shark : Fish
    {
        public int Weight { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Shark eating");
        }
    }
}
