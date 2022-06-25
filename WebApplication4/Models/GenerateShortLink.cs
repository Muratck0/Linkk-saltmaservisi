using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.Views.Extension;

namespace WebApplication4.Models
{
    public static class GenerateShortLink
    {
        public static string Generate()
        {
            string shortLink = "";
            shortLink = DateTime.Now.TarihiCevir();
            shortLink = shortLink.Temizle();


            return shortLink;
        }
    }
}