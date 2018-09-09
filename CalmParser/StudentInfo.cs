using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VipassanaParser
{
    class StudentInfo
    {
        public string FamilyName { get; set; }
        public string GivenName { get; set; }
        public enum Gender { M, F };
        public enum StSrv { SIT, SV };
        public enum FTPT { FT, PT };
        public enum ONS { O, N };
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string Age { get; set; }

        public string[] GetStudentInfo()
        {
            return new string[] { "Family Name", "Given Name", "FTPT", "Phone", "Mobile", "Email", "Date of Birth", "Age" };
        }

        public string[] GetStudentType()
        {
            return new string[] { "old", "new", "service" };
        }

        public string[] GetStudentGender()
        {
            return new string[] { "Male", "Famale" };
        }
    }


}
