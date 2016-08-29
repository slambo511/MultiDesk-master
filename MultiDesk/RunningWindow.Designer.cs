namespace MultiDesk
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
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(11, 11);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(26, 26);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(43, 11);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(26, 26);
            this.btnTwo.TabIndex = 1;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(75, 11);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(26, 26);
            this.btnThree.TabIndex = 2;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(107, 11);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(26, 26);
            this.btnFour.TabIndex = 3;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(139, 11);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(26, 26);
            this.btnFive.TabIndex = 4;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(171, 11);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(26, 26);
            this.btnSix.TabIndex = 5;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(203, 11);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(26, 26);
            this.btnSeven.TabIndex = 6;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(235, 11);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(26, 26);
            this.btnEight.TabIndex = 7;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            // 
            // RunningWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 49);
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
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RunningWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RunningWindow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RunningWindow_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
    }
}