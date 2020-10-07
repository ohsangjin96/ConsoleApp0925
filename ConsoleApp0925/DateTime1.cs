using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0925
{
    class DateTime1
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DateTime.Now);//년,월,일,시,분,초 까지 나옴
            //Console.WriteLine(DateTime.Today);//년,월,일 까지 나옴 (시,분,초 는 12:00:00으로 초기화 되어있음)
            //Console.WriteLine(DateTime.Now.ToShortDateString());//년,월,일까지만 나옴
            //Console.WriteLine(DateTime.Now.ToLongDateString());//요일까지 한글로 나옴

            //DateTime from = new DateTime(2020, 9, 2);
            //TimeSpan interval = DateTime.Now - from;
            //Console.WriteLine(interval.Days);

            //DateTime Dday = new DateTime(2020, 9, 26, 13, 0, 0);
            //double rHour = (Dday - DateTime.Now).TotalHours;
            ////양수를 주면 오늘 날짜에 그 양수만큼 늘어나고 음수를 주면 오늘 날짜에 그 음수만큼 뺀다.
            //Console.WriteLine(rHour);

            //이번달 1일~말일
            //    DateTime from =new DateTime(DateTime.Today.Year,DateTime.Today.Month,1);
            //    DateTime to = from.AddMonths(1).AddDays(-1);
            //    Console.WriteLine($"{from.ToShortDateString()}~{to.ToShortDateString()}");

            //    //이번주 일~토
            //    from = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek);
            //    to = from.AddDays(6);
            //    Console.WriteLine($"{from.ToShortDateString()}~{to.ToShortDateString()}");
            //


            string date = DateTime.Today.ToString("yyyyMMdd");
            Console.WriteLine(date);

            int cnt = 15;
            string orderNum=date+cnt.ToString().PadLeft(5, '0');
            Console.WriteLine(orderNum);
        }
    }
}
