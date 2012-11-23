using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern.Event
{
    public class ObserverB
    {
        public void Subscribe(Clock clock)
        {
            clock.Timeout += TimeHasOut;
        }

        public void TimeHasOut(object clock, InfoEventArgs args)
        {
            Console.WriteLine("ObserverB: " + args.message);
        }
    }
}
