using System;

namespace ArraryQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            Console.WriteLine("홀수");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
                if (arr[i] % 2 != 0)
                {
                    Console.Write(arr[i] + " ");
                }

            }
            Console.WriteLine();
            Console.WriteLine("짝수");
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] % 2 == 0)
                {
                    Console.Write(arr[i] + " ");
                }

            }
            Console.WriteLine();
            Console.WriteLine("3의배수");
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] % 3 == 0)
                {
                    Console.Write(arr[i] + " ");
                }

            }

        }
    }
}
