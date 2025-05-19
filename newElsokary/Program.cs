namespace Elsokary
{
    public class Program
    {
        public static void Main(string[] args)
        {
           for (int i = 0; i < 5; i++)
            
            {
            Console.WriteLine("Enter a number day of the week:");
                int day=Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day number. Please enter a number between 1 and 7.");
                    break;
            }
            }
        }

        
    }
}