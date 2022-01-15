using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Proxy
{
    public interface IServiceMechine
    {
        public void ChangeAddress();
        public void ChangePassword();
        public void UpdatePassport();
        public void ShowInfo();
    }
}
