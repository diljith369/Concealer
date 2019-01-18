namespace ConcealerNew
{
    partial class ConcealerForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Normal Shell");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("In Line Shell");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Ms Build Shell");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("C# Reverse Shells", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Normal Shell");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("PS Reverse Shells", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Binary");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Your Shell", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConcealerForm));
            this.paneltrv = new System.Windows.Forms.Panel();
            this.trvSelect = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnconsole = new System.Windows.Forms.Button();
            this.btnshowfile = new System.Windows.Forms.Button();
            this.btngui = new System.Windows.Forms.Button();
            this.lblrhost = new System.Windows.Forms.Label();
            this.lblrport = new System.Windows.Forms.Label();
            this.txtrhost = new System.Windows.Forms.TextBox();
            this.txtrport = new System.Windows.Forms.TextBox();
            this.pnlbuttons = new System.Windows.Forms.Panel();
            this.rtxtshellcode = new System.Windows.Forms.RichTextBox();
            this.lblshellcode = new System.Windows.Forms.Label();
            this.pnlshellcode = new System.Windows.Forms.Panel();
            this.pnlforlblshellcode = new System.Windows.Forms.Panel();
            this.pnlfortxtrhost = new System.Windows.Forms.Panel();
            this.paneltrv.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlbuttons.SuspendLayout();
            this.pnlshellcode.SuspendLayout();
            this.pnlforlblshellcode.SuspendLayout();
            this.pnlfortxtrhost.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltrv
            // 
            this.paneltrv.Controls.Add(this.trvSelect);
            this.paneltrv.Controls.Add(this.panel1);
            this.paneltrv.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneltrv.Location = new System.Drawing.Point(0, 0);
            this.paneltrv.Name = "paneltrv";
            this.paneltrv.Size = new System.Drawing.Size(170, 520);
            this.paneltrv.TabIndex = 0;
            // 
            // trvSelect
            // 
            this.trvSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.trvSelect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trvSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvSelect.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.trvSelect.Location = new System.Drawing.Point(0, 47);
            this.trvSelect.Name = "trvSelect";
            treeNode1.Name = "trvItemNormal";
            treeNode1.Text = "Normal Shell";
            treeNode2.Name = "trvItemInLine";
            treeNode2.Text = "In Line Shell";
            treeNode3.Name = "trvItemMsbuild";
            treeNode3.Text = "Ms Build Shell";
            treeNode4.Name = "trvItemRevShells";
            treeNode4.Text = "C# Reverse Shells";
            treeNode5.Name = "trvitempsNormalRevShell";
            treeNode5.Text = "Normal Shell";
            treeNode6.Name = "psRevShell";
            treeNode6.Text = "PS Reverse Shells";
            treeNode7.Name = "trvItembinary";
            treeNode7.Text = "Binary";
            treeNode8.Name = "trvItemUrShell";
            treeNode8.Text = "Your Shell";
            this.trvSelect.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode6,
            treeNode8});
            this.trvSelect.Size = new System.Drawing.Size(170, 473);
            this.trvSelect.TabIndex = 2;
            this.trvSelect.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvSelect_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 47);
            this.panel1.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label.Location = new System.Drawing.Point(31, 5);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(135, 28);
            this.label.TabIndex = 1;
            this.label.Text = "Concealer";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(170, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 47);
            this.panel2.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClose.Location = new System.Drawing.Point(352, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnconsole
            // 
            this.btnconsole.FlatAppearance.BorderSize = 0;
            this.btnconsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsole.Image = ((System.Drawing.Image)(resources.GetObject("btnconsole.Image")));
            this.btnconsole.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnconsole.Location = new System.Drawing.Point(3, 3);
            this.btnconsole.Name = "btnconsole";
            this.btnconsole.Size = new System.Drawing.Size(91, 229);
            this.btnconsole.TabIndex = 2;
            this.btnconsole.Text = "Console";
            this.btnconsole.UseVisualStyleBackColor = true;
            this.btnconsole.Click += new System.EventHandler(this.btnconsole_Click);
            // 
            // btnshowfile
            // 
            this.btnshowfile.Enabled = false;
            this.btnshowfile.FlatAppearance.BorderSize = 0;
            this.btnshowfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshowfile.Image = ((System.Drawing.Image)(resources.GetObject("btnshowfile.Image")));
            this.btnshowfile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnshowfile.Location = new System.Drawing.Point(269, 3);
            this.btnshowfile.Name = "btnshowfile";
            this.btnshowfile.Size = new System.Drawing.Size(98, 229);
            this.btnshowfile.TabIndex = 3;
            this.btnshowfile.Text = "Show File";
            this.btnshowfile.UseVisualStyleBackColor = true;
            this.btnshowfile.Click += new System.EventHandler(this.btnshowfile_Click);
            // 
            // btngui
            // 
            this.btngui.FlatAppearance.BorderSize = 0;
            this.btngui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngui.Image = ((System.Drawing.Image)(resources.GetObject("btngui.Image")));
            this.btngui.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btngui.Location = new System.Drawing.Point(141, 2);
            this.btngui.Name = "btngui";
            this.btngui.Size = new System.Drawing.Size(92, 229);
            this.btngui.TabIndex = 4;
            this.btngui.Text = "GUI";
            this.btngui.UseVisualStyleBackColor = true;
            this.btngui.Click += new System.EventHandler(this.btngui_Click);
            // 
            // lblrhost
            // 
            this.lblrhost.AutoSize = true;
            this.lblrhost.Location = new System.Drawing.Point(3, 0);
            this.lblrhost.Name = "lblrhost";
            this.lblrhost.Size = new System.Drawing.Size(40, 16);
            this.lblrhost.TabIndex = 5;
            this.lblrhost.Text = "Rhost";
            // 
            // lblrport
            // 
            this.lblrport.AutoSize = true;
            this.lblrport.Location = new System.Drawing.Point(272, 0);
            this.lblrport.Name = "lblrport";
            this.lblrport.Size = new System.Drawing.Size(38, 16);
            this.lblrport.TabIndex = 6;
            this.lblrport.Text = "Rport";
            // 
            // txtrhost
            // 
            this.txtrhost.Location = new System.Drawing.Point(6, 23);
            this.txtrhost.Name = "txtrhost";
            this.txtrhost.Size = new System.Drawing.Size(251, 22);
            this.txtrhost.TabIndex = 7;
            this.txtrhost.Text = "127.0.0.1";
            // 
            // txtrport
            // 
            this.txtrport.Location = new System.Drawing.Point(275, 23);
            this.txtrport.Name = "txtrport";
            this.txtrport.Size = new System.Drawing.Size(85, 22);
            this.txtrport.TabIndex = 8;
            this.txtrport.Text = "443";
            // 
            // pnlbuttons
            // 
            this.pnlbuttons.Controls.Add(this.btnconsole);
            this.pnlbuttons.Controls.Add(this.btngui);
            this.pnlbuttons.Controls.Add(this.btnshowfile);
            this.pnlbuttons.Location = new System.Drawing.Point(183, 122);
            this.pnlbuttons.Name = "pnlbuttons";
            this.pnlbuttons.Size = new System.Drawing.Size(364, 134);
            this.pnlbuttons.TabIndex = 9;
            // 
            // rtxtshellcode
            // 
            this.rtxtshellcode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxtshellcode.Location = new System.Drawing.Point(0, -32);
            this.rtxtshellcode.Name = "rtxtshellcode";
            this.rtxtshellcode.Size = new System.Drawing.Size(356, 283);
            this.rtxtshellcode.TabIndex = 10;
            this.rtxtshellcode.Text = "";
            // 
            // lblshellcode
            // 
            this.lblshellcode.AutoSize = true;
            this.lblshellcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblshellcode.Location = new System.Drawing.Point(0, 0);
            this.lblshellcode.Name = "lblshellcode";
            this.lblshellcode.Size = new System.Drawing.Size(66, 16);
            this.lblshellcode.TabIndex = 11;
            this.lblshellcode.Text = "Shell code";
            // 
            // pnlshellcode
            // 
            this.pnlshellcode.Controls.Add(this.pnlforlblshellcode);
            this.pnlshellcode.Controls.Add(this.rtxtshellcode);
            this.pnlshellcode.Location = new System.Drawing.Point(184, 257);
            this.pnlshellcode.Name = "pnlshellcode";
            this.pnlshellcode.Size = new System.Drawing.Size(356, 251);
            this.pnlshellcode.TabIndex = 12;
            this.pnlshellcode.Visible = false;
            // 
            // pnlforlblshellcode
            // 
            this.pnlforlblshellcode.Controls.Add(this.lblshellcode);
            this.pnlforlblshellcode.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlforlblshellcode.Location = new System.Drawing.Point(0, 0);
            this.pnlforlblshellcode.Name = "pnlforlblshellcode";
            this.pnlforlblshellcode.Size = new System.Drawing.Size(356, 22);
            this.pnlforlblshellcode.TabIndex = 0;
            // 
            // pnlfortxtrhost
            // 
            this.pnlfortxtrhost.Controls.Add(this.lblrport);
            this.pnlfortxtrhost.Controls.Add(this.txtrhost);
            this.pnlfortxtrhost.Controls.Add(this.lblrhost);
            this.pnlfortxtrhost.Controls.Add(this.txtrport);
            this.pnlfortxtrhost.Location = new System.Drawing.Point(183, 58);
            this.pnlfortxtrhost.Name = "pnlfortxtrhost";
            this.pnlfortxtrhost.Size = new System.Drawing.Size(364, 58);
            this.pnlfortxtrhost.TabIndex = 13;
            // 
            // ConcealerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(564, 520);
            this.Controls.Add(this.pnlfortxtrhost);
            this.Controls.Add(this.pnlshellcode);
            this.Controls.Add(this.pnlbuttons);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.paneltrv);
            this.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConcealerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.paneltrv.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlbuttons.ResumeLayout(false);
            this.pnlshellcode.ResumeLayout(false);
            this.pnlforlblshellcode.ResumeLayout(false);
            this.pnlforlblshellcode.PerformLayout();
            this.pnlfortxtrhost.ResumeLayout(false);
            this.pnlfortxtrhost.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltrv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TreeView trvSelect;
        private System.Windows.Forms.Button btnconsole;
        private System.Windows.Forms.Button btnshowfile;
        private System.Windows.Forms.Button btngui;
        private System.Windows.Forms.Label lblrhost;
        private System.Windows.Forms.Label lblrport;
        private System.Windows.Forms.TextBox txtrhost;
        private System.Windows.Forms.TextBox txtrport;
        private System.Windows.Forms.Panel pnlbuttons;
        private System.Windows.Forms.RichTextBox rtxtshellcode;
        private System.Windows.Forms.Label lblshellcode;
        private System.Windows.Forms.Panel pnlshellcode;
        private System.Windows.Forms.Panel pnlforlblshellcode;
        private System.Windows.Forms.Panel pnlfortxtrhost;
    }
}

