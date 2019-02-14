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
            
            List<PrioritiesAndTasksModel> model = new List<PrioritiesAndTasksModel>();

            if (ctx.Tasks.Count() != 0)
            {
                foreach (var el in ctx.Tasks)
                {

                    model.Add(new PrioritiesAndTasksModel() { task = el, priority = ctx.Priorities.FirstOrDefault(x => x.ID == el.Priority_ID) });
                }
            }
            return View(model);
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

        [HttpPost]
        public ActionResult Create(PriorityAndTaskModel incomingData)
        {
            ctx.Tasks.Add(new Tasks()
            {
                Date = incomingData.task.Date,
                Name = incomingData.task.Name,
                Priority_ID = incomingData.task.Priority_ID,
                Status = incomingData.task.Status
            });
            ctx.SaveChanges();

            return Redirect("/");
        }


    }
}