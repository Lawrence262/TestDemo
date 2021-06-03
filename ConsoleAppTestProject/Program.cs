using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestDemo;

namespace ConsoleAppTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                UnitTest1 t = new UnitTest1();
                t.AddTest();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
