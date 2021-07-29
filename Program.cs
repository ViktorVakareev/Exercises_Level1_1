using System;
using System.Collections.Generic;

namespace Exercises_Level1_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////1. Square root and power of a number 
            //int number = 32346;
            //var numbers = new[] { 2, 202, 2002 };
            //double squareRoot = Math.Sqrt(number);
            //long squareOfNumber = (long)Math.Pow(number, 2);
           
            //Console.WriteLine("{0}, {1} and {2}", numbers[0], numbers[1], numbers[2]);
            //Console.WriteLine($"{numbers[0]}, {numbers[1]} and {numbers[2]}");
            //Console.WriteLine("The square power of 32346 is: {0}", squareOfNumber);
            //Console.WriteLine($"The square root of 32346 is: {squareRoot:f2}\n");
            //Console.ReadLine();

            ////2. Get current date and time
            //var currentDate = DateTime.Now;           
            //Console.WriteLine($"Current date / time: { currentDate }");
            //Console.ReadLine();

            ////3. Working with boolean
            //Console.Write("Enter name: ");
            //string name = Console.ReadLine();
            //Console.Write("Enter gender: ");
            //string gender = Console.ReadLine().ToUpper();
            //bool isFemale = FindGender(gender);
            
            //Console.WriteLine("Hello Victor!");
            //Console.WriteLine($"{name}'s gender is '{gender}' so isFemale variable = {isFemale}\n");
            //Console.ReadLine();

            ////4. Get the ASCII code of a char
            //char symbol = '$';
                    
            //Console.WriteLine($"The code for '{symbol}' is: {(int)symbol}\n");

            ////5. Conacatenate strings, cast type object to string
            //string word1 = "Hello";
            //string word2 = "World";
            //object obj1 = String.Format(word1 + " " + word2);
            //string objectAsString = (string)obj1;
           
            //Console.WriteLine($"This is an object: {obj1}");
            //Console.WriteLine($"This is a string: {objectAsString}\n");
            //Console.ReadLine();

            ////6. Exchange int values of two integers
            //int a = 5;
            //int b = 10;
            //Console.WriteLine($"a = {a}, b = {b}");
            //int temp = 0;
            //temp = a;
            //a = b;
            //b = temp;

            //Console.WriteLine($"After exchanging values -> a = {a}, b = {b}\n");
            //Console.ReadLine();

            ////7. Employees
            //Random rnd = new Random();
            //int employeeId1 = rnd.Next(38560000, 38569999);
            //int employeeId2 = rnd.Next(38560000, 38569999);

            //var employee1 = new Employee()
            //{
            //    FirstName = "Victor",
            //    FamilyName = "Vakareev",
            //    Age = 40,
            //    gender = Gender.m,
            //    IdNumber = 55,
            //    EmployeeNumber = employeeId1
            //};
            //var employee2 = new Employee()
            //{
            //    FirstName = "Maria",
            //    FamilyName = "Testova",
            //    Age = 24,
            //    gender = Gender.f,
            //    IdNumber = 44,
            //    EmployeeNumber = employeeId2
            //};
            
            //Console.WriteLine(employee1.ToString());
            //Console.WriteLine(employee2.ToString());
            //Console.ReadLine();

            ////8. Even or Odd?
            //Console.Write("Enter a number to check if even or odd(int): ");
            //int num = int.Parse(Console.ReadLine());
            
            //Console.WriteLine($"The number is: {CheckEvenOrOdd(num)}");
            //Console.ReadLine();

            ////9. Rectangle area
            //Console.Write("Enter rectangular side A in cm: ");
            //double width = Double.Parse(Console.ReadLine());
            //Console.Write("Enter rectangular side A in cm: ");
            //double height = Double.Parse(Console.ReadLine());
            
            //Console.WriteLine($"The rectangle area is: {width * height} cm2");
            //Console.ReadLine();

            ////10. Trapezoid area
            //Console.Write("Enter trapezoid side A in cm: ");
            //double sideA = Double.Parse(Console.ReadLine());
            //Console.Write("Enter trapezoid side B in cm: ");
            //double sideB = Double.Parse(Console.ReadLine());
            //Console.Write("Enter trapezoid height in cm: ");
            //double heightTrapezoid = Double.Parse(Console.ReadLine());
           
            //Console.WriteLine($"The trapezoid area is: {(sideA + sideB) / 2 * heightTrapezoid} cm2");
            //Console.ReadLine();

            ////11. Check if int is Prime
            //Console.Write("Enter an integer to check if is Prime (0 < n <= 100): ");
            //int checkNumber = Int32.Parse(Console.ReadLine());
            //CheckPrimeOrNot(checkNumber);
            //Console.ReadLine();

            ////12. Find max integer from int[]
            //var numbersArray = new int[] { 99, 234, -34, 232, 0, 99, -458 };
            //Console.WriteLine(FindMaxElement(numbersArray));
            //Console.ReadLine();

            ////13. Show sign of the result (num1*num2*num3) real numbers without calculating it
            //Console.Write("Enter three real numbers:\n");
            //double a = Double.Parse(Console.ReadLine());
            //double b = Double.Parse(Console.ReadLine());
            //double c = Double.Parse(Console.ReadLine());
            //ReturnResultSign(a, b, c);
            //Console.ReadLine();

            ////14. Prints all numbers from 1 to 30, that are NOT divisible by 3 and 7 at the same time
            //PrintNumbers();
            //Console.ReadLine();

            ////15. Build array of n integers -> element == 5*elementIndex            
            //PrintCustomArrayOfIntegers();
            //Console.ReadLine();

            ////16. Build list of n integers -> element == 5*elementIndex            
            //PrintCustomListOfIntegers();
            //Console.ReadLine();

            ////17. GetMax(int first, int second) -> prints the bigger number 
            //Console.Write("Enter two integers:\n");
            //int first = int.Parse(Console.ReadLine());
            //int second = int.Parse(Console.ReadLine());
            //GetMax(first, second);


            ////18. Generate and print 10 random numbers in the range [100, 200]
            //Console.Write("Enter two numbers - the range of the generated numbers(int):\n");
            //int rangeFrom = int.Parse(Console.ReadLine());
            //int rangeTo = int.Parse(Console.ReadLine());
            //Console.Write("Enter how many random numbers to generate in the range(int):\n");
            //int count = int.Parse(Console.ReadLine());
            //PrintRandomNumbers(rangeFrom, rangeTo, count);

            ////19. Print the current day of the week
            //Console.WriteLine(DateTime.Today.DayOfWeek);
            //Console.ReadLine();
        }

        // METHODS
        //18+.
        private static void PrintRandomNumbers(int from, int to, int count)
        {
            var randomNumbers = new List<int>();
            Random randomGenerator = new Random();

            for (int i = 0; i < count; i++)
            {
                int random = randomGenerator.Next(from, to);
                randomNumbers.Add(random);
            }
            foreach (var number in randomNumbers)
            {
                Console.Write(($"{number} "));
            }
        }

        //17+.
        private static void GetMax(int first, int second)
        {
            Console.WriteLine($"The bigger number is: {Math.Max(first, second)}" );
        }

        //16+.
        private static void PrintCustomListOfIntegers()
        {
            Console.Write("Enter list size:\n");
            int listSize = int.Parse(Console.ReadLine());
            var numbersList = new List<int>();

            for (int i = 0; i < listSize; i++)
            {
               numbersList.Add(5 * i);
            }

            foreach (var element in numbersList)
            {
                Console.Write($"{element} ");
            }
        }
        
        //15+.
        private static void PrintCustomArrayOfIntegers()
        {
            Console.Write("Enter array size:\n");
            int arraySize = int.Parse(Console.ReadLine());
            var array = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                array[i] = 5 * i;
            }

            foreach (var element in array)
            {
                Console.Write($"{element} ");
            }
        }

        //14+.
        private static void PrintNumbers()
        {
            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    continue;
                }
                Console.Write($"{i} ");
            }
        }

        //13+.
        private static void ReturnResultSign(double a, double b, double c)
        {
            if ((a < 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c > 0) ||
                            (a > 0 && b < 0 && c > 0) || (a > 0 && b > 0 && c < 0))
            {
                Console.WriteLine("'-'");
            }
            else if ((a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c > 0) ||
                (a > 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c < 0))
            {
                Console.WriteLine("'+'");
            }
            else if (a == 0.0 || b == 0.0 || c == 0.0)
            {
                Console.WriteLine("'0'");
            }
        }

        //12+.
        private static int FindMaxElement(int[] numbersArray)
        {
            int max = int.MinValue;
            foreach (var number in numbersArray)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }

        //11+.
        private static void CheckPrimeOrNot(int num)
        {

            bool flag = true;

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    flag = false;
                    break;
                }
            }
            if (flag)
                Console.Write("Number is Prime.");
        }

        //8+.
        private static string CheckEvenOrOdd(int num)
        {
            if (num % 2 == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
        }

        //3+.
        private static bool FindGender(string gender)
        {
            bool isFemale;
            if (gender.Equals("M"))
            {
                isFemale = false;
            }
            else
            {
                isFemale = true;
            }
            return isFemale;
        }
    }
}
