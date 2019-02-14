using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Tasks
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public bool Status { get; set; } = false;
        public int Priority_ID { get; set; }
    }
}
