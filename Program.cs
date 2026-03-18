using System;

class Program
{
    static void Main(string[] args)
    {   // 1. 이름 묻기
        Console.WriteLine("토스증권 계좌 개설을 시작합니다.");
        Console.Write("성함을 입력해주세요: ");
        string name = Console.ReadLine();
       
        // 2. 입금액 묻기
        Console.Write("처음 입금할 금액을 입력해주세요: ");
        string moneyinput = Console.ReadLine();
      
        // 3.[형 변환] 글자를 숫자로
        int money = int.Parse(moneyinput);
        int bonus = money / 10;
       
        // 4. 결과 출력하기
        Console.WriteLine("\n----------------------------");
        Console.WriteLine(name + "님의 계좌가 개설되었습니다!");
        Console.WriteLine("최종 합계: " + (money + bonus) + "원");
        Console.WriteLine("-------------------------------");

        while (money <= 500000)
        {
            Console.WriteLine("퀀트 봇을 실행하기 위한 최소 금액이 부족합니다");
            Console.WriteLine("추가 입금 금액을 입력해주세요: " + "현재 잔액 :" + money);

            string money2 = Console.ReadLine();

            int rmoney2 = int.Parse(money2);

            money += rmoney2;
            
            if (money >= 500000)
            {
                Console.WriteLine("투자 할 준비를 끝냈습니다.");
                break;
            }
            else
            {
                Console.WriteLine("더 많은 금액을 예치하세요");
            }
        }
        int buycount = 0;
     
        for( int i = 1; i <= 10; i++)
        {
            if (buycount < 5)
            {


                money -= 100000;
                buycount++;
                Console.WriteLine(i + "번째 종목 분석 중...");
                Console.WriteLine(i + "번째 매수 완료. 현재 잔액 : " + money);

            }
            else
            {
                Console.Write("목표 수량 5개를 다 채웠으. 분석 종료");
                break;
            }

        }

       

  




    }
}