using CalculatorLib;
using System;

namespace CalculatorProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt p1;
            Punkt p2;

            Console.WriteLine("Bitte Zahl 1 eingeben.");
            string zahl1 = Console.ReadLine();

            Console.WriteLine("Bitte Zahl 2 eingeben.");
            string zahl2 = Console.ReadLine();

            float z1 = 0;
            float z2 = 0;

            try
            {
                z1 = float.Parse(zahl1);
                z2 = float.Parse(zahl2);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Ergebnis: " + (z1 + z2));

        }
    }
}
