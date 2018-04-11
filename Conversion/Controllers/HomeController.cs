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
       
           public ActionResult ConvertGallons(ViewModel vm)
        {
            if (vm == null) { return View("convertgallons", new ViewModel { ShowResult = false }); }

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

            return View("convertgallons", vm);
        }

        public ActionResult ConvertCF(ViewModel vm)
        {
            if (vm == null) { return View("convertcf", new ViewModel { ShowResult = false }); }

            if (vm.Option == 1)
            {
                vm.Result = Methods.CelsiusToFahrenheit(vm.Input);
                vm.OptionName = "Celsius To Fahrenheit";
            }
            else
            {
                vm.Result = Methods.FahrenheitToCelsius(vm.Input);
                vm.OptionName = "Fahrenheit to Celsius";
            }
            vm.ShowResult = true;

            ////not needed, just for an example
            //ViewData.Add("glosrob-example", "A value goes here!");

            return View("convertcf", vm);
        }

        public ActionResult ConvertKP(ViewModel vm)
        {
            if (vm == null) { return View("convertkp", new ViewModel { ShowResult = false }); }

            if (vm.Option == 1)
            {
                vm.Result = Methods.PoundstoKilos(vm.Input);
                vm.OptionName = "Pounds to Kilos";
            }
            else
            {
                vm.Result = Methods.KilostoPounds(vm.Input);
                vm.OptionName = "Kilograms to Pounds";
            }
            vm.ShowResult = true;

            ////not needed, just for an example
            //ViewData.Add("glosrob-example", "A value goes here!");

            return View("convertkp", vm);
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