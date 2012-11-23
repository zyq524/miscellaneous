using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern.Classic
{
    public abstract class AbstractClock
    {
        private List<AbstractObserver> observers = new List<AbstractObserver>();

        public void Add(AbstractObserver observer)
        {
            if (observer == null)
            {
                throw new ArgumentNullException("observer");
            }
            this.observers.Add(observer);
        }

        public void Remove(AbstractObserver observer)
        {
            if (observer == null)
            {
                throw new ArgumentNullException("observer");
            }
            if (this.observers.Contains(observer))
            {
                this.observers.Remove(observer);
            }
        }

        public void Notify(string message)
        {
            foreach (var o in observers)
            {
                o.Update(message);
            }
        }
    }
}
