using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic.Chapter03.Works
{
    class Work03
    {
        public void Run()
        {
            //주어진 1~100까지의 두개의 숫자에 대한 더하기 문제를 제공하여,
            // 사용자가 문제를 풀게 한 후 정답인지 오답인지 평가하는 프로그램

            Random rand = new Random();
            int num01 = rand.Next(1, 100);
            int num02 = rand.Next(1, 100);
            int sumNum = num01 + num02;
            Console.WriteLine("제가 생각한 숫자는 {0}과 {1}입니다.", num01, num02);
            Console.WriteLine("{0} + {1} = 무엇일까요?", num01, num02);
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == sumNum)
            {
                Console.WriteLine("정답입니다!");
            }
            else
            {
                Console.WriteLine("틀렸어요! 더 공부하세요!");
            }
        }
    }
}
