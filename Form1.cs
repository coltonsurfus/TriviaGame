using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TriviaGame
{
    public partial class Form1 : Form
    {
        // Declaring i outside of the call function so it keeps track of what question user is on
        int i = 0;
        int questionCorrect = 0;

        // Create list containing question objects
        List<Question> questionList = new List<Question>();


        public Form1()
        {
            InitializeComponent();
        }

        // Uses the loadFile function to load text file for the game
        private void Form1_Load(object sender, EventArgs e)
        {
            loadFile();
            
        }

        // Start button, when clicked it loads the first question
        private void button1_Click(object sender, EventArgs e)
        {
            questionCorrect = 0;
            //scoreLabel.Text = "Questions Correct: " + questionCorrect;
            loadQuestion();
            t = 60;
            timer1.Enabled = true;
            
            
         

           
        }

        // Guess Button, when clicked it checks the user answer to the correct answer
        private void guessButton_Click(object sender, EventArgs e)
        {
            guessButton.Enabled = false;
            // If user selects the first radio button as their answer
            if (firstAnswerRadBtn.Checked)
            {
                
               if (questionList[i].getFirstAnswer() == questionList[i].getCorrectAnswer())
                {
                    questionCorrect++;
                    //scoreLabel.Text = "Questions Correct: " + questionCorrect;
                    resultLabel.Text = "Correct!";
                    resultLabel.Update();
                    System.Threading.Thread.Sleep(3000);
                    
                    i++;
                    resultLabel.Text = "";
                    resultLabel.Update();

                    loadQuestion();
                }
               else
                {
                    resultLabel.Text = "Wrong!";
                    resultLabel.Update();
                    System.Threading.Thread.Sleep(3000);
                    i++;
                    resultLabel.Text = "";
                    resultLabel.Update();

                    loadQuestion();
                }
                
            }
            // If user selects the second radio button as their answer
            else if (secondAnswerRadBtn.Checked)
            {
                if (questionList[i].getSecondAnswer() == questionList[i].getCorrectAnswer())
                {
                    questionCorrect++;
                    //scoreLabel.Text = "Questions Correct: " + questionCorrect;
                    //scoreLabel.Update();
                    resultLabel.Text = "Correct!";
                    resultLabel.Update();
                    System.Threading.Thread.Sleep(3000);
                    i++;
                    resultLabel.Text = "";
                    resultLabel.Update();

                    loadQuestion();
                }
                else
                {
                    resultLabel.Text = "Wrong!";
                    resultLabel.Update();
                    System.Threading.Thread.Sleep(3000);
                    i++;
                    resultLabel.Text = "";
                    resultLabel.Update();

                    loadQuestion();
                }
            }
            // If user selects nothing as their answer
            else
            {
                resultLabel.Text = "You didn't select an answer so you skipped the question";
                resultLabel.Update();
                i++;
                resultLabel.Text = "";
                resultLabel.Update();
                loadQuestion();
            }
        }

        // Function that loads textfile full of questions and sticks them in a list
        private void loadFile()
        {
            string line;
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(@"questions.txt");

                while ((line = file.ReadLine()) != null)
                {
                    string[] words = line.Split(',');

                    string quest = words[0];
                    string answer1 = words[1];
                    string answer2 = words[2];
                    string correctAns = words[3];

                    questionList.Add(new Question(quest, answer1, answer2, correctAns));

                }
            }

            catch
            {

            }
        }

        // Function that loads a different question each time it is called
        private void loadQuestion()
        {
            //System.Threading.Thread.Sleep(3000);
            if (questionList.Count > i) { 
            guessButton.Enabled = true;
            questionLabel.Text = (questionList[i].getQuestion());
            firstAnswerRadBtn.Text = (questionList[i].getFirstAnswer());
            secondAnswerRadBtn.Text = (questionList[i].getSecondAnswer());
            //i++;
            //testLabel.Text = "Question: " + questionList[i].getQuestion() + " 1stAnswer: " + questionList[i].getFirstAnswer() + " 2ndAnswer: " + questionList[i].getSecondAnswer() + " correctAnswer: " + questionList[i].getCorrectAnswer();
        }

            else
            {
                questionLabel.Text = "Out of Questions";
                i = 0;
            }
        }
        int t = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (t > 0) { 
            t--;
            timerLabel.Text = t.ToString();
            }

            else
            {
                guessButton.Enabled = false;
                questionLabel.Text = "You have completed " + i + " questions with " + questionCorrect + " correct.";
                
            }
        }
    }
}
