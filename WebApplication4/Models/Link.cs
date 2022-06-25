using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Link
    {
        public string UzunLink { get; set; }
        public string KisaLink { get; set; }

        public void Ekle()
        {
            SqlConnection conn = new SqlConnection
                (@"Server=DESKTOP-0JD0258;Database=ShortLink;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand("insert into UserLink (LongLink,Link) values(@longLink,@link)", conn);
            cmd.Parameters.AddWithValue("@longlink", UzunLink);
            cmd.Parameters.AddWithValue("@link", KisaLink);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public string UzunLinkGetir()
        {
            SqlConnection conn = new SqlConnection
                (@"Server=DESKTOP-0JD0258;Database=ShortLink;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand("Select * from UserLink where Link=@link", conn);
            cmd.Parameters.AddWithValue("@link", KisaLink);
            DataTable dt = new DataTable();
            conn.Open();
            dt.Load(cmd.ExecuteReader());
            conn.Close();

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["LongLink"].ToString();
            }
            else
            {
                return "";
            }
        }

        public List<Link> TumLinkleriGetir()
        {
            SqlConnection conn = new SqlConnection
               (@"Server=DESKTOP-0JD0258;Database=ShortLink;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand("Select * from UserLink ", conn);

            DataTable dt = new DataTable();
            conn.Open();
            dt.Load(cmd.ExecuteReader());
            conn.Close();
            List<Link> linkler = new List<Link>();
            foreach (DataRow satir in dt.Rows)
            {
                linkler.Add(new Link
                {
                    KisaLink = satir["Link"].ToString(),
                    UzunLink = satir["LongLink"].ToString()
                });
                
            }
            return linkler;
        }
    }
}