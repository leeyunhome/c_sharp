using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_22
{
    class Person
    {
        public int Age;
        public string Name;

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public override string ToString()
        {
            return Name + ": " + Age;
        }
    }

    delegate bool CompareDelegate(Person arg1, Person arg2);

    class SortPerson
    {
        Person[] men;

        public SortPerson(Person[] men)
        {
            this.men = men;
        }

        public void Sort(CompareDelegate compareMethod) // 비교를 위한 델러깃 인자
        {
            Person temp;

            for (int i = 0; i < men.Length; i++)
            {
                int min_idx = i;

                for (int j = i + 1; j < men.Length; j++)
                {
                    if (compareMethod(men[j], men[min_idx]))
                    {
                        min_idx = j;
                    }
                }
                temp = men[min_idx];
                men[min_idx] = men[i];
                men[i] = temp;
            }
        }

        public void Display()
        {
            for (int i = 0; i < men.Length; i++)
            {
                Console.WriteLine(men[i] + ",");
            }
        }
    }
    class SortObject    // 배열을 정렬할 수 있는 기능을 가진 타입 정의
    {
        int[] numbers;

        public SortObject(int [] numbers)// 배열을 생성자의 인자로 받아서 보관
        {
            this.numbers = numbers;
        }

        public delegate bool CompareDelegate(int arg1, int arg2);

        public void Sort(CompareDelegate compareMethod)  //전형적인 선택정렬 알고리즘을 구현한 메서드
        {                   // numbers 배열의 요소를 크기순으로 정렬
            int temp;

            for (int i = 0; i < numbers.Length; i++)
            {
                int min_idx = i;
                for (int j = i +1; j < numbers.Length; j++)
                {
                    if (compareMethod(numbers[j], numbers[min_idx]))
                    {
                        min_idx = j;
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
        static bool AscSortByName(Person arg1, Person arg2)
        {
            // string 객체의 CompareTo 메서드는 문자열 비교를 수행
            // 문자열이 사전 정렬 순으로 비교해서 크면 1, 같으면 0, 작으면 -1을 반환
            // 따라서 0보다 작은 값을 반환한 경우를 true로 가정하면 오름차순 정렬
            return arg1.Name.CompareTo(arg2.Name) < 0;
        }
        static void Main(string[] args)
        {
            Person[] personArray = new Person[]
            {
                new Person(51, "Ronaldo"),
                new Person(37, "Messi"),
                new Person(35, "Heungmin"),
                new Person(32, "JisungPark"),
            };

            SortPerson so1 = new SortPerson(personArray);
            so1.Sort(AscSortByName);
            so1.Display();

            int[] intArray = new int[] { 5, 2, 3, 1, 0, 4 };

            SortObject so = new SortObject(intArray);
            so.Sort(AscendingCompare);  // 오름차순 정렬을 할 수 있는 메서드 전달
            so.Display();

            Console.WriteLine();

            so.Sort(DescendingCompare); // 내림차순 정렬을 할 수 있는 메서드 전달
            so.Display();
        }

        public static bool AscendingCompare(int arg1, int arg2)
        {
            return (arg1 < arg2);
        }
        public static bool DescendingCompare(int arg1, int arg2)
        {
            return (arg1 > arg2);
        }
    }
}
