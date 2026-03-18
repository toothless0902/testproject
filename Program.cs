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

      while (money > 0)
        {
            Console.WriteLine("\n---------------------------------");
            Console.Write("출금할 금액을 입력하세요(종료하려면 0을 입력): ");

            int money2 = int.Parse(Console.ReadLine());

            if (money2 == 0)
            {
                Console.WriteLine("시스템 종료");
                break;

            }
            if(money2 <= money)
            {
                money -= money2; // -= > money - money2
                Console.Write(money2 + "원 출금 완료");
                Console.WriteLine("남은 잔액" + money + "원");

            }
            else
            {
                Console.Write("잔액 부족 현재" + money + "원만 남아있습니다");

            }
        }
        Console.WriteLine("잔액 부족. 봇 가동 중단");

       

  




    }
}