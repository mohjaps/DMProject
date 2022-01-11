namespace DMProject.Game_Forms
{
    partial class frmPlay
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
            this.components = new System.ComponentModel.Container();
            this.btnFirst = new Guna.UI2.WinForms.Guna2Button();
            this.btnEquals = new Guna.UI2.WinForms.Guna2Button();
            this.btnOperation = new Guna.UI2.WinForms.Guna2Button();
            this.btnSecond = new Guna.UI2.WinForms.Guna2Button();
            this.btnAnswer = new Guna.UI2.WinForms.Guna2Button();
            this.lblQuestionsCount = new System.Windows.Forms.Label();
            this.btnAnswerKey2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAnswerKey3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAnswerKey4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAnswerKey1 = new Guna.UI2.WinForms.Guna2Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblTimer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFirst
            // 
            this.btnFirst.AllowDrop = true;
            this.btnFirst.BorderRadius = 48;
            this.btnFirst.CheckedState.Parent = this.btnFirst;
            this.btnFirst.CustomImages.Parent = this.btnFirst;
            this.btnFirst.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFirst.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFirst.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFirst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFirst.DisabledState.Parent = this.btnFirst;
            this.btnFirst.FillColor = System.Drawing.Color.White;
            this.btnFirst.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.btnFirst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFirst.HoverState.Parent = this.btnFirst;
            this.btnFirst.Location = new System.Drawing.Point(559, 164);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.ShadowDecoration.Parent = this.btnFirst;
            this.btnFirst.Size = new System.Drawing.Size(128, 122);
            this.btnFirst.TabIndex = 13;
            this.btnFirst.Text = "guna2Button6";
            // 
            // btnEquals
            // 
            this.btnEquals.AllowDrop = true;
            this.btnEquals.BorderRadius = 48;
            this.btnEquals.CheckedState.Parent = this.btnEquals;
            this.btnEquals.CustomImages.Parent = this.btnEquals;
            this.btnEquals.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEquals.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEquals.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEquals.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEquals.DisabledState.Parent = this.btnEquals;
            this.btnEquals.FillColor = System.Drawing.Color.White;
            this.btnEquals.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.btnEquals.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEquals.HoverState.Parent = this.btnEquals;
            this.btnEquals.Location = new System.Drawing.Point(559, 309);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.ShadowDecoration.Parent = this.btnEquals;
            this.btnEquals.Size = new System.Drawing.Size(128, 122);
            this.btnEquals.TabIndex = 14;
            this.btnEquals.Text = "=";
            // 
            // btnOperation
            // 
            this.btnOperation.AllowDrop = true;
            this.btnOperation.BorderRadius = 48;
            this.btnOperation.CheckedState.Parent = this.btnOperation;
            this.btnOperation.CustomImages.Parent = this.btnOperation;
            this.btnOperation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOperation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOperation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOperation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOperation.DisabledState.Parent = this.btnOperation;
            this.btnOperation.FillColor = System.Drawing.Color.White;
            this.btnOperation.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.btnOperation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOperation.HoverState.Parent = this.btnOperation;
            this.btnOperation.Location = new System.Drawing.Point(713, 164);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.ShadowDecoration.Parent = this.btnOperation;
            this.btnOperation.Size = new System.Drawing.Size(128, 122);
            this.btnOperation.TabIndex = 15;
            this.btnOperation.Text = "guna2Button8";
            // 
            // btnSecond
            // 
            this.btnSecond.AllowDrop = true;
            this.btnSecond.BorderRadius = 48;
            this.btnSecond.CheckedState.Parent = this.btnSecond;
            this.btnSecond.CustomImages.Parent = this.btnSecond;
            this.btnSecond.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSecond.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSecond.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSecond.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSecond.DisabledState.Parent = this.btnSecond;
            this.btnSecond.FillColor = System.Drawing.Color.White;
            this.btnSecond.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.btnSecond.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSecond.HoverState.Parent = this.btnSecond;
            this.btnSecond.Location = new System.Drawing.Point(870, 164);
            this.btnSecond.Name = "btnSecond";
            this.btnSecond.ShadowDecoration.Parent = this.btnSecond;
            this.btnSecond.Size = new System.Drawing.Size(128, 122);
            this.btnSecond.TabIndex = 16;
            this.btnSecond.Text = "guna2Button9";
            // 
            // btnAnswer
            // 
            this.btnAnswer.AllowDrop = true;
            this.btnAnswer.BorderRadius = 48;
            this.btnAnswer.CheckedState.Parent = this.btnAnswer;
            this.btnAnswer.CustomImages.Parent = this.btnAnswer;
            this.btnAnswer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAnswer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAnswer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnswer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAnswer.DisabledState.Parent = this.btnAnswer;
            this.btnAnswer.FillColor = System.Drawing.Color.White;
            this.btnAnswer.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.btnAnswer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAnswer.HoverState.Parent = this.btnAnswer;
            this.btnAnswer.Location = new System.Drawing.Point(782, 309);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.ShadowDecoration.Parent = this.btnAnswer;
            this.btnAnswer.Size = new System.Drawing.Size(128, 122);
            this.btnAnswer.TabIndex = 18;
            this.btnAnswer.Text = "15";
            this.btnAnswer.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnAnswerKey_DragDrop);
            this.btnAnswer.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnAnswerKey_DragEnter);
            // 
            // lblQuestionsCount
            // 
            this.lblQuestionsCount.AutoSize = true;
            this.lblQuestionsCount.BackColor = System.Drawing.SystemColors.Control;
            this.lblQuestionsCount.Font = new System.Drawing.Font("Zilla Slab SemiBold", 20F);
            this.lblQuestionsCount.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblQuestionsCount.Location = new System.Drawing.Point(38, 18);
            this.lblQuestionsCount.Name = "lblQuestionsCount";
            this.lblQuestionsCount.Size = new System.Drawing.Size(38, 41);
            this.lblQuestionsCount.TabIndex = 7;
            this.lblQuestionsCount.Text = "0";
            // 
            // btnAnswerKey2
            // 
            this.btnAnswerKey2.AllowDrop = true;
            this.btnAnswerKey2.BorderColor = System.Drawing.Color.CadetBlue;
            this.btnAnswerKey2.BorderRadius = 48;
            this.btnAnswerKey2.BorderThickness = 3;
            this.btnAnswerKey2.CheckedState.Parent = this.btnAnswerKey2;
            this.btnAnswerKey2.CustomImages.Parent = this.btnAnswerKey2;
            this.btnAnswerKey2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAnswerKey2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAnswerKey2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnswerKey2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAnswerKey2.DisabledState.Parent = this.btnAnswerKey2;
            this.btnAnswerKey2.FillColor = System.Drawing.Color.White;
            this.btnAnswerKey2.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.btnAnswerKey2.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnAnswerKey2.HoverState.Parent = this.btnAnswerKey2;
            this.btnAnswerKey2.Location = new System.Drawing.Point(31, 237);
            this.btnAnswerKey2.Name = "btnAnswerKey2";
            this.btnAnswerKey2.ShadowDecoration.Parent = this.btnAnswerKey2;
            this.btnAnswerKey2.Size = new System.Drawing.Size(128, 122);
            this.btnAnswerKey2.TabIndex = 19;
            this.btnAnswerKey2.Text = "guna2Button1";
            this.btnAnswerKey2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAnswerKey1_MouseUp);
            // 
            // btnAnswerKey3
            // 
            this.btnAnswerKey3.AllowDrop = true;
            this.btnAnswerKey3.BorderColor = System.Drawing.Color.CadetBlue;
            this.btnAnswerKey3.BorderRadius = 48;
            this.btnAnswerKey3.BorderThickness = 3;
            this.btnAnswerKey3.CheckedState.Parent = this.btnAnswerKey3;
            this.btnAnswerKey3.CustomImages.Parent = this.btnAnswerKey3;
            this.btnAnswerKey3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAnswerKey3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAnswerKey3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnswerKey3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAnswerKey3.DisabledState.Parent = this.btnAnswerKey3;
            this.btnAnswerKey3.FillColor = System.Drawing.Color.White;
            this.btnAnswerKey3.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.btnAnswerKey3.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnAnswerKey3.HoverState.Parent = this.btnAnswerKey3;
            this.btnAnswerKey3.Location = new System.Drawing.Point(154, 333);
            this.btnAnswerKey3.Name = "btnAnswerKey3";
            this.btnAnswerKey3.ShadowDecoration.Parent = this.btnAnswerKey3;
            this.btnAnswerKey3.Size = new System.Drawing.Size(128, 122);
            this.btnAnswerKey3.TabIndex = 21;
            this.btnAnswerKey3.Text = "guna2Button3";
            this.btnAnswerKey3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAnswerKey1_MouseUp);
            // 
            // btnAnswerKey4
            // 
            this.btnAnswerKey4.AllowDrop = true;
            this.btnAnswerKey4.BorderColor = System.Drawing.Color.CadetBlue;
            this.btnAnswerKey4.BorderRadius = 48;
            this.btnAnswerKey4.BorderThickness = 3;
            this.btnAnswerKey4.CheckedState.Parent = this.btnAnswerKey4;
            this.btnAnswerKey4.CustomImages.Parent = this.btnAnswerKey4;
            this.btnAnswerKey4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAnswerKey4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAnswerKey4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnswerKey4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAnswerKey4.DisabledState.Parent = this.btnAnswerKey4;
            this.btnAnswerKey4.FillColor = System.Drawing.Color.White;
            this.btnAnswerKey4.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.btnAnswerKey4.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnAnswerKey4.HoverState.Parent = this.btnAnswerKey4;
            this.btnAnswerKey4.Location = new System.Drawing.Point(275, 237);
            this.btnAnswerKey4.Name = "btnAnswerKey4";
            this.btnAnswerKey4.ShadowDecoration.Parent = this.btnAnswerKey4;
            this.btnAnswerKey4.Size = new System.Drawing.Size(128, 122);
            this.btnAnswerKey4.TabIndex = 22;
            this.btnAnswerKey4.Text = "guna2Button4";
            this.btnAnswerKey4.Click += new System.EventHandler(this.btnAnswerKey4_Click);
            this.btnAnswerKey4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAnswerKey1_MouseUp);
            // 
            // btnAnswerKey1
            // 
            this.btnAnswerKey1.AllowDrop = true;
            this.btnAnswerKey1.BorderColor = System.Drawing.Color.CadetBlue;
            this.btnAnswerKey1.BorderRadius = 48;
            this.btnAnswerKey1.BorderThickness = 3;
            this.btnAnswerKey1.CheckedState.Parent = this.btnAnswerKey1;
            this.btnAnswerKey1.CustomImages.Parent = this.btnAnswerKey1;
            this.btnAnswerKey1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAnswerKey1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAnswerKey1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnswerKey1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAnswerKey1.DisabledState.Parent = this.btnAnswerKey1;
            this.btnAnswerKey1.FillColor = System.Drawing.Color.White;
            this.btnAnswerKey1.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.btnAnswerKey1.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnAnswerKey1.HoverState.Parent = this.btnAnswerKey1;
            this.btnAnswerKey1.Location = new System.Drawing.Point(154, 128);
            this.btnAnswerKey1.Name = "btnAnswerKey1";
            this.btnAnswerKey1.ShadowDecoration.Parent = this.btnAnswerKey1;
            this.btnAnswerKey1.Size = new System.Drawing.Size(128, 122);
            this.btnAnswerKey1.TabIndex = 23;
            this.btnAnswerKey1.Text = "guna2Button5";
            this.btnAnswerKey1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAnswerKey1_MouseUp);
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblTimer.ForeColor = System.Drawing.Color.Green;
            this.lblTimer.Location = new System.Drawing.Point(415, 12);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(54, 26);
            this.lblTimer.TabIndex = 24;
            this.lblTimer.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(991, 321);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(138, 91);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 472);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnAnswerKey1);
            this.Controls.Add(this.btnAnswerKey4);
            this.Controls.Add(this.btnAnswerKey3);
            this.Controls.Add(this.btnAnswerKey2);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.btnSecond);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.lblQuestionsCount);
            this.Controls.Add(this.btnNext);
            this.Name = "frmPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPlay";
            this.Load += new System.EventHandler(this.frmPlay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnFirst;
        private Guna.UI2.WinForms.Guna2Button btnEquals;
        private Guna.UI2.WinForms.Guna2Button btnOperation;
        private Guna.UI2.WinForms.Guna2Button btnSecond;
        private Guna.UI2.WinForms.Guna2Button btnAnswer;
        private System.Windows.Forms.Label lblQuestionsCount;
        private Guna.UI2.WinForms.Guna2Button btnAnswerKey2;
        private Guna.UI2.WinForms.Guna2Button btnAnswerKey3;
        private Guna.UI2.WinForms.Guna2Button btnAnswerKey4;
        private Guna.UI2.WinForms.Guna2Button btnAnswerKey1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTimer;
        private System.Windows.Forms.Timer timer1;
    }
}