using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
                Console.WriteLine("Enter the first number:");

        if (int.TryParse(Console.ReadLine(), out int a)) 
        {
            Console.WriteLine("Enter the second number:");
        }

        else
        {
            Console.WriteLine("Not a number!");
            return;
        }

        if(!int.TryParse(Console.ReadLine(),out var b))
        {
            Console.WriteLine("Not a number!");
            return;
        }

        Console.WriteLine("Enter the operator: & | or ^");
        var s = Console.ReadLine();
        if (s.Length == 0 || s.Length > 1) 
        {
            Console.WriteLine("Invalid operator");
            return;
        }

        switch (s[0])
        {
            case '&':
                Console.WriteLine("The correct operator is entered &");
                Console.WriteLine("Bitwise operation {0} & {1} = {2}", a, b, a & b);
                Console.WriteLine("Bitwise operation {0} & {1} = {2}", a, b, Convert.ToString(a & b, 2));
                Console.WriteLine("Bitwise operation {0} & {1} = {2}", a, b, Convert.ToString(a & b, 16));
                break;
            case '|':
                Console.WriteLine("The correct operator is entered |");
                Console.WriteLine("Bitwise operation {0} | {1} = {2}", a, b, a | b);
                Console.WriteLine("Bitwise operation {0} | {1} = {2}", a, b, Convert.ToString(a | b, 2));
                Console.WriteLine("Bitwise operation {0} | {1} = {2}", a, b, Convert.ToString(a | b, 16));
                break;
            case '^':
                Console.WriteLine("The correct operator is entered ^");
                Console.WriteLine("Bitwise operation {0} ^ {1} = {2}", a, b, a ^ b);
                Console.WriteLine("Bitwise operation {0} ^ {1} = {2}", a, b, Convert.ToString(a ^ b, 2));
                Console.WriteLine("Bitwise operation {0} ^ {1} = {2}", a, b, Convert.ToString(a ^ b, 16));
                break;
            default:
                Console.WriteLine("Invalid operator");
                break;

        }

        Console.WriteLine("Enter the operator: +, -, *, or /");
        var d = Console.ReadLine();

        if (d.Length == 0 || d.Length > 1);
        {
            Console.WriteLine("Invalid operation entered");
            return;
        }

        switch (d[0])
        {
            case '+':
                Console.WriteLine("Result of {0} + {1} = {2}", a, b, a + b);
                break;
            case '-':
                Console.WriteLine("Result of {0} - {1} = {2}", a, b, a - b);
                break;
            case '*':
                Console.WriteLine("Result of {0} * {1} = {2}", a, b, a * b);
                break;
            case '/':
                Console.WriteLine("Result of {0} / {1} = {2}", a, b, a / b);
                break;
                default :
                Console.WriteLine("Invalid operation");
                break;
            }
    }
}