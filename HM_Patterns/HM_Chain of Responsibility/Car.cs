using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Chain_of_Responsibility
{
    public abstract class Car
    {
        int Grade;
        protected Car next;

        public bool IsOK { get; set; }

        public void SetNext(Car next)
        {
            this.next = next;
        }
        public abstract void Handle();
    }
}
