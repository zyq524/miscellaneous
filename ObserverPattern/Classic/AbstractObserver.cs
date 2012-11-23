using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern.Classic
{
    public abstract class AbstractObserver
    {
        public abstract void Update(string message);
    }
}
