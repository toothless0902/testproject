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

        Console.WriteLine("\n---출금 시스템 가동---");
        Console.Write("출금할 금액을 입력하세요: ");

        string input = Console.ReadLine();
        int requestMoney = int.Parse(input);

        if (requestMoney <= money)
        {
            money = money - requestMoney;
            Console.WriteLine(requestMoney + "원 출금 완료! ");
            Console.WriteLine("남은 최종 잔액: " + money + "원");

        }
    

        
        else
        {
            Console.WriteLine("잔액이 부족하여 출금할 수 없습니다");
            Console.Write(" 현재 부족한 금액: " + (requestMoney - money) + "원");

        }

        if (money >= 1000000)
        {
            Console.WriteLine(" VIP 고객님 환영합니다.");
        }
        else if ( money >= 100000)
        {
            Console.WriteLine("일반 고객님 환영합니다.");
         }
        else
        {
            Console.WriteLine("계좌를 채워보세요");
        }

  




    }
}