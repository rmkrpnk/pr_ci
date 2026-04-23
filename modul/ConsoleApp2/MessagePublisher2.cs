using System;

namespace Task2
{
    public class MessagePublisher
    {
        public delegate void MessageSentEventHandler(string message);

        public event MessageSentEventHandler MessageSent;
        public void Send(string message)
        {
            MessageSent?.Invoke(message);
        }
    }
}