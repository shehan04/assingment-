using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace DataLayer
{
    public class connectioncls
    {
        private string connectionString = "Data Source=DELL-PC;Initial Catalog=StudentRegistrationDB;Integrated Security=True";
        public int insert(SqlCommand com)
        {
            int x;

           
            try
            {
                SqlConnection dbcon = new SqlConnection(connectionString);
                dbcon.Open();
                com.Connection = dbcon;

                x = com.ExecuteNonQuery();

                dbcon.Close();
                return x;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataSet getRecord(string sql)
        {

            DataSet ds = new DataSet();
            try
            {
                SqlConnection dbcon = new SqlConnection(connectionString);
                dbcon.Open();
                SqlDataAdapter ad = new SqlDataAdapter(sql,dbcon);
                ad.Fill(ds);
                dbcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;

        }

    }
}
