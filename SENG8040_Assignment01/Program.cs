using System;

namespace SENG8040_Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            int input = 0;
            bool success;

            //lenghth
            Console.WriteLine(" Please enter a value greater than 0 for length of the rectangle: ");

            try
            {
                do
                {
                    success = int.TryParse(Console.ReadLine(), out input);
                    if (!success)
                    {
                        Console.WriteLine(" Invalid input ");
                        Console.WriteLine(" Please try another input !! ");
                        continue;
                    }
                    if (input <= 0)
                    {
                        success = false;
                        Console.WriteLine(" Value should be greater than zero (0) ");
                        Console.WriteLine(" Please try another input !! ");
                    }

                }

                while (!success);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            rectangle.SetLength(input);

            //width
            Console.WriteLine(" Please enter a value greater than 0 for width of the rectangle: ");
            try
            {
                do
                {
                    success = int.TryParse(Console.ReadLine(), out input);
                    if (!success)
                    {
                        Console.WriteLine(" Invalid input ");
                        Console.WriteLine(" Please try another input !! ");
                        continue;
                    }
                    if (input <= 0)
                    {
                        success = false;
                        Console.WriteLine(" Value should be greater than zero (0) ");
                        Console.WriteLine(" Please try another input !! ");
                    }

                }

                while (!success);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            rectangle.SetWidth(input);

            int choice = 0;
            do
            {

                Console.WriteLine("\nPlease select an option from below mentioned list : ");
                Console.WriteLine(" 1. Get Rectangle Length ");
                Console.WriteLine(" 2. Update Rectangle Length ");
                Console.WriteLine(" 3. Get Rectangle Width ");
                Console.WriteLine(" 4. Update Rectangle Width ");
                Console.WriteLine(" 5. Calculate Rectangle Perimeter ");
                Console.WriteLine(" 6. Calculate Rectangle Area ");
                Console.WriteLine(" 7. Exit \n");

                //user choice inpiut
                try
                {
                    do
                    {
                        success = int.TryParse(Console.ReadLine(), out choice);
                        if (!success)
                        {
                            Console.WriteLine(" Invalid input ");
                            Console.WriteLine(" Please try another input !! ");
                            continue;
                        }

                    }

                    while (!success);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine(" Length of rectangle is: {0}\n ", rectangle.GetLength());
                        break;

                    case 2:
                        Console.WriteLine(" Please enter a value for length of the rectangle: ");
                        try
                        {
                            do
                            {
                                success = int.TryParse(Console.ReadLine(), out input);
                                if (!success)
                                {
                                    Console.WriteLine(" Invalid input ");
                                    Console.WriteLine(" Please try another input !! ");
                                    continue;
                                }
                                if (input < 1)
                                {
                                    success = false;
                                    Console.WriteLine(" Value should be greater than zero (0) ");
                                    Console.WriteLine(" Please try another input !! ");
                                }

                            }

                            while (!success);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //length updated
                        rectangle.SetLength(input);
                        Console.WriteLine(" New length updated ");
                        break;

                    case 3:
                        Console.WriteLine(" Width of rectangle is: {0}\n ", rectangle.GetWidth());
                        break;

                    case 4:
                        Console.WriteLine(" Please enter a value for width of the rectangle: ");
                        try
                        {
                            do
                            {
                                success = int.TryParse(Console.ReadLine(), out input);
                                if (!success)
                                {
                                    Console.WriteLine(" Invalid input ");
                                    Console.WriteLine(" Please try another input !! ");
                                    continue;
                                }
                                if (input < 1)
                                {
                                    success = false;
                                    Console.WriteLine(" Value should be greater than zero (0) ");
                                    Console.WriteLine(" Please try another input !! ");
                                }

                            }

                            while (!success);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        // width updated
                        rectangle.SetWidth(input);
                        Console.WriteLine(" New width updated ");
                        break;

                    case 5:
                        Console.WriteLine(" Perimeter of rectangle : {0}\n ", rectangle.GetPerimeter());
                        break;

                    case 6:
                        Console.WriteLine(" Area of rectangle : {0}\n ", rectangle.GetArea());
                        break;

                    case 7:
                        Console.WriteLine(" Exitting ");
                        break;

                    default:
                        Console.WriteLine(" Enter Valid values for menu options (1-7) ");
                        continue;
                }
            }

            while (choice != 7);
        }
    }
}
