using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain
{
    public abstract class BaseHendler
    {
        protected BaseHendler next;

        public void SetNext(BaseHendler MyNext)
        {
            this.next = MyNext;
        }

        public abstract void HandelRequest(int amount);
    }
}
