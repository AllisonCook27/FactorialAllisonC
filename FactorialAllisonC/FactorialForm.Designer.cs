namespace FactorialAllisonC
{
    partial class frmFactorial
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblget = new System.Windows.Forms.Label();
            this.lblanswer = new System.Windows.Forms.Label();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUserNumber = new System.Windows.Forms.TextBox();
            this.lstIncrements = new System.Windows.Forms.ListBox();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(95, 85);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(69, 26);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblget
            // 
            this.lblget.AutoSize = true;
            this.lblget.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblget.Location = new System.Drawing.Point(22, 45);
            this.lblget.Name = "lblget";
            this.lblget.Size = new System.Drawing.Size(115, 19);
            this.lblget.TabIndex = 1;
            this.lblget.Text = "Enter a Number:";
            // 
            // lblanswer
            // 
            this.lblanswer.AutoSize = true;
            this.lblanswer.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanswer.Location = new System.Drawing.Point(109, 224);
            this.lblanswer.Name = "lblanswer";
            this.lblanswer.Size = new System.Drawing.Size(0, 19);
            this.lblanswer.TabIndex = 2;
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(283, 24);
            this.mnuMenu.TabIndex = 3;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(92, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // txtUserNumber
            // 
            this.txtUserNumber.Location = new System.Drawing.Point(162, 45);
            this.txtUserNumber.Name = "txtUserNumber";
            this.txtUserNumber.Size = new System.Drawing.Size(100, 20);
            this.txtUserNumber.TabIndex = 6;
            // 
            // lstIncrements
            // 
            this.lstIncrements.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstIncrements.FormattingEnabled = true;
            this.lstIncrements.Location = new System.Drawing.Point(72, 117);
            this.lstIncrements.Name = "lstIncrements";
            this.lstIncrements.Size = new System.Drawing.Size(120, 95);
            this.lstIncrements.TabIndex = 7;
            // 
            // frmFactorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(283, 261);
            this.Controls.Add(this.lstIncrements);
            this.Controls.Add(this.txtUserNumber);
            this.Controls.Add(this.lblanswer);
            this.Controls.Add(this.lblget);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.mnuMenu);
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "frmFactorial";
            this.Text = "Factorial by Allison C";
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblget;
        private System.Windows.Forms.Label lblanswer;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.TextBox txtUserNumber;
        private System.Windows.Forms.ListBox lstIncrements;
    }
}

