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
            this.PortfolioListView = new System.Windows.Forms.ListView();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // PortfolioListView
            // 
            this.PortfolioListView.CheckBoxes = true;
            this.PortfolioListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.PortfolioListView.Location = new System.Drawing.Point(161, 41);
            this.PortfolioListView.Name = "PortfolioListView";
            this.PortfolioListView.Size = new System.Drawing.Size(293, 450);
            this.PortfolioListView.TabIndex = 2;
            this.PortfolioListView.UseCompatibleStateImageBehavior = false;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(243, 13);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(81, 23);
            this.RemoveBtn.TabIndex = 3;
            this.RemoveBtn.Text = "Remove Chk.";
            this.RemoveBtn.UseVisualStyleBackColor = true;
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
            // columnHeader1
            // 
            this.columnHeader1.Width = 293;
            // 
            // CreatePortfolioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 503);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.PortfolioListView);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.StockListCombo);
            this.Name = "CreatePortfolioView";
            this.Text = "Create Portfolio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox StockListCombo;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ListView PortfolioListView;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}