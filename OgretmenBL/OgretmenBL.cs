using System;
using OkulApp.MODEL;
using System.Data.SqlClient;
using DAL;
namespace OgretmenBL
{
    public class OgretmenBL
    {
        public bool OgretmenEkle(Ogretmen ogrt) 
        {
            SqlParameter[] p = {
                        new SqlParameter("@Numara",ogrt.TC),
                        new SqlParameter("@Ad",ogrt.Ad),
                        new SqlParameter("@Soyad",ogrt.Soyad),                     
                        };
            Helper hlp = new Helper();
            return hlp.ExecuteNonQuery("Insert into tblOgrenciler values (@TC,@Ad,@Soyad)", p) > 0;

        }
    }
}
