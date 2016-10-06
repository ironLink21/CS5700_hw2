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
            String symbol = StockListCombo.Text;
            if (!PortfolioListBox.Items.Contains(symbol))
            {
                PortfolioListBox.Items.Add(symbol);
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {

            foreach (var item in PortfolioListBox.CheckedItems.OfType<string>().ToList())
            {
                PortfolioListBox.Items.Remove(item);
            }
        }

        private void PortfolioListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
