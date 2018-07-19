using System;

namespace AreaofRectangle
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Let's find the area of your rectangle!");
            Console.Write("Please type the height of the rectangle: ");
            decimal.lengthSide = decimal.Parse(Console.ReadLine()); 

            Console.Write("Please type the width of the rectangle: ");
            decimal.widthSide = decimal.Parse(Console.ReadLine());

            decimal area = lengthside * widthSide;
            Console.WriteLine("The area of the rectangle is: {0}", area);
            Console.ReadLine();




        }
    }
}
