using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_Practical.Model
{
    public class StudentInfo
    {
        public int StudentID { get; set; }
        public string RegistrationNo { get; set; }
        public string Level { get; set; }
        public string Program { get; set; }
        public int Year { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string MobileNo { get; set; }
        public string PermanentAddress { get; set; }
        public string District { get; set; }
        public string Municipality { get; set; }
        public string WardNo { get; set; }
        public string Village { get; set; }
        public string MailingAddress { get; set; }
        public string MailingDistrict { get; set; }
        public string MailingMunicipality { get; set; }
        public string MailingWard { get; set; }
        public string MailingVillage { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirthAD { get; set; }
        public string DateOfBirthBS { get; set; }
        public DateTime CitizenshipIssueDate { get; set; }
        public string CitizenshipIssueDistrict { get; set; }
        public string CitizenshipNo { get; set; }
        public DateTime CitizenshipDate { get; set; }
        public string FatherName { get; set; }
        public string FatherMobileNo { get; set; }
        public string MotherName { get; set; }
        public string MotherMobileNo { get; set; }
        public string Note { get; set; }
        public string photoName { get; set; }

        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        public string VoucherNo { get; set; }
        public string VoucherPhotoName { get; set; }
        public string VoucherPhotoNo { get; set; }
        public Boolean IsAutoAdmit { get; set; }
        public int StatusID { get; set; }
    }
}
