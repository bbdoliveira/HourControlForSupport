using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeEntry.Entities
{
    class TimeControl
    {
        public DateTime ServiceStart { get; set; }
        public DateTime ServiceEnd { get; set; }
        public TimeSpan TesteSpan { get; set; }

        public TimeControl()
        {
        }
        public TimeControl(DateTime serviceStart, DateTime serviceEnd, TimeSpan testeSpan)
        {
            ServiceStart = serviceStart;
            ServiceEnd = serviceEnd;
            TesteSpan = testeSpan;
        }

        public TimeSpan TimeWorked(DateTime serviceStart, DateTime serviceEnd)
        {
            return serviceEnd.Subtract(serviceStart);
        }

        public void MostraTempo()
        {
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", TesteSpan.Hours,
                    TesteSpan.Minutes, TesteSpan.Seconds, TesteSpan.Milliseconds / 10);
        }

        public override string ToString()
        {
            string elapsedTime;
            return elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", TesteSpan.Hours,
                    TesteSpan.Minutes, TesteSpan.Seconds, TesteSpan.Milliseconds / 10);
        }
    }
}
