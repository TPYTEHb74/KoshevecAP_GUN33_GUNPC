﻿  class Program
  {
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        if (!Int32.TryParse(Console.ReadLine(), out var a))
        {
            Console.WriteLine("Not a number!");
            return;
        }

        Console.Write("Enter the second number: ");
        if (!Int32.TryParse(Console.ReadLine(), out var b))
        {
            Console.WriteLine("Not a number!");
            return;
        }

        Console.Write("Enter the '&' '|' '^' : ");
        var s = Console.ReadLine();
        var boolVar = true;
        if (s.Length == 0 || s.Length > 1 && !boolVar)
        {
            Console.WriteLine("Wrong sign");
            return;
        }

        switch (s[0])
        {
            case '&':
                Console.WriteLine("Result of {0} & {1} = {2}", a, b, a & b);
                break;
            case '|':
                Console.WriteLine("Result of {0} | {1} = {2}", a, b, a | b);
                break;
            case '^':
                Console.WriteLine("Result of {0} ^ {1} = {2}", a, b, a ^ b);
                break;
            default:
                Console.WriteLine("Wrong sign");
                break;
        }

        int[] bases = { 2, 10, 16 };
        int[] numbers = { a, b, a ^ b, a & b, a | b, };

        foreach (int baseValue in bases)
        {
            Console.WriteLine("Base {0} Conversion:", baseValue);
            foreach (short number in numbers)
            {
                Console.WriteLine("{0}  -->  {1}",  number, Convert.ToString(number,  baseValue));
            }         
        }       
    }
  }