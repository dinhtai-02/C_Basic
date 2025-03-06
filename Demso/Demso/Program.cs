// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demso
{
    class Program
    {
        static void Main()
        {
            string n = Console.ReadLine();

            if (n[0] == '-')
            {
                Console.WriteLine(n.Length - 1);
            }
            else
            {
                Console.WriteLine(n.Length);
            }
                
        }
    }
}
