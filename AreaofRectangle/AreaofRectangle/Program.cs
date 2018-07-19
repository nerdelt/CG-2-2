using System;

namespace AreaofRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int h;
            int y;

            Console.WriteLine("Let's find the area of your rectangle!");
            Console.Write("Please type the height of the rectangle: ");
            int h = Console.ReadLine();

            Console.Write("Please type the width of the rectangle: ");
            int y =Console.ReadLine();

            int area = h*y;
            Console.WriteLine("The area of the rectangle is: {0}", area);
            Console.ReadLine();




        }
    }
}
