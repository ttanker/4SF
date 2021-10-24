using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    //배열은 기본적으로 자료형이라고 할 수 있으며
    //기본자료형에 속한다.
    //선언 방식은 어떤 자료형[]

    //모든 자료형은 구조체 아니면 클래스에 가까운데
    //기본자료형도 마찬가지

    class Item
    {
        public string Name;
        public int AT;
        public int DF;
    }
    static void Main(string[] args)
    {
        //[0][0][0][0][0][0][0][0][0]
        //int가 10개 생김
        int[] ArrInt = new int[10];

        float[] Arrfloat = new float[10];

        //정수형 short
        //int64
        //ArrInt는 int의 배열형(int의 집합)
        //ArrInt[0]은 무슨 자료형인가?

        //c#에서는 모든 자료형은 클래스 혹은
        //구조체에 가깝다.
        //멤버변수와 멤버 함수가 있다.

        //여러게가 모여있는 것.
        //연속되어 있다.
        //접근방법 그 모여있는 자료들을 접근하는 방법

        for (int i = 0; i < ArrInt.Length; i++)
        {
            Console.WriteLine(ArrInt[i]);
        }
        //배열은 언제 사용하는 가?
        //아이템 100개 있다.

        //아이템이라는 참조형을
        //담을 수 있는 공간이 10개 생김

        //new Item();
        //이건 아이템을 만든 것이 아니다
        //이건 아이템을 담을수 있는 공간을 만든것이다.
        //new Item[100];

        Item NewItem = new Item();
        Item NewItem2 = NewItem;

        //아이템이라는 메모리를 
        //가리킬 수 있는 참조형이 10개 생김
        Item[] ArrItem = new Item[10];

        for (int i = 0; i < ArrItem.Length; i++)
        {
            ArrItem[i] = new Item();
        }

        ArrItem[0].Name = "철검";
        ArrItem[1].Name = "전설의 검";
        ArrItem[2].Name = "갑옷";
        ArrItem[3].Name = "멋진 갑옷";
        ArrItem[4].Name = "포션";

        for (int i = 0; i < ArrItem.Length; i++)
        {
           Console.WriteLine(ArrItem[i].Name);
        }
    }
}

