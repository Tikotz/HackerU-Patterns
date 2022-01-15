using System;
using System.Text.Json;

namespace Proto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("ori", "Tiko", 1);
            Recits rec1 = new Recits(client, 1000, 69, new DateTime(2015, 12, 25));
            Recits rec1_clone = rec1.Clone();


            Recits cloneserial = DeepCopy<Recits>(rec1);
            client.Name = "Ori";
            Console.WriteLine(rec1_clone);
            Console.WriteLine(cloneserial);

        }


        public static T DeepCopy<T>(T info)
        {
            var json = JsonSerializer.Serialize(info);
            T obj = JsonSerializer.Deserialize<T>(json);
            return obj;
        }


    }
}

