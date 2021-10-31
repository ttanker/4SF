using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//자료구조
//자료구조를 직접 만들어 보는건
//게임 프로그래머의 언어와 같이 기초소양이다.
//총알이 1000발이 발사된다. 어떻게 관리하지?
//NPC가 500명이 있다. 그중에서 '피오나'
//라는 이름의 NPC가 있는데 어떻게 찾지?

class MyDataStruct<T>
{
    //넣는다.()
    //탐색. ()
    //확장한다. ()
    public void Push(T _Data)
    {
        //if(/*이 자료가 들어왔을 때 내 사이즈를 오버하면 */)
        //{
        //    MDS.Ex(/*적절한 수*/);
        //}

        //여러가지 예외처리해야 할 것이 있다.
    }
    public int Find(T _Data)
    {
        return 100;
    }
    public void Ex(int _Size)
    {

    }
}

namespace _38DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //자료구조라는 건
            //int 10
            //0 1 2 3 4 5 6 7 8 9

            //자료구조에는
            //다음의 구조나 인터페이스를 지원한다.
            //함수로 표현한다.
            //넣는다.()
            //탐색. ()
            //확장한다. ()


            //자료구조에는 보통 컨테이너라는 
            //용어를 사용하는데
            //시퀀스 컨테이너(넣어주면 넣어주는대로
            //차곡차고 쌓임)와 List(c#) vecter (c#에서는 없다. c/c++)
            //연관 컨테이너(예, 어떠한 규칙에 따라 값 말고 순서가 바뀜) Dictionary(c# 해쉬 맵) map(c++)
            //어뎁터 컨테이너라고 분류. stack queue

            //데이터의 메모리 구조는
            //배열과
            //노드형

            //자료구조이다.
            int[] Arr = new int[10];
            Arr[0] = 0;
            Arr[1] = 1;

            MyDataStruct<int> MDS = new MyDataStruct<int>();

            //100을 넣어줘
            MDS.Push(100);

            //50을 찾아줘
            MDS.Find(50);

            //자동으로 이루어진다.
            //MDS.Ex(50000);

        }
    }
}
