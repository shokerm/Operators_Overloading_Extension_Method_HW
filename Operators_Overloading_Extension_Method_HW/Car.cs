using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Operators_Overloading_Extension_Method_HW
{
    public class Car
    {
        public int Id { get; set; }
        public string Color { get; set; }

        public int NumOfDoors { get; set; }



        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
