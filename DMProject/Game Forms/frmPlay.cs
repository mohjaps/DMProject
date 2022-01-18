using DMProject.Models;
using DMProject.Models.Principles;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMProject.Game_Forms
{
    public partial class frmPlay : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        List<int> baseTables = new List<int>(); // Gets Basic Table Number
        Random rnd = new Random(); // Get A Random Number From 0 To 'Determines Later'.
        List<string> questions = new List<string>(); // A List For questions That Solved.
        string[] operations = new string[2]{ "×", "÷" }; // An Array For Store Operations.
        int maxQuestion = 0; // Gets Max Number Of Questions 
        int minuates = 0, seconds = 0; // Timer Variables 
        int correct = 0, wrong = 0; // Number Of Correct And Wrong Answers
        int answerKey; // Correct Answer
        int totalTime = -1; // Total Consumed Time In Seconds
        string username = ""; // Player Username
        DateTime StartTime = DateTime.Now; // Starting DateTime
        SoundPlayer SP = new SoundPlayer(); // Sound Player
        private int tempIndex; // BackGround Color Variable
        public frmPlay()
        {
            InitializeComponent();
        }
        private Color SelectThemeColor()
        {
            int index = rnd.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                rnd.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[tempIndex];
            return ColorTranslator.FromHtml(color);
        }
        private void frmPlay_Load(object sender, EventArgs e)
        {
            BackColor = SelectThemeColor();

            foreach(Control control in this.Controls)
                if(control is Button) control.AllowDrop = true;

            object[] ob = (object[])Tag; // Fetch Data From Previous Form

            baseTables = (List<int>)ob[0]; // Get The Multiple Tables.
            baseTables.Sort();
            maxQuestion = int.Parse(ob[1].ToString());
            // 20 Seconds For Question
            minuates = maxQuestion/3;
            seconds = (maxQuestion%3) * 20;
            username = ob[2].ToString();
            lblSelectedTables.Text = $"Tables: {string.Join(" - ", baseTables)}";
            GetQuestion();
            printTime();
        }
        private void GetQuestion()
        {
            
            btnAnswer.Text = "?";
            if (questions.Count() == maxQuestion) // Close The Form When It Equals The Maximum Number Of Questions
            {
                timer1.Stop();
                string msg = correct > wrong ? "Great" : correct == wrong ? "Good" : "Falied";
                DialogResult ClosingDialog = MessageBox.Show($"Game End\nCorrect Answers Count: {correct}\nWrong Answers Count: {wrong}\n{msg}");
                if (ClosingDialog == DialogResult.OK)
                    Close();
                return;
            }

            // Variables 
            string question = "", operation;
            int operatorNumber, baseTable, answer;
            List<Guna2Button> answerButtons = new List<Guna2Button>(); // Answer Buttons.
                                                                       // 
            foreach (Control button in Controls)
            {
                if (button is Guna2Button && button.Name.Contains("AnswerKey"))
                    answerButtons.Add((Guna2Button)button);
            }
        Again:
            // Question Components.
            operatorNumber = rnd.Next(11); // Gets First Operator Randomly 
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
                answerKey = answer;
                answerButtons[rnd.Next(4)].Text = $"{answer}";
                
                // Create Wrong Answers 
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
                answerKey = operatorNumber;
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
            timer1.Start();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!btnAnswer.Text.Equals("?"))
            {
                timer1.Stop();
                bool isCorrect = (btnAnswer.Text == answerKey.ToString());
                if (isCorrect)
                {
                    SP.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "Sounds/Correct.wav";
                    SP.Play();
                    MessageBox.Show("Answer Is Correct", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    correct++;
                }
                else
                {
                    SP.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "Sounds/Lose.wav";
                    SP.Play();
                    MessageBox.Show("Answer Is Wrong", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    wrong++;
                }
                lblTrue.Text = correct.ToString();
                lblWrong.Text = wrong.ToString();
                GetQuestion();
                BackColor = SelectThemeColor();
            }
            else
            {
                MessageBox.Show("Answer The Question Before Go Next...", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
        }
        private void btnAnswerKey1_MouseUp(object sender, MouseEventArgs e)
        {
            string s = ((Guna2Button)sender).Text;
            DoDragDrop(s, DragDropEffects.Copy);
        }
        private void frmPlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            Round round = new Round();
            round.PlayerUsername = username;
            round.selectedTables = string.Join(", ", baseTables);
            round.totalQuestions = maxQuestion;
            round.solvedQuestions = correct + wrong;
            round.correct = correct;
            round.wrong = wrong;
            round.timeConsumed = totalTime.ToString();
            round.Score = (int)Math.Round(((double)correct / maxQuestion) * 100);
            round.RoundDateTime = StartTime;
            try
            {
                DatabaseCongfigurations.AddRound(round);
                double cnt = DatabaseCongfigurations.RoundsCount(username);
                double sum = DatabaseCongfigurations.RoundsTotalScore(username);
                Player player = DatabaseCongfigurations.GetPlayer(username);
                player.Score = (int)(Math.Round(sum / cnt));
                DatabaseCongfigurations.UpdatePlayer(player);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            string msg = correct > wrong ? "Great" : correct == wrong ? "Good" : "Falied";
            DialogResult ClosingDialog = MessageBox.Show($"You Are Trying To Exit This Round, Are You Sure?", "Trying To Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ClosingDialog == DialogResult.Yes)
            {
                MessageBox.Show($"Correct Answers Count: {correct}\nWrong Answers Count: {wrong}\n{msg}");
                Close();
                return;
            }
            timer1.Start();
        }

        private void guna2CustomGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            printTime();
            seconds--;
            totalTime+=1;
            if (seconds < 0)
            {
                seconds = 59;
                minuates--;
            }
            if (minuates < 0)
            {
                timer1.Stop();
                string msg = correct > wrong ? "Great" : correct == wrong ? "Good" : "Falied";
                MessageBox.Show($"Game End\nCorrect Answers Count: {correct}\nWrong Answers Count: {wrong}\n{msg}", "Time Over", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
