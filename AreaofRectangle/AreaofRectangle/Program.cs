using System;

namespace AreaofRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(h);
            int y = int.Parse(y);

            Console.WriteLine("Let's find the area of your rectangle!");
            Console.Write("Please type the height of the rectangle: ");
            string h = Console.ReadLine();

            Console.Write("Please type the width of the rectangle: ");
            string y =Console.ReadLine();

            int area = h*y;
            Console.WriteLine("The area of the rectangle is: {0}", area);
            Console.ReadLine();




        }
    }
}
