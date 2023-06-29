using System;

namespace ArraryApp02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            // 메모리 입력 & 화면(콘솔)에 출력
            for (int i = 0, cnt = 1; i <arr.Length; i++, cnt+=2)
            {
                arr[i] = cnt;
                Console.WriteLine(arr[i] + " ");

            }


            //출력
            //for (int j = 0; j < arr.Length; j++)
            //{
            // Console.Write(arr[j] + " ");  //입출력을 합칠 수 있음
            //}
        }
    }
}
