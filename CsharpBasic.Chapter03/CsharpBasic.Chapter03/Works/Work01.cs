using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic.Chapter03.Works
{
    class Work01
    {
        public void Run()
        {
            // 사용자에게 입력 받은 숫자의 특성을 알려주는 프로그램
            // 입력받은 숫자가, 양수/음수인지 아니면 0인지

            Console.WriteLine("숫자를 입력하세요.");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("입력한 숫자는 양수입니다.");
            }
            else if (number < 0)
            {
                Console.WriteLine("입력한 숫자는 음수입니다.");
            }
            else
            {
                Console.WriteLine("입력한 숫자는 0입니다.");
            }

            if (number % 2 == 0)
            {
                Console.WriteLine("입력한 숫자는 짝수입니다.");
            }
            else
            {
                Console.WriteLine("입력한 숫자는 홀수입니다.");
            }
        }
    }
}
