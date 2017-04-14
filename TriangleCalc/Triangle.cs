using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleCalc
{
    class Triangle
    {
        private List<int> sides;

        public Triangle(int s1, int s2, int s3)
        {
            // Check for length possibilites
            sides = new List<int>() { s1, s2, s3 };
            int maxSide = sides.Max();
            List<int> remainingSides = sides.ToList();
            remainingSides.Remove(maxSide);
            if (maxSide >= remainingSides.Sum())
            {
                throw new Exception("Cannot create Triangle from given sides.");
            };
        }

        public double Area()
        {
            double p = Perimeter() / 2.0;
            double area = Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]));
            return area;
        }

        public int Perimeter()
        {
            return sides.Sum();
        }

        public IEnumerable<double> Angles()
        {
            List<double> angles = new List<double>();

            // get base and height
            int baseSide = sides.Max();
            List<int> remainingSides = sides.ToList();
            remainingSides.Remove(baseSide);
            double heightSide = Area() * 2.0 / baseSide;
            
            // retrieve angles based on height and side(hypotenuse)
            double angle1 = Math.Asin(heightSide / remainingSides[0]) * 180 / Math.PI;
            double angle2 = Math.Asin(heightSide / remainingSides[1]) * 180 / Math.PI;
            double angle3 = 180 - angle1 - angle2;  

            angles.Add(angle1);
            angles.Add(angle2);
            angles.Add(angle3);

            return angles;
        }
    }
}
