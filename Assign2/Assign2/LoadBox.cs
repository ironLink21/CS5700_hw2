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
using System.IO;

namespace Assign2
{
    public partial class CreatePortfolioView : Form
    {
        public MainBox mainbox { get; set; }

        public CreatePortfolioView(List<Stock> stockList, MainBox mainbox)
        {
            InitializeComponent();

            StockListCombo.Items.Clear();

            this.mainbox = mainbox;
            foreach(Stock stock in stockList)
            {
                // creates the combo box
                StockListCombo.Items.Add(stock.symbol);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            String symbol = StockListCombo.Text;
            if (!PortfolioListBox.Items.Contains(symbol))
            {  
                // add selected symbol to the checkListBox
                PortfolioListBox.Items.Add(symbol);
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in PortfolioListBox.CheckedItems.OfType<string>().ToList())
            {
                // removes all checked items from the checkListBox
                PortfolioListBox.Items.Remove(item);
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            var csv = new StringBuilder();

            foreach (string symbol in PortfolioListBox.Items)
            {
                foreach (Stock stock in mainbox.stockList)
                {
                    if (symbol.Equals(stock.symbol))
                    {
                        try
                        {
                            mainbox.portfolio.Add(stock.symbol, stock);

                            // creating the csv files
                            var newLine = string.Format("{0},{1}", stock.symbol, stock.name);
                            csv.AppendLine(newLine);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("{0} exception caught.", ex);
                        }
                    }
                }
            }

            //TODO: write to a file in csv
            SaveFileDialog fout = new SaveFileDialog();
            if (fout.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(fout.FileName, csv.ToString());
            }

            this.Close();
        }
    }
}
