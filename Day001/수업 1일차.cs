using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //입력받은 두수를 입력
            //1. 변수 선언 & 입력
            //int a, b;
            //a = Int32.Parse(Console.ReadLine()); //Int32.Parse = 문자열을 숫자로 받는다(여기서 숫자는 정수를 뜻함 왜? int열로 받아서, 자바 스크립트의 파싱이랑 이름이 비슷하네)
            // b = Int32.Parse(Console.ReadLine());
            //2. 로직
            //int result = a + b; 
            //3. 출력
            //Console.WriteLine(result);

            //가로(width), 세로(height) 입력 받아 넓이를 구합시다.
            //단. 입력은 정수로 계산될 범위까지 들어옵니다.
            int width, height;
            Console.WriteLine("가로 길이를 입력하시오 :");
            width = int.Parse(Console.ReadLine());
            Console.WriteLine("세로 길이를 입력하시오 :");
            height = int.Parse(Console.ReadLine());
            
            int result = width * height;

            Console.WriteLine("넓이 : " + result);  
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //기본자료형
            sbyte a = 127; // -128 ~ 127
            byte b = 255; // 0 ~ 255

            Console.WriteLine($"a={a}, $b={b}"); // 이건 옛날 방식 c+ c++ // $b 이게 c#

            short c = -32768; // -32768 ~ 32767
            ushort d = 65535; // 0 ~ 65535

            Console.WriteLine($"c={c}, $d={d}");

            int e = -2147483648; // -2147483648 ~ 2147483647
            uint f = 4294967295; // 0 ~ 4294967295

            Console.WriteLine($"e={e}, $f={f}");

            long g = -5000_0000_0000;
            ulong h = 200_0000_0000_0000_0000;

            byte i = 240; // 240 --> 리터럴

        }
    }
}

