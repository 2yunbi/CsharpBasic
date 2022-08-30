using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic.Chapter04.Examples
{
    class Ex004
    {
        public void Run()
        {
            //5! 5팩토리얼

            int fact_result = 1;
            
            for(int index = 5; index > 0; index--)
            {
                fact_result *= index;
            }
            Console.WriteLine("5!은 {0}입니다.", fact_result);
        }
    }
}
