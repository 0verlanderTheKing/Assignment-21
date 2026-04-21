namespace Assignment_21
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox capitalText;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label correctCountLabel;
        private System.Windows.Forms.Label IncorrectCountLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.stateLabel = new System.Windows.Forms.Label();
            this.capitalText = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.correctCountLabel = new System.Windows.Forms.Label();
            this.IncorrectCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.stateLabel.Location = new System.Drawing.Point(28, 28);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(172, 28);
            this.stateLabel.TabIndex = 0;
            this.stateLabel.Text = "What is the capital of";
            // 
            // capitalText
            // 
            this.capitalText.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.capitalText.Location = new System.Drawing.Point(33, 78);
            this.capitalText.Name = "capitalText";
            this.capitalText.Size = new System.Drawing.Size(273, 32);
            this.capitalText.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.submitButton.Location = new System.Drawing.Point(393, 74);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(115, 39);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.restartButton.Location = new System.Drawing.Point(393, 128);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(115, 39);
            this.restartButton.TabIndex = 3;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.resultLabel.Location = new System.Drawing.Point(29, 134);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(340, 55);
            this.resultLabel.TabIndex = 4;
            // 
            // correctCountLabel
            // 
            this.correctCountLabel.AutoSize = true;
            this.correctCountLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.correctCountLabel.Location = new System.Drawing.Point(29, 235);
            this.correctCountLabel.Name = "correctCountLabel";
            this.correctCountLabel.Size = new System.Drawing.Size(84, 23);
            this.correctCountLabel.TabIndex = 5;
            this.correctCountLabel.Text = "Correct: 0";
            // 
            // IncorrectCountLabel
            // 
            this.IncorrectCountLabel.AutoSize = true;
            this.IncorrectCountLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.IncorrectCountLabel.Location = new System.Drawing.Point(190, 235);
            this.IncorrectCountLabel.Name = "IncorrectCountLabel";
            this.IncorrectCountLabel.Size = new System.Drawing.Size(96, 23);
            this.IncorrectCountLabel.TabIndex = 6;
            this.IncorrectCountLabel.Text = "Incorrect: 0";
            // 
            // Form1
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 300);
            this.Controls.Add(this.IncorrectCountLabel);
            this.Controls.Add(this.correctCountLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.capitalText);
            this.Controls.Add(this.stateLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "assignment 21";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
