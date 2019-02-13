using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site1
{
    public class PriorityAndTaskModel
    {
        public PriorityAndTaskModel()
        {
            SelectListItems = new List<SelectListItem>();
        }
        public IEnumerable<SelectListItem> SelectListItems { get; set; }
        public Tasks task { get; set; }
    }
}