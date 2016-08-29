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
            this.editStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.makeRunningMenuFloatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.gbxPosition = new System.Windows.Forms.GroupBox();
            this.rbBottomRight = new System.Windows.Forms.RadioButton();
            this.rbBottomCentre = new System.Windows.Forms.RadioButton();
            this.rbBottomLeft = new System.Windows.Forms.RadioButton();
            this.rbCentreRight = new System.Windows.Forms.RadioButton();
            this.rbCentreLeft = new System.Windows.Forms.RadioButton();
            this.rbTopRight = new System.Windows.Forms.RadioButton();
            this.rbTopCentre = new System.Windows.Forms.RadioButton();
            this.rbTopLeft = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFloatDock = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbxNumberOfDesktops.SuspendLayout();
            this.gbxPosition.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(730, 24);
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
            // editStripMenuItem1
            // 
            this.editStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeRunningMenuFloatToolStripMenuItem});
            this.editStripMenuItem1.Name = "editStripMenuItem1";
            this.editStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.editStripMenuItem1.Text = "&Edit";
            // 
            // makeRunningMenuFloatToolStripMenuItem
            // 
            this.makeRunningMenuFloatToolStripMenuItem.Name = "makeRunningMenuFloatToolStripMenuItem";
            this.makeRunningMenuFloatToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.makeRunningMenuFloatToolStripMenuItem.Text = "Make Running Menu &Float";
            this.makeRunningMenuFloatToolStripMenuItem.Click += new System.EventHandler(this.makeRunningMenuFloatToolStripMenuItem_Click);
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
            // gbxPosition
            // 
            this.gbxPosition.Controls.Add(this.rbBottomRight);
            this.gbxPosition.Controls.Add(this.rbBottomCentre);
            this.gbxPosition.Controls.Add(this.rbBottomLeft);
            this.gbxPosition.Controls.Add(this.rbCentreRight);
            this.gbxPosition.Controls.Add(this.rbCentreLeft);
            this.gbxPosition.Controls.Add(this.rbTopRight);
            this.gbxPosition.Controls.Add(this.rbTopCentre);
            this.gbxPosition.Controls.Add(this.rbTopLeft);
            this.gbxPosition.Location = new System.Drawing.Point(256, 44);
            this.gbxPosition.Name = "gbxPosition";
            this.gbxPosition.Size = new System.Drawing.Size(454, 181);
            this.gbxPosition.TabIndex = 2;
            this.gbxPosition.TabStop = false;
            this.gbxPosition.Text = "Select menu position";
            // 
            // rbBottomRight
            // 
            this.rbBottomRight.AutoSize = true;
            this.rbBottomRight.Location = new System.Drawing.Point(363, 157);
            this.rbBottomRight.Name = "rbBottomRight";
            this.rbBottomRight.Size = new System.Drawing.Size(81, 17);
            this.rbBottomRight.TabIndex = 7;
            this.rbBottomRight.Text = "Bottom right";
            this.rbBottomRight.UseVisualStyleBackColor = true;
            this.rbBottomRight.CheckedChanged += new System.EventHandler(this.rbBottomRight_CheckedChanged);
            // 
            // rbBottomCentre
            // 
            this.rbBottomCentre.AutoSize = true;
            this.rbBottomCentre.Location = new System.Drawing.Point(185, 157);
            this.rbBottomCentre.Name = "rbBottomCentre";
            this.rbBottomCentre.Size = new System.Drawing.Size(91, 17);
            this.rbBottomCentre.TabIndex = 6;
            this.rbBottomCentre.Text = "Bottom centre";
            this.rbBottomCentre.UseVisualStyleBackColor = true;
            this.rbBottomCentre.CheckedChanged += new System.EventHandler(this.rbBottomCentre_CheckedChanged);
            // 
            // rbBottomLeft
            // 
            this.rbBottomLeft.AutoSize = true;
            this.rbBottomLeft.Location = new System.Drawing.Point(16, 157);
            this.rbBottomLeft.Name = "rbBottomLeft";
            this.rbBottomLeft.Size = new System.Drawing.Size(79, 17);
            this.rbBottomLeft.TabIndex = 5;
            this.rbBottomLeft.Text = "Bottom Left";
            this.rbBottomLeft.UseVisualStyleBackColor = true;
            this.rbBottomLeft.CheckedChanged += new System.EventHandler(this.rbBottomLeft_CheckedChanged);
            // 
            // rbCentreRight
            // 
            this.rbCentreRight.AutoSize = true;
            this.rbCentreRight.Location = new System.Drawing.Point(363, 88);
            this.rbCentreRight.Name = "rbCentreRight";
            this.rbCentreRight.Size = new System.Drawing.Size(85, 17);
            this.rbCentreRight.TabIndex = 4;
            this.rbCentreRight.Text = "Centre RIght";
            this.rbCentreRight.UseVisualStyleBackColor = true;
            this.rbCentreRight.CheckedChanged += new System.EventHandler(this.rbCentreRight_CheckedChanged);
            // 
            // rbCentreLeft
            // 
            this.rbCentreLeft.AutoSize = true;
            this.rbCentreLeft.Location = new System.Drawing.Point(16, 88);
            this.rbCentreLeft.Name = "rbCentreLeft";
            this.rbCentreLeft.Size = new System.Drawing.Size(73, 17);
            this.rbCentreLeft.TabIndex = 3;
            this.rbCentreLeft.Text = "Centre left";
            this.rbCentreLeft.UseVisualStyleBackColor = true;
            this.rbCentreLeft.CheckedChanged += new System.EventHandler(this.rbCentreLeft_CheckedChanged);
            // 
            // rbTopRight
            // 
            this.rbTopRight.AutoSize = true;
            this.rbTopRight.Location = new System.Drawing.Point(363, 19);
            this.rbTopRight.Name = "rbTopRight";
            this.rbTopRight.Size = new System.Drawing.Size(72, 17);
            this.rbTopRight.TabIndex = 2;
            this.rbTopRight.Text = "Top Right";
            this.rbTopRight.UseVisualStyleBackColor = true;
            this.rbTopRight.CheckedChanged += new System.EventHandler(this.rbTopRight_CheckedChanged);
            // 
            // rbTopCentre
            // 
            this.rbTopCentre.AutoSize = true;
            this.rbTopCentre.Checked = true;
            this.rbTopCentre.Location = new System.Drawing.Point(185, 19);
            this.rbTopCentre.Name = "rbTopCentre";
            this.rbTopCentre.Size = new System.Drawing.Size(78, 17);
            this.rbTopCentre.TabIndex = 1;
            this.rbTopCentre.TabStop = true;
            this.rbTopCentre.Text = "Top Centre";
            this.rbTopCentre.UseVisualStyleBackColor = true;
            this.rbTopCentre.CheckedChanged += new System.EventHandler(this.rbTopCentre_CheckedChanged);
            // 
            // rbTopLeft
            // 
            this.rbTopLeft.AutoSize = true;
            this.rbTopLeft.Location = new System.Drawing.Point(16, 19);
            this.rbTopLeft.Name = "rbTopLeft";
            this.rbTopLeft.Size = new System.Drawing.Size(61, 17);
            this.rbTopLeft.TabIndex = 0;
            this.rbTopLeft.Text = "Top left";
            this.rbTopLeft.UseVisualStyleBackColor = true;
            this.rbTopLeft.CheckedChanged += new System.EventHandler(this.rbTopLeft_CheckedChanged);
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
            // btnFloatDock
            // 
            this.btnFloatDock.Location = new System.Drawing.Point(635, 253);
            this.btnFloatDock.Name = "btnFloatDock";
            this.btnFloatDock.Size = new System.Drawing.Size(75, 23);
            this.btnFloatDock.TabIndex = 8;
            this.btnFloatDock.Text = "Float Menu";
            this.btnFloatDock.UseVisualStyleBackColor = true;
            this.btnFloatDock.Click += new System.EventHandler(this.btnFloatDock_Click);
            // 
            // MainMenu
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(730, 295);
            this.Controls.Add(this.btnFloatDock);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gbxPosition);
            this.Controls.Add(this.gbxNumberOfDesktops);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "MultiDesk Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxNumberOfDesktops.ResumeLayout(false);
            this.gbxNumberOfDesktops.PerformLayout();
            this.gbxPosition.ResumeLayout(false);
            this.gbxPosition.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbxPosition;
        private System.Windows.Forms.RadioButton rbCentreLeft;
        private System.Windows.Forms.RadioButton rbTopRight;
        private System.Windows.Forms.RadioButton rbTopCentre;
        private System.Windows.Forms.RadioButton rbTopLeft;
        private System.Windows.Forms.RadioButton rbBottomLeft;
        private System.Windows.Forms.RadioButton rbCentreRight;
        private System.Windows.Forms.RadioButton rbBottomRight;
        private System.Windows.Forms.RadioButton rbBottomCentre;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripMenuItem editStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem makeRunningMenuFloatToolStripMenuItem;
        private System.Windows.Forms.Button btnFloatDock;
    }
}