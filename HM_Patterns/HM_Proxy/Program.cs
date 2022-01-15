using System;

namespace HM_Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InteriorOffice interiorOffice = new InteriorOffice();
            ServiceMachine serviceMachine = new ServiceMachine(interiorOffice);

            serviceMachine.ShowInfo();
            serviceMachine.UpdatePassport();
            serviceMachine.ChangeAddress();
            serviceMachine.ChangePassword();

            
        }
    }
}
