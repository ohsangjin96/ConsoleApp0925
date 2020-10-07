using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0925
{
    class String1
    {
        static void Main()
        {
            while (true)
            {
                string str1 = "가나다라마바사";
                Console.Write("주민번호를 입력해주세요: ");
                string strEmail = Console.ReadLine();

                int year = int.Parse(strEmail.Substring(0, 2));
                int Month = int.Parse(strEmail.Substring(2, 2));
                int day = int.Parse(strEmail.Substring(4, 2));
                int sex = int.Parse(strEmail.Substring(6, 1));
                Console.WriteLine($"{year}년 {Month}월 {day}일에 태어나셨습니다.");
                if (sex == 1)
                {
                    Console.WriteLine("남성");
                    break;
                }
                else
                {
                    Console.WriteLine("여성");
                    break;
                }

            }
                string str3 = @"C:\Users\GDC5\Pictures\image\20191024114946.jpg";
                int str4 = str3.LastIndexOf(@"\");
                int str5= str3.LastIndexOf(".");
                
                Console.WriteLine(str3.Substring(str4+1));
                Console.WriteLine(str3.Substring(str5+1).ToUpper());
            
            if(str3.Substring(str5 + 1).ToUpper().Equals("EXE"))
                Console.WriteLine("첨부 할수 없는 파일입니다.");
            
        }
    }
}
