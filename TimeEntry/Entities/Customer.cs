using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeEntry.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustCompany { get; set; }
        public string CustProject { get; set; }
    }
}
