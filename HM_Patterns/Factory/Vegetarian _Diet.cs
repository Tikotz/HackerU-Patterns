using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Vegetarian__Diet : IDietBase
    {
        public string DiatMenu { get; set; } = "Eat ONLY vegetables AND die...";

       
        public void GetDiat()
        {
            Console.WriteLine(DiatMenu);
        }
    }
}
