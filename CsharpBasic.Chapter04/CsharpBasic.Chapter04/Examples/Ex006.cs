using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic.Chapter04.Examples
{
    class Ex006
    {
        public void Run()
        {
            // 구구단
            for (int i = 2; i < 10; i++)
            {
                Console.WriteLine("{0}단 시작!", i);
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                }
            }
        }
    }
}
