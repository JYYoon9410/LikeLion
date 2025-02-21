using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.입력
{
    class Program
    {
        static void Main(string[] args)
        {
            //사용자 입력을 문자열 받기
            //Console.Write("이름을 입력하세요: ");
            //string userName = Console.ReadLine(); // 사용자로 부터 입력받기

            //Console.WriteLine($"안녕하세요, {userName}님!");

            // 문자열을 정수로 변환
            //Console.Write("나이를 입력하세요 : ");
            //string input = Console.ReadLine(); //사용자로부터 입력 받기
            //int age = int.Parse(input); //문자열을 정수로 변환

            //Console.WriteLine($"내년에는 {age + 1} 살이 되겠군요!"); //변환된 값 사용
            //Console.WriteLine("내년에는 " + age + "살이 되겠군요!"); //문자열 +정수
            //Console.WriteLine("내년에는 {0} 살이 되겠군요!", age);

            //해당 스샷내용 
            //루인 스킬 피해      : 4.5 <-입력받기

            Console.Write("루인 스킬 피해를 입력하세요: ");
            string dminput = Console.ReadLine();
            float dmg = float.Parse(dminput);

            Console.Write("카드 게이지 획득량을 입력하세요: ");
            string cdinput = Console.ReadLine();
            float idt = float.Parse(cdinput);

            Console.Write("각성기 피해량을 입력하세요: ");
            string ultinput = Console.ReadLine();
            float ultdmg = float.Parse(ultinput);

            Console.Write("최대 마나를 입력하세요: ");
            string manainput = Console.ReadLine();
            int max_mana = int.Parse(manainput);

            Console.Write("전투중 마나 회복량을 입력하세요: ");
            string bt_manainput = Console.ReadLine();
            int battle_mana = int.Parse(bt_manainput);

            Console.Write("비 전투중 마나 회복량을 입력하세요: ");
            string nbt_manainput = Console.ReadLine();
            int nbattle_mana = int.Parse(nbt_manainput);

            Console.Write("이동속도를 입력하세요: ");
            string spdinput = Console.ReadLine();
            float spd = float.Parse(spdinput);

            Console.Write("탈 것 속도를 입력하세요: ");
            string vspdinput = Console.ReadLine();
            float vspd = float.Parse(vspdinput);

            Console.Write("운반 속도를 입력하세요: ");
            string mspdinput = Console.ReadLine();
            float mspd = float.Parse(mspdinput);

            Console.Write("스킬 재사용 대기시간 감소를 입력하세요: ");
            string cldwinput = Console.ReadLine();
            float cldw = float.Parse(cldwinput);


            Console.WriteLine("\n===================================");


            Console.WriteLine($"루인 스킬피해 : {dmg}%");
            Console.WriteLine($"카드 게이지 획득량 : {idt}%");
            Console.WriteLine($"각성기 피해 : {ultdmg}%");
            Console.WriteLine($"최대 마나 : {max_mana}");
            Console.WriteLine($"전투중 마나 회복량 : {battle_mana}");
            Console.WriteLine($"비 전투중 마나 회복량 : {nbattle_mana}");
            Console.WriteLine($"이동속도 : {spd}%");
            Console.WriteLine($"탈 것 속도 : {vspd}%");
            Console.WriteLine($"탈 것 속도 : {mspd}%");
            Console.WriteLine($"스킬 재사용 대기시간 감소 : {cldw}%");


            Console.WriteLine("===================================");




        }
    }
}
