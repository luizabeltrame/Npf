using Domain;
using System.Collections.Generic;
using System.Web.Mvc;

namespace NpfWebApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDivisibility divisibility;

        public HomeController()
        {
            divisibility = new Divisibility();
        }

        //public IEnumerable<NumberDetail> Get(IEnumerable<string> numbers)
        //{
        //    return divisibility.Get(numbers);
        //    //return Newtonsoft.Json.JsonConvert.SerializeObject(result);
        //}

        public ActionResult Index()
        {
            return View();
        }

        public void Get()
        {
            var a = 2;
            //return divisibility.Get(numbers);
            //return Newtonsoft.Json.JsonConvert.SerializeObject(result);
        }
    }
}
