using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace DataLayer
{
    public class student_d
    {

      //  databasecon con = new databasecon();
        public bool insert_studnet(string StudentId, string Name, string DOB,double Gpa,int Active)
        {
            bool value = false;
            
            try
            {

               
              //  string Sql = "INSERT INTO Registration VALUES ('" + StudentId + "','" + Name + "','" + DOB + "'," + Gpa + "," + Active + ")";


                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddStudent2";
                cmd.Parameters.Add("@studnetId", SqlDbType.VarChar).Value = StudentId;
                cmd.Parameters.Add("@name", SqlDbType.Char).Value = Name;
                cmd.Parameters.Add("@dob", SqlDbType.VarChar).Value = DOB;
                cmd.Parameters.Add("@gpa", SqlDbType.Decimal).Value = Gpa;
                cmd.Parameters.Add("@active", SqlDbType.TinyInt).Value = Active;
                connectioncls conne = new connectioncls();
                if (conne.insert(cmd) > 0)
                {
                    value = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return value;

        }
        public DataSet studentDetails()
        {
            DataSet ds = new DataSet();
            try
            {
                string sql = "SELECT * FROM Registration";
                connectioncls con = new connectioncls();
                ds = con.getRecord(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;


        }


    }
}
