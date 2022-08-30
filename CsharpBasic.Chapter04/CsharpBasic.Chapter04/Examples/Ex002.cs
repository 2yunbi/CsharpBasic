using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic.Chapter04.Examples
{
    class Ex002
    {
        public void Run()
        {
            const int number = 2;
            for (int index = 1; index < 10; index++)
            {
                Console.WriteLine("{0} * {1} = {2}", number, index, number * index);
            }
        }
    }
}
