using System;

namespace ArraryApp02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];


            //입력
            for (int i = 0; i < 100; i++)
            {
                arr[i] = i + 1;
            }

            //출력
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write(arr[j] + " ");  //입출력을 합칠 수 있음
            }
        }
    }
}
