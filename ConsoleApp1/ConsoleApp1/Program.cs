using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myGirls = { "yuu_kazuki", "ziva_pay", "mihara", "naomi" };

            Console.WriteLine("순서대로 나와라 for 따위는 안쓸꺼야\n");
            foreach (string girl in myGirls)
            {
                Console.WriteLine(girl + " 나왔습니다.!");
            }
            //Random random = new Random();
            //int countFive;
            //int countAll;
            //int iterationNumber = 1000;
            //float sum = 0;
            //for (int i = 0; i < iterationNumber; i++)
            //{
            //    countFive = 0;
            //    countAll = 0;
            //    while (countFive < 10)
            //    {
            //        countAll++;
            //        if ((random.Next(10) + 1) == 5) countFive++;
            //    }
            //    sum += countAll;
            //}
            //Console.WriteLine("평균" + sum / iterationNumber + "회 발생됨");

            //Console.WriteLine("5가 " + countFive + " 번 발생할 때 까지");
            //Console.WriteLine("정수 Random Numeber가" + countAll + 
            //    " 번 발생되었음");

            //int cummulativeSum = 0;
            //int a = 0;
            //while (cummulativeSum < 10000)
            //{
            //    a++;
            //    cummulativeSum += a;
            //    Console.WriteLine(a + "까지 누적합은 " + cummulativeSum);
            //}

            //int x = 100, y = 100;
            //string ultimateWeaponReady = "아니오";
            //ConsoleKeyInfo keyValue;
            //Console.WriteLine("병사의 현재 위치는 (" + x + " ," + y + ") 입니다.");
            //Console.Write("궁극기가 충전되었나(예 or 아니오)?:");
            //ultimateWeaponReady = Console.ReadLine();

            //while (true)
            //{
            //    keyValue = Console.ReadKey();
            //    switch(keyValue.Key)
            //    {
            //        case ConsoleKey.E:
            //            Console.WriteLine("병사가 회복한다.");
            //            break;
            //        case ConsoleKey.H:
            //            Console.WriteLine("영웅변경");
            //            break;
            //        case ConsoleKey.Q:
            //            if (ultimateWeaponReady == "예")
            //                Console.WriteLine("궁극기가 준비되었습니다. 목표포착");
            //            else if (ultimateWeaponReady == "아니오")
            //                Console.WriteLine("궁극기가 충전중이다.");
            //            else
            //                Console.WriteLine("궁극기가 준비상태를 알 수 없다.");
            //            break;
            //        case ConsoleKey.UpArrow:
            //            y -= 1;
            //            Console.WriteLine("병사의 (" + x + " ," + y + ") 로 이동.");
            //            break;
            //        case ConsoleKey.DownArrow:
            //            y += 1;
            //            Console.WriteLine("병사의 (" + x + " ," + y + ") 로 이동.");
            //            break;
            //        case ConsoleKey.LeftArrow:
            //            x -= 1;
            //            Console.WriteLine("병사의 (" + x + " ," + y + ") 로 이동.");
            //            break;
            //        case ConsoleKey.RightArrow:
            //            x += 1;
            //            Console.WriteLine("병사의 (" + x + " ," + y + ") 로 이동.");
            //            break;
            //        default:
            //            Console.WriteLine("명령이 정의되지 않은 키 입니다.");
            //            break;
            //    }
            //}

            //ConsoleKeyInfo keyValue;
            //keyValue = Console.ReadKey();
            //keyValue.Key//방향키 처림
            //    { ConsoleKey.UpArrow}
        
            //string player1, player2;
            //int dice1, dice2;
            //Console.Write("input player1's name >> ");
            //player1 = Console.ReadLine();
            
            //Console.Write("input player2's name >> ");
            //player2 = Console.ReadLine();

            //Random random = new Random();
            //dice1 = random.Next(6) + 1;
            //dice2 = random.Next(6) + 1;

            //switch (dice1)
            //{
            //    case 1:
            //        Console.WriteLine(player1 + " : " + dice1 + "이 나왔습니다.");
            //        break;                    
            //    case 2:                       
            //        Console.WriteLine(player1 + " : " + dice1 + "이 나왔습니다.");
            //        break;                    
            //    case 3:                       
            //        Console.WriteLine(player1 + " : " + dice1 + "이 나왔습니다.");
            //        break;                    
            //    case 4:                       
            //        Console.WriteLine(player1 + " : " + dice1 + "이 나왔습니다.");
            //        break;                    
            //    case 5:                       
            //        Console.WriteLine(player1 + " : " + dice1 + "이 나왔습니다.");
            //        break;                    
            //    case 6:                       
            //        Console.WriteLine(player1 + " : " + dice1 + "이 나왔습니다.");
            //        break;
            //}

            //switch (dice2)
            //{
            //    case 1:
            //        Console.WriteLine(player2 + " : " + dice2 + "이 나왔습니다.");
            //        break;
            //    case 2:
            //        Console.WriteLine(player2 + " : " + dice2 + "이 나왔습니다.");
            //        break;
            //    case 3:
            //        Console.WriteLine(player2 + " : " + dice2 + "이 나왔습니다.");
            //        break;
            //    case 4:
            //        Console.WriteLine(player2 + " : " + dice2 + "이 나왔습니다.");
            //        break;
            //    case 5:
            //        Console.WriteLine(player2 + " : " + dice2 + "이 나왔습니다.");
            //        break;
            //    case 6:
            //        Console.WriteLine(player2 + " : " + dice2 + "이 나왔습니다.");
            //        break;
            //}

            //if (dice1 == dice2)
            //    Console.WriteLine("draw");
            //else
            //    Console.WriteLine(dice1 > dice2 ? player1 + " win" : player2 + " win");

            //Console.WriteLine(player1 + " : " + dice1);
            //Console.Write(player2 + " : " + dice2);


            //Console.WriteLine(11 > 6 ? true : false);

            //if (DateTime.Now.Month <7)
            //{
            //    Console.WriteLine("새해의 결심을 점검해보자");
            //    if (DateTime.Now.Month < 4)
            //    {
            //        Console.WriteLine("연말까지는 많이 남았네");
            //    }
            //    else
            //    {
            //        Console.WriteLine("6월이 끝나기 전엔 시작하자");
            //    }
            //}
            //else
            //{
            //    if (DateTime.Now.Month < 10)
            //    {
            //        Console.WriteLine("그리 늦지 않았어");
            //    }
            //    else
            //    {
            //        Console.WriteLine("내년에 해도 늦지 않아");
            //    }
            //}

            //String Name;
            //String NickName;
            //long Money = 10000;
            //String Deposit;

            //Console.Write("input your name : ");
            //Name = Console.ReadLine();
            //Console.Write("input your nick name : ");
            //NickName = Console.ReadLine();
            //Console.Write(Name + "'s current balance : " + Money + ". input your deposit :");
            //Deposit = Console.ReadLine();
            //Money += (int)(Money * 0.001234) + int.Parse(Deposit);
            //Console.Write(Name + "'s current balance after deposit : " + Money);

            //Console.Write("input your name : >> ");
            //String Name = Console.ReadLine();
            //Console.WriteLine(Name);

            //Console.WriteLine(10 + 4);
            //Console.WriteLine(10 - 4);
            //Console.WriteLine(10 * 4);

            //Console.WriteLine(10 > 4);
            //Console.WriteLine(10 == 10);

            //string str1 = "이게", string2 = "합쳐진다고?";

            //Console.WriteLine(str1 + string2);

            //string input1, input2;
            //int result;
            //Console.WriteLine("input a number >> ");
            //input1 = Console.ReadLine();
            //Console.WriteLine("input a number >> ");
            //input2 = Console.ReadLine();
            //result = int.Parse(input1) + int.Parse(input2);
            //Console.WriteLine("result is " + (float)result);
        }
    }
}
