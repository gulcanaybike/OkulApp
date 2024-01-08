using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace DAL
{
    public class Helper :IDisposable
    {     
        SqlConnection cn;
        SqlCommand cmd;
        string cstr = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;
        private bool disposedValue;


        private static Helper instance=null;
        public static Helper Instance
        {
            get 
            {
                if (instance != null)
                {
                    return instance;
                }
                else
                {
                    instance = new Helper();
                    return instance;
                }
            }
            set { instance = value; }
        }
        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p=null)
        {
            try
            {
                using (cn = new SqlConnection(cstr))
                {
                    using (cmd = new SqlCommand(cmdtext, cn))
                    {
                        if (p != null)
                        {
                            cmd.Parameters.AddRange(p);
                        }
                        cn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        public SqlDataReader ExecuteReader(string cmdtext, SqlParameter[] p = null)
        {
            try
            {
                cn = new SqlConnection(cstr);
                cmd = new SqlCommand(cmdtext, cn);
                if (p != null)
                {
                    cmd.Parameters.AddRange(p);
                }
                cn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    cn.Dispose();
                    cmd.Dispose();                 
                   
                }    
                disposedValue = true;
            }
        }

        ~Helper()
        {
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
