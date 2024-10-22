using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace TimeEntry.Entities
{
    public class DALTimeEntry
    {
        public static string path = Directory.GetCurrentDirectory() + "\\TimeEntryDB.sqlite";
        public static SQLiteConnection sqliteConnection;


    }
}
