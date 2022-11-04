namespace Module2_HW1
{
    public class Actions
    {
        private Logger _logger;

        public Actions()
        {
            _logger = Module2_HW1.Logger.Instance;
        }

        public string? Logger
        {
            get => _logger.Log;
            set => _logger.Log = value;
        }

        public Result InfoAction()
        {
            string? msg = $"{{{DateTime.Now}}}: {{{LoggerType.Info}}}:\t\t" +
                $"{{Start method: InfoAction}}\n";

            Console.Write(msg);
            _logger.Log += msg;

            return new Result { Status = true };
        }

        public Result WarningAction()
        {
            string? msg = $"{{{DateTime.Now}}}: {{{LoggerType.Warning}}}:\t" +
                $"{{Skipped logic in method: WarningAction}}\n";

            Console.Write(msg);
            _logger.Log += msg;

            return new Result { Status = true };
        }

        public Result ErrorAction()
        {
            return new Result { Status = false, Error = "I broke a logic" };
        }
    }
}
