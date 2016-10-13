using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    // worked with Everett Lenberg in writing this file
    public abstract class Subject
    {
        public readonly List<Observer> _subscribers = new List<Observer>();

        public Subject()
        {
        }

        public abstract void Notify();

        public void register(Observer observer)
        {
            _subscribers.Add(observer);
        }
        
        public void unregister(Observer observer)
        {
            _subscribers.Remove(observer);
        }
    }
}
