using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic.Chapter02.Examples
{
    class Ex011
    {
        //전역변수
        int globalValue = 20;
        public void Run()
        {
            //지역변수
            int localValue = 10;

            Sum();
            Multiple();

            Console.WriteLine("local : {0}, / global : {1}", localValue, globalValue);
        }

        private void Sum()
        {
            globalValue = globalValue + 10;
        }

        private void Multiple()
        {
            globalValue = globalValue * 2;
        }
    }
}
