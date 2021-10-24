using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using _28partial;을 사용하면 네임스페이스 안에 있는 내용을 사용해서 앞에 _28Partial. 생략가능 
//partial은 편한 기능 클래스를 강제로 쪼갤때가 있음

namespace _28Partial
{
    //함수가 너무 많아지면 
    class Program //클래스 이름이 네임스페이스가 들어가 _28Partial.Program이 됨 
    {
        static void Main(string[] args)
        {
            
        }
    }
   // partial을 클래스 이름 앞에 붙이면 같은 프로그램은 떨어져 있어도 실행할 때 합쳐저서 나옴
}
