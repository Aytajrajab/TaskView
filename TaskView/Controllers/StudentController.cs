using Microsoft.AspNetCore.Mvc;

namespace TaskView.Controllers
{
    public class StudentController :Controller
    {
        public IActionResult Index(int ?id)
        {
            if (id==null)
            {
                ViewData["Message"] = "Id is null";
                return View("Index");
            }
            return Json(new {Name="Aytac",Surname="Racabli",Age=21});
        }
    }
}
