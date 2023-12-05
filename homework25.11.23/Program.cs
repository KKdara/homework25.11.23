using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace homework25._11._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Home task 13.1");
            Building building = new Building();
            building.Height = 100;
            building.Floors = 35;
            building.Flats = 200;
            building.Entrances = 20;
            building.Print();
            
            Console.WriteLine("\nTask 14.1");
#if DEBUG
            BankAccount account = new BankAccount(3000, "Savings", "Bob");
            account.DumpToScreen();
#else 
Console.WriteLine("бям");
#endif
            Console.WriteLine("Press any key to continue work)");
            Console.ReadKey();
        }
    }
}
