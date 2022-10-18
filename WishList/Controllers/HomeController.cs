using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeController:Controller
    {/// <summary>
    /// Index
    /// </summary>
    /// <returns></returns>
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
