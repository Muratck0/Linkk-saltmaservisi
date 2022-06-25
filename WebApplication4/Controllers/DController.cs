using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class DController : Controller
    {
        // GET: D
        public ActionResult In(String I)
        {

            Link link = new Link();
                link.KisaLink = I;
            
            string directLink =link.UzunLinkGetir();
            Response.Redirect(directLink);
            return View();
        }
    }
}