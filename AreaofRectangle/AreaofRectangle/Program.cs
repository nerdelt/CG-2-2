using System;

namespace AreaofRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int h;
            int y;

            Console.WriteLine("Lets find the area of your rectangle!");
            Console.Write("Please type the height of the rectangle: ");
            h = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please type the width of the rectangle: ");
            y = Convert.ToInt32(Console.ReadLine());

            int area = h*y;
            Console.WriteLine("The area of the rectangle is: {0}", area);
            Console.ReadLine();




        }
    }
}
