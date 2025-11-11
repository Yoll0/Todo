using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TaskModel
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Opisanie { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
         public bool Status { get; set; }


        public TaskModel(string name, string category, string opisanie, DateTime time, DateTime date, bool status)
        {
            Name = name;
            Category = category;
            Opisanie = opisanie;
            Date = date;
            Time = time;
            Status = status;

        }



    }
}
