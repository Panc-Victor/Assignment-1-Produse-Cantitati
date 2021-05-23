using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Produse_Cantitati
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Format("{0,-15}{1,-5}{2,7}",
                                 "Produs",
                                 "UM",
                                 "Cant"));
            PrintProductLine("Mere", "buc", 3);
            PrintProductLine("Pere", "buc", 5);
            PrintProductLine("Zahar", "kg", 10);
        }
        private static void PrintProductLine(
            string productName,
            string um,
            float quantity)
        {
            string line = string.Format("{0,-15}{1,-5}{2,7}",
                            productName,
                            um,
                            quantity);
            Console.WriteLine(line);
        }
    }
}
