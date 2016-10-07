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
        public List<Stock> stockList { get; set; }
        public List<Stock> portfolio { get; set; }
        public CreatePortfolioView loadBox { get; set; }
        public AddPanel addPanel { get; set; }

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
                stockList = new List<Stock>();
                portfolio = new List<Stock>();

                CSVfileHandler reader = new CSVfileHandler();
                stockList = reader.inputStream(fopen.FileName);

                loadBox = new CreatePortfolioView(stockList, this);
                loadBox.ShowDialog();
            }
        }

        private void AddPanelBtn_Click(object sender, EventArgs e)
        {
            addPanel = new AddPanel(portfolio);
            addPanel.ShowDialog();
        }

        private void MainBox_Load(object sender, EventArgs e)
        {
        }

        
    }
}
