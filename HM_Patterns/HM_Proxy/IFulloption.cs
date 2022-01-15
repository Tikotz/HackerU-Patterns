using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Proxy
{
    public interface IFulloption
    {
        public void AddClient();
        public void RemoveClient();
        public void ShowInfo();
        public void ShowAllClients();
    }
}
