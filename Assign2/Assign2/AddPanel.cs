using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace Assign2
{
    public partial class AddPanel : Form
    {
        public string currStock;
        public string priceType;
        int currPanel = 0;

        public AddPanel(Dictionary<String, Stock> stockList)
        {
            InitializeComponent();

            foreach(Stock stock in stockList.Values)
            {
                CurrStocksCombo.Items.Add(stock.symbol);
            }

            CreateBtn.Enabled = false;
            CurrStocksCombo.Enabled = false;
            HighPriceRadio.Enabled = false;
            LowPriceRadio.Enabled = false;
        }

        private void PortfolioRadio_CheckedChanged(object sender, EventArgs e)
        {
            CreateBtn.Enabled = true;
            CurrStocksCombo.Enabled = false;
            HighPriceRadio.Enabled = false;
            LowPriceRadio.Enabled = false;
        }

        private void StockPriceRadio_CheckedChanged(object sender, EventArgs e)
        {
            CurrStocksCombo.Enabled = true;
            CreateBtn.Enabled = false;
            HighPriceRadio.Enabled = true;
            LowPriceRadio.Enabled = true;
        }

        private void IndStockVolRadio_CheckedChanged(object sender, EventArgs e)
        {
            CurrStocksCombo.Enabled = true;
            CreateBtn.Enabled = false;
            HighPriceRadio.Enabled = true;
            LowPriceRadio.Enabled = true;
        }

        private void CurrStocksCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            currStock = CurrStocksCombo.Text;
        }

        private void HighPriceRadio_CheckedChanged(object sender, EventArgs e)
        {
            CreateBtn.Enabled = true;
            priceType = "high";
        }

        private void LowPriceRadio_CheckedChanged(object sender, EventArgs e)
        {
            CreateBtn.Enabled = true;
            priceType = "low";
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {

            // grab the stock's symbol(s) & grab from the portfolio list

            // create panel based upon the type of panel
            // choose type of decorator (open, closed)
            
            // stock.Subscribe(observer(panel))

            // creates the panel in order from 0 - 5, once there are 6 panels created it will
            // start over with the first pannel 
            if(currPanel == 6)
            {
                currPanel = 0;   
            }
            else
            {
                currPanel += 1;
            }

            // create new instance of panel, decorator
            if (PortfolioRadio.Checked)
            {
                // creates the PortfolioObserver
            } 
            else if(StockPriceRadio.Checked)
            {
                // creates the StockPriceObserver
            }
            else if(IndStockVolRadio.Checked)
            {
                // creates the StockVolumeObserver
            }

            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
