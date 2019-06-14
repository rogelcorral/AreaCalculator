using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    //This simple program calculates the area
    //of basic shapes.
    //
    // Rogel SJ Corral
    // 19 September 2016
    //

    class Program
    {

        static void Main(string[] args)
        {
            // Displays the main menu

            bool displayMenu = true;
            while (displayMenu) 
            {
                displayMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            // Main menu options

            Console.Clear();
            Console.WriteLine("Choose what Area you want to calculate:");
            Console.WriteLine("1) Area of a Square");
            Console.WriteLine("2) Area of a Circle");
            Console.WriteLine("3) Area of a Triangle");
            Console.WriteLine("4) Area of an Ellipse");
            Console.WriteLine("5) Area of a Trapezoid");
            Console.WriteLine("6) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                AreaSquare();
                return true;
            }
            else if (result == "2")
            {
                AreaCircle();
                return true;
            }
            else if (result == "3")
            {
                AreaTriangle();
                return true;
            }
            else if (result == "4")
            {
                AreaEllipse();
                return true;
            }
            else if (result == "5")
            {
                AreaTrapezoid();
                return true;
            }
            else if (result == "6")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void AreaSquare()
        {
            // Compute for the Area of a Square

            Console.Clear();
            double SA;
            Console.WriteLine("Input Length: ");
            double L = double.Parse(Console.ReadLine());
            Console.WriteLine("Input Width: ");
            double W = double.Parse(Console.ReadLine());
            SA = L * W;

            Console.WriteLine("Area of a Square: " + SA);
            Console.ReadLine();
        }

        private static bool AreaCircle()
        {
            // Compute for the Area of a Circle

            Console.Clear();
            Console.WriteLine("Choose Radius or Diameter:");
            Console.WriteLine("1) Radius");
            Console.WriteLine("2) Diameter");
            Console.WriteLine("3) Exit");
            string resultC = Console.ReadLine();
            if (resultC == "1")
            {
                AreaCircleR();
                return true;
            }
            else if (resultC == "2")
            {
                AreaCircleD();
                return true;
            }
            else if (resultC == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void AreaCircleR()
        {
            // Sub menu for the function AreaCircle
            // When Input is Radius

            Console.Clear();
            double CA;
            Console.WriteLine("Input Radius: ");
            double R = double.Parse(Console.ReadLine());
            CA = Math.PI * (Math.Pow(R, 2));

            Console.WriteLine("Area of a Circle: " + CA);
            Console.ReadLine();
        }

        private static void AreaCircleD()
        {
            // Sub menu for the function AreaCircle
            // When Input is Diameter

            Console.Clear();
            double CA;
            Console.WriteLine("Input Diameter: ");
            double D = double.Parse(Console.ReadLine());
            CA = Math.PI * (Math.Pow((D/2), 2));

            Console.WriteLine("Area of a Circle: " + CA);
            Console.ReadLine();
        }

        private static void AreaTriangle()
        {
            // Compute for the Area of a Triangle

            Console.Clear();
            double TriA;
            Console.WriteLine("Input Base: ");
            double B = double.Parse(Console.ReadLine());
            Console.WriteLine("Input Height: ");
            double H = double.Parse(Console.ReadLine());

            TriA = (B * H) / 2;

            Console.WriteLine("Area of a Triangle: " + TriA);
            Console.ReadLine();
        }

        private static void AreaEllipse()
        {
            // Compute for the Area of an Ellipse

            Console.Clear();
            double EA;
            Console.WriteLine("Input Radius 1: ");
            double R1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input Radius 2: ");
            double R2 = double.Parse(Console.ReadLine());

            EA = Math.PI * R1 * R2;

            Console.WriteLine("Area of an Ellipse: " + EA);
            Console.ReadLine();
        }

        private static void AreaTrapezoid()
        {
            // Compute for the Area of a Trapezoid

            Console.Clear();
            double TraA;
            Console.WriteLine("Input Width 1: ");
            double W1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input Width 2: ");
            double W2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input Height: ");
            double He = double.Parse(Console.ReadLine());

            TraA = ((W1 + W2) / 2) * He;

            Console.WriteLine("Area of a Trapezoid: " + TraA);
            Console.ReadLine();
        }

    }
}
