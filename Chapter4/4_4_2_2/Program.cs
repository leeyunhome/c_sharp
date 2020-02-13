using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Weigh
{
    double mass;
    public double Mass { get { return mass; } }

    public Weigh(double value)
    {
        this.mass = value;
    }
}
public class Kilogram : Weigh
{
    public Kilogram(double value) : base(value) { }    

    static public explicit operator Gram(Kilogram kilogram)
    {
        return new Gram(kilogram.Mass * 1000d);
    }

    public static Kilogram operator +(Kilogram op1, Kilogram op2)
    {
        return new Kilogram(op1.Mass + op2.Mass);
    }
    public override string ToString()
    {
        return Mass + "kg";
    }

}

public class Gram : Weigh
{
    public Gram(double value) : base(value) { }

    public static Gram operator +(Gram op1, Gram op2)
    {
        return new Gram(op1.Mass + op2.Mass);
    }
    public override string ToString()
    {
        return Mass + "g";
    }
}
namespace _4_4_2_2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Kilogram 타입 사용 예제
            Kilogram kg1 = new Kilogram(5);
            Kilogram kg2 = new Kilogram(10);
            Gram gram1 = (Gram)kg1;
            Gram gram2 = (Gram)kg2;

            Kilogram kg3 = kg1 + kg2;
            Gram gram3 = gram1 + gram2;

            Console.WriteLine(gram1);
            Console.WriteLine(kg3);
            Console.WriteLine(gram3);
        }
    }
}
