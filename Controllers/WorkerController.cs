using Microsoft.AspNetCore.Mvc;

namespace MaterialManagement.Controllers
{
    public class WorkerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
