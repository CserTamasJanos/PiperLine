namespace PiperLine
{
    partial class PiperLine
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
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLinePointSwitch = new System.Windows.Forms.Button();
            this.trackBarThickness = new System.Windows.Forms.TrackBar();
            this.pictureBoxLine = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(58, 324);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(25, 23);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.Text = "D";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.MoveLine);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(58, 268);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(25, 23);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.Text = "U";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.MoveLine);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(10, 296);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(25, 23);
            this.buttonLeft.TabIndex = 1;
            this.buttonLeft.Text = "L";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.MoveLine);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(105, 296);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(25, 23);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.Text = "R";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.MoveLine);
            // 
            // buttonLinePointSwitch
            // 
            this.buttonLinePointSwitch.Location = new System.Drawing.Point(40, 296);
            this.buttonLinePointSwitch.Name = "buttonLinePointSwitch";
            this.buttonLinePointSwitch.Size = new System.Drawing.Size(60, 23);
            this.buttonLinePointSwitch.TabIndex = 5;
            this.buttonLinePointSwitch.Text = "Left";
            this.buttonLinePointSwitch.UseVisualStyleBackColor = true;
            this.buttonLinePointSwitch.Click += new System.EventHandler(this.buttonLinePointSwitch_Click);
            // 
            // trackBarThickness
            // 
            this.trackBarThickness.Location = new System.Drawing.Point(468, 296);
            this.trackBarThickness.Name = "trackBarThickness";
            this.trackBarThickness.Size = new System.Drawing.Size(104, 45);
            this.trackBarThickness.TabIndex = 6;
            this.trackBarThickness.TickFrequency = 3;
            this.trackBarThickness.Scroll += new System.EventHandler(this.trackBarThickness_Scroll);
            // 
            // pictureBoxLine
            // 
            this.pictureBoxLine.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLine.Name = "pictureBoxLine";
            this.pictureBoxLine.Size = new System.Drawing.Size(522, 197);
            this.pictureBoxLine.TabIndex = 7;
            this.pictureBoxLine.TabStop = false;
            // 
            // PiperLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pictureBoxLine);
            this.Controls.Add(this.trackBarThickness);
            this.Controls.Add(this.buttonLinePointSwitch);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PiperLine";
            this.Text = "PiperLine";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLinePointSwitch;
        private System.Windows.Forms.TrackBar trackBarThickness;
        private System.Windows.Forms.PictureBox pictureBoxLine;
    }
}

