namespace Module2_HW1
{
    public enum LoggerType
    {
        Error,
        Info,
        Warning
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Starter.Run();

            Console.ReadKey();
        }
    }
}