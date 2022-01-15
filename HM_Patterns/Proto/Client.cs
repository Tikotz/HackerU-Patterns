using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proto
{
    public class Client
    {
        public string Name{ get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        public Client()
        {

        }
        public Client(string name,string LName, int id)
        {
            Name = name;
            LastName = LName;
            Id = id;
        }


    }
}
