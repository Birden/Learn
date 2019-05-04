using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    class Some
    {
        public void Multiply(int a, int b)
        {
            Console.WriteLine("Result:" + a * b);
        }
        public void Multiply(int a, int b, int c)
        {
            Console.WriteLine("Result:" + a * b * c);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Some test = new Some();
            test.Multiply(2, 4);
            test.Multiply(2, 4, 5);
            Console.ReadKey();
        }
    }
}
