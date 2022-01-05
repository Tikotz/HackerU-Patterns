using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class NoDiet : IDietBase
    {

        public string DiatMenu { get; set; } = "YOU DONT NEED ANY DIAT YOU STUPID HUMEN";

        public void GetDiat()
        {
            Console.WriteLine(DiatMenu);
        }
    }
}
