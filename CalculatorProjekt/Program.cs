using CalculatorLib;
using System;

namespace CalculatorProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
    
            Console.WriteLine("Bitte Zahl 1 eingeben.");
            string zahl1 = Console.ReadLine();

            Console.WriteLine("Bitte Zahl 2 eingeben.");
            string zahl2 = Console.ReadLine();

            MyPoint p1 = new MyPoint();
            MyPoint p2 = new MyPoint();
            
            try
            {
                p1 = MyPoint.Parse(zahl1);
                p2 = MyPoint.Parse(zahl2);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Ergebnis: " + (p1 + p2));

        }
    }
}
