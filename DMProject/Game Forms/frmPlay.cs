using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMProject.Game_Forms
{
    public partial class frmPlay : Form
    {
        List<int> baseTables = new List<int>(); // Gets Basic Table Number
        Random rnd = new Random(); // Get A Random Number From 0 To 'Determines Later'.
        List<string> questions = new List<string>(); // A List For questions That Solved.
        string[] operations = new string[2]{ "×", "÷" }; // An Array For Store Operations.
        int maxQuestion;
        int minuates = 0, seconds = 0;
        int correct = 0, wrong = 0;
        Guna2Button selected;

        //Enum Operations = new Enum();
        public frmPlay()
        {
            InitializeComponent();
        }

        private void frmPlay_Load(object sender, EventArgs e)
        {
            foreach(Control control in this.Controls)
                if(control is Button) control.AllowDrop = true;

            baseTables = (List<int>)Tag; // Get The Multiple Tables
            baseTables.Sort();
            maxQuestion = baseTables.Count() * 11 * 2;
            minuates = baseTables.Count();
            this.Text = $"Tables [{string.Join(", ", baseTables)}]";
            GetQuestion();
            printTime();
        }
        private void GetQuestion()
        {
            if (questions.Count() == maxQuestion) // Close The Form When It Equals The Maximum Number Of Questions
            {
                timer1.Start();
                DialogResult ClosingDialog = MessageBox.Show("Game End");
                if (ClosingDialog == DialogResult.OK)
                    Close();
                return;
            }

            // Variables 
            string question = "", operation;
            int operatorNumber, baseTable, answer;
            List<Guna2Button> answerButtons = new List<Guna2Button>(); // Answer Buttons. 
            foreach (Control button in Controls)
            {
                if (button is Guna2Button && button.Name.Contains("AnswerKey"))
                    answerButtons.Add((Guna2Button)button);
            }
        Again:
            // Question Components.
            operatorNumber = rnd.Next(11); // Gets First Operator
            operation = operations[rnd.Next(2)]; // Gets The Operation 
            baseTable = baseTables[rnd.Next(baseTables.Count())]; // Gets The Second Operator Form Selected Tables.
            answer = operatorNumber * baseTable; // Gets The Answer Of The Multiply Operation. 

            for (int i = 0; i < answerButtons.Count(); i++)
                answerButtons[i].Text = "";

            btnOperation.Text = operation;
            btnSecond.Text = baseTable.ToString();

            if (operation.Equals("×"))
            {
                btnFirst.Text = operatorNumber.ToString();
                question = $"{operatorNumber} {operation} {baseTable} ?";
                btnAnswer.Text = answer.ToString();
                answerButtons[rnd.Next(4)].Text = $"{answer}";
                
                for (int j = 0; j < answerButtons.Count(); j++)
                {
                    if (answerButtons[j].Text.Length == 0)
                    {
                        int operatorNumberanser = rnd.Next(11);
                        if (operatorNumberanser != operatorNumber)
                        {
                            List<string> k = answerButtons.Select(x => x.Text).ToList();
                            string stringAnswer = (operatorNumberanser * baseTable).ToString();
                            if (!k.Contains(stringAnswer))
                                answerButtons[j].Text = stringAnswer;
                            else j--;
                        }
                        else j--;
                    }
                }
            }
            else if (operation.Equals("÷"))
            {
                btnFirst.Text = answer.ToString();
                question = $"{answer} {operation} {baseTable} ?";
                btnAnswer.Text = operatorNumber.ToString();
                answerButtons[rnd.Next(4)].Text = $"{operatorNumber}";

                for (int j = 0; j < answerButtons.Count(); j++)
                {
                    if (answerButtons[j].Text.Length == 0)
                    {
                        int operatorNumberanser = rnd.Next(11);
                        if (operatorNumberanser != operatorNumber)
                        {
                            List<string> k = answerButtons.Select(x => x.Text).ToList();
                            int answ = operatorNumberanser * baseTable;
                            string stringAnswer = (answ / baseTable).ToString();
                            if (!k.Contains(stringAnswer))
                                answerButtons[j].Text = stringAnswer;
                            else j--;
                        }
                        else j--;
                    }
                }

            }
            if (!questions.Contains(question))
                questions.Add(question);
            else goto Again;


            lblQuestionsCount.Text = $"{int.Parse(lblQuestionsCount.Text.Replace($"/ {maxQuestion}", "")) + 1} / {maxQuestion}";
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            GetQuestion();
        }
        // Drag And Drop Answer
        private void btnAnswerKey_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void btnAnswerKey_DragDrop(object sender, DragEventArgs e)
        {
            btnAnswer.Text = e.Data.GetData(DataFormats.Text).ToString();
            for (int i = 0; i < Controls.Count; i++)
                if (Controls[i] is Guna2Button && Controls[i].Name.Contains("AnswerKey"))
                    ((Guna2Button)Controls[i]).BorderColor = Color.CadetBlue;
            
            //selected.BorderColor = Color.Blue;
        }

        private void btnAnswerKey1_MouseUp(object sender, MouseEventArgs e)
        {
            string s = ((Guna2Button)sender).Text;
            DoDragDrop(s, DragDropEffects.Copy);
            
            //selected = ((Guna2Button)sender);
        }

        private void btnAnswerKey4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            printTime();
            seconds--;
            if (seconds < 0)
            {
                seconds = 59;
                minuates--;
            }
            if (minuates < 0)
            {
                timer1.Stop();
                MessageBox.Show("Time Over", "Time Over", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
            }
            if (minuates == 0 && seconds < 10)
                lblTimer.ForeColor = Color.Red;
            Application.DoEvents();
        }
        private void printTime()
        {
            string time = $"{minuates}:{seconds}";
            if (minuates < 10 && seconds >= 10)
                time = $"0{minuates}:{seconds}";
            else if (minuates >= 10 && seconds < 10)
                time = $"0{minuates}:0{seconds}";
            else if (minuates < 10 && seconds < 10)
                time = $"0{minuates}:0{seconds}";
            lblTimer.Text = time;
        }
    }
}
