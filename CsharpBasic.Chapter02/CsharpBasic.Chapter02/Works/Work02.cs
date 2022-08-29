using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic.Chapter02.Works
{
    class Work02
    {
        public void Run()
        {
            //사용자에게 두 개의 수를 받아, 사칙연산의 결과를 알려주는 프로그램.

            Console.WriteLine("사칙연산 프로그램");
            Console.WriteLine("숫자를 입력하세요.");
            int num01 = int.Parse(Console.ReadLine());

            Console.WriteLine("숫자를 하나 더 입력하세요.");
            int num02 = int.Parse(Console.ReadLine());

            int sumNum = num01 + num02;
            int minusNum = num01 - num02;
            int multipleNum = num01 * num02;
            double diviceNum = (double)num01 / num02;

            Console.WriteLine("더하기 값은 {0} + {1} = {2}", num01, num02, sumNum);
            Console.WriteLine("빼기 값은 {0} - {1} = {2}", num01, num02, minusNum);
            Console.WriteLine("곱하기 값은 {0} * {1} = {2}", num01, num02, multipleNum);
            Console.WriteLine("나누기 값은 {0} / {1} = {2}", num01, num02, diviceNum);
        }
    }
}
