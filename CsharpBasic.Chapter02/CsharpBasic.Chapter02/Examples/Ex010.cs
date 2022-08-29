using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic.Chapter02.Examples
{
    class Ex010
    {
        public void Run()
        {
            // 문자 -> 숫자 형변환
            string strNumber = "10";

            int convertNumber = Convert.ToInt32(strNumber);
            int parseNumber = Int32.Parse(strNumber);

            Console.WriteLine("{0} + {1} = {2}", convertNumber, parseNumber, convertNumber + parseNumber);
        }
    }
}
