using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Uygulama();
        }

        static void Uygulama()
        {
            Menu();
            Console.Write("Choose: ");
            string choose = Console.ReadLine();

            Console.Clear();


            switch (choose)
            {
                case "1":
                    Plus();
                    break;
                case "2":
                    Minus();
                    break;
                case "3":
                    DividedBy();
                    break;
                case "4":
                    Times();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }

        static void Menu()
        {
            Console.WriteLine("--- CALCULATOR ---");

            Console.WriteLine();

            Console.WriteLine("1- Plus (+)");
            Console.WriteLine("2- Minus (-)");
            Console.WriteLine("3- Divided By (/)");
            Console.WriteLine("4- Times/Multiply (x)");

            Console.WriteLine();
        }

        static void Plus()
        {
            Console.Write("Enter the first number: ");
            double fnum = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double snum = double.Parse(Console.ReadLine());
            Console.WriteLine();
            double result = fnum + snum;
            Console.WriteLine("Result: " + result);
            Console.WriteLine();
            TurnMenu();
        }

        static void Minus()
        {
            Console.Write("Enter the first number: ");
            double fnum = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double snum = double.Parse(Console.ReadLine());
            Console.WriteLine();
            double result = fnum - snum;
            Console.WriteLine("Result: " + result);
            Console.WriteLine();
            TurnMenu();
        }

        static void DividedBy()
        {
            Console.Write("Enter the first number: ");
            double fnum = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double snum = double.Parse(Console.ReadLine());
            Console.WriteLine();
            double result = fnum / snum;
            Console.WriteLine("Result: " + result);
            Console.WriteLine();
            TurnMenu();
        }

        static void Times()
        {
            Console.Write("Enter the first number: ");
            double fnum = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double snum = double.Parse(Console.ReadLine());
            Console.WriteLine();
            double result = fnum * snum;
            Console.WriteLine("Result: " + result);
            Console.WriteLine();

            TurnMenu();
        }

        static void TurnMenu()
        {
            Console.Write("If you want to return to the menu, press the *M* key, if you want to close the program, press the *X* key: ");
            string choose = Console.ReadLine().ToUpper();

            if (choose == "M")
            {
                Console.Clear();
                Uygulama();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
