using Domain;
using System.Collections.Generic;
using System.Web.Mvc;

namespace NpfApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDivisibility divisibility;

        public HomeController()
        {
            divisibility = new Divisibility();
        }

        public JsonResult Get(IEnumerable<string> numbers)
        {
            var result = divisibility.Get(numbers);
            return Json(Newtonsoft.Json.JsonConvert.SerializeObject(result), JsonRequestBehavior.AllowGet);
        }
    }
}
