namespace WeeklyUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Day: ");
            string day = Console.ReadLine().ToLower();

            switch(day)
            {
                case "monday":
                    Console.WriteLine("plan 1");
                    break;
                case "tuesday":
                    Console.WriteLine("plan 2");
                    break;
                case "wednesday":
                    Console.WriteLine("plan 3");
                    break;
                case "thursday":
                    Console.WriteLine("plan 4");
                    break;
                case "friday":
                    Console.WriteLine("plan 5");
                    break;
                case "saturday":
                    Console.WriteLine("weekend plan 1");
                    break;
                case "sunday":
                    Console.WriteLine("weekend plan 2");
                    break;
                default:
                    Console.WriteLine("error");
                    break;

            }

        }
    }
}