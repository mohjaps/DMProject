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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlay));
            this.btnFirst = new Guna.UI2.WinForms.Guna2Button();
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblWrong = new System.Windows.Forms.Label();
            this.lblTrue = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.office2019GrayTheme1 = new Telerik.WinControls.Themes.Office2019GrayTheme();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblSelectedTables = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFirst
            // 
            this.btnFirst.AllowDrop = true;
            this.btnFirst.BorderColor = System.Drawing.Color.Red;
            this.btnFirst.BorderRadius = 48;
            this.btnFirst.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnFirst.BorderThickness = 3;
            this.btnFirst.CheckedState.Parent = this.btnFirst;
            this.btnFirst.CustomImages.Parent = this.btnFirst;
            this.btnFirst.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFirst.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFirst.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFirst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFirst.DisabledState.Parent = this.btnFirst;
            this.btnFirst.FillColor = System.Drawing.Color.White;
            this.btnFirst.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.btnFirst.ForeColor = System.Drawing.Color.Red;
            this.btnFirst.HoverState.Parent = this.btnFirst;
            this.btnFirst.Location = new System.Drawing.Point(36, 341);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.ShadowDecoration.Parent = this.btnFirst;
            this.btnFirst.Size = new System.Drawing.Size(128, 122);
            this.btnFirst.TabIndex = 13;
            this.btnFirst.Text = "guna2Button6";
            // 
            // btnOperation
            // 
            this.btnOperation.AllowDrop = true;
            this.btnOperation.BorderColor = System.Drawing.Color.Red;
            this.btnOperation.BorderRadius = 48;
            this.btnOperation.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnOperation.BorderThickness = 3;
            this.btnOperation.CheckedState.Parent = this.btnOperation;
            this.btnOperation.CustomImages.Parent = this.btnOperation;
            this.btnOperation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOperation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOperation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOperation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOperation.DisabledState.Parent = this.btnOperation;
            this.btnOperation.FillColor = System.Drawing.Color.White;
            this.btnOperation.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.btnOperation.ForeColor = System.Drawing.Color.Red;
            this.btnOperation.HoverState.Parent = this.btnOperation;
            this.btnOperation.Location = new System.Drawing.Point(99, 178);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.ShadowDecoration.Parent = this.btnOperation;
            this.btnOperation.Size = new System.Drawing.Size(128, 122);
            this.btnOperation.TabIndex = 15;
            this.btnOperation.Text = "guna2Button8";
            // 
            // btnSecond
            // 
            this.btnSecond.AllowDrop = true;
            this.btnSecond.BorderColor = System.Drawing.Color.Red;
            this.btnSecond.BorderRadius = 48;
            this.btnSecond.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnSecond.BorderThickness = 3;
            this.btnSecond.CheckedState.Parent = this.btnSecond;
            this.btnSecond.CustomImages.Parent = this.btnSecond;
            this.btnSecond.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSecond.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSecond.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSecond.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSecond.DisabledState.Parent = this.btnSecond;
            this.btnSecond.FillColor = System.Drawing.Color.White;
            this.btnSecond.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.btnSecond.ForeColor = System.Drawing.Color.Red;
            this.btnSecond.HoverState.Parent = this.btnSecond;
            this.btnSecond.Location = new System.Drawing.Point(263, 156);
            this.btnSecond.Name = "btnSecond";
            this.btnSecond.ShadowDecoration.Parent = this.btnSecond;
            this.btnSecond.Size = new System.Drawing.Size(128, 122);
            this.btnSecond.TabIndex = 16;
            this.btnSecond.Text = "guna2Button9";
            // 
            // btnAnswer
            // 
            this.btnAnswer.AllowDrop = true;
            this.btnAnswer.BorderColor = System.Drawing.Color.Red;
            this.btnAnswer.BorderRadius = 48;
            this.btnAnswer.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnAnswer.BorderThickness = 3;
            this.btnAnswer.CheckedState.Parent = this.btnAnswer;
            this.btnAnswer.CustomImages.Parent = this.btnAnswer;
            this.btnAnswer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAnswer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAnswer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnswer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAnswer.DisabledState.Parent = this.btnAnswer;
            this.btnAnswer.FillColor = System.Drawing.Color.White;
            this.btnAnswer.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.btnAnswer.ForeColor = System.Drawing.Color.Red;
            this.btnAnswer.HoverState.Parent = this.btnAnswer;
            this.btnAnswer.Location = new System.Drawing.Point(354, 376);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.ShadowDecoration.Parent = this.btnAnswer;
            this.btnAnswer.Size = new System.Drawing.Size(128, 122);
            this.btnAnswer.TabIndex = 18;
            this.btnAnswer.Text = "?";
            this.btnAnswer.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnAnswerKey_DragDrop);
            this.btnAnswer.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnAnswerKey_DragEnter);
            // 
            // lblQuestionsCount
            // 
            this.lblQuestionsCount.AutoSize = true;
            this.lblQuestionsCount.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestionsCount.Font = new System.Drawing.Font("Zilla Slab SemiBold", 20F);
            this.lblQuestionsCount.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblQuestionsCount.Location = new System.Drawing.Point(71, 44);
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
            this.btnAnswerKey2.Location = new System.Drawing.Point(532, 268);
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
            this.btnAnswerKey3.Location = new System.Drawing.Point(563, 427);
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
            this.btnAnswerKey4.Location = new System.Drawing.Point(488, 579);
            this.btnAnswerKey4.Name = "btnAnswerKey4";
            this.btnAnswerKey4.ShadowDecoration.Parent = this.btnAnswerKey4;
            this.btnAnswerKey4.Size = new System.Drawing.Size(128, 122);
            this.btnAnswerKey4.TabIndex = 22;
            this.btnAnswerKey4.Text = "guna2Button4";
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
            this.btnAnswerKey1.Location = new System.Drawing.Point(287, 549);
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
            this.lblTimer.Location = new System.Drawing.Point(700, 53);
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
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.lblWrong);
            this.guna2Panel1.Controls.Add(this.lblTrue);
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox2);
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel1.Location = new System.Drawing.Point(287, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(226, 54);
            this.guna2Panel1.TabIndex = 25;
            // 
            // lblWrong
            // 
            this.lblWrong.AutoSize = true;
            this.lblWrong.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.lblWrong.ForeColor = System.Drawing.Color.Red;
            this.lblWrong.Location = new System.Drawing.Point(185, 14);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(24, 26);
            this.lblWrong.TabIndex = 28;
            this.lblWrong.Text = "0";
            // 
            // lblTrue
            // 
            this.lblTrue.AutoSize = true;
            this.lblTrue.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.lblTrue.ForeColor = System.Drawing.Color.Green;
            this.lblTrue.Location = new System.Drawing.Point(69, 14);
            this.lblTrue.Name = "lblTrue";
            this.lblTrue.Size = new System.Drawing.Size(24, 26);
            this.lblTrue.TabIndex = 26;
            this.lblTrue.Text = "0";
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox2.Image = global::DMProject.Properties.Resources.wrong;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(131, 8);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.ShadowDecoration.Parent = this.guna2CirclePictureBox2;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(40, 38);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 27;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::DMProject.Properties.Resources.correct;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(13, 8);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(40, 38);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 26;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.White;
            this.guna2CustomGradientPanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.guna2CustomGradientPanel1.BorderThickness = 2;
            this.guna2CustomGradientPanel1.Controls.Add(this.lblSelectedTables);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblQuestionsCount);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblTimer);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2Panel1);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(823, 132);
            this.guna2CustomGradientPanel1.TabIndex = 26;
            this.guna2CustomGradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2CustomGradientPanel1_MouseDown);
            // 
            // lblSelectedTables
            // 
            this.lblSelectedTables.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedTables.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblSelectedTables.ForeColor = System.Drawing.Color.Blue;
            this.lblSelectedTables.Location = new System.Drawing.Point(375, 93);
            this.lblSelectedTables.Name = "lblSelectedTables";
            this.lblSelectedTables.Size = new System.Drawing.Size(54, 26);
            this.lblSelectedTables.TabIndex = 26;
            this.lblSelectedTables.Text = "00:00";
            // 
            // guna2Button1
            // 
            this.guna2Button1.AllowDrop = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.Red;
            this.guna2Button1.BorderRadius = 48;
            this.guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Button1.BorderThickness = 3;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Red;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(223, 306);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(107, 109);
            this.guna2Button1.TabIndex = 27;
            this.guna2Button1.Text = "=";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FillColor = System.Drawing.Color.Transparent;
            this.btnNext.Image = global::DMProject.Properties.Resources.next;
            this.btnNext.ImageRotate = 0F;
            this.btnNext.Location = new System.Drawing.Point(727, 624);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(64, 64);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNext.TabIndex = 28;
            this.btnNext.TabStop = false;
            this.btnNext.UseTransparentBackground = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = global::DMProject.Properties.Resources.Exit;
            this.btnExit.ImageRotate = 0F;
            this.btnExit.Location = new System.Drawing.Point(12, 651);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(64, 50);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 29;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(823, 713);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.btnAnswerKey1);
            this.Controls.Add(this.btnAnswerKey4);
            this.Controls.Add(this.btnAnswerKey3);
            this.Controls.Add(this.btnAnswerKey2);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.btnSecond);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.btnFirst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPlay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPlay_FormClosing);
            this.Load += new System.EventHandler(this.frmPlay_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnFirst;
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
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblWrong;
        private System.Windows.Forms.Label lblTrue;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Telerik.WinControls.Themes.Office2019GrayTheme office2019GrayTheme1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnNext;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSelectedTables;
        private Guna.UI2.WinForms.Guna2PictureBox btnExit;
    }
}