using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mono
{
    public class GenericLists<T> where T : IShape
    {
        Func<T,double> getArea = T => T.GetArea();
        Func<T, double> getCircumference = T => T.GetCircumference();

        public double getMaxArea(List<T> items)
        {
            return GetMax(items, getArea);
        }

        public double getMinArea(List<T> items)
        {
            return GetMin(items, getArea);
        }

        public double getMaxCircumference(List<T> items)
        {
            return GetMax(items, getCircumference);
        }

        public double getMinCircumference(List<T> items)
        {
            return GetMin(items, getCircumference);
        }

        public double GetMax(List<T> items, Func<T, double> function)
        {
            double max = 0;
            foreach (T item in items)
            {
                if (max <function.Invoke(item))
                {
                    max = function.Invoke(item);
                }
            }
            return max;
        }

        public double GetMin(List<T> items, Func<T, double> function)
        {

            double min = function.Invoke(items.ElementAt(0));
            foreach (T item in items)
            {
                if (min > function.Invoke(item))
                {
                    min = function.Invoke(item);
                }
            }
            return min;
        }


    }
}