using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Assignment_21
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> capitals = new Dictionary<string, string>()
        {
            { "Pennsylvania", "Harrisburg" },
            { "West Virginia", "Charleston" },
            { "Kentucky", "Frankfort" },
            { "Indiana", "Indianapolis" },
            { "Michigan", "Lansing" }
        };

        private List<string> states;
        private int currentIndex = 0;
        private int correctCount = 0;
        private int incorrectCount = 0;

        public Form1()
        {
            InitializeComponent();
            StartQuiz();
        }

        private void StartQuiz()
        {
            Random random = new Random();
            states = capitals.Keys.OrderBy(x => random.Next()).ToList();

            currentIndex = 0;
            correctCount = 0;
            incorrectCount = 0;

            lblCorrectCount.Text = "Correct: 0";
            lblIncorrectCount.Text = "Incorrect: 0";
            lblResult.Text = "";
            txtCapital.Clear();

            ShowNextState();
        }

        private void ShowNextState()
        {
            if (currentIndex < states.Count)
            {
                lblState.Text = "What is the capital of " + states[currentIndex] + "?";
                txtCapital.Clear();
                txtCapital.Focus();
            }
            else
            {
                lblState.Text = "Quiz complete!";
                lblResult.Text = "Final Score - Correct: " + correctCount + " | Incorrect: " + incorrectCount;

                MessageBox.Show(
                    "Quiz complete!\n\nCorrect answers: " + correctCount + "\nIncorrect answers: " + incorrectCount,
                    "Results",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                btnSubmit.Enabled = false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (currentIndex >= states.Count)
            {
                return;
            }

            string state = states[currentIndex];
            string userAnswer = FormatInput(txtCapital.Text);

            if (userAnswer == capitals[state])
            {
                lblResult.Text = "Correct!";
                correctCount++;
            }
            else
            {
                lblResult.Text = "Incorrect. The capital is " + capitals[state] + ".";
                incorrectCount++;
            }

            lblCorrectCount.Text = "Correct: " + correctCount;
            lblIncorrectCount.Text = "Incorrect: " + incorrectCount;

            currentIndex++;
            ShowNextState();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;
            StartQuiz();
        }

        private string FormatInput(string input)
        {
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
