using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StringApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            Console.WriteLine(greeting);
            Console.WriteLine();

            //함수 IndexOf  배열의 순서를 찾아준다
            Console.WriteLine($"{greeting.IndexOf("Good")}");
            Console.WriteLine($"{ greeting.IndexOf("o")}");
            Console.WriteLine($"{greeting.IndexOf("d")}");

            //LastIndexOf()
            Console.WriteLine($"{greeting.LastIndexOf("Good") }");
            Console.WriteLine($"{greeting.LastIndexOf("o")}");

            //StartsWith()
            Console.WriteLine($"StartsWith :{greeting.StartsWith("Good")}");
            Console.WriteLine($"StartsWith :{greeting.StartsWith("Morning")}");

            //EndsWith()
            Console.WriteLine($"EndsWith :{greeting.EndsWith("Good")}");
            Console.WriteLine($"EndsWith :{greeting.EndsWith("Morning")}");

            //Contains()
            Console.WriteLine($"Contains :{greeting.Contains("Evening")}");
            Console.WriteLine($"Contains :{greeting.Contains("Morning")}");

            //Replace()
            Console.WriteLine($"Replaced :{greeting.Replace("Morning", "Evening")}");


        }
    }
}
