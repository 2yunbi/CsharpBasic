using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic.Chapter04.Works
{
    public class Work03
    {
        //1 ~ 50까지의 랜덤 숫자 맞추기 프로그램
        // 사용자가 틀렸을 경우 입력한 숫자가 랜덤한 숫자보다  큰지, 작은지 알려주기
        public void Run()
        {
            Random rand = new Random();
            int target_number = rand.Next(1, 50);
            int answer_number = 0;
            Console.WriteLine("1~50 숫자를 맞춰보세요.");

            do
            {
                answer_number = Convert.ToInt32(Console.ReadLine());

                if (target_number != answer_number)
                {
                    Console.WriteLine("틀렸습니다. {0}!", target_number > answer_number ? "UP" : "DOWN");
                }
            } while (target_number != answer_number);

            Console.WriteLine("정답입니다!");
        }
    }
}
