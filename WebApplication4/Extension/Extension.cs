using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Views.Extension
{
    public static class Extension
    {
        public static string TarihiCevir(this DateTime dt)
        {
            return dt.ToString("d.MM.yyyy.HH.mm.s");

        }
        public static string Temizle(this string kisaLink)
        {
            return kisaLink.Replace(".", "");
        }
    }
}