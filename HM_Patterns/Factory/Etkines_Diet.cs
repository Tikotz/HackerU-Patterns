using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Etkines_Diet : IDietBase
    {
        public string DiatMenu { get; set; } = "Dont eat Delicious FOOD!";

        public void GetDiat()
        {
            Console.WriteLine(DiatMenu);
        }
    }
}
