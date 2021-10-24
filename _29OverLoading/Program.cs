using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    public enum DMGTYPE
    {
        PYDMG,
        FIREDMG,
        ICEDMG
    }

    //물리방어
    int AttDef = 5;
    //불방어
    int FireDef = 5;
    //물방어
    int IceDef = 5;

    int Hp = 100;

    //생성자도 오버로딩이 가능함
    //Damageint
    //함수오버로딩 함수 이름이 달라야 다른 함수로 인식하는데
    //뒤에 있는 자료형까지 이름으로 인식
    //함수이름은 다 같은데 내용은 다 다름
    public void Damage(int _Damage) //Damageint로 인식
    {
        Hp -= _Damage;
    }
    public void Damage(float _ddd, int _Damage) //Damagefloatint로 인식
    {

    }
    public void Damage(int _Damage, DMGTYPE _Type) //Damageintint로 인식
    {
        switch (_Type)
        {
            case DMGTYPE.PYDMG:
                _Damage -= AttDef;
                break;
            case DMGTYPE.FIREDMG:
                _Damage -= FireDef;
                break;
            case DMGTYPE.ICEDMG:
                _Damage -= IceDef;
                break;
            default:
                break;
        }

        Damage(_Damage);
    }
}

namespace _29OverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            NewPlayer.Damage(100, Player.DMGTYPE.FIREDMG);
        }
    }
}
