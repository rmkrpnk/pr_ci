using System;

namespace practice1
{
    public class Logger
    {
        public Action<string> LogHandler;

        public void Log(string message)
        {
            if (LogHandler != null)
            {
                LogHandler(message);
            }
        }
    }
}