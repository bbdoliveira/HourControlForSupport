using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeEntry.Entities
{
    public class HoraDia
    {
        public string hora { get; set; }

        public HoraDia()
        {
        }
        public HoraDia(string hora)
        {
            this.hora = hora;
        }
    }
}
