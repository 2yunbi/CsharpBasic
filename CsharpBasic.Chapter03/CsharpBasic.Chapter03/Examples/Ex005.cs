﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic.Chapter03.Examples
{
    class Ex005
    {
        public void Run()
        {
            const int number = 0;

            if(number > 0)
            {
                Console.WriteLine("{0}은 양수입니다.", number);
            }
            else if (number < 0)
            {
                Console.WriteLine("{0}은 음수입니다.", number);
            }
            else
            {
                Console.WriteLine("{0}은 zero입니다.", number);
            }
            
            //0은 zero입니다.
        }
    }
}
