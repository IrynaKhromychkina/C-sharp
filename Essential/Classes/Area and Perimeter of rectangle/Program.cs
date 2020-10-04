using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleAreaAndPerimeter
{

    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning1 = true;

            while (isRunning1)
            {
                Console.WriteLine("Please enter the width of rectangle.");
                string widthString = Console.ReadLine().Trim();

                bool successWidth = Double.TryParse(widthString, out double widthDouble);

                if (successWidth && widthDouble > 0)
                {
                    isRunning1 = false;
                    bool isRunning2 = true;

                    while (isRunning2)
                    {
                        Console.WriteLine("Please enter the height of rectangle.");
                        string heightString = Console.ReadLine().Trim();
                        bool successHeight = Double.TryParse(heightString, out double heightDouble);

                        if (successHeight && heightDouble > 0)
                        {
                            isRunning2 = false;
                            Console.WriteLine("Thank you!");
                            Rectangle rectangleEntered = new Rectangle(widthDouble, heightDouble);
                            Console.WriteLine($"The area of the rectangle is {rectangleEntered.Area} and the perimeter is {rectangleEntered.Perimeter}");
                        }

                        else
                        {
                            if (successHeight && heightDouble <= 0)
                            {
                                Console.WriteLine("The height can not be zero or less than zero");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Wrong input.");
                                continue;
                            }
                        }
                    }
                }

                else
                {
                    if (successWidth && widthDouble <= 0)
                    {
                        Console.WriteLine("The width can not be zero or  less than zero");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input.");
                        continue;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}


