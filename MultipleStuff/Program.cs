using System;

namespace MultipleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperList sl = new SuperList(){ 4f, -4f, 256f, 32256f};

            sl.GetMinMax1(out double min1, out double max1);
            Console.WriteLine($"GetMinMax1: min-|{min1}|; max-|{max1}|");

            MinMax minmax2= sl.GetMinMax2();
            Console.WriteLine($"GetMinMax1: min-|{minmax2.Min}|; max-|{minmax2.Max}|");
        }
    }
}
