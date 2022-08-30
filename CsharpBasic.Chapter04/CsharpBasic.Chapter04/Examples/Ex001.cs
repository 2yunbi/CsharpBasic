using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic.Chapter04.Examples
{
    class Ex001
    {
        public void Run()
        {
            //무한루프
            const int number = 2;
            int index = 1;
            for (; ; )
            {
                Console.WriteLine("{0} * {1} = {2}", number, index, number * index);
                break;
            }
        }
    }
}
