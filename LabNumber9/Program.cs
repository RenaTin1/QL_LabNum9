using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Serena Tindle-- LabNumber9 (Circumference and Area of Radius)

            bool ContinueProgram = true;
            while (ContinueProgram == true)
            {

                Circle RadiusCalc = new Circle(); //create an object

                Console.WriteLine("Welcome to the Circle Tester"); //prompt
                Console.WriteLine("Enter radius:");
                
                RadiusCalc.Radius = ReadValidDouble(); //feed object
                Console.WriteLine("Circumference:" + RadiusCalc.GetCircumference());
                Console.WriteLine("Area:"+RadiusCalc.GetArea());//call method for area

                string UserOption; //Continue program or exit?
                Console.WriteLine("Continue? (y/n)");
                UserOption = Console.ReadLine();

                if (UserOption == "N" || UserOption == "No" || UserOption == "no" || UserOption == "n")
                {
                    ContinueProgram = false;
                    Console.WriteLine("Goodbye. You created two circle object(s).");
                }

                Console.ReadKey();
        }
        }
        
        public static double ReadValidDouble() //method for validation 
        {
            double.Parse(Console.ReadLine());
            double input = 0;

            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please enter valid data");
            }
            return input;

        }
    }
}
