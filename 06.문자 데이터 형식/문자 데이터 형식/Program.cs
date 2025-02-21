using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문자_데이터_형식
{
    class Program
    {
        static void Main(string[] args)
        {
            //char형식 : 단일 문자를 표현
            //char letter = 'A'; //문자 'A' 저장
            //char symbol = '#'; //특수 기호 저장
            //char number = '9'; //숫자 형태의 문자 저장(문자 '9', 숫자 9 아님)

            //Console.WriteLine(letter);
            //Console.WriteLine(symbol);
            //Console.WriteLine(number);

            //string 형식 : 여러 분자를 저장
            //string greeting = "Hello World"; //문자열 저장
            //string name = "Alice"; //이름 저장

            //Console.WriteLine(greeting);
            //Console.WriteLine(name);

            // Hello world Alice 출력하기

            //Console.Write(greeting + " " + name);

            //bool 형식 : 참(true) = 1 거짓 (false) = 0

            //bool isRunning = true; //프로그램 실행 상태
            //bool isFinished = false; //프로그램 종료 상태

            //Console.WriteLine(isRunning);
            //Console.WriteLine(isFinished);

            // const : 변하지 않는 값을 정의
            //const double Pi = 3.14159; //원주율
            //const int MAxScore = 100; //최대 점수

            //Console.WriteLine(Pi); //출력 3.14159
            //Console.WriteLine(MAxScore); //출력:100
            //Pi = 3.14; 오류! 상수 값은 변경할 수 없습니다.

            //닷넷 형식 : 기본 형식의 닷넷표현
            //System.Int32 number = 123; //int닷넷형식
            //System.String text = "Hello"; //string의 닷넷 형식
            //System.Boolean flag = true; // bool의 닷넷 형식

            //Console.WriteLine(number);
            //Console.WriteLine(text);
            //Console.WriteLine(flag);

            //int 래퍼 형식의 메서드 활용
            int number = 123;

            string numberAsstring = number.ToString(); //정수를 문자열로 변환

            //bool 래퍼형식
            bool flag = true;

            string flagAsString = flag.ToString(); //논리값을 문자열로 변환

            Console.WriteLine(numberAsstring);
            Console.WriteLine(flagAsString);


        }
    }
}
