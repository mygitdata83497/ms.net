using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment08
{
    internal class Program
    {
        public static void Main(string[] args)
        {

        }
        enum DepartmentType
        {
            Sales,Executive,Devloper,Managment
        }

        public class Employee 
        {

            private static int _AutoGenerate=1;
            private int _Id;
            private double _Salary;
            private string _Designation;
            private enum _Dept;

            public enum Dept
            {
                get { return _Dept; }
                set { _Dept = DepartmentType; }
            }


            public string Designation
            {
                get { return _Designation; }
                set { _Designation = value; }
            }
            public double Salary
            {
                get { return _Salary; }
                set { _Salary = value; }
            }
            public int Id
            {
                get { return _Id; }
            }

        }

    }
}
