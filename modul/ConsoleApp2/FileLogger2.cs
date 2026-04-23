using System;
using System.IO;

namespace Task2
{
    public class FileLogger
    {
        private string _logFilePath;
        public FileLogger(string logFilePath)
        {
            _logFilePath = logFilePath;
        }
        public void OnMessageSent(string message)
        {
            string logEntry = $"[{DateTime.Now:HH:mm:ss}] {message}\n";
            File.AppendAllText(_logFilePath, logEntry);
        }
    }
}