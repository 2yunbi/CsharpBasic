using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic.Chapter03.Examples
{
    class Ex008
    {
        public void Run()
        {
            // &&연산자 활용과 3항 연산자를 이용한 조건문
            Console.WriteLine("숫자를 입력하세요.");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isOddNumber = ((number % 2 == 1) ? true : false);
            
            if(number > 0 && isOddNumber)
            {
                Console.WriteLine("{0}은 양의 홀수입니다.", number);
            }
            else if (number > 0 && !isOddNumber)
            {
                Console.WriteLine("{0}은 양의 짝수입니다.", number);
            }
            else if (number < 0 && isOddNumber)
            {
                Console.WriteLine("{0}은 음의 홀수입니다.", number);
            }
            else  if (number < 0 && isOddNumber)
            {
                Console.WriteLine("{0}은 음의 짝수입니다.", number);
            }
            else
            {
                Console.WriteLine("{0}은 zero입니다.", number);
            }
        }
    }
}
