using System;
using System.Collections.Generic;
using System.Text;

namespace Enum_Struct_Upcasting_Downcasting.Models
{
    public class Employers : Software_developer
    {
        public int tired { get; set; } 
        public override void Money()
        {
            Console.WriteLine("Employers have a Money");
        }
    }
}
