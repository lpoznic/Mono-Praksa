using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mono
{
    class Circle : IShape
    { 
        private double R { get; set; }

        public Circle(double r)
        {
            this.R = r;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(this.R, 2);
        }

        public double GetCircumference()
        {
            return 2 * Math.PI * R;
        }

        public void PrintShapeInfo()
        {
            Console.Write("Radius :" + R);
            Console.WriteLine("Area: " + GetArea());
            Console.WriteLine("Circumference :" + GetCircumference());
        }
    }
}
