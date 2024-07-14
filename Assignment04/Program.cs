using static Assignment04.Program;

namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.AcceptDetails();
            Console.WriteLine(student.PrintDetails());
            
        }

        public class Student
        {
            private string _Name;
            private bool _Gender;
            private int _Age;
            private int _Std;
            private char _Div;
            private double _Marks;

            public Student() { }
            public Student(string name, bool gender, int age, int std, char div, double marks)
            {
                this._Name = name;
                this._Gender = gender;
                this._Age = age;
                this._Std = std;
                this._Div = div;
                this._Marks = marks;
            }

            public string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }
                                
            public bool Gender 
            { 
                get { return _Gender;}
                set { _Gender = value; }
            }
            public int Age 
            {
                get { return _Age;}
                set { _Age = value; }
            }
            public int Std 
            { 
                get { return _Std;}
                set { _Std = value; }
            }
            public char Div 
            { 
                get { return _Div;}
                set { _Div = value; }   
            }
            public  double Marks 
            {  
                get { return _Marks;}   
                set { _Marks = value; }    
            }

            public void AcceptDetails() 
            {
                Console.WriteLine("Enter Name");
                this._Name = Console.ReadLine();
                Console.WriteLine("Enter Gender");
                char g = Convert.ToChar(Console.ReadLine());
                if (g == 'M')
                    this._Gender = true;
                else if (g == 'F')
                    this._Gender = false;
                else
                    Console.WriteLine("Enter Valid Gender");
                Console.WriteLine("Enter Age");
                    this._Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Standard");
                    this._Std = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Division");
                    this._Div = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter Marks");
                    this._Marks = Convert.ToDouble(Console.ReadLine());
            }

            public string PrintDetails()
            {
                return "Name: " + this._Name + ", Gender: " + this._Gender + ", Age: " + this._Age + ", Standard: " + this._Std + ", Division: " + this._Div + ", Marks: " + this._Marks ;
            }
        }
    }
}
