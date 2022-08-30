using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic.Chapter04.Examples
{
    class Ex003
    {
        public void Run()
        {
            // 증감연산자의 흐름
            int number = 10;

            Console.WriteLine(number++); // 10
            Console.WriteLine(++number); // 12
        }
    }
}
