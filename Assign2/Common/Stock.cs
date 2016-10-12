using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Stock : Subject
    {
        public string symbol { get; set; }
        public string name { get; set; }

        public virtual string openingP { get; set; }
        public virtual string closingP { get; set; }
        public virtual string currP { get; set; }
        public virtual string bidP { get; set; }
        public virtual string askP { get; set; }
        public virtual string volSold { get; set; }
        public virtual string avg10 { get; set; }

        // TODO: Design and implement the properties and behaviors of this class.
        public Stock()
        {
        }

        public Stock (string symbol1, string name1)
        {
            symbol = symbol1;
            name = name1;
        }

        //public Stock(string symbol1, string name1, string openingP1, string closingP1, string currP1, string bidP1, string askP1, string volSold1, string avg101)
        //{
        //    symbol = symbol1;
        //    name = name1;
        //
        //    openingP = openingP1;
        //    closingP = closingP1;
        //    currP = currP1;
        //    bidP = bidP1;
        //    askP = askP1;
        //    volSold = volSold1;
        //    avg10 = avg101;
        //}

        public void Update(TickerMessage message)
        {
            // TODO: Update the state of the stock object

            // For the moment, we'll have it simply write the new stock info to the console.  This code needs to be remove.
            // The observers will be responsible to presenting stock information to the user

            Console.WriteLine($"{message.Symbol}\tprice={message.CurrentPrice}\tvolumn={message.CurrentVolume}");
        }
    }
}
