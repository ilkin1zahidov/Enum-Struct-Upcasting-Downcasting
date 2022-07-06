using System;
using System.Collections.Generic;
using System.Text;

namespace Enum_Struct_Upcasting_Downcasting.Models
{
    public class Boss : Director
    {
        public int Fulltime { get; set; }
        public override void Money()
        {
            Console.WriteLine("Boss have a money");
        }
    }
}
