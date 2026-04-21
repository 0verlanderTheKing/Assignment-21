using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Assignment_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            shape.SelectedIndex = 0;
            InitializeComponent();
            UpdateLabels();
        }

        private void selectChange(object sender, EventArgs e)
        {
            
            resultLabel.Text = "";
            firstInputBox.Clear();
            secondInputBox.Clear();          
            firstInputBox.Focus();
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            string selectedShape = shape.SelectedItem.ToString();

            if (selectedShape == "Circle")
            {
                firstLabel.Text = "Radius:";
                secondLabel.Text = "";
                secondInputBox.Enabled = false;
                secondInputBox.Visible = false;
                secondLabel.Visible = false;
            }
            else if (selectedShape == "Rectangle")
            {
                firstLabel.Text = "Width:";
                secondLabel.Text = "Length:";
                secondInputBox.Enabled = true;
                secondInputBox.Visible = true;
                secondLabel.Visible = true;
            }
            else if (selectedShape == "Cylinder")
            {
                firstLabel.Text = "Radius:";
                secondLabel.Text = "Height:";
                secondInputBox.Enabled = true;
                secondInputBox.Visible = true;
                secondLabel.Visible = true;
            }
        }

        private bool emptySpace(string text)
        {
            return text == null || text.Trim() == "";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string selectedShape = shape.SelectedItem.ToString();
            double firstValue = 0;
            double secondValue = 0;
            double answer = 0;

            try
            {
                if (emptySpace(firstInputBox.Text))
                {
                    MessageBox.Show("Invalid input");
                    firstInputBox.Focus();
                    return;
                }

                firstValue = double.Parse(firstInputBox.Text);

                if (firstValue < 0)
                {
                    MessageBox.Show("Invalid input");
                    firstInputBox.Focus();
                    return;
                }

                if (selectedShape == "Circle")
                {
                    answer = Area.CalculateArea(firstValue);
                    resultLabel.Text = "Circle area: " + Math.Round(answer, 1).ToString("0.0");
                }
                else if (selectedShape == "Rectangle")
                {
                    if (emptySpace(secondInputBox.Text))
                    {
                        MessageBox.Show("Invalid input");
                        secondInputBox.Focus();
                        return;
                    }

                    secondValue = double.Parse(secondInputBox.Text);

                    if (secondValue < 0)
                    {
                        MessageBox.Show("Invalid input");
                        secondInputBox.Focus();
                        return;
                    }

                    answer = Area.CalculateArea(firstValue, secondValue);
                    resultLabel.Text = "Rectangle area: " + Math.Round(answer, 1).ToString("0.0");
                }
                else if (selectedShape == "Cylinder")
                {
                    if (emptySpace(secondInputBox.Text))
                    {
                        MessageBox.Show("Invalid input");
                        secondInputBox.Focus();
                        return;
                    }

                    secondValue = double.Parse(secondInputBox.Text);

                    if (secondValue < 0)
                    {
                        MessageBox.Show("Invalid input");
                        secondInputBox.Focus();
                        return;
                    }

                    answer = Area.CalculateArea(firstValue, secondValue, true);
                    resultLabel.Text = "Cylinder area: " + Math.Round(answer, 1).ToString("0.0");
                }
            }
            catch
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            shape.SelectedIndex = 0;
            firstInputBox.Clear();
            secondInputBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}