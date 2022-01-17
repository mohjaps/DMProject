namespace DMProject.Game_Forms
{
    partial class PlayerLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerLogin));
            this.radioBtnNew = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioBtnExixtedPlayer = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gboxNew = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAge = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gboxLogin = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtUsernameLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2CircleButton();
            this.gboxNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge)).BeginInit();
            this.gboxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioBtnNew
            // 
            this.radioBtnNew.AutoSize = true;
            this.radioBtnNew.Checked = true;
            this.radioBtnNew.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioBtnNew.CheckedState.BorderThickness = 0;
            this.radioBtnNew.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioBtnNew.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioBtnNew.CheckedState.InnerOffset = -4;
            this.radioBtnNew.Location = new System.Drawing.Point(49, 56);
            this.radioBtnNew.Name = "radioBtnNew";
            this.radioBtnNew.Size = new System.Drawing.Size(96, 21);
            this.radioBtnNew.TabIndex = 0;
            this.radioBtnNew.TabStop = true;
            this.radioBtnNew.Text = "New Player";
            this.radioBtnNew.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioBtnNew.UncheckedState.BorderThickness = 2;
            this.radioBtnNew.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioBtnNew.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioBtnNew.CheckedChanged += new System.EventHandler(this.radioBtnExixtedPlayer_CheckedChanged);
            this.radioBtnNew.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayerLogin_KeyDown);
            // 
            // radioBtnExixtedPlayer
            // 
            this.radioBtnExixtedPlayer.AutoSize = true;
            this.radioBtnExixtedPlayer.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioBtnExixtedPlayer.CheckedState.BorderThickness = 0;
            this.radioBtnExixtedPlayer.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioBtnExixtedPlayer.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioBtnExixtedPlayer.CheckedState.InnerOffset = -4;
            this.radioBtnExixtedPlayer.Location = new System.Drawing.Point(233, 56);
            this.radioBtnExixtedPlayer.Name = "radioBtnExixtedPlayer";
            this.radioBtnExixtedPlayer.Size = new System.Drawing.Size(103, 21);
            this.radioBtnExixtedPlayer.TabIndex = 1;
            this.radioBtnExixtedPlayer.Text = "Login Player";
            this.radioBtnExixtedPlayer.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioBtnExixtedPlayer.UncheckedState.BorderThickness = 2;
            this.radioBtnExixtedPlayer.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioBtnExixtedPlayer.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioBtnExixtedPlayer.CheckedChanged += new System.EventHandler(this.radioBtnExixtedPlayer_CheckedChanged);
            this.radioBtnExixtedPlayer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayerLogin_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(32, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Back Home";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gboxNew
            // 
            this.gboxNew.Controls.Add(this.label5);
            this.gboxNew.Controls.Add(this.label4);
            this.gboxNew.Controls.Add(this.txtUsername);
            this.gboxNew.Controls.Add(this.txtAge);
            this.gboxNew.Controls.Add(this.txtName);
            this.gboxNew.Controls.Add(this.label1);
            this.gboxNew.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gboxNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gboxNew.Location = new System.Drawing.Point(35, 100);
            this.gboxNew.Name = "gboxNew";
            this.gboxNew.ShadowDecoration.Parent = this.gboxNew;
            this.gboxNew.Size = new System.Drawing.Size(730, 296);
            this.gboxNew.TabIndex = 6;
            this.gboxNew.Text = "New Player";
            this.gboxNew.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayerLogin_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(58, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 35);
            this.label5.TabIndex = 6;
            this.label5.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(58, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name";
            // 
            // txtUsername
            // 
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.Parent = this.txtUsername;
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.FocusedState.Parent = this.txtUsername;
            this.txtUsername.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.HoverState.Parent = this.txtUsername;
            this.txtUsername.Location = new System.Drawing.Point(204, 80);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.SelectedText = "";
            this.txtUsername.ShadowDecoration.Parent = this.txtUsername;
            this.txtUsername.Size = new System.Drawing.Size(440, 33);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayerLogin_KeyDown);
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.Transparent;
            this.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAge.DisabledState.Parent = this.txtAge;
            this.txtAge.FocusedState.Parent = this.txtAge;
            this.txtAge.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.txtAge.ForeColor = System.Drawing.Color.Black;
            this.txtAge.Location = new System.Drawing.Point(204, 192);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAge.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.txtAge.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.txtAge.Name = "txtAge";
            this.txtAge.ShadowDecoration.Parent = this.txtAge;
            this.txtAge.Size = new System.Drawing.Size(440, 33);
            this.txtAge.TabIndex = 2;
            this.txtAge.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.txtAge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayerLogin_KeyDown);
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.Parent = this.txtName;
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.FocusedState.Parent = this.txtName;
            this.txtName.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(204, 136);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(440, 33);
            this.txtName.TabIndex = 1;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayerLogin_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(58, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // gboxLogin
            // 
            this.gboxLogin.Controls.Add(this.txtUsernameLogin);
            this.gboxLogin.Controls.Add(this.label7);
            this.gboxLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gboxLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gboxLogin.Location = new System.Drawing.Point(32, 100);
            this.gboxLogin.Name = "gboxLogin";
            this.gboxLogin.ShadowDecoration.Parent = this.gboxLogin;
            this.gboxLogin.Size = new System.Drawing.Size(730, 296);
            this.gboxLogin.TabIndex = 7;
            this.gboxLogin.Text = "Login Player";
            this.gboxLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayerLogin_KeyDown);
            // 
            // txtUsernameLogin
            // 
            this.txtUsernameLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsernameLogin.DefaultText = "";
            this.txtUsernameLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsernameLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsernameLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsernameLogin.DisabledState.Parent = this.txtUsernameLogin;
            this.txtUsernameLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsernameLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsernameLogin.FocusedState.Parent = this.txtUsernameLogin;
            this.txtUsernameLogin.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.txtUsernameLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsernameLogin.HoverState.Parent = this.txtUsernameLogin;
            this.txtUsernameLogin.Location = new System.Drawing.Point(218, 133);
            this.txtUsernameLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsernameLogin.Name = "txtUsernameLogin";
            this.txtUsernameLogin.PasswordChar = '\0';
            this.txtUsernameLogin.PlaceholderText = "";
            this.txtUsernameLogin.SelectedText = "";
            this.txtUsernameLogin.ShadowDecoration.Parent = this.txtUsernameLogin;
            this.txtUsernameLogin.Size = new System.Drawing.Size(440, 33);
            this.txtUsernameLogin.TabIndex = 3;
            this.txtUsernameLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayerLogin_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(72, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 35);
            this.label7.TabIndex = 0;
            this.label7.Text = "Username";
            // 
            // btnLogin
            // 
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.DisabledState.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.Transparent;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Image = global::DMProject.Properties.Resources.next;
            this.btnLogin.ImageSize = new System.Drawing.Size(50, 50);
            this.btnLogin.Location = new System.Drawing.Point(718, 41);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(50, 50);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // PlayerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.gboxLogin);
            this.Controls.Add(this.gboxNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioBtnExixtedPlayer);
            this.Controls.Add(this.radioBtnNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayerLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayerLogin";
            this.Load += new System.EventHandler(this.PlayerLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayerLogin_KeyDown);
            this.gboxNew.ResumeLayout(false);
            this.gboxNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge)).EndInit();
            this.gboxLogin.ResumeLayout(false);
            this.gboxLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2RadioButton radioBtnNew;
        private Guna.UI2.WinForms.Guna2RadioButton radioBtnExixtedPlayer;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GroupBox gboxNew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtAge;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox gboxLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtUsernameLogin;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2CircleButton btnLogin;
    }
}