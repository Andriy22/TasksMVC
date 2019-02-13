using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
namespace Site1.Controllers
{
    public class HomeController : Controller
    {
        DAL.DBase ctx = new DAL.DBase();
        public ActionResult Index()
        {
            return View(ctx.Tasks);
        }
        public ActionResult Create()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (var el in ctx.Priorities)
                items.Add(new SelectListItem { Value = el.ID.ToString(), Text = el.Name });
            PriorityAndTaskModel priorityAndTasksModel = new PriorityAndTaskModel()
            {
                SelectListItems = items,
                task = new Tasks()
            };
            return View(priorityAndTasksModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

      

    }
}