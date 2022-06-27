using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mono
{
    class Square : Rectangle
    {

        public Square()
        {
            this.A = 0;
            this.B = A;
        }
        public Square(int a)
        {
            this.A = a;
            this.B = this.A;
        }

        public override void PrintShapeInfo()
        {
            Console.WriteLine("Side: " + this.A);
            Console.WriteLine("Area: " + GetArea());
            Console.WriteLine("Circumference: "+ GetCircumference());
        }
    }
}
