using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//상속은 2개를 못받음
//사용자 정의 자료형
interface QuestUnit
{
    //멤버변수 X
    //int A = 0;

    //함수의 형태만 물려 줄 수 있는 문법이다.
    //함수를 선언만 가능함, 정의를 사용할 수 없음
    //상속을 받은 클래스는 그 함수를 구현해야함
    //무조건 public
    void Talk(QuestUnit _OtherUnit);
}

class FightUnit
{
    int AT;
    int DMG;

    public void Damage()
    {

    }
}
//인터페이스는 실체가 없음
//인터페이스는 함수구현을 강제할 수 있다.
//함수의 구현을 강제한다면 무조건 호출 가능, 함수가 있다는 것을 보장
//인터페이스는 상속이라고 안하는 사람도 있음
//상속보다는 포함의 개념이라고 말하는 사람도 있음
//인터페이스를 상속받았다고 치면
//Talk를 구현
class Player : FightUnit, QuestUnit
{
    public void Talk(QuestUnit _OtherUnit)
    {

    }
}

class Npc : FightUnit, QuestUnit
{
    public void Talk(QuestUnit _OtherUnit)
    {

    }
}
class Program
{
    static void Main(string[] args)
    {
        Player NewPlayer = new Player();
        Npc NewNPC = new Npc();
        

        //업캐스팅이 됨
        NewPlayer.Talk(NewNPC);
        NewNPC.Talk(NewPlayer);
    }
}

