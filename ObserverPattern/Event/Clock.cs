using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ObserverPattern.Event
{
    public class InfoEventArgs : EventArgs
    {
        public readonly string message;

        public InfoEventArgs(string message)
        {
            this.message = message;
        }
    }

    public class Clock
    {
        public delegate void TimeoutHandler(object clock, InfoEventArgs message);

        public event TimeoutHandler Timeout;

        public void Run(string message, int countDownSeconds)
        {
            Thread.Sleep(countDownSeconds * 1000);
            var args = new InfoEventArgs(message);
            if (Timeout != null)
            {
                Timeout(this, args);
            }
        }
    }
}
