namespace HangMan
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picHang = new System.Windows.Forms.PictureBox();
            this.gbWord = new System.Windows.Forms.GroupBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.btnRetry = new System.Windows.Forms.Button();
            this.lblCharWrong = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLtr = new System.Windows.Forms.TextBox();
            this.lblWordsCount = new System.Windows.Forms.Label();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.loadDictionaryuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hangManByGaryNgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWord = new System.Windows.Forms.Label();
            this.hintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHang)).BeginInit();
            this.gbWord.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picHang);
            this.groupBox1.Location = new System.Drawing.Point(410, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // picHang
            // 
            this.picHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHang.Location = new System.Drawing.Point(3, 18);
            this.picHang.Name = "picHang";
            this.picHang.Size = new System.Drawing.Size(149, 216);
            this.picHang.TabIndex = 3;
            this.picHang.TabStop = false;
            // 
            // gbWord
            // 
            this.gbWord.Controls.Add(this.lblCharWrong);
            this.gbWord.Controls.Add(this.lblLength);
            this.gbWord.Location = new System.Drawing.Point(14, 27);
            this.gbWord.Name = "gbWord";
            this.gbWord.Size = new System.Drawing.Size(390, 234);
            this.gbWord.TabIndex = 1;
            this.gbWord.TabStop = false;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.lblWord);
            this.gbStatus.Controls.Add(this.btnRetry);
            this.gbStatus.Controls.Add(this.lblStatus);
            this.gbStatus.Location = new System.Drawing.Point(605, 45);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(373, 232);
            this.gbStatus.TabIndex = 5;
            this.gbStatus.TabStop = false;
            this.gbStatus.Visible = false;
            // 
            // btnRetry
            // 
            this.btnRetry.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetry.Location = new System.Drawing.Point(121, 157);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(143, 59);
            this.btnRetry.TabIndex = 4;
            this.btnRetry.Text = "Retry";
            this.btnRetry.UseVisualStyleBackColor = true;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // lblCharWrong
            // 
            this.lblCharWrong.AutoSize = true;
            this.lblCharWrong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharWrong.Location = new System.Drawing.Point(6, 209);
            this.lblCharWrong.Name = "lblCharWrong";
            this.lblCharWrong.Size = new System.Drawing.Size(0, 17);
            this.lblCharWrong.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(378, 208);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "*.*\r\nYou Lose\r\n";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(284, 209);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(0, 13);
            this.lblLength.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLtr);
            this.groupBox3.Location = new System.Drawing.Point(14, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(548, 93);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // txtLtr
            // 
            this.txtLtr.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLtr.Location = new System.Drawing.Point(9, 14);
            this.txtLtr.MaxLength = 1;
            this.txtLtr.Multiline = true;
            this.txtLtr.Name = "txtLtr";
            this.txtLtr.Size = new System.Drawing.Size(533, 71);
            this.txtLtr.TabIndex = 2;
            this.txtLtr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLtr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLtr_KeyDown);
            this.txtLtr.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLtr_KeyUp);
            // 
            // lblWordsCount
            // 
            this.lblWordsCount.AutoSize = true;
            this.lblWordsCount.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordsCount.Location = new System.Drawing.Point(12, 372);
            this.lblWordsCount.Name = "lblWordsCount";
            this.lblWordsCount.Size = new System.Drawing.Size(0, 11);
            this.lblWordsCount.TabIndex = 4;
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDictionaryuToolStripMenuItem,
            this.hangManByGaryNgToolStripMenuItem,
            this.hintToolStripMenuItem});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(577, 24);
            this.mnuMenu.TabIndex = 5;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // loadDictionaryuToolStripMenuItem
            // 
            this.loadDictionaryuToolStripMenuItem.Name = "loadDictionaryuToolStripMenuItem";
            this.loadDictionaryuToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.loadDictionaryuToolStripMenuItem.Text = "Load Dictionary";
            this.loadDictionaryuToolStripMenuItem.Click += new System.EventHandler(this.loadDictionaryuToolStripMenuItem_Click);
            // 
            // hangManByGaryNgToolStripMenuItem
            // 
            this.hangManByGaryNgToolStripMenuItem.Name = "hangManByGaryNgToolStripMenuItem";
            this.hangManByGaryNgToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.hangManByGaryNgToolStripMenuItem.Text = "HangMan - By GaryNg";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(118, 130);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(74, 13);
            this.lblWord.TabIndex = 5;
            this.lblWord.Text = "The Word is: ";
            // 
            // hintToolStripMenuItem
            // 
            this.hintToolStripMenuItem.Name = "hintToolStripMenuItem";
            this.hintToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.hintToolStripMenuItem.Text = "&Hint!";
            this.hintToolStripMenuItem.Click += new System.EventHandler(this.hintToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 392);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.lblWordsCount);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbWord);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mnuMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMenu;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHang)).EndInit();
            this.gbWord.ResumeLayout(false);
            this.gbWord.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbWord;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtLtr;
        private System.Windows.Forms.Label lblWordsCount;
        private System.Windows.Forms.Label lblCharWrong;
        private System.Windows.Forms.PictureBox picHang;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem loadDictionaryuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hangManByGaryNgToolStripMenuItem;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.ToolStripMenuItem hintToolStripMenuItem;
    }
}

