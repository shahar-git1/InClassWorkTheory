using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassWorkTheory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "First", "Second", "Third", "Fourth", "Fifth" };
            Console.WriteLine(string.Join(Environment.MachineName, arr));

            Console.ReadKey();
        }
    }
}
