using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Robo
{
    public class RoboService
    {
        public void Start()
        {
            var timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Elapsed += new System.Timers.ElapsedEventHandler(timer1_Tick);
            timer1.Enabled = true;
            Console.WriteLine("Robô foi iniciado");
        }

        private void timer1_Tick(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Robô sendo executado a cada 10 segundos");
        }

        public void Stop()
        {
            Console.WriteLine("Robô desligado");
        }
    }
}
