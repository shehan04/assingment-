using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataLayer;
namespace Segment_5
{
    public partial class Student_registration : Form
    {
        public Student_registration()
        {
            InitializeComponent();
            student_details s = new student_details();
       
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Student Id");
                dt.Columns.Add("Name");
                dt.Columns.Add("DOB");
                dt.Columns.Add("GPA");
                dt.Columns.Add("Active");
              //  dt.Columns.Add("copy");
                student_details s = new student_details();

                for (int i = 0; i < s.gvStudent.Rows.Count; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["Student Id"] = s.gvStudent.Rows[i].Cells[0].Value.ToString();
                    dr["Name"] = s.gvStudent.Rows[i].Cells[1].Value.ToString();
                    dr["DOB"] = s.gvStudent.Rows[i].Cells[2].Value.ToString();
                    dr["GPA"] = s.gvStudent.Rows[i].Cells[3].Value.ToString();
                    dr["Active"] = s.gvStudent.Rows[i].Cells[4].Value.ToString();
                    // dr["copy"] = s.gvStudent.Rows[i].Cells[5].Value.ToString();

                    dt.Rows.Add(dr);
                }



                DataRow dr1 = dt.NewRow();
                dr1["Student Id"] = txtStudentid.Text;
                dr1["Name"] = txtStudentname.Text;
                dr1["DOB"] = dtpDob.Text;
                dr1["GPA"] = txtGpa.Text;
                int value;
                if (cbActive.Checked)
                {
                    value = 1;
                }
                else
                {
                    value = 0;
                }

                dr1["Active"] = value;
              //  dr1["copy"] = "0";
                dt.Rows.Add(dr1);
                s.gvStudent.DataSource = dt;
  
              //  s.Show();
              //  s.gvStudent.Columns["copy"].Visible=false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
