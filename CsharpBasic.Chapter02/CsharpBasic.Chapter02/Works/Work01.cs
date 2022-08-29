using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic.Chapter02.Works
{
    class Work01
    {
        public void Run()
        {
            //사용자에게 두 개의 수를 입력 받아, 처음 입력한 값이 두번째 입력한 값보다 클 경우 True를 출력.

            Console.WriteLine("숫자를 입력해 보세요!");
            int num01 = int.Parse(Console.ReadLine());

            Console.WriteLine("숫자를 하나 더 입력해 보세요!");
            int num02 = int.Parse(Console.ReadLine());


            bool comparisonNum = num01 > num02;
            Console.WriteLine("당신이 입력한 숫자는 {0}와, {1}입니다. {2}", num01, num02, comparisonNum);
        }
    }
}
