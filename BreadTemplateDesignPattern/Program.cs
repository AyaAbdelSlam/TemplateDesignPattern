using System;

namespace BreadTemplateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Bread sourdough = new Sourdough();
            sourdough.Make();

            Console.WriteLine("\n");
            Bread twelveGrain = new TwelveGrain();
            twelveGrain.Make();

            Console.WriteLine("\n");

            Bread wholeWheat = new WholeWheat();
            wholeWheat.Make();
            Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}
