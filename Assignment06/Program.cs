namespace Assignment06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date1 = new Date();
            date1.AcceptDate();
            date1.PrintDate();
            Console.WriteLine(date1.isValid());   
            Console.WriteLine("---------------");
            Date date2 = new Date();
            date2.AcceptDate();
            Console.WriteLine(date2.ToString());
            Console.WriteLine(date1.isValid());
            Console.WriteLine("---------------");
            int res = date2 - date1;
            Console.WriteLine("Difference Of Years " + res + " years");
            Console.WriteLine("---------------");
            Console.ReadLine();
        }

        public class Date {
            private int _Day;
            private int _Month;
            private int _Year;

            public int Year
            {
                get { return _Year; }
                set { _Year = value; }
            }

            public int Month
            {
                get { return _Month; }
                set { _Month = value; }
            }

            public int Day
            {
                get { return _Day; }
                set { _Day = value; }
            }

            public Date() { }

            public Date(int Day, int Month, int Year)
            {
                this._Day = Day;
                this._Month = Month;
                this._Year = Year;
            }

            public void AcceptDate()
            {
                Console.WriteLine("Enter the Day");
                this._Day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Month");
                this._Month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Year");
                this._Year = Convert.ToInt32(Console.ReadLine());
            }

            public void PrintDate()
            {
                Console.WriteLine("Day: " + this._Day + ", Month: " + this._Month + ", Year: " + this._Year);
            }

            public bool isValid()
            {
                if (this._Day < 32 && this._Day > 0)
                {
                    if (this._Month < 13 && this._Month > 0)
                        if (this._Year > 0)
                            return true;
                }
                return false;
            }
            public string ToString()
            {
                return "Day: " + this._Day + ", Month: " + this._Month + ", Year: " + this._Year;
            }

            public static int operator -(Date d1,Date d2)
            {
                return d1.Year - d2.Year; 
            }

        }

    }
}
