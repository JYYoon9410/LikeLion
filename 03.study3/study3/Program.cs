using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study3
{
    class Program
    {
        static void Main(string[] args)
        {
            //리터럴 : 코드에서 고정된 값을 의미
            //int num = 10;    // 정수형 리터럴
            //double pi = 3.14; // 실수형 리터럴
            //char letter = 'A'; //문자 리터럴
            //string name = "Alice"; //문자열 리터럴

            //Console.WriteLine(num); //출력 : 10
            //Console.WriteLine(pi);
            //Console.WriteLine(letter);
            //Console.WriteLine(name);

            //캐릭터 
            //Hp : 100
            //atk: 56.7
            //등급: S
            int Hp = 100;
            double atk = 56.7;
            char grade = 'S';
            string name = "멋진사자";

            Console.WriteLine("캐릭터");
            Console.WriteLine("이름 :" +name);
            Console.WriteLine("체력 :"+Hp);
            Console.WriteLine("공격력: "+atk);
            Console.WriteLine("등급: "+grade);

        }
    }
}
