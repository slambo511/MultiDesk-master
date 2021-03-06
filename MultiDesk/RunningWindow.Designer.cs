﻿namespace MultiDesk
{
    partial class RunningWindow
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
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(331, 5);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(40, 26);
            this.btnEight.TabIndex = 7;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(285, 5);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(40, 26);
            this.btnSeven.TabIndex = 6;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(239, 5);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(40, 26);
            this.btnSix.TabIndex = 5;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(193, 5);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(40, 26);
            this.btnFive.TabIndex = 4;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(147, 5);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(40, 26);
            this.btnFour.TabIndex = 3;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(101, 5);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(40, 26);
            this.btnThree.TabIndex = 2;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(55, 5);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(40, 26);
            this.btnTwo.TabIndex = 1;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(9, 5);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(40, 26);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // RunningWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 36);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RunningWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RunningWindow";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.RunningWindow_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RunningWindow_FormClosing);
            this.Load += new System.EventHandler(this.RunningWindow_Load_1);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RunningWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RunningWindow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RunningWindow_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnEight;
        internal System.Windows.Forms.Button btnSeven;
        internal System.Windows.Forms.Button btnSix;
        internal System.Windows.Forms.Button btnFive;
        public System.Windows.Forms.Button btnFour;
        public System.Windows.Forms.Button btnThree;
        public System.Windows.Forms.Button btnTwo;
        internal System.Windows.Forms.Button btnOne;
    }
}