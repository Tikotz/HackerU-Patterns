using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public interface IDietBase
    {
        public string DiatMenu { get; set; }
        public void GetDiat();
    }
}
