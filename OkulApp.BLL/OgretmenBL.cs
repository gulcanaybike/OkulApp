using DAL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace OkulApp.BLL
{
    public class OgretmenBL
    {
        public bool OgretmenEkle(Ogretmen ogrt)
        {
            SqlParameter[] p = {
                        new SqlParameter("@TC",ogrt.TC),
                        new SqlParameter("@Ad",ogrt.Ad),
                        new SqlParameter("@Soyad",ogrt.Soyad)                      
                        };
            Helper hlp = new Helper();
            return hlp.ExecuteNonQuery("Insert into tblOgretmenler values (@TC,@Ad,@Soyad)", p) > 0;
        }

    }
}

