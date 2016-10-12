using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Subject
    {
        /*private readonly object _myLock = new object();
        private readonly List<StockDecorator> _subscribers = new List<StockDecorator>();

        public List<StockDecorator> Subscribers { get { return _subscribers; } }

        public void Subscribe(StockDecorator observer)
        {
            lock (_myLock)
            {
                if (observer != null && !_subscribers.Contains(observer))
                    _subscribers.Add(observer);
            }
        }

        public void Unsubscribe(StockDecorator observer)
        {
            lock (_myLock)
            {
                if (_subscribers.Contains(observer))
                    _subscribers.Remove(observer);
            }
        }

        public void Notify()
        {
            lock (_myLock)
            {
                foreach (StockDecorator observer in _subscribers)
                    observer.Update(Clone());
            }
        }

        public virtual Subject Clone()
        {
            return MemberwiseClone() as Subject;
        }*/
    }
}
