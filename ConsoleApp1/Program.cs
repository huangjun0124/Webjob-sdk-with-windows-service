using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up a timer to trigger every minute.  
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 10; // 10 milliseconds
            timer.Elapsed += new System.Timers.ElapsedEventHandler(OnTimer);
            timer.Start();
            while (true)
            {
                Console.Read();
            }
        }

        public static void OnTimer(object sender, System.Timers.ElapsedEventArgs args)
        {
            (sender as System.Timers.Timer).Stop();
            JobHost host = new JobHost();
            host.RunAndBlock();
        }
    }
}
