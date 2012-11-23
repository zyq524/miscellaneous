using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern.Classic
{
    public class ObserverB : AbstractObserver
    {
        public override void Update(string message)
        {
            Console.WriteLine("ObserverB: " + message);
        }
    }
}
