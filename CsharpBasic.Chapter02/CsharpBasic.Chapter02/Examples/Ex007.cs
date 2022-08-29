using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic.Chapter02.Examples
{
    public class Ex007
    {
        public void Run()
        {
            //학생의 총 점수와 평균 점수를 계산하는 프로그램
            // 국어 100점, 영어 100점, 수학 87점, 체육 97점

            int korean = 100;
            int english = 100;
            int math = 98;
            int sports = 97;

            int sumScore = korean + english + math + sports;

            double arrangeScore = (double)sumScore / 4;

            Console.WriteLine("학생의 총 점수는 {0}이며, 평균은 {1} 입니다.", sumScore, arrangeScore);
        }
    }
}
