using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic.Chapter04.Works
{
    public class Work02
    {
        // 사용자에게 특정 숫자를 입력 받아, 해당 숫자의 팩토리얼을 계산하는 프로그램
        public void Run()
        {
            Console.WriteLine("팩토리얼 계산 프로그램");
            Console.WriteLine("숫자를 입력하세요: ");
            int factorial = Convert.ToInt32(Console.ReadLine());

            int fact = 1;
            for(int i = factorial; i > 0; i--)
            {
                fact *= i;
            }
            Console.WriteLine("{0}! = {1}", factorial, fact);
            
        }
    }
}
