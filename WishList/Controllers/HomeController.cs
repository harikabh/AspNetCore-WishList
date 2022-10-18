using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            return View("Index");
        }
        public ActionResult Error() 
        {
            return View("Error");
        }
    }
}
