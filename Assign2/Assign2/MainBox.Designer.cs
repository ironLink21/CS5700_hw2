namespace Assign2
{
    partial class MainBox
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel0 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.AddPanelBtn = new System.Windows.Forms.Button();
            this.IPaddrBox = new System.Windows.Forms.TextBox();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.ctnButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.disConnectBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel.Controls.Add(this.panel0);
            this.flowLayoutPanel.Controls.Add(this.panel1);
            this.flowLayoutPanel.Controls.Add(this.panel2);
            this.flowLayoutPanel.Controls.Add(this.panel3);
            this.flowLayoutPanel.Controls.Add(this.panel4);
            this.flowLayoutPanel.Controls.Add(this.panel5);
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 41);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(620, 341);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // panel0
            // 
            this.panel0.Location = new System.Drawing.Point(3, 3);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(200, 163);
            this.panel0.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(209, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 163);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(415, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 163);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 163);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(209, 172);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 163);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(415, 172);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 163);
            this.panel5.TabIndex = 2;
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(12, 12);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(92, 23);
            this.LoadBtn.TabIndex = 1;
            this.LoadBtn.Text = "Load Portfolio";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // AddPanelBtn
            // 
            this.AddPanelBtn.Location = new System.Drawing.Point(110, 12);
            this.AddPanelBtn.Name = "AddPanelBtn";
            this.AddPanelBtn.Size = new System.Drawing.Size(75, 23);
            this.AddPanelBtn.TabIndex = 3;
            this.AddPanelBtn.Text = "Add Panel";
            this.AddPanelBtn.UseVisualStyleBackColor = true;
            this.AddPanelBtn.Click += new System.EventHandler(this.AddPanelBtn_Click);
            // 
            // IPaddrBox
            // 
            this.IPaddrBox.Location = new System.Drawing.Point(305, 14);
            this.IPaddrBox.Name = "IPaddrBox";
            this.IPaddrBox.Size = new System.Drawing.Size(100, 20);
            this.IPaddrBox.TabIndex = 4;
            this.IPaddrBox.TextChanged += new System.EventHandler(this.IPaddrBox_TextChanged);
            // 
            // PortBox
            // 
            this.PortBox.Location = new System.Drawing.Point(411, 14);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(59, 20);
            this.PortBox.TabIndex = 5;
            this.PortBox.TextChanged += new System.EventHandler(this.PortBox_TextChanged);
            // 
            // ctnButton
            // 
            this.ctnButton.Location = new System.Drawing.Point(476, 12);
            this.ctnButton.Name = "ctnButton";
            this.ctnButton.Size = new System.Drawing.Size(75, 23);
            this.ctnButton.TabIndex = 6;
            this.ctnButton.Text = "Connect";
            this.ctnButton.UseVisualStyleBackColor = true;
            this.ctnButton.Click += new System.EventHandler(this.ctnButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port";
            // 
            // disConnectBtn
            // 
            this.disConnectBtn.Location = new System.Drawing.Point(557, 12);
            this.disConnectBtn.Name = "disConnectBtn";
            this.disConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.disConnectBtn.TabIndex = 9;
            this.disConnectBtn.Text = "DisConnect";
            this.disConnectBtn.UseVisualStyleBackColor = true;
            this.disConnectBtn.Click += new System.EventHandler(this.disConnectBtn_Click);
            // 
            // MainBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 392);
            this.Controls.Add(this.disConnectBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctnButton);
            this.Controls.Add(this.PortBox);
            this.Controls.Add(this.IPaddrBox);
            this.Controls.Add(this.AddPanelBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "MainBox";
            this.Text = "StockPortfolio";
            this.Load += new System.EventHandler(this.MainBox_Load);
            this.flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button AddPanelBtn;
        private System.Windows.Forms.Panel panel0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox IPaddrBox;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.Button ctnButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button disConnectBtn;
    }
}

