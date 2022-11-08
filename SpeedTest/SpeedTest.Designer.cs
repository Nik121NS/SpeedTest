namespace SpeedTest
{
    partial class SpeedTest
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
            this.gameTextLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameTextLabel
            // 
            this.gameTextLabel.AutoSize = true;
            this.gameTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameTextLabel.Location = new System.Drawing.Point(93, 135);
            this.gameTextLabel.Name = "gameTextLabel";
            this.gameTextLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gameTextLabel.Size = new System.Drawing.Size(0, 25);
            this.gameTextLabel.TabIndex = 0;
            this.gameTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameTextLabel.Click += new System.EventHandler(this.gameTextLabel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(99, 257);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1892, 44);
            this.textBox1.TabIndex = 1;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(865, 367);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(360, 69);
            this.acceptButton.TabIndex = 2;
            this.acceptButton.Text = "Новое предложение.";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // SpeedTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2093, 515);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gameTextLabel);
            this.Name = "SpeedTest";
            this.Text = "SpeedTest";
            this.Load += new System.EventHandler(this.SpeedTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameTextLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button acceptButton;
    }
}