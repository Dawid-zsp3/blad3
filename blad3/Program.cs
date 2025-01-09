public class LogicalOperators
{
    public static void Main(string[] args)
    {
        int x = 10;
        int y = 20;
        if (x > 5 || y < 15 && x < 30)
        {
            Console.WriteLine("Warunek spelniony ");
        }
        else
        {
            Console.WriteLine("Warunek niespelniony");
        }
    }
}