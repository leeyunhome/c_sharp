using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Computer
{
}

interface IMonitor  // 메서드 시그니처만을 포함하고 있는 인터페이스
{
    void TurnOn();
    int Inch { get; set; }  // 프로퍼티 get/set 포함
    int Width { get; }      // get만 포함하는 것도 가능
}

interface IKeyboard { } // 비어 있는 인터페이스 정의 가능

// 클래스 상속과 함께 인터페이스로부터 다중 상속 가능
class Notebook : Computer, IMonitor, IKeyboard
{
    public void TurnOn() { }    // 추상 메서드와는 달리 override 예약어가 필요없음.

    int inch;
    public int Inch
    {
        get { return inch; }
        set { inch = value; }
    }

    int width;
    public int Width { get { return width; } }
}
namespace page202
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
