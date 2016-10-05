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
            this.PanelTypesLabel = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
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
            this.CurrStocksCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PanelTypePanel
            // 
            this.PanelTypePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelTypePanel.Controls.Add(this.radioButton3);
            this.PanelTypePanel.Controls.Add(this.radioButton2);
            this.PanelTypePanel.Controls.Add(this.radioButton1);
            this.PanelTypePanel.Controls.Add(this.PanelTypesLabel);
            this.PanelTypePanel.Location = new System.Drawing.Point(12, 12);
            this.PanelTypePanel.Name = "PanelTypePanel";
            this.PanelTypePanel.Size = new System.Drawing.Size(147, 91);
            this.PanelTypePanel.TabIndex = 1;
            // 
            // PanelTypesLabel
            // 
            this.PanelTypesLabel.AutoSize = true;
            this.PanelTypesLabel.Location = new System.Drawing.Point(39, 3);
            this.PanelTypesLabel.Name = "PanelTypesLabel";
            this.PanelTypesLabel.Size = new System.Drawing.Size(66, 13);
            this.PanelTypesLabel.TabIndex = 0;
            this.PanelTypesLabel.Text = "Panel Types";
            this.PanelTypesLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Portfolio";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Stock Prices";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(139, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Individual Stock Volume";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(293, 12);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateBtn.TabIndex = 2;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(293, 41);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // AddPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 115);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.PanelTypePanel);
            this.Controls.Add(this.CurrStocksCombo);
            this.Name = "AddPanel";
            this.Text = "AddPanel";
            this.PanelTypePanel.ResumeLayout(false);
            this.PanelTypePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CurrStocksCombo;
        private System.Windows.Forms.Panel PanelTypePanel;
        private System.Windows.Forms.Label PanelTypesLabel;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}