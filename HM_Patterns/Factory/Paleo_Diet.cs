using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Paleo_Diet : IDietBase
    {
        public string DiatMenu { get; set; } = "Eat Just Meat";
        
        public void GetDiat()
        {
            Console.WriteLine(DiatMenu);
        }
    }
}
