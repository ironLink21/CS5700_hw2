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
        string currStock;

        public AddPanel(List<Stock> stockList)
        {
            InitializeComponent();

            foreach(Stock stock in stockList)
            {
                CurrStocksCombo.Items.Add(stock.symbol);
            }

            CreateBtn.Enabled = false;
            CurrStocksCombo.Enabled = false;
        }

        private void PortfolioRadio_CheckedChanged(object sender, EventArgs e)
        {
            CreateBtn.Enabled = true;
            CurrStocksCombo.Enabled = false;
        }

        private void StockPriceRadio_CheckedChanged(object sender, EventArgs e)
        {
            CurrStocksCombo.Enabled = true;
            CreateBtn.Enabled = false;
        }

        private void IndStockVolRadio_CheckedChanged(object sender, EventArgs e)
        {
            CurrStocksCombo.Enabled = true;
            CreateBtn.Enabled = false;
        }

        private void CurrStocksCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateBtn.Enabled = true;
            currStock = CurrStocksCombo.Text;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            // create new instance of panel, decorator

            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
