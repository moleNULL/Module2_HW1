namespace Module2_HW1
{
    public class Starter
    {
        public static void Run()
        {
            Actions actions = new Actions();

            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                int rnd = rand.Next(1, 4);
                Result? res = null;

                switch (rnd)
                {
                    case 1:
                        res = actions.InfoAction();
                        break;
                    case 2:
                        res = actions.WarningAction();
                        break;
                    case 3:
                        res = actions.ErrorAction();
                        break;
                    default:
                        throw new Exception("Incorrect random number. Must be within range 1..3");
                }

                if (res.Status == false)
                {
                    string? msg = $"{{{DateTime.Now}}}: {{{LoggerType.Error}}}:\t\t" +
                        $"{{Action failed by a reason: {res?.Error}}}\n";

                    Console.Write(msg);
                    actions.Logger += msg;
                }
            }

            string logFile = "log.txt";

            File.WriteAllText(logFile, actions.Logger);

            Console.WriteLine($"\n\n\t\t\t\tLog information has been written into {logFile}");
        }
    }
}
