using BCA_Practical.BusinessLayer;
using BCA_Practical.Model;
using BCA_Practical.Model.Enum;
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
    public partial class StudentAdd : Form
    {
        StudentService ss;
        StudentInfo _toEdit;
        public StudentAdd()
        {
            InitializeComponent();
            ss = new StudentService();
            _toEdit = new StudentInfo();
            loadGenderDropDown();
        }

        public StudentAdd(StudentInfo toEdit)
        {
            InitializeComponent();
            ss = new StudentService();
            _toEdit = toEdit;
            loadGenderDropDown();
            FillPreviousForm();
        }

        private void loadGenderDropDown()
        {
            var genders = Enum.GetValues(typeof(Gender));
            ddlGender.DisplayMember = "Key";
            ddlGender.ValueMember = "Value";

            var keys = new List<KeyValue>();
            foreach (var item in genders)
            {
                keys.Add(new KeyValue()
                {
                    Key = item.ToString(),
                    Value = ((int)item).ToString()
                });
            }
            ddlGender.DataSource = keys;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StudentInfo si = new StudentInfo()
            {
                StudentID = _toEdit.StudentID,
                FirstName = txtFirstName.Text,
                MiddleName = txtMiddleName.Text,
                LastName = txtLastName.Text,
                FatherName = txtFatherName.Text,
                MotherName = txtMotherName.Text,
                Gender = ddlGender.SelectedValue.ToString()
            };

            if (string.IsNullOrEmpty(si.FirstName))
            {
                MessageBox.Show("Enter First Name");
            }
            else if (string.IsNullOrEmpty(si.LastName))
            {
                MessageBox.Show("Enter Last Name");
            }
            else
            {
                DataTable dt = ss.AddStudent(si);
                if (dt != null && dt.Rows.Count > 0)
                {
                    MessageBox.Show("Student "
                                        + (_toEdit.StudentID > 0 ? "Update" : "Add")
                                        + " Success!");
                }
                else
                {
                    MessageBox.Show("Student Add Failed!");
                }
            }
        }

        void FillPreviousForm()
        {
            txtFirstName.Text = _toEdit.FirstName;
            txtMiddleName.Text = _toEdit.MiddleName;
            txtLastName.Text = _toEdit.LastName;
            txtFatherName.Text = _toEdit.FatherName;
            txtMotherName.Text = _toEdit.MotherName;
            ddlGender.SelectedValue = _toEdit.Gender;
        }
        void ClearForm()
        {
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            txtFatherName.Text = "";
            txtMotherName.Text = "";
            ddlGender.SelectedValue = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
