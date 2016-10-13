using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    // worked with Everett Lenberg in writing this file
    public abstract class Context
    {
        public abstract object getContext();
    }

    public class ContextPortfolio : Context
    {
        public Dictionary<String, Stock> portfolio;

        public ContextPortfolio(Dictionary<String, Stock> portfolio)
        {
            this.portfolio = portfolio;
        }

        public override object getContext()
        {
            return null;
        }
    }

    public class ContextStock : Context
    {
        public Stock stock;

        public ContextStock(Stock stock)
        {
            this.stock = stock;
        }

        public override object getContext()
        {
            return null;
        }
    }
}
