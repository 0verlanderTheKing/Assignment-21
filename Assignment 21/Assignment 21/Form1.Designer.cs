namespace Assignment_21
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblCorrectCount;
        private System.Windows.Forms.Label lblIncorrectCount;

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
            this.lblState = new System.Windows.Forms.Label();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblCorrectCount = new System.Windows.Forms.Label();
            this.lblIncorrectCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblState.Location = new System.Drawing.Point(28, 28);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(172, 28);
            this.lblState.TabIndex = 0;
            this.lblState.Text = "What is the capital of";
            // 
            // txtCapital
            // 
            this.txtCapital.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCapital.Location = new System.Drawing.Point(33, 78);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(273, 32);
            this.txtCapital.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSubmit.Location = new System.Drawing.Point(393, 74);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(115, 39);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnRestart.Location = new System.Drawing.Point(393, 128);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(115, 39);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblResult.Location = new System.Drawing.Point(29, 134);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(340, 55);
            this.lblResult.TabIndex = 4;
            // 
            // lblCorrectCount
            // 
            this.lblCorrectCount.AutoSize = true;
            this.lblCorrectCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCorrectCount.Location = new System.Drawing.Point(29, 235);
            this.lblCorrectCount.Name = "lblCorrectCount";
            this.lblCorrectCount.Size = new System.Drawing.Size(84, 23);
            this.lblCorrectCount.TabIndex = 5;
            this.lblCorrectCount.Text = "Correct: 0";
            // 
            // lblIncorrectCount
            // 
            this.lblIncorrectCount.AutoSize = true;
            this.lblIncorrectCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblIncorrectCount.Location = new System.Drawing.Point(190, 235);
            this.lblIncorrectCount.Name = "lblIncorrectCount";
            this.lblIncorrectCount.Size = new System.Drawing.Size(96, 23);
            this.lblIncorrectCount.TabIndex = 6;
            this.lblIncorrectCount.Text = "Incorrect: 0";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 300);
            this.Controls.Add(this.lblIncorrectCount);
            this.Controls.Add(this.lblCorrectCount);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.lblState);
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
