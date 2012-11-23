using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ObserverPattern.Classic
{
    public class Clock : AbstractClock
    {
        private readonly string message;
        private readonly int countDownSeconds;

        public Clock(string message, int countDownSeconds)
        {
            this.message = message;
            this.countDownSeconds = countDownSeconds;
        }

        public void Alert()
        {
            Thread.Sleep(countDownSeconds * 1000);
            this.Notify(message);
        }

    }
}
