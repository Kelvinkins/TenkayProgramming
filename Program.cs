using System;

namespace MyFirstProgram
{



    class Rectangle
    {
        //class members
        double length;
        double width;

        //This method accepts rectangle details
        public void AcceptDetails()
        {
            length = 10.6;
            width = 17.5;
        }

        //This gets rectangle area
        public double GetArea()
        {
            return length * width;
        }

        //This displays the details of a rectangle
        public void Display()
        {
            Console.WriteLine($"This is length:{length}");
            Console.WriteLine($"This is width:{width}");
            Console.WriteLine($"This is the area of the rectangle:{GetArea()}");
        }



    }




    class Program
    {

        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.AcceptDetails();
            rectangle.Display();

        }
    }
}
