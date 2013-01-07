using System;
using System.Linq;
using System.Web.Mvc;
using Presenter;
using Presenter.Interfaces;

namespace UI.Controllers
{
   public class HomeController : Controller {

      IConversionPresenter conversionPresenter;

      public HomeController()
      {
         this.conversionPresenter = new ConversionPresenter();
      }

      public HomeController(IConversionPresenter conversionPresenter)
      {
         this.conversionPresenter = conversionPresenter;
      }

      public ActionResult Index() {
         return View("Index");
      }

      public ActionResult About() {
         ViewBag.Message = "Your app description page.";

         return View("About");
      }

      public ActionResult Contact() {
         ViewBag.Message = "Your contact page.";

         return View("Contact");
      }

      [HttpGet]
      public ActionResult ConvertUnit(string fromUnit)
      {
         conversionPresenter.ConvertUnit(fromUnit);
         return View("Index");
      }
   }
}