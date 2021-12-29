using System;
class Container : IEnumerable
    {
        IFigure[] figures;

        public Container(IFigure[] gf)
        {
            figures = gf;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return figures.GetEnumerator();
        }
    }
class circle : IFigure
    {
        private int radius;
        private String colour;

        public circle(int newRadius, String newColour)
        {
            radius = newRadius;
            colour = newColour;
        }

        public double space
        {
            get
            {
                return Math.PI * Math.Pow(radius, 2);
            }
        }

        public void info()
        {
            Console.WriteLine($"radius of circle = {radius}");
            Console.WriteLine($"colour of circle = {colour}");
            Console.WriteLine($"circle space size = {space}");
        }
    }
class square : IFigure
    {
        private int side;

        public double space
        {
            get
            {
                return side * Math.Sqrt(2);
            }
        }
        public void info()
        {
            Console.WriteLine($"square side size = {side}");
            Console.WriteLine($"square spase size = {space}");
            Console.WriteLine($"square perimeter size = {perimeter()}");
        }
        public square(int newSide)
        {
            side = newSide;
        }

        public int perimeter()
        {
            return 4 * side;
        }
    }
interface IFigure
    {
        double space 
        {
            get;
        }
        void info();
    }
class Program
    {
		public static void Main()
		{
			square f1 = new square(5);
			square f2 = new square(8);
			circle f3 = new circle(3, "red");
			circle f4 = new circle(7, "green");
			IFigure[] figures = new string[] {f1, f2, f3, f4};

			Container arr = new Container(figures);
			foreach (string a in arr)
			{
				Console.WriteLine(a);
			}
		}
	}
