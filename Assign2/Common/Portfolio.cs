using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    class Portfolio : Subject
    {
        public Dictionary<String, Stock> portfolio = new Dictionary<String, Stock>();

        public void Update(TickerMessage message)
        {
            if (message == null) return;

            if (portfolio.ContainsKey(message.Symbol))
            {
                portfolio[message.Symbol].Update(message);
            }

            Notify();
        }

        public override void Notify()
        {
            foreach (Observer observer in _subscribers)
            {
                observer.Update(new ContextPortfolio(portfolio));
            }
        }
    }
}
