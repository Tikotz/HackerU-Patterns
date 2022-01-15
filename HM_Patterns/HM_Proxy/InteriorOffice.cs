using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Proxy
{
    public class InteriorOffice : IFulloption, IServiceMechine
    {
        public void AddClient()
        {
            Console.WriteLine("New Client is added");
        }

        public void ChangeAddress()
        {
            Console.WriteLine("Address Updated ");
        }

        public void ChangePassword()
        {
            Console.WriteLine("Password changed");
        }

        public void RemoveClient()
        {
            Console.WriteLine("Client removed");
        }

        public void ShowAllClients()
        {
            Console.WriteLine("All clients...");
        }

        public void ShowInfo()
        {
            Console.WriteLine("All Info...");
        }

        public void UpdatePassport()
        {
            Console.WriteLine("Enjoy New Passport");
        }
    }
}
