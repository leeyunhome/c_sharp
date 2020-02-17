using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int GetResultDelegate();   // int를 반환하고 매개변수가 없는 델러깃 타입을 정의

class Target
{
    public void Do(GetResultDelegate getResult)
    {
        Console.WriteLine(getResult());
    }
}

class Source
{
    public int GetResult()  // 콜백 용도로 전달될 메서드
    {
        return 10;
    }

    public void Test()
    {
        Target target = new Target();
        target.Do(new GetResultDelegate(this.GetResult));
    }
}
namespace _4_21
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Source s = new Source();
            s.Test();
        }
    }
}
