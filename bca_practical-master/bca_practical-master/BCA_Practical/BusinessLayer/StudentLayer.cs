using BCA_Practical.Helper;
using BCA_Practical.Model;
using BCA_Practicals;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_Practical.BusinessLayer
{
    public class StudentService
    {
        public List<StudentInfo> GetAllStudent()
        {
            var result = new List<StudentInfo>();

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StudentID","")
            };
            DataTable dt = DAO.GetTable(@"select * from students where(IsNull(@StudentID, '') = '' or StudentID = @StudentID)"
                                            , param
                                            , CommandType.Text);
            result = ClassToTable.ConvertDataTable<StudentInfo>(dt).ToList();
            return result;
        }
        public DataTable AddStudent(StudentInfo model)
        {
            string query = "";
            if (model.StudentID > 0)
            {
                query = @"update students set firstName = @firstName, middleName = @middleName, lastName = @lastName, gender=@gender,fatherName=@fatherName,motherName=@motherName where studentID = @studentID select id=@studentID, success = 1, message = 'update success'";
            }
            else // student id is 0
            {
                query = @"insert into students(FirstName,MiddleName,LastName,Gender,FatherName,MotherName,StatusID)
                        values (@firstName,@middleName,@lastName,@gender,@fatherName,@motherName,1) select id=@studentID, success = 1, message = 'insert success'";
            }
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                     new SqlParameter("@FirstName",model.FirstName),
                      new SqlParameter("@MiddleName",model.MiddleName),
                       new SqlParameter("@LastName",model.LastName),
                        new SqlParameter("@Gender",model.Gender),
                         new SqlParameter("@FatherName",model.FatherName),
                          new SqlParameter("@MotherName",model.MotherName),
                          new SqlParameter("@studentID",model.StudentID),
                };
                return DAO.GetTable(query, param, CommandType.Text);
            }
            catch
            {
                throw;
            }
        }

        public StudentInfo GetStudentByID(int id)
        {
            var result = new StudentInfo();

            SqlParameter[] param = new SqlParameter[]
            {
                // new SqlParameter("@dec",3),
                 new SqlParameter("@StudentID",id)
            };
            DataTable dt = DAO.GetTable(@"select * from students 
                                        where StudentID = @StudentID", param, CommandType.Text);
            result = ClassToTable.ConvertDataTable<StudentInfo>(dt).FirstOrDefault();
            return result;
        }

        public DataTable DeleteStudent(int stdID)
        {
            var result = new StudentInfo();

            SqlParameter[] param = new SqlParameter[]
            {
                 new SqlParameter("@StudentID",stdID)
            };
            return DAO.GetTable(@"update students
			set StatusID = 0 where StudentID = @StudentID
			select success = 0, message = 'Student Deleted Successfully'", param, CommandType.Text);
        }
    }
}
