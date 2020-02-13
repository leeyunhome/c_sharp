using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate bool CompareDelegate(object arg1, object arg2);    // object 인자 2개

class SortObject
{
    object[] things;

    public SortObject(object[] things)  // object 배열
    {
        this.things = things;
    }

    public void Sort(CompareDelegate compareMethod)
    {
        object temp;

        for (int i = 0; i < things.Length; ++i)
        {
            int min_idx = i;

            for (int j = i + 1; j < things.Length; ++j)
            {
                if (compareMethod(things[j], things[min_idx]))
                {
                    min_idx = j;
                }
            }
            temp = things[min_idx];
            things[min_idx] = things[i];
            things[i] = temp;
        }
    }

    public void Display()
    {
        for (int i = 0; i < things.Length; ++i)
        {
            Console.WriteLine(things[i] + ",");
        }
    }
}

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

namespace _4_23
{
    class Program
    {
        static bool AscSortByName(object arg1, object arg2)
        {
            Person person1 = arg1 as Person;   //대상 타입으로 형변환
            Person person2 = arg2 as Person;

            return person1.Name.CompareTo(person2.Name) < 0;
        }

        static void Main(string[] args)
        {
            Person[] personArray = new Person[]
            {
                new Person(33, "Leehyerim"),
                new Person(28, "Yoonhyerim"),
                new Person(5, "Kimjisu"),
                new Person(11, "Beakyujin"),
            };

            SortObject so = new SortObject(personArray);
            so.Sort(AscSortByName);
            so.Display();

        }
    }
}
