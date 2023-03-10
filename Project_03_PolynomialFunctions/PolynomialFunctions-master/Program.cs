using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_03_Polynomial_functions
{
    class Program
    {
        static void Main(string[] args)
        {
            MainProgram();
            void MainProgram()
            {
                int id = 1;
                double guess;
                string userInput;
                List<Point2D> pointList = new List<Point2D>();

                Console.WriteLine("Please input points in x y representation\nType END to finish");

                while (true)
                {
                    Console.Write($"Point {id++}: ");
                    userInput = Console.ReadLine();
                    if (userInput == "END")
                    {
                        break;
                    }
                    pointList.Add(new Point2D(userInput));
                }
                Polynomial polynom = new Polynomial(pointList);

                Console.WriteLine($"Resulting polynomial will be of the order {pointList.Count - 1}");
                Console.WriteLine("Calculated Polynomial: ");
                polynom.ShowFunction();
                polynom.ShowSolution(-1);
                polynom.ShowSolution(0);
                polynom.ShowSolution(1);
                polynom.ShowDerivative();
                bool exit = false;
                do
                {
                    Console.Write("Looking for a root with initial guess : ");
                    exit = double.TryParse(Console.ReadLine(), out guess);
                } while (!exit);
                polynom.FindRoots(guess);
               
                LoopOfMainProgram();
            }
            void LoopOfMainProgram()
            {
                while (true)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear(); MainProgram(); break;
                }
            }

        }
    }
}
