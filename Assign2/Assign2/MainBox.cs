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
using System.Net;

namespace Assign2
{
    public partial class MainBox : Form
    {
        public List<Stock> stockList { get; set; }
        public StockPortfolio portfolio { get; set; }
        public CreatePortfolioView loadBox { get; set; }
        public AddPanel addPanel { get; set; }
        public IPAddress ip_address { get; set; }
        public int ip_port { get; set; }
        private Communicator communicator { get; set; }

        public MainBox()
        {
            InitializeComponent();
        }

        private void RefreshObserversListView()
        {

        }

        // button controls
        private void LoadBtn_Click(object sender, EventArgs e)
        {
            // open openfiledialog
            OpenFileDialog fopen = new OpenFileDialog();
            if (fopen.ShowDialog() == DialogResult.OK)
            {
                stockList = new List<Stock>();
                portfolio = new StockPortfolio();

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

        private void IPaddrBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.ip_address = IPAddress.Parse(IPaddrBox.Text);
            } catch(Exception ex)
            {
                Console.WriteLine("{0} exception caught.", ex);
            }
        }

        private void PortBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.ip_port = int.Parse(PortBox.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} exception caught.", ex);
            }
        }

        private void ctnButton_Click(object sender, EventArgs e)
        {
            communicator = new Communicator() { Portfolio = portfolio, RemoteEndPoint = new IPEndPoint(ip_address, ip_port) };
            communicator.Start();
        }

        private void disConnectBtn_Click(object sender, EventArgs e)
        {
            communicator.Stop();
        }
    }
}
