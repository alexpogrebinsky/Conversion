using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Conversion.Business;
using Conversion.Models;

namespace Conversion.Controllers
{
    public class HomeController : Controller
    {
       

        public ActionResult Convert(ViewModel vm)
        {
            if (vm == null) { return View("convert", new ViewModel { ShowResult = false }); }

            if (vm.Option == 1)
            {
                vm.Result = Methods.LiterstoGallonsConvert(vm.Input);
                vm.OptionName = "Liters to Gallons";
            }
            else
            {
                vm.Result = Methods.GallonstoLitersConvert(vm.Input);
                vm.OptionName = "Gallons to Liters";
            }
            vm.ShowResult = true;

            ////not needed, just for an example
            //ViewData.Add("glosrob-example", "A value goes here!");

            return View("convert", vm);
        }

     

        public ActionResult Index()
        {

       


            return View();
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