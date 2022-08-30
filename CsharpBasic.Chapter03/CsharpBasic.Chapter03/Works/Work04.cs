using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic.Chapter03.Works
{
    class Work04
    {
        public void Run()
        {
            //사용자에게 중간고사 점수와 기말고사 점수를 입력 받아 평균 점수를 계산한 후에 
            //90점 이상/ 80~90점사이 /70점~80점사이/ 70점 이하에 따라 A학점/B학점/C학점/F학점

            Console.WriteLine("중간고사 점수를 입력하세요.");
            int midScore = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("기말고사 점수를 입력하세요.");
            int finalScore = Convert.ToInt32(Console.ReadLine());
            double arrangeScore = (double)(midScore + finalScore) / 2;

            if (arrangeScore > 90)
            {
                Console.WriteLine("평균 점수는 {0}점이며, A학점입니다.", arrangeScore);
            }
            else
            {
                if(80 < arrangeScore && arrangeScore <90)
                {
                    Console.WriteLine("평균 점수는 {0}점이며, B학점입니다.", arrangeScore);
                }
                else
                {
                    if (70 < arrangeScore && 80 > arrangeScore )
                    {
                        Console.WriteLine("평균 점수는 {0}점이며, C학점입니다.", arrangeScore);
                    }
                    else
                    {
                        Console.WriteLine("평균 점수는 {0}점이며, F학점입니다.", arrangeScore);
                    }
                }
            }
        }
    }
}
