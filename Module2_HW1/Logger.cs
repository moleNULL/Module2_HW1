namespace Module2_HW1
{
    public enum LoggerType
    {
        Error,
        Info,
        Warning
    }

    // Singleton
    public class Logger
    {
        private static Logger? _instance = null;

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }

                return _instance;
            }
        }

        public string? Log { get; set; }
    }
}
