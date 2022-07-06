using System;
using System.Collections.Generic;
using System.Text;

namespace Enum_Struct_Upcasting_Downcasting.Models
{
    public class Eagle : Bird
    {
        public int Age { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eagle eating");
        }
    }
}
