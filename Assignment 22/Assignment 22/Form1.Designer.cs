namespace Assignment_22
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.shapeLabel = new System.Windows.Forms.Label();
            this.shape = new System.Windows.Forms.ComboBox();
            this.firstLabel = new System.Windows.Forms.Label();
            this.firstInputBox = new System.Windows.Forms.TextBox();
            this.secondLabel = new System.Windows.Forms.Label();
            this.secondInputBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shapeLabel
            // 
            this.shapeLabel.AutoSize = true;
            this.shapeLabel.Location = new System.Drawing.Point(24, 24);
            this.shapeLabel.Name = "shapeLabel";
            this.shapeLabel.Size = new System.Drawing.Size(74, 13);
            this.shapeLabel.TabIndex = 0;
            this.shapeLabel.Text = "Select shape:";
            // 
            // shape
            // 
            this.shape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shape.FormattingEnabled = true;
            this.shape.Items.AddRange(new object[] {
            "Circle",
            "Rectangle",
            "Cylinder"});
            this.shape.Location = new System.Drawing.Point(119, 21);
            this.shape.Name = "shape";
            this.shape.Size = new System.Drawing.Size(230, 21);
            this.shape.TabIndex = 1;
            this.shape.SelectedIndexChanged += new System.EventHandler(this.shape_SelectedIndexChanged);
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.Location = new System.Drawing.Point(24, 70);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(43, 13);
            this.firstLabel.TabIndex = 2;
            this.firstLabel.Text = "Radius:";
            // 
            // firstInputBox
            // 
            this.firstInputBox.Location = new System.Drawing.Point(119, 67);
            this.firstInputBox.Name = "firstInputBox";
            this.firstInputBox.Size = new System.Drawing.Size(230, 20);
            this.firstInputBox.TabIndex = 3;
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.Location = new System.Drawing.Point(24, 105);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(55, 13);
            this.secondLabel.TabIndex = 4;
            this.secondLabel.Text = "";
            // 
            // secondInputBox
            // 
            this.secondInputBox.Location = new System.Drawing.Point(119, 102);
            this.secondInputBox.Name = "secondInputBox";
            this.secondInputBox.Size = new System.Drawing.Size(230, 20);
            this.secondInputBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(27, 146);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 30);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(138, 146);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 30);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(249, 146);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 30);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Location = new System.Drawing.Point(27, 193);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(322, 58);
            this.resultLabel.TabIndex = 9;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 273);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.secondInputBox);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.firstInputBox);
            this.Controls.Add(this.firstLabel);
            this.Controls.Add(this.shape);
            this.Controls.Add(this.shapeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment 22";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label shapeLabel;
        private System.Windows.Forms.ComboBox shape;
        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.TextBox firstInputBox;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.TextBox secondInputBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label resultLabel;
    }
}
