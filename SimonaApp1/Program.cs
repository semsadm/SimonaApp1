using Calculator.bl;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace SimonaApp1 
{
    class Program
    {
        static void Main(string[] args)
        {
            //var options = new RoundOptions(4, MidpointRounding.AwayFromZero);
            //var calculator = new Calculator.bl.Calculator(options);
        }


        static void Login ()

        {
            string password = "qwerty";
            string login = "johnsilver";

            int tries = 1;
            while (tries <= 3)
            {
                Console.WriteLine("Enter login");
                string userLogin = Console.ReadLine();

                Console.WriteLine("Enter pass");
                string userPass = Console.ReadLine();

                if (userLogin == login && userPass == password)
                {
                    Console.WriteLine("Enter the system");
                }
                tries++;
            }
            if (tries == 4)
            {
                Console.WriteLine("You exceeded the number of available tries.");
            }
        }

        static void Factorial ()
        {
            Console.WriteLine("Enter n>=0");
            int n = int.Parse(Console.ReadLine());

            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }

        static void Mean()
        {
            int[] numbers = new int[10];

            int inputCount = 0;
            while (inputCount < 10)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[inputCount] = number;

                inputCount++;

                if (number == 0)
                    break;
            }

            int sum = 0;
            int count = 0;

            foreach (int n in numbers)
            {
                if (n > 0 && n % 3 == 0)
                {
                    sum += n;
                    count++;
                }
            }

            double average = (double)sum / count;
            Console.WriteLine(average);
        }
          
        static void Fibonacci()
        {
            Console.WriteLine("Enter the number of Fibonacci numbers you want to generate");
            int n = int.Parse(Console.ReadLine());

            int[] fibonacci = new int[n];

            int a0 = 0;
            int a1 = 1;

            fibonacci[0] = a0;
            fibonacci[1] = a1;

            for (int i = 2; i < n; i++)
            {
                int a = a0 + a1;
                fibonacci[i] = a;

                a0 = a1;
                a1 = a;
            }

            foreach (int cur in fibonacci)

            {
                Console.WriteLine(cur);
            }
            Console.ReadLine();
        }

        static void MAX()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            // 1-st
            //int max = a;
            //if (b > a)
            //  max = b;

            // 2nd
            //int max;
            //if (a > b)
            //    max = a;
            //else
            //    max = b;

            //3rd
            int max = a > b ? a : b;

            Console.WriteLine($"Max={max}");
        }

        static void Geron()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("Ru-ru");
            Console.WriteLine("Let's calculate the squate of a triangle");

            Console.WriteLine("Enter the length of side AB:");
            double ab = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length of side BC:");
            double bc = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length of side AC:");
            double ac = double.Parse(Console.ReadLine());

            double p = (ab + bc + ac) / 2;


            double square = Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
            Console.WriteLine($"Square of the triangle equals {square}");
        }

        static void BMI ()
        {
            Console.WriteLine("What's your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("What's your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What's your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What's your weight in  kg?");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("What's your height in meters");
            double height = double.Parse(Console.ReadLine());

            double bodyMassIndex = weight / (height * height);

            string profile =
                  $"Your profile:{Environment.NewLine}"
                + $"Full Name: {lastName} {firstName} {Environment.NewLine}"
                + $"Age: {age} { Environment.NewLine}"
                + $"Weight: {weight}{Environment.NewLine}"
                + $"Height: {height}{Environment.NewLine}"
                + $"Body Mass Index: {bodyMassIndex}";

            Console.WriteLine(profile);
        }

        static void Hello ()
        {
            Console.WriteLine("Enter an integer");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter an integer");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"a={a}, b={b}");

            int c = a;
            a = b;
            b = c;

            Console.WriteLine($"a={a}, b={b}");

            Console.ReadLine();

            Console.WriteLine("What's your name?");

            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}");
        }

    }

} 