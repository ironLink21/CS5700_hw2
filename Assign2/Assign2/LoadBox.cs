using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign2
{
    public partial class CreatePortfolioView : Form
    {
        public CreatePortfolioView(List<string> symbList)
        {
            InitializeComponent();

            StockListCombo.Items.Clear();

            foreach(String item in symbList)
            {
                StockListCombo.Items.Add(item);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(PortfolioListView.Items.Count == 0)
            {
                ColumnHeader col = new ColumnHeader("Stock");
                PortfolioListView.Columns.Add(col);
            }

            String symbol = StockListCombo.Text;
            if (!PortfolioListView.Items.ContainsKey(symbol))
            {
                PortfolioListView.Items.Add(symbol, symbol, 0);
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            for (int i = PortfolioListView.Items.Count - 1; i >= 0; i--)
            {
                if (PortfolioListView.Items[i].Checked)
                {
                    PortfolioListView.Items[i].Remove();
                }
            }
        }
    }
}
