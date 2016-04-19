using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    public class MyPoint
    {
        private float x;
        private float y;

        public float X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public float Y
        {
            get { return y; }
            set { y = value; }
        }

        public static MyPoint Parse(string zahl1)
        {
            string[] array = zahl1.Split(';');
            MyPoint punkt = new MyPoint();

            punkt.X = float.Parse(array[0]);
            punkt.Y = float.Parse(array[1]);

            return punkt;
        }

        public static MyPoint operator+(MyPoint p1, MyPoint p2)
        {
            MyPoint ergebnis = new MyPoint();
            ergebnis.X = p1.X + p2.X;
            ergebnis.Y = p1.Y + p2.Y;

            return ergebnis;
        }
        public override string ToString()
        {
            return this.X + ";" + this.Y;
        }
    }
}
