namespace Assign2
{
    partial class CreatePortfolioView
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
            this.StockListCombo = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.PortfolioListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // StockListCombo
            // 
            this.StockListCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.StockListCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.StockListCombo.FormattingEnabled = true;
            this.StockListCombo.Location = new System.Drawing.Point(12, 12);
            this.StockListCombo.Name = "StockListCombo";
            this.StockListCombo.Size = new System.Drawing.Size(143, 21);
            this.StockListCombo.TabIndex = 0;
            this.StockListCombo.Text = "Stocks";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(161, 12);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Add Sym.";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(243, 13);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(81, 23);
            this.RemoveBtn.TabIndex = 3;
            this.RemoveBtn.Text = "Remove Chk.";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(331, 13);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateBtn.TabIndex = 4;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            // 
            // PortfolioListBox
            // 
            this.PortfolioListBox.FormattingEnabled = true;
            this.PortfolioListBox.Location = new System.Drawing.Point(161, 42);
            this.PortfolioListBox.Name = "PortfolioListBox";
            this.PortfolioListBox.Size = new System.Drawing.Size(245, 244);
            this.PortfolioListBox.TabIndex = 5;
            this.PortfolioListBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // CreatePortfolioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 301);
            this.Controls.Add(this.PortfolioListBox);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.StockListCombo);
            this.Name = "CreatePortfolioView";
            this.Text = "Create Portfolio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox StockListCombo;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.CheckedListBox PortfolioListBox;
    }
}