using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowingHidingOverridingPrac
{
    internal class Program
    {
        // Shadowing 예제
        public static int number = 10; //같은 이름의 지역변수에 의해 가려짐(클래스 변수)
        public int number2 = 2; //같은 이름의 지역변수에 의해 가려짐(인스턴스 변수)
        static void Main(string[] args)
        {
            int number = 10;
            int number2 = 3;
            Console.WriteLine(number); //지역변수 number 출력
            Console.WriteLine(Program.number); //이렇게 접근은 가능
            Console.WriteLine((new Program()).number2); //인스턴스 변수인 경우는 이렇게..
        }
    }
}
