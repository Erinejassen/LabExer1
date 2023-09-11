using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountRegistration
{
    public delegate long DelegateNumber(long number);
    public delegate string DelegateText(string text);
    internal class StudentInfoClass
    {

        public static string Firstname;
        public static string Lastname;
        public static string Middlename;
        public static string Address;
        public static string Program;

        public static long Age = 0;
        public static long ContactNo = 0;
        public static long StudentNo = 0;

        public delegate string DelegateText(string text);
        public delegate long DelegateNumber(long number);

        public static string GetFirstName(string FirstName) {
            return FirstName;
        }

        public static string GetLastName(string LastName)
        {
            return LastName;
        }

        public static string GetMiddleName(string MiddleName)
        {
            return MiddleName;
        }

        public static string GetAddress(string Address)
        {
            return Address;
        }
        
        public static string GetProgram(string Program) 
        {
            return Program;
        }

        public static long GetAge(long Age) 
        {
            return Age;
        }

        public static long GetContactNo(long ContactNo)
        {
            return ContactNo;
        }

        public static long GetStudentNo(long StudentNo)
        {
            return StudentNo;
        }

    }
}
