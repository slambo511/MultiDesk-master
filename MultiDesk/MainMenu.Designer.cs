namespace MultiDesk
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxNumberOfDesktops = new System.Windows.Forms.GroupBox();
            this.rbEight = new System.Windows.Forms.RadioButton();
            this.rbSeven = new System.Windows.Forms.RadioButton();
            this.rbSix = new System.Windows.Forms.RadioButton();
            this.rbFive = new System.Windows.Forms.RadioButton();
            this.rbFour = new System.Windows.Forms.RadioButton();
            this.rbThree = new System.Windows.Forms.RadioButton();
            this.rbTwo = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbxNumberOfDesktops.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(215, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactUsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.contactUsToolStripMenuItem.Text = "&Contact Us";
            // 
            // gbxNumberOfDesktops
            // 
            this.gbxNumberOfDesktops.Controls.Add(this.rbEight);
            this.gbxNumberOfDesktops.Controls.Add(this.rbSeven);
            this.gbxNumberOfDesktops.Controls.Add(this.rbSix);
            this.gbxNumberOfDesktops.Controls.Add(this.rbFive);
            this.gbxNumberOfDesktops.Controls.Add(this.rbFour);
            this.gbxNumberOfDesktops.Controls.Add(this.rbThree);
            this.gbxNumberOfDesktops.Controls.Add(this.rbTwo);
            this.gbxNumberOfDesktops.Location = new System.Drawing.Point(23, 44);
            this.gbxNumberOfDesktops.Name = "gbxNumberOfDesktops";
            this.gbxNumberOfDesktops.Size = new System.Drawing.Size(167, 181);
            this.gbxNumberOfDesktops.TabIndex = 1;
            this.gbxNumberOfDesktops.TabStop = false;
            this.gbxNumberOfDesktops.Text = "Number of desktops";
            // 
            // rbEight
            // 
            this.rbEight.AutoSize = true;
            this.rbEight.Location = new System.Drawing.Point(18, 157);
            this.rbEight.Name = "rbEight";
            this.rbEight.Size = new System.Drawing.Size(49, 17);
            this.rbEight.TabIndex = 7;
            this.rbEight.Text = "Eight";
            this.rbEight.UseVisualStyleBackColor = true;
            this.rbEight.CheckedChanged += new System.EventHandler(this.rbEight_CheckedChanged);
            // 
            // rbSeven
            // 
            this.rbSeven.AutoSize = true;
            this.rbSeven.Location = new System.Drawing.Point(18, 134);
            this.rbSeven.Name = "rbSeven";
            this.rbSeven.Size = new System.Drawing.Size(56, 17);
            this.rbSeven.TabIndex = 6;
            this.rbSeven.Text = "Seven";
            this.rbSeven.UseVisualStyleBackColor = true;
            this.rbSeven.CheckedChanged += new System.EventHandler(this.rbSeven_CheckedChanged);
            // 
            // rbSix
            // 
            this.rbSix.AutoSize = true;
            this.rbSix.Checked = true;
            this.rbSix.Location = new System.Drawing.Point(18, 111);
            this.rbSix.Name = "rbSix";
            this.rbSix.Size = new System.Drawing.Size(39, 17);
            this.rbSix.TabIndex = 5;
            this.rbSix.TabStop = true;
            this.rbSix.Text = "Six";
            this.rbSix.UseVisualStyleBackColor = true;
            this.rbSix.CheckedChanged += new System.EventHandler(this.rbSix_CheckedChanged);
            // 
            // rbFive
            // 
            this.rbFive.AutoSize = true;
            this.rbFive.Location = new System.Drawing.Point(18, 88);
            this.rbFive.Name = "rbFive";
            this.rbFive.Size = new System.Drawing.Size(45, 17);
            this.rbFive.TabIndex = 4;
            this.rbFive.Text = "Five";
            this.rbFive.UseVisualStyleBackColor = true;
            this.rbFive.CheckedChanged += new System.EventHandler(this.rbFive_CheckedChanged);
            // 
            // rbFour
            // 
            this.rbFour.AutoSize = true;
            this.rbFour.Location = new System.Drawing.Point(18, 65);
            this.rbFour.Name = "rbFour";
            this.rbFour.Size = new System.Drawing.Size(46, 17);
            this.rbFour.TabIndex = 3;
            this.rbFour.Text = "Four";
            this.rbFour.UseVisualStyleBackColor = true;
            this.rbFour.CheckedChanged += new System.EventHandler(this.rbFour_CheckedChanged);
            // 
            // rbThree
            // 
            this.rbThree.AutoSize = true;
            this.rbThree.Location = new System.Drawing.Point(18, 42);
            this.rbThree.Name = "rbThree";
            this.rbThree.Size = new System.Drawing.Size(53, 17);
            this.rbThree.TabIndex = 2;
            this.rbThree.Text = "Three";
            this.rbThree.UseVisualStyleBackColor = true;
            this.rbThree.CheckedChanged += new System.EventHandler(this.rbThree_CheckedChanged);
            // 
            // rbTwo
            // 
            this.rbTwo.AutoSize = true;
            this.rbTwo.Location = new System.Drawing.Point(18, 19);
            this.rbTwo.Name = "rbTwo";
            this.rbTwo.Size = new System.Drawing.Size(46, 17);
            this.rbTwo.TabIndex = 1;
            this.rbTwo.Text = "Two";
            this.rbTwo.UseVisualStyleBackColor = true;
            this.rbTwo.CheckedChanged += new System.EventHandler(this.rbTwo_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(23, 253);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(115, 253);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainMenu
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(215, 295);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gbxNumberOfDesktops);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "MultiDesk";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxNumberOfDesktops.ResumeLayout(false);
            this.gbxNumberOfDesktops.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbxNumberOfDesktops;
        private System.Windows.Forms.RadioButton rbEight;
        private System.Windows.Forms.RadioButton rbSeven;
        private System.Windows.Forms.RadioButton rbSix;
        private System.Windows.Forms.RadioButton rbFive;
        private System.Windows.Forms.RadioButton rbFour;
        private System.Windows.Forms.RadioButton rbThree;
        private System.Windows.Forms.RadioButton rbTwo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
    }
}