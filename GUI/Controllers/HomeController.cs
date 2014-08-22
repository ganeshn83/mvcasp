using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GUI.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CustomerService.CustomerServiceClient customerserviceClient = new CustomerService.CustomerServiceClient();
            var CustList = customerserviceClient.ListCustomers();
            ViewData["CustList"] = CustList;
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
