using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleStuff
{
    public class SuperList : List<double>
    {

        public void GetMinMax1(out double min, out double max)
        {
            min = double.MaxValue;
            max = double.MinValue;

            foreach (double num in this)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }
        }

        public MinMax GetMinMax2()
        {
            double min = double.MaxValue;
            double max = double.MinValue;

            foreach (double num in this)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }
            return new MinMax(min, max);
        }

        public Tuple<double, double> GetMinMax3()
        {
            double min = double.MaxValue;
            double max = double.MinValue;

            foreach (double num in this)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }
            return new Tuple<double, double>(min, max);
        }

        public (double min, double max) GetMinMax4()
        {
            double min = double.MaxValue;
            double max = double.MinValue;

            foreach (double num in this)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }
            return (min, max);
        }





    }

    public struct MinMax
    {
        public double Min { get; }
        public double Max { get; }

        public MinMax(double min, double max)
        {
            Min = min;
            Max = max;
        }
    }








}
