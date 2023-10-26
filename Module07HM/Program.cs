using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordOfTanks;

namespace Module07HM
{
    public class Program
    {
        static void Main()
        {
            Tank[] tanks = new Tank[10];

            for (int i = 0; i < 5; i++)
            {
                tanks[i] = new Tank("Т-34");
                tanks[i + 5] = new Tank("Pantera");
            }

            // Проведение битв
            for (int i = 0; i < 5; i++)
            {
                if (tanks[i] ^ tanks[i + 5])
                    Console.WriteLine($"{tanks[i].GetTankParameters()} победил в сражении с {tanks[i + 5].GetTankParameters()}");
                else
                    Console.WriteLine($"{tanks[i + 5].GetTankParameters()} победил в сражении с {tanks[i].GetTankParameters()}");
            }
        }
    }
}
