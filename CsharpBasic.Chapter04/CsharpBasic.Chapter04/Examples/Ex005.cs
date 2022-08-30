using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic.Chapter04.Examples
{
    class Ex005
    {
        public void Run()
        {
            // 3번의 중첩 반복만
            for (int index_i = 0; index_i < 2; index_i++)
            {
                for(int index_j = 0; index_j < 3; index_j++)
                {
                    for (int index_k = 0; index_k < 4; index_k++)
                    {
                        Console.WriteLine("i:{0} / j:{1} / k: {2}", index_i, index_j, index_k);
                    }
                }
            }
        }
    }
}
