﻿namespace TS_Post_Database_Inserter
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Launch = new System.Windows.Forms.Button();
            this.LpdfL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PHExcelL = new System.Windows.Forms.Label();
            this.PDFL = new System.Windows.Forms.Label();
            this.OpenMFol = new System.Windows.Forms.Button();
            this.MFol = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SetupMasFold = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenMDIRBTN = new System.Windows.Forms.Button();
            this.PDFNum = new System.Windows.Forms.Label();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Launch
            // 
            this.Launch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Launch.Location = new System.Drawing.Point(262, 254);
            this.Launch.Name = "Launch";
            this.Launch.Size = new System.Drawing.Size(75, 23);
            this.Launch.TabIndex = 2;
            this.Launch.Text = "Launch";
            this.Launch.UseVisualStyleBackColor = true;
            this.Launch.Click += new System.EventHandler(this.Launch_Click);
            // 
            // LpdfL
            // 
            this.LpdfL.AutoSize = true;
            this.LpdfL.Location = new System.Drawing.Point(13, 162);
            this.LpdfL.Name = "LpdfL";
            this.LpdfL.Size = new System.Drawing.Size(57, 13);
            this.LpdfL.TabIndex = 1;
            this.LpdfL.Text = "Label PDF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Settings";
            // 
            // PHExcelL
            // 
            this.PHExcelL.AutoSize = true;
            this.PHExcelL.Location = new System.Drawing.Point(13, 149);
            this.PHExcelL.Name = "PHExcelL";
            this.PHExcelL.Size = new System.Drawing.Size(62, 13);
            this.PHExcelL.TabIndex = 1;
            this.PHExcelL.Text = "Excel Label";
            // 
            // PDFL
            // 
            this.PDFL.AutoSize = true;
            this.PDFL.Location = new System.Drawing.Point(13, 175);
            this.PDFL.Name = "PDFL";
            this.PDFL.Size = new System.Drawing.Size(57, 13);
            this.PDFL.TabIndex = 1;
            this.PDFL.Text = "Label PDF";
            // 
            // OpenMFol
            // 
            this.OpenMFol.Location = new System.Drawing.Point(12, 110);
            this.OpenMFol.Name = "OpenMFol";
            this.OpenMFol.Size = new System.Drawing.Size(131, 23);
            this.OpenMFol.TabIndex = 0;
            this.OpenMFol.Text = "Select Master Folder";
            this.OpenMFol.UseVisualStyleBackColor = true;
            this.OpenMFol.Click += new System.EventHandler(this.OpenMFol_Click);
            // 
            // MFol
            // 
            this.MFol.AutoSize = true;
            this.MFol.Location = new System.Drawing.Point(13, 136);
            this.MFol.Name = "MFol";
            this.MFol.Size = new System.Drawing.Size(71, 13);
            this.MFol.TabIndex = 1;
            this.MFol.Text = "Master Folder";
            // 
            // SetupMasFold
            // 
            this.SetupMasFold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SetupMasFold.Location = new System.Drawing.Point(206, 13);
            this.SetupMasFold.Name = "SetupMasFold";
            this.SetupMasFold.Size = new System.Drawing.Size(131, 23);
            this.SetupMasFold.TabIndex = 0;
            this.SetupMasFold.Text = "Setup a Master Folder";
            this.SetupMasFold.UseVisualStyleBackColor = true;
            this.SetupMasFold.Click += new System.EventHandler(this.SetupMasFod_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CloseBtn.Location = new System.Drawing.Point(16, 254);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(73, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ONLY CLICK IF YOU UNDERSTAND ITS FUNCTION";
            // 
            // OpenMDIRBTN
            // 
            this.OpenMDIRBTN.Location = new System.Drawing.Point(12, 81);
            this.OpenMDIRBTN.Name = "OpenMDIRBTN";
            this.OpenMDIRBTN.Size = new System.Drawing.Size(131, 23);
            this.OpenMDIRBTN.TabIndex = 0;
            this.OpenMDIRBTN.Text = "Open Master Folder";
            this.OpenMDIRBTN.UseVisualStyleBackColor = true;
            this.OpenMDIRBTN.Click += new System.EventHandler(this.OpenMDIR_Click);
            // 
            // PDFNum
            // 
            this.PDFNum.AutoSize = true;
            this.PDFNum.Location = new System.Drawing.Point(13, 188);
            this.PDFNum.Name = "PDFNum";
            this.PDFNum.Size = new System.Drawing.Size(57, 13);
            this.PDFNum.TabIndex = 1;
            this.PDFNum.Text = "Label PDF";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(153, 110);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(82, 23);
            this.RefreshBtn.TabIndex = 0;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(349, 291);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.Launch);
            this.Controls.Add(this.PDFNum);
            this.Controls.Add(this.PDFL);
            this.Controls.Add(this.LpdfL);
            this.Controls.Add(this.PHExcelL);
            this.Controls.Add(this.MFol);
            this.Controls.Add(this.SetupMasFold);
            this.Controls.Add(this.OpenMDIRBTN);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.OpenMFol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TouchStone Frieght LTD - Delivery Order Edittor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Start_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label LpdfL;
        protected internal System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label PHExcelL;
        private System.Windows.Forms.Label PDFL;
        private System.Windows.Forms.Button OpenMFol;
        public System.Windows.Forms.Label MFol;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button SetupMasFold;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OpenMDIRBTN;
        private System.Windows.Forms.Label PDFNum;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button Launch;
    }
}

