namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n0 = 0;
            int n1 = 1;
            int n2;
            Console.WriteLine(n0 + "\n" + n1);
            for (int i = 2; i < 10; i++)
            {
                n2 = n0 + n1;
                Console.WriteLine(n2 + " ");
                n0 = n1;
                n1 = n2;
            }
            Console.WriteLine("-----\n");

            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----\n");

            for (int i = 1; i < 10; i++) 
            {
                for (int j = 1; j < 10; j++) 
                {
                    Console.Write($"{i * j}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----\n");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }
            Console.WriteLine("-----\n");

            string password = "qwerty";
            int result = 0;

            do
            {
                Console.WriteLine("Enter a password of 6 characters:");
                string checkPassword = Console.ReadLine();
                if (checkPassword == password)
                {
                    Console.WriteLine("Welkome!");
                    Console.ReadLine();
                    break;
                }
                Console.WriteLine("The password was entered incorrectly");
            }
            while (++result < 6);

        }
    }
}
