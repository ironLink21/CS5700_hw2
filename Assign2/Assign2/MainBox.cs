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
    public partial class MainBox : Form
    {
        List<String> symbList { get; set; }
        List<Stock> stockList { get; set; }
        public CreatePortfolioView loadBox { get; set; }


        public MainBox()
        {
            InitializeComponent();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {

            // open openfiledialog
            OpenFileDialog fopen = new OpenFileDialog();
            if (fopen.ShowDialog() == DialogResult.OK)
            {
                symbList = new List<string>();
                stockList = new List<Stock>();

                CSVreader reader = new CSVreader();
                stockList = reader.inputStream(fopen.FileName);

                foreach(Stock stock in stockList)
                {
                    symbList.Add(stock.symbol);
                }

                loadBox = new CreatePortfolioView(symbList);
                loadBox.ShowDialog();
            }
        }

        private void MainBox_Load(object sender, EventArgs e)
        {
        }
    }
}
