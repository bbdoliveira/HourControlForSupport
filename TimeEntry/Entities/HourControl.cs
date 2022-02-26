using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeEntry.Entities
{
    internal class HourControl
    {
        public DateTime StartService { get; set; }
        public DateTime EndService { get; set; }

        public TimeSpan WorkedHOurs { get; set; }

        public HourControl()
        {
        }

        public HourControl(DateTime startService, DateTime endService, TimeSpan workedHOurs)
        {
            StartService = startService;
            EndService = endService;
            WorkedHOurs = workedHOurs;
        }

        public TimeSpan HorasTrabalhadas(DateTime start, DateTime finish)
        {
            return EndService - StartService;
        }
    }
}
