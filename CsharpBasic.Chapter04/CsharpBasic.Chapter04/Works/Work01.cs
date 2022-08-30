using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic.Chapter04.Works
{
    class Work01
    {
        public void Run()
        {
            //구구단 2단 만들기
            int number = 2;
            for (int index = 1; ;)
            {
                Console.WriteLine("{0} * {1} = {2}", number, index, number * index);

                if (index == 9)
                {
                    break;
                }
                index++;
            }
        }
    }
}
