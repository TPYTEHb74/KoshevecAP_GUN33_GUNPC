namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // Здесь мфссивы заданий 1-4

            int[] FibonacciNumbers = new int[] { 8, 13, 21, 34, 55, 89, 144, 233
            };

            string[] strings = new string[]
            {
               "January", "February", "MarchMarch", "April", "May", "June", "July", "August", "September", "October", "November", "December"
            };

            int[,] ints1 = new int[3, 3]
            {
                {2, 3, 4 }, {4, 9, 16 }, {8, 27, 64 }
            };

            const double PI = Math.PI;
            const double E = Math.E;

            double[][] a = new double[3][]
            {
                new double[] {1, 2, 3, 4, 5},
                new double[] {PI, E},
                new double[] { Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000), }
            };

            Console.WriteLine(a[1][0]);
            Console.WriteLine(a[2][2]);
            Console.WriteLine(a[2][3]);

            //Массивы для заданий 5 и 6

            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };
            Array.Copy(array, 0, array2, 0, 3);
            foreach (int i in array2)
            {
                Console.WriteLine(i);
            }

            Array.Resize(ref array, array.Length * 2);
            foreach (int n in array)
            {
                Console.WriteLine(n);
            }
        }
    }
}
