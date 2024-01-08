using OkulApp.MODEL;
using System;
using System.Data.SqlClient;
using DAL;
using System.Net;
namespace OkulApp.BLL
{
    public class OgrenciBL
    {
       /* private static OgrenciBL instance=null;
        public static OgrenciBL Instance
        {
            get
            {
                if (instance != null)
                {
                    return instance;
                }
                else
                {
                    instance = new OgrenciBL();
                    return instance;
                }
            }
            set { instance = value; }
        }*/
        public bool OgrenciEkle(Ogrenci ogr)
        {
            try
            {
                SqlParameter[] p = {
                        new SqlParameter("@Ad",ogr.Ad),
                        new SqlParameter("@Soyad",ogr.Soyad),
                        new SqlParameter("@Numara",ogr.Numara)
                        };
                Helper hlp = Helper.Instance;
                return hlp.ExecuteNonQuery("Insert into tblOgrenciler values (@Ad,@Soyad,@Numara)", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }
            //SqlConnection cn = null;
            //SqlCommand cmd = null;
            //try
            //{
            //    using (cn = new SqlConnection("Data Source= .; Initial Catalog=OkulDB; user=sa; password=abc123"))
            //    {
            //        using (cmd = new SqlCommand($"Insert into tblOgrenciler values (@Ad,@Soyad,@Numara)", cn))
            //        {
            //            SqlParameter[] p = {
            //            new SqlParameter("@Ad",ogr.Ad),
            //            new SqlParameter("@Soyad",ogr.Soyad),
            //            new SqlParameter("@Numara",ogr.Numara)
            //            };
            //            cmd.Parameters.AddRange(p);

            //            cn.Open();
            //            int sonuc = cmd.ExecuteNonQuery();
            //            return sonuc > 0;
            //        }
            //    }
            //}
            //catch (SqlException ex)
            //{
            //    throw ex;
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
            //finally
            //{
            //    if (cn != null && cn.State != ConnectionState.Closed)
            //    {
            //        cn.Close();
            //        cn.Dispose();
            //        cmd.Dispose();
            //    }
            //}
        }
        public bool OgrenciGuncelle(Ogrenci ogr)
        {
            try
            {
                SqlParameter[] p = {
                             new SqlParameter("@Ad",ogr.Ad),
                             new SqlParameter("@Soyad",ogr.Soyad),
                             new SqlParameter("@Numara",ogr.Numara),
                             new SqlParameter("@Ogrenciid",ogr.Ogrenciid)
                         };
                Helper hlp = Helper.Instance;
                return hlp.ExecuteNonQuery("Update tblOgrenciler set Ad=@Ad,Soyad=@Soyad,Numara=@Numara where OgrenciId=@Ogrenciid", p) > 0;      
            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool OgrenciSil(int id)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@OgrenciId", id) };
                Helper hlp = Helper.Instance;
                return hlp.ExecuteNonQuery("Delete from tblOgrenciler where OgrenciId=@OgrenciId", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }

        }
        /*public bool OgrenciSil(Ogrenci ogr)
        {
            int id;
            SqlParameter[] p = {
                        new SqlParameter("@id",ogr.Ogrenciid),                      
                        };
            Helper hlp = new Helper();
            return hlp.ExecuteNonQuery("Delete from tblOgrenciler where OgrenciId=@id", p) > 0;
        }*/
        public Ogrenci OgrenciBul(string numara)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Numara", numara) };
                Helper hlp = Helper.Instance;
                var dr = hlp.ExecuteReader("Select OgrenciId,Ad,Soyad,Numara from tblOgrenciler where Numara=@Numara", p);
                Ogrenci ogr = null;
                if (dr.Read())
                {
                    ogr = new Ogrenci();
                    ogr.Ogrenciid = Convert.ToInt32(dr["OgrenciId"]);
                    ogr.Ad = dr["Ad"].ToString();
                    ogr.Soyad = dr["Soyad"].ToString();
                    ogr.Numara = dr["Numara"].ToString();
                }
                dr.Close();
                hlp.Dispose();
                return ogr;
            }
            catch (Exception)
            {
             
                throw;
            }
        }
    }
}
//n katmanlı mimari