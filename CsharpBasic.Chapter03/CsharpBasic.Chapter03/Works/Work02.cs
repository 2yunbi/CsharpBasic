using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic.Chapter03.Works
{
    class Work02
    {
        public void Run()
        {
            // 영화 평점에 대한 피드백을 해주는 프로그램
            // 조건
            // 1. 영화 제목 입력 받기
            // 2.영화에 대한 평점을 1~5까지 입력 받기

            Console.WriteLine("어떤 영화를 보셨나요?");
            string movie = Console.ReadLine();
            Console.WriteLine("오! {0}영화 재밌을 것 같은데요?", movie);
            Console.WriteLine("영화는 어땠어요? (1~5까지 점수를 입력해주세요.)");
            int movieScore = Convert.ToInt32(Console.ReadLine());

            switch (movieScore)
            {
                case 1:
                    Console.WriteLine("{0} 영화는 환불받고 싶을 정도로 최악의 영화군요", movie);
                    break;
                case 2:
                    Console.WriteLine("{0} 영화는 지루한 영화군요", movie);
                    break;
                case 3:
                    Console.WriteLine("{0} 영화는 시간 때우기 좋은 그 이상 그 이하도 아닌 영화군요", movie);
                    break;
                case 4:
                    Console.WriteLine("{0} 영화는 흥미를 유발할 만한 완성도 높은 영화군요", movie);
                    break;
                case 5:
                    Console.WriteLine("{0} 영화는 당신의 최고이 영화 하나로 기억되겠군요", movie);
                    break;
                default:
                    Console.WriteLine("평점 계산에 실패하였습니다.");
                    break;

            }

        }
    }
}
