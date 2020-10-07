using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp0925
{
    class DateTime2
    {
        static void Main()
        {

            
            System.Timers.Timer timer1 = new System.Timers.Timer();
            timer1.Interval = 1000;//밀리세컨드
            timer1.Elapsed += timer1_Elapsed;
            timer1.Start();

            Console.ReadLine();
        }

        private static void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine(DateTime.Now);
        } 

        
     
    }
}
