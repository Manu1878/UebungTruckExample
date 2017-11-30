using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DummyClient
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            Handler h = new Handler();

            while (true)
            {
                h.SendMessage("S1-45AB@Graz@Ladung1@" + rand.Next(10, 50) + "@" + rand.Next(70, 300) + "@LadungA@100@400");
                Thread.Sleep(5000);
            }
        }
    }
}
