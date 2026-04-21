using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment_21
{
    public partial class Form1 : Form
    {
        private string[] states = { "Pennsylvania", "West Virginia", "Kentucky", "Indiana", "Michigan" };
        private string[] capitals = { "Harrisburg", "Charleston", "Frankfort", "Indianapolis", "Lansing" };

        private int currentIndex = 0;
        private int correctCount = 0;
        private int incorrectCount = 0;
        private List<int> randomize;

        public Form1()
        {
            InitializeComponent();
            test();
        }

        private void test()
        {
            Random random = new Random();
            randomize = new List<int>();

            for (int i = 0; i < states.Length; i++)
            {
                randomize.Add(i);
            }

            for (int i = 0; i < randomize.Count; i++)
            {
                int swapIndex = random.Next(randomize.Count);

                int temporary = randomize[i];
                randomize[i] = randomize[swapIndex];
                randomize[swapIndex] = temporary;
            }

            correctCountLabel.Text = "Correct: 0";
            IncorrectCountLabel.Text = "Incorrect: 0";
            resultLabel.Text = "";
            currentIndex = 0;
            correctCount = 0;
            incorrectCount = 0;
            capitalText.Clear();
            next();
        }

        private void next()
        {
            if (currentIndex < randomize.Count)
            {
                int state = randomize[currentIndex];
                stateLabel.Text = "What is the capital of " + states[state] + "?";
                capitalText.Clear();
                capitalText.Focus();
            }
            else
            {
                int totalQuestions = correctCount + incorrectCount;

                stateLabel.Text = "Quiz complete!";
                resultLabel.Text = "Score: " + correctCount + "/" + totalQuestions;

                MessageBox.Show("Quiz Over! You got " + correctCount + "/" + totalQuestions + " correct!");
                submitButton.Enabled = false;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (currentIndex >= randomize.Count)
            {
                return;
            }

            int state = randomize[currentIndex];
            string userAnswer = FormatInput(capitalText.Text);

            if (userAnswer == capitals[state])
            {
                resultLabel.Text = "Correct!";
                correctCount = correctCount + 1;
            }
            else if (userAnswer == "")
            {
                MessageBox.Show("Please put an input.");
                return;
            }
            else
            {
                resultLabel.Text = "Incorrect. The capital is " + capitals[state];
                incorrectCount = incorrectCount + 1;
            }

            correctCountLabel.Text = "Correct: " + correctCount;
            IncorrectCountLabel.Text = "Incorrect: " + incorrectCount;

            currentIndex = currentIndex + 1;
            next();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            submitButton.Enabled = true;
            test();
        }

        private string FormatInput(string input)
        {
            input = input.Trim();

            if (input == "")
            {
                return "";
            }

            input = input.ToLower();

            char firstLetter = char.ToUpper(input[0]);
            string rest = "";

            for (int i = 1; i < input.Length; i++)
            {
                rest += input[i];
            }

            return firstLetter + rest;
        }
    }
}