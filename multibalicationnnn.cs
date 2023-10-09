using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multibalicationnumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("enter any number");
            i = int.Parse(Console.ReadLine());
           
            do
            {
                int secoundpower = i * i;
                Console.WriteLine(i + "x" + i + "=" + secoundpower);
                i--;



            }
            while (i > 0);
            Console.ReadLine();

        }
    }
}
