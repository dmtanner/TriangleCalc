using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get side lengths
            Console.Write("Length 1: ");
            int Side1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Length 2: ");
            int Side2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Length 3: ");
            int Side3 = Convert.ToInt32(Console.ReadLine());

            try
            {
                Triangle triangle = new Triangle(Side1, Side2, Side3);
                Console.WriteLine("Perimeter: {0}", triangle.Perimeter());
                Console.WriteLine("Area: {0}", triangle.Area());
                Console.WriteLine("Angles: {0}", String.Join(", ", triangle.Angles().Select(x => Math.Truncate(x)) ) );
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.Read();
        }
    }
}
