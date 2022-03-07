using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeEntry.Entities
{
    public class HoraDia
    {
        public int hora { get; set; }

        public HoraDia()
        {
        }
        public HoraDia(int hora)
        {
            this.hora = hora;
        }
    }
}
