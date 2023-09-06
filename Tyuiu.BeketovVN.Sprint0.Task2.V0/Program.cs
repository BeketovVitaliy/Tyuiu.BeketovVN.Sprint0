using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BeketovVN.Sprint0.Task2.V0.Lib;

namespace Tyuiu.BeketovVN.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMassage("Виталий"));
            Console.ReadKey();
        }
    }
}
