using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic.Chapter02.Examples
{
    class Ex009
    {
        public void Run()
        {
            // 암시적인 형 변환과 명시적인 형 변환
            int number01 = 10;
            double number02 = number01;
            int number03 = (int)number02;

            Console.WriteLine("number01 변수의 타입 {0}", number01.GetType());
            Console.WriteLine("number02 변수의 타입 {0}", number02.GetType());
            Console.WriteLine("number03 변수의 타입 {0}", number03.GetType());
        }
    }
}
