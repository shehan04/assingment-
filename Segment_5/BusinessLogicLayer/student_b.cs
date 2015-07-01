using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataLayer;

namespace BusinessLogicLayer
{
    public class student_b
    {

        private string studnetId {get; set;}
        private string name { get; set; }
        private string dob { get; set; }
        private double gpa { get; set; } 
        private int active {get; set;} 
      
        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }
        
       

        public string StudnetId
        {
            get { return studnetId; }
            set { studnetId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        



        public double Gpa
        {
            get { return gpa; }
            set { gpa = value; }
        }
       

        public int Active
        {
            get { return active; }
            set { active = value; }
        }

        public bool insertStudnetInfo()
        {
           
            bool value = false;
            try
            {
                //if (student.insert_studnet(studnetId,name,Dob,gpa,active))
                student_d student = new student_d();
                if (student.insert_studnet(studnetId,name,dob,gpa,active))
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
        public DataSet records()
        {
            DataSet ds = new DataSet();
            try
            {
                student_d stud = new student_d();
                ds = stud.studentDetails();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }




    }
}
