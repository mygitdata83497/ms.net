namespace Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice, x, y;
            double res;
            do
            {
                Console.WriteLine("Want To Continue Press y or Press n");
                if (Console.ReadLine() == "n")
                    break;
                Console.WriteLine("Enter the First Value");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Second Value");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Operation To be done on Values");
                Console.WriteLine("Press: 1 > Add, 2 > Sub, 3 > Mul, 4 > Div");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Thank You");
                        break;
                    case 1:
                        res = x + y;
                        Console.WriteLine("Result= " + res);
                        break;
                    case 2:
                        res = x - y;
                        Console.WriteLine("Result= " + res);
                        break;
                    case 3:
                        res = x * y;
                        Console.WriteLine("Result= " + res);
                        break;
                    case 4:
                        res = x / y;
                        Console.WriteLine("Result= " + res);
                        break;
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }
            } while (true);
        }
    }
}
