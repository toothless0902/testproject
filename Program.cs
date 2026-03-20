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

        while (money < 500000)
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
        int[] prices = { 88000, 12000, 45000, 32000, 900000, 500000, 3000, 20190 };

        Console.WriteLine("\n[알고리즘 가동] 시장 데이터 분석 중...");

        Array.Sort(prices);
     
        for( int i = 0; i < prices.Length; i++) //prices.length를 활용한 반복 -> 리스트 안의 인덱스 값 수  ex) 인덱스 총 8개 -> prices.Length = 8
        {
            if (buycount < 5 && money >= prices[i])
            {



                money -= prices[i]; //money = money - prices[i] -> prices[i]는 인덱스 몇번째의 수
                buycount++;


                Console.WriteLine($"{i + 1}번째 후보 분석 : 가격 {prices[i]}원");
                Console.WriteLine($"{buycount+1}번째 매수 완료! 현재 잔액 {money}원");

            }
            else if (buycount >= 5)
            {
                Console.WriteLine("\n[분석 종료] 목표 수량 5개를 모두 채웠습니다.");
                break;
            }
            else if (money < prices[i])
            {
                Console.WriteLine($"{i + 1} 번째 후보 분석 : 가격 {prices[i]}원 -> 잔액 부족으로 맷 불가!");
            }

        }

        Console.WriteLine("\n----------------------------------");
        Console.WriteLine($"{name}님의 퀀트 봇 운용 결과");
        Console.WriteLine($"총 매수 종목 수: {buycount+1}개");
        Console.WriteLine($"최종 잔액: {money}원");
        Console.WriteLine("\n-----------------------------------");



  




    }
}