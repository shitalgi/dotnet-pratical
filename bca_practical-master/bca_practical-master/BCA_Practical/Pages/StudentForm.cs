using BCA_Practical.BusinessLayer;
using BCA_Practical.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCA_Practical.Pages
{
    public partial class StudentForm : Form
    {
        StudentService _ss;
        List<StudentInfo> students;
        public StudentForm()
        {
            InitializeComponent();
            _ss = new StudentService();
            students = new List<StudentInfo>();
            dgStudent.AutoGenerateColumns = false;
            
        }

        void LoadStudent()
        {
            string srchFirstName = txtFirstName.Text;
            students = _ss.GetAllStudent().Where(x => x.StatusID == 1).ToList();
            students = students.Where(x =>
                    string.IsNullOrEmpty(srchFirstName) || x.FirstName.Contains(srchFirstName)
                ).ToList();
            dgStudent.DataSource = students;
        }

        private void btnLoadStudent_Click(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            StudentAdd sa = new StudentAdd();
            sa.Show();
        }

        private void dgStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewButtonCell buttonCell = dgStudent.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                if (buttonCell != null)
                {
                    if (buttonCell.OwningColumn.HeaderText.ToLower() == "edit")
                    {
                        editStudent(e.RowIndex);
                    }
                    else if (buttonCell.OwningColumn.HeaderText.ToLower() == "delete")
                    {
                        deleteStudent(e.RowIndex);
                    }
                }
            }
        }


        private void editStudent(int roIndex)
        {
            StudentInfo toEdit = students[roIndex];
            StudentAdd sa = new StudentAdd(toEdit);
            sa.Show();
        }
        private void deleteStudent(int roIndex)
        {
            StudentInfo toEdit = students[roIndex];
            DataTable dtResult = _ss.DeleteStudent(toEdit.StudentID);
            if (dtResult != null && dtResult.Rows.Count > 0)
            {
                MessageBox.Show("Student Information Deleted Successfully");
                LoadStudent();
            }
        }
    }
}

//Create Table District(
//DistrictID int not null primary key identity(1,1),
//DistrictName varchar(50),
//DistrictCode varchar(50),
//ProvinceID int
//)

