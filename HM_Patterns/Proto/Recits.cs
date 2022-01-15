using HM_Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proto
{
    public class Recits : IClone<Recits>
    {
        public Client client1 { get; set; }
        public int AmountThatPayed { get; set; }
        public int Taxes { get; set; }
        public DateTime DateOfPerchase { get; set; }


      
        public Recits(Client client, int amountThatPayed,int taxes, DateTime dateOfPerchase)
        {
            this.client1 = client;
            AmountThatPayed = amountThatPayed;
            Taxes = taxes;
            DateOfPerchase = dateOfPerchase;
        }
        public Recits()
        {

        }
        public Recits Clone()
        {
            Recits clone = new Recits(this.client1,this.AmountThatPayed,this.Taxes,this.DateOfPerchase);
            return clone;

        }

        public override string ToString()
        {
            return $"client : {client1.Name} {client1.LastName} , age: {client1.Id} \n deal date : {DateOfPerchase}";
        }
    }
}
