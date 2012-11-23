using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ObserverPattern.Classic
{
    public class Clock : AbstractClock
    {

        public void Run(string message, int countDownSeconds)
        {
            Thread.Sleep(countDownSeconds * 1000);
            this.Notify(message);
        }

    }
}
