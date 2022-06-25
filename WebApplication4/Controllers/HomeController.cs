using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Link link = new Link();
            return View(link.TumLinkleriGetir());
        }
        [HttpPost]
        public JsonResult LinkKisalt(string uzunLink)
        {
            string kisaLink = GenerateShortLink.Generate();

            Link link = new Link();
            link.UzunLink = uzunLink;
            link.KisaLink= kisaLink;
            link.Ekle();

            return Json(kisaLink);
        }






    }
} 
   