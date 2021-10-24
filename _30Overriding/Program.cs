using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FightUnit
{
    //외부 자식 내부 까지만
    //디폴트 접근제한 지정자는 private
    protected string Name = "NONE";
    protected int AT = 10;
    protected int HP = 100;

    //이 문법의 핵심은
    //자식에서 만약 나의 GetAT를 재구현했다면
    //자식의 형태의 GetAT를 호출해 주세요.
    //이것을 오버라이딩
    //다형성(동적바인딩)의 핵심 문법중 하나이다.
    public virtual int GetAT()
    {
        Console.WriteLine("FightUnit의 GETAT");
        return AT;
    }
    //업캐스팅
    //DamageFightUnit
    //첫번째 상속의 개념을 지키키 위해서
    //(코드 재활용성)(코드를 적제치고 최대한의 효과를 누리고 싶다.)
    //여러개의 함수를 구현할 필요가 없음(코드가 복잡해짐)
    public void Damage(FightUnit _OtherFightUnit)
    {
        //각자 플레이어면 플레이어의 것
        // _OtherFightUnit.AT
        int AT = _OtherFightUnit.GetAT();

        Console.WriteLine(_OtherFightUnit.Name + "에게" + AT + "만큼의 데미지를 입었습니다.");

        HP -= AT;
    }
    //생성자는 오버라이딩을 불가
    //프로퍼티는 VIRTUAL 가능

    //오버로딩은 좋은 해결책이 될 수 없음 
    //DamagePlayer
    /*public void Damage(Player _OtherFightUnit, int _DamagePlus)
    {
        
        Console.WriteLine(_OtherFightUnit.Name + "에게" + _OtherFightUnit.AT + "만큼의 데미지를 입었습니다.");

        HP -= _OtherFightUnit.AT;
    }*/

}


class Player : FightUnit
{
    int ItemAt = 5; //FightUnit에서 알 수 없음
    //부모의 GetAT를 재구현
    public  override int GetAT()
    {
        Console.WriteLine("플레이어의 GETAT");
        return AT + ItemAt;
    }

    public Player()//이건 이름이 없어도 됨
    {
    }
    public Player(string _Name)//이름을 무조건 만들도록 제한함
    {
        Name = _Name;
    }
}

class Monster : FightUnit
{
    public Monster(string _Name)
    {
        Name = _Name;
    }
}

namespace _30Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Monster NewMonster = new Monster("몬스터");
            Player NewPlayer = new Player("플레이어"); //생성자를 이름을 넣어주면 만들수 없게 만들었기 때문에 이름을 무조건 넣어야함

            //NewPlayer.GetAT();
            NewPlayer.Damage(NewMonster);
            NewMonster.Damage(NewPlayer);
        }
    }
}
