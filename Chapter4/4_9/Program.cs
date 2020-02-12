using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Computer
{
    protected bool powerOn;
    public void Boot() { }
    public void Shutdown() 
    {
        Console.WriteLine("Shutdown!");
    }
    public void Reset() { }
}

public class Notebook : Computer
{
    bool fingerScan;    // Notebook 타입에 해당하는 멤버만 추가
    public bool HasFingerScanDevice() { return fingerScan; }

    public void CloseLid()
    {
        if (powerOn == true)
        {
            Shutdown(); // Notebook에서 추가된 메서드 내에서 부모의 메서드 호출

        }
    }
}

public class Desktop : Computer
{

}

public class Netbook : Computer
{

}

public class DeviceManager
{
    public void TurnOff(Computer device)
    {
        device.Shutdown();
    }
}



namespace _4_9
{
    

    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 5;
            int n2 = 5;
            Console.WriteLine(n1.Equals(n2));

            n2 = 6;
            Console.WriteLine(n1.Equals(n2));

            //int n = 5;
            //Console.WriteLine(n.Equals(5)); // 출력 결과: True

            //Type type = typeof(double);
            //Console.WriteLine(type.FullName);

            //Console.WriteLine(typeof(System.Int16).FullName);

            //int n = 5;
            //string txt = "text";

            //Type intType = n.GetType();
            //Console.WriteLine(intType.FullName);
            //Console.WriteLine(txt.GetType().FullName);

            //Computer computer = new Computer();
            //Type type = computer.GetType();

            //Console.WriteLine(type.FullName);
            //Console.WriteLine(type.IsClass);
            //Console.WriteLine(type.IsArray);



            //int n = 500;
            //double d = 3.141592;

            //string txt = "Hello: ";

            //Console.WriteLine(txt + n.ToString());
            //Console.WriteLine(txt + d.ToString());

            //txt = d.ToString();

            //Console.WriteLine(txt);

            //Program program = new Program();
            //Console.WriteLine(program.ToString());

            //int n = 5;
            //if (n is string)
            //{
            //    Console.WriteLine("변수 n은 string 타입");
            //}

            //string txt = "text";
            //if (txt is int)
            //{
            //    Console.WriteLine("변수 txt는 int 타입");
            //}

            //Console.WriteLine(txt.GetType());
            //Console.WriteLine(n.GetType());

            //Computer[] machines = new Computer[] { new Notebook(), new Desktop(), new Netbook() };// 암시적 형변환

            //DeviceManager manager = new DeviceManager();

            //foreach (Computer device in machines)
            //{
            //    manager.TurnOff(device);
            //}

            //Notebook notebook = new Notebook();
            //Desktop desktop = new Desktop();
            //Netbook netbook = new Netbook();

            //DeviceManager manager = new DeviceManager();
            //manager.TurnOff(notebook);
            //manager.TurnOff(desktop);
            //manager.TurnOff(netbook);

            //Notebook noteBook = new Notebook();
            //noteBook.Boot();    // Notebook 인스턴스에 대해 부모의 메서드 호출
        }
    }
}
