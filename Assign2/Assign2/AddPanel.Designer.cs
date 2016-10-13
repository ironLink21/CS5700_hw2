namespace Assign2
{
    partial class AddPanel
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
            this.CurrStocksCombo = new System.Windows.Forms.ComboBox();
            this.PanelTypePanel = new System.Windows.Forms.Panel();
            this.IndStockVolRadio = new System.Windows.Forms.RadioButton();
            this.StockPriceRadio = new System.Windows.Forms.RadioButton();
            this.PortfolioRadio = new System.Windows.Forms.RadioButton();
            this.PanelTypesLabel = new System.Windows.Forms.Label();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.HighPriceRadio = new System.Windows.Forms.RadioButton();
            this.LowPriceRadio = new System.Windows.Forms.RadioButton();
            this.PanelTypePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrStocksCombo
            // 
            this.CurrStocksCombo.FormattingEnabled = true;
            this.CurrStocksCombo.Location = new System.Drawing.Point(165, 12);
            this.CurrStocksCombo.Name = "CurrStocksCombo";
            this.CurrStocksCombo.Size = new System.Drawing.Size(121, 21);
            this.CurrStocksCombo.TabIndex = 0;
            this.CurrStocksCombo.Text = "Stocks";
            this.CurrStocksCombo.SelectedIndexChanged += new System.EventHandler(this.CurrStocksCombo_SelectedIndexChanged);
            // 
            // PanelTypePanel
            // 
            this.PanelTypePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelTypePanel.Controls.Add(this.IndStockVolRadio);
            this.PanelTypePanel.Controls.Add(this.StockPriceRadio);
            this.PanelTypePanel.Controls.Add(this.PortfolioRadio);
            this.PanelTypePanel.Controls.Add(this.PanelTypesLabel);
            this.PanelTypePanel.Location = new System.Drawing.Point(12, 12);
            this.PanelTypePanel.Name = "PanelTypePanel";
            this.PanelTypePanel.Size = new System.Drawing.Size(147, 91);
            this.PanelTypePanel.TabIndex = 1;
            // 
            // IndStockVolRadio
            // 
            this.IndStockVolRadio.AutoSize = true;
            this.IndStockVolRadio.Location = new System.Drawing.Point(6, 65);
            this.IndStockVolRadio.Name = "IndStockVolRadio";
            this.IndStockVolRadio.Size = new System.Drawing.Size(139, 17);
            this.IndStockVolRadio.TabIndex = 3;
            this.IndStockVolRadio.TabStop = true;
            this.IndStockVolRadio.Text = "Individual Stock Volume";
            this.IndStockVolRadio.UseVisualStyleBackColor = true;
            this.IndStockVolRadio.CheckedChanged += new System.EventHandler(this.IndStockVolRadio_CheckedChanged);
            // 
            // StockPriceRadio
            // 
            this.StockPriceRadio.AutoSize = true;
            this.StockPriceRadio.Location = new System.Drawing.Point(6, 42);
            this.StockPriceRadio.Name = "StockPriceRadio";
            this.StockPriceRadio.Size = new System.Drawing.Size(85, 17);
            this.StockPriceRadio.TabIndex = 2;
            this.StockPriceRadio.TabStop = true;
            this.StockPriceRadio.Text = "Stock Prices";
            this.StockPriceRadio.UseVisualStyleBackColor = true;
            this.StockPriceRadio.CheckedChanged += new System.EventHandler(this.StockPriceRadio_CheckedChanged);
            // 
            // PortfolioRadio
            // 
            this.PortfolioRadio.AutoSize = true;
            this.PortfolioRadio.Location = new System.Drawing.Point(6, 19);
            this.PortfolioRadio.Name = "PortfolioRadio";
            this.PortfolioRadio.Size = new System.Drawing.Size(63, 17);
            this.PortfolioRadio.TabIndex = 1;
            this.PortfolioRadio.TabStop = true;
            this.PortfolioRadio.Text = "Portfolio";
            this.PortfolioRadio.UseVisualStyleBackColor = true;
            this.PortfolioRadio.CheckedChanged += new System.EventHandler(this.PortfolioRadio_CheckedChanged);
            // 
            // PanelTypesLabel
            // 
            this.PanelTypesLabel.AutoSize = true;
            this.PanelTypesLabel.Location = new System.Drawing.Point(39, 3);
            this.PanelTypesLabel.Name = "PanelTypesLabel";
            this.PanelTypesLabel.Size = new System.Drawing.Size(66, 13);
            this.PanelTypesLabel.TabIndex = 0;
            this.PanelTypesLabel.Text = "Panel Types";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(293, 12);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateBtn.TabIndex = 2;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(293, 41);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // HighPriceRadio
            // 
            this.HighPriceRadio.AutoSize = true;
            this.HighPriceRadio.Location = new System.Drawing.Point(166, 39);
            this.HighPriceRadio.Name = "HighPriceRadio";
            this.HighPriceRadio.Size = new System.Drawing.Size(74, 17);
            this.HighPriceRadio.TabIndex = 4;
            this.HighPriceRadio.TabStop = true;
            this.HighPriceRadio.Text = "High Price";
            this.HighPriceRadio.UseVisualStyleBackColor = true;
            this.HighPriceRadio.CheckedChanged += new System.EventHandler(this.HighPriceRadio_CheckedChanged);
            // 
            // LowPriceRadio
            // 
            this.LowPriceRadio.AutoSize = true;
            this.LowPriceRadio.Location = new System.Drawing.Point(166, 62);
            this.LowPriceRadio.Name = "LowPriceRadio";
            this.LowPriceRadio.Size = new System.Drawing.Size(72, 17);
            this.LowPriceRadio.TabIndex = 5;
            this.LowPriceRadio.TabStop = true;
            this.LowPriceRadio.Text = "Low Price";
            this.LowPriceRadio.UseVisualStyleBackColor = true;
            this.LowPriceRadio.CheckedChanged += new System.EventHandler(this.LowPriceRadio_CheckedChanged);
            // 
            // AddPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 115);
            this.Controls.Add(this.LowPriceRadio);
            this.Controls.Add(this.HighPriceRadio);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.PanelTypePanel);
            this.Controls.Add(this.CurrStocksCombo);
            this.Name = "AddPanel";
            this.Text = "AddPanel";
            this.PanelTypePanel.ResumeLayout(false);
            this.PanelTypePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CurrStocksCombo;
        private System.Windows.Forms.Panel PanelTypePanel;
        private System.Windows.Forms.Label PanelTypesLabel;
        private System.Windows.Forms.RadioButton IndStockVolRadio;
        private System.Windows.Forms.RadioButton StockPriceRadio;
        private System.Windows.Forms.RadioButton PortfolioRadio;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.RadioButton HighPriceRadio;
        private System.Windows.Forms.RadioButton LowPriceRadio;
    }
}