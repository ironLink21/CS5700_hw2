using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Stock
    {
        // TODO: Design and implement the properties and behaviors of this class.

        public void Update(TickerMessage message)
        {
            // TODO: Update the state of the stock object

            // For the moment, we'll have it simply write the new stock info to the console.  This code needs to be remove.
            // The observers will be responsible to presenting stock information to the user

            Console.WriteLine($"{message.Symbol}\tprice={message.CurrentPrice}\tvolumn={message.CurrentVolume}");
        }
    }
}
