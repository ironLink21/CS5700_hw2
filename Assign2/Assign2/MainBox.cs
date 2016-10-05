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
    public partial class MainBox : Form
    {
        List<String> symbList { get; set; }
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
                // grabs file
                string fileName = fopen.FileName;

                // pass to csv reader - need to write my own

                // symbList = csv Reader output
                symbList = new List<string>();
                symbList.Add( "adc" );
                symbList.Add("def");
                symbList.Add("ghi");
                symbList.Add("jkl");
                loadBox = new CreatePortfolioView(symbList);
                loadBox.ShowDialog();
            }
            


        }

        private void MainBox_Load(object sender, EventArgs e)
        {

        }
    }
}
