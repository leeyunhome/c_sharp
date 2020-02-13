using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Currency
{
    decimal money;
    public decimal Money { get { return money; } }

    public Currency(decimal money)
    {
        this.money = money;
    }
}

public class Won : Currency
{
    public Won(decimal money) : base(money) { }

    public override string ToString()
    {
        return Money + "Won";
    }
}

public class Dollar : Currency
{
    public Dollar(decimal money) : base(money) { }

    static public explicit operator Won(Dollar dollar)
    {
        return new Won(dollar.Money * 1000m);
    }
    public override string ToString()
    {
        return Money + "Dollar";
    }
}

public class Yen : Currency
{
    public Yen(decimal money) : base(money) { }

    static public implicit operator Won(Yen yen)
    {
        return new Won(yen.Money * 13m);
    }

    public override string ToString()
    {
        return Money + "Yen";
    }
}
namespace _4_4_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Won won = new Won(1000);
            Dollar dollar = new Dollar(1);
            Yen yen = new Yen(100);

            Won won1 = yen;
            Won won2 = (Won)yen;
            Won won3 = (Won)dollar;

            Console.WriteLine(won1);
            Console.WriteLine(won2);
            Console.WriteLine(won3);

            //won = yen;  // yen과 won의 타입이 다르기 때문에 컴파일 시에 오류 발생
        }
    }
}
