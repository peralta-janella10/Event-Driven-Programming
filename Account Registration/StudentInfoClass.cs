using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Registration
{
    internal class StudentInfoClass
    {
        public delegate long DelegateNumber(long number);
        public delegate string DelegateText(string text);

        public static string FirstName;
        public static string LastName;
        public static string MiddleName;
        public static string Address;
        public static string Program;

        public static long Age;
        public static long ContactNo;
        public static long StudentNo;

       
        public static string GetFirstName(string text) => FirstName;
        public static string GetLastName(string text) => LastName;
        public static string GetMiddleName(string text) => MiddleName;
        public static string GetAddress(string text) => Address;
        public static string GetProgram(string text) => Program;

        public static long GetAge(long number) => Age;
        public static long GetContactNo(long number) => ContactNo;
        public static long GetStudentNo(long number) => StudentNo;
    }
}
