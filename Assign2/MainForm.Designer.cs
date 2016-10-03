namespace Assign2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.symbolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualStockPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualStockVolumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.symbolsToolStripMenuItem,
            this.panelsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // symbolsToolStripMenuItem
            // 
            this.symbolsToolStripMenuItem.Name = "symbolsToolStripMenuItem";
            this.symbolsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.symbolsToolStripMenuItem.Text = "Symbols";
            // 
            // panelsToolStripMenuItem
            // 
            this.panelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockPriceToolStripMenuItem,
            this.individualStockPriceToolStripMenuItem,
            this.individualStockVolumeToolStripMenuItem});
            this.panelsToolStripMenuItem.Name = "panelsToolStripMenuItem";
            this.panelsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.panelsToolStripMenuItem.Text = "Panels";
            // 
            // stockPriceToolStripMenuItem
            // 
            this.stockPriceToolStripMenuItem.Name = "stockPriceToolStripMenuItem";
            this.stockPriceToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.stockPriceToolStripMenuItem.Text = "Portfolio Stock Price";
            this.stockPriceToolStripMenuItem.Click += new System.EventHandler(this.stockPriceToolStripMenuItem_Click);
            // 
            // individualStockPriceToolStripMenuItem
            // 
            this.individualStockPriceToolStripMenuItem.Name = "individualStockPriceToolStripMenuItem";
            this.individualStockPriceToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.individualStockPriceToolStripMenuItem.Text = "Individual Stock Price";
            // 
            // individualStockVolumeToolStripMenuItem
            // 
            this.individualStockVolumeToolStripMenuItem.Name = "individualStockVolumeToolStripMenuItem";
            this.individualStockVolumeToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.individualStockVolumeToolStripMenuItem.Text = "Individual Stock Volume";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(728, 540);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 567);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem symbolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualStockPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualStockVolumeToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

