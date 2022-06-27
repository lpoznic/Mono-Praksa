using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mono
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rectangle> rectangles = new List<Rectangle>();
            GenericLists<Rectangle> list = new GenericLists<Rectangle>();

            List<Circle> circles = new List<Circle>();
            GenericLists<Circle> circleList = new GenericLists<Circle>();

            for (int i = 0; i < 20; i++)
            {
                Random random = new Random();
                circles.Add(new Circle(random.Next(1,10)));
                Console.WriteLine("{0}", i + 1); 
                circles.ElementAt(i).PrintShapeInfo();
                Console.WriteLine("\n");
            }
            Console.WriteLine("Area: ");
            Console.Write(circleList.getMaxArea(circles).ToString("R") + " -- " + circleList.getMinArea(circles).ToString("R")+"\n");
            Console.WriteLine("Circumference: ");
            Console.Write(circleList.getMaxCircumference(circles).ToString("R") + " -- " + circleList.getMinCircumference(circles).ToString("R")+ "\n");

        }

    }
        
}

