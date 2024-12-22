using System.Data.SqlTypes;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Strings
{
    internal class Program
    {
        // Задание 1
        // Напишите метод, который принимает две строки и возвращает конкатенацию этих строк.
        static string ConcatenateStrings(string firstString, string secondString)
        {
            return firstString + " " + secondString;
        }

        //Втрой вариант
        //static void ConcatenateStrings(string v, string v1)
        //{
        //    Console.WriteLine("Введите первую строку: ");
        //    string firstString = Console.ReadLine();

        //    Console.WriteLine("Введите вторую строку: ");
        //    string secondString = Console.ReadLine();

        //    Console.WriteLine($"Concat: {string.Concat(firstString, " ", secondString)}");
        //}


        // Задание 2
        // Напишите метод GreetUser, который получает имя(string) и возраст(int)
        private static string GreetUser(string userName, int userAge)
        {
            string text = $"\nHello, {userName}!\nYou are {userAge} years old.";
            return text;
        }

        // Втрой вариант
        //private static void GreetUserNew()
        //{
        //    Console.WriteLine("Введите имя пользователя:");
        //    var userName = Console.ReadLine();

        //    Console.WriteLine("Введите возраст пользователя:");
        //    var userAge = Console.ReadLine();

        //    Console.WriteLine($"Hello, {userName}!\nYou are {userAge} You are.");
        //}


        // Задание 3
        private static string InfoStringDG(string text)
        {
            string _text = "";

            _text = $"\nКоличество символов в строке - {text.Length}\nВверхний регистр - {text.ToUpper()},\nНижний регистр - {text.ToLower()}";

            return _text;
        }


        //Задание 4
        private static string SymbolString(string str)
        {
            
            Console.WriteLine($"Первые 5 символов строки: {str.Substring(0, 5)}");
           
            return str;
        }


        // Задание 5 (два варианта)
        // Первый вариант
        private static StringBuilder ConcatenateStrings(string[] arr)

        {
            StringBuilder sb = new StringBuilder();

            foreach (string s in arr)
            {
                sb.Append(s).Append(" ");
            }

            return sb;
        }
        // Втрой вариант 
        private static void StringToBilderNew(string[] strings)
        {
            StringBuilder sb = new StringBuilder();

            foreach (string i in strings)
            {
                sb.Append(i);
                sb.Append(" ");
            }
            Console.Write(sb.ToString());
            Console.WriteLine();
        }


        // Задание 6
        public static void ReplaceWords(string inputString, string wordToReplace, string replacementWord)
        {
            string text = inputString;
            text = text.Replace(wordToReplace, replacementWord);
            Console.WriteLine(text);
        }


        static void Main(string[] args)
        {
            //Concatenate();
            //GreetUserNew();

            string Concat = ConcatenateStrings("Hello", "World");
            Console.WriteLine(Concat);
            Console.WriteLine(new String('*', 15));


            string User = GreetUser("Alex", 43);
            Console.WriteLine(User);
            Console.WriteLine(new String('*', 15));

            string string1 = InfoStringDG("Название: Руководство по C#");
            Console.WriteLine(string1);
            Console.WriteLine(new String('*', 15));

            string string2 = SymbolString("Замечательный");
            Console.WriteLine(string2);
            Console.WriteLine(new String('*', 15));

            string[] strings = { "Hello", "World", "from", "C#" };
            StringBuilder result = ConcatenateStrings(strings);
            Console.WriteLine(result.ToString());
            Console.WriteLine(new String('*', 15));
        }

      
    }
}