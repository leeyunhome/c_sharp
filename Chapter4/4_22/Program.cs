using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_22
{
    class SortObject    // 배열을 정렬할 수 있는 기능을 가진 타입 정의
    {
        int[] numbers;

        public SortObject(int [] numbers)// 배열을 생성자의 인자로 받아서 보관
        {
            this.numbers = numbers;
        }

        public void Sort(bool ascending)  //전형적인 선택정렬 알고리즘을 구현한 메서드
        {                   // numbers 배열의 요소를 크기순으로 정렬
            int temp;

            for (int i = 0; i < numbers.Length; i++)
            {
                int min_idx = i;
                for (int j = i +1; j < numbers.Length; j++)
                {
                    if (ascending == true)  // 오름차순 정렬
                    {
                        if (numbers[min_idx] > numbers[j])
                        {
                            min_idx = j;
                        }
                    }
                    else
                    {
                        if (numbers[min_idx] < numbers[j])
                        {
                            min_idx = j;
                        }
                    }
                    
                }
                temp = numbers[min_idx];
                numbers[min_idx] = numbers[i];
                numbers[i] = temp;
            }
        }     

        public void Display()   // numbes요소를 화면에 출력
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
            Console.WriteLine("");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 5, 2, 3, 1, 0, 4 };

            SortObject so = new SortObject(intArray);
            so.Sort(true);
            so.Display();
        }
    }
}
