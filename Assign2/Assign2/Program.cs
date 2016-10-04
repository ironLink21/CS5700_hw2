using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Common;

namespace Assign2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            StockPortfolio portfolio = new StockPortfolio();

            portfolio.Add("AAPL", new Stock() { });
            portfolio.Add("AMZN", new Stock() { });
            portfolio.Add("GOOGL", new Stock() { });
            portfolio.Add("MSFT", new Stock() { });


            Console.Write("Run the Exchange Simluator and enter it here: ");
            string response = Console.ReadLine();
            IPEndPoint simulatorEndPoint = EndPointParser.Parse(response);

            Communicator communicator = new Communicator() { Portfolio = portfolio, RemoteEndPoint = simulatorEndPoint };

            Console.WriteLine("To exit, type and key.  Starting...");

            communicator.Start();



            Console.ReadKey();
        }
    }
}
