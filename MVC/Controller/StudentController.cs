using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC
{
    public class StudentController : Controller
    {
        public IActionResult Index(Nullable<int> id)
        {
            if (id==null)
            {
                ViewData["Info"] = "Id is null";
                return View();
            }

            return Json(new {Name="Vahid" ,Surname="Rashidli", Age=20});
        }
    }
}
