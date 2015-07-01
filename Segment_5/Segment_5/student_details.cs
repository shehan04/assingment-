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

namespace Segment_5
{
    public partial class student_details : Form
    {
        public student_details()
        {
            InitializeComponent();
            //gvStudent.Columns.Add("studentId", "Student Id");
            //gvStudent.Columns.Add("name", "Name");
            //gvStudent.Columns.Add("dob", "DOB");
            //gvStudent.Columns.Add("gpa", "GPA");
            //gvStudent.Columns.Add("active", "Active");
            //gvStudent.Columns.Add("copy", "copy");
            //gvStudent.Columns["copy"].Visible = false;
            try
            {
                DataSet ds = new DataSet();
                student_b stu = new student_b();
                ds = stu.records();

                DataTable dtAll = ds.Tables[0].Copy();
                for (var i = 1; i < ds.Tables.Count; i++)
                {
                    dtAll.Merge(ds.Tables[i]);
                }
                gvStudent.AutoGenerateColumns = true;
                gvStudent.DataSource = dtAll;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtAddnew_Click(object sender, EventArgs e)
        {
            Student_registration s = new Student_registration();
            s.Show();
        }

        private void txtSave_Click(object sender, EventArgs e)
        {

            student_b student = new student_b();

            for (int i = 0; i < gvStudent.Rows.Count; i++)
            {
                student.StudnetId =gvStudent.Rows[i].Cells[0].Value.ToString();
                student.Name = gvStudent.Rows[i].Cells[0].Value.ToString();
                student.Dob = gvStudent.Rows[i].Cells[0].Value.ToString();
                student.Gpa = Convert.ToDouble(gvStudent.Rows[i].Cells[0].Value.ToString());
                student.Active =Convert.ToInt32( gvStudent.Rows[i].Cells[0].Value.ToString());
                if (student.insertStudnetInfo())
                {
                   lbMsg.Text=i+"Record Inserted";
                }
            }
        }
        private void student_details_Load(object sender, EventArgs e)
        {
        
        }


             


        }
    }


