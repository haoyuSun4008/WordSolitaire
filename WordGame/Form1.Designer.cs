namespace WordGame
{
    partial class WordGame
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordGame));
            this.Tips = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.Label();
            this.PlayerAns = new System.Windows.Forms.TextBox();
            this.CompAns = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Test = new System.Windows.Forms.Button();
            this.Commit = new System.Windows.Forms.Button();
            this.record = new System.Windows.Forms.TextBox();
            this.EndGame = new System.Windows.Forms.Button();
            this.StartGame = new System.Windows.Forms.Button();
            this.TimeBar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Tips
            // 
            this.Tips.BackColor = System.Drawing.Color.White;
            this.Tips.Font = new System.Drawing.Font("Centaur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tips.Location = new System.Drawing.Point(20, 130);
            this.Tips.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tips.Multiline = true;
            this.Tips.Name = "Tips";
            this.Tips.Size = new System.Drawing.Size(914, 107);
            this.Tips.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Centaur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "tips";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.log.Font = new System.Drawing.Font("Centaur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.Location = new System.Drawing.Point(14, 472);
            this.log.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(105, 32);
            this.log.TabIndex = 3;
            this.log.Text = "history log";
            this.log.UseCompatibleTextRendering = true;
            // 
            // Answer
            // 
            this.Answer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Answer.Font = new System.Drawing.Font("Centaur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer.Location = new System.Drawing.Point(536, 262);
            this.Answer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(144, 34);
            this.Answer.TabIndex = 3;
            this.Answer.Text = "player";
            this.Answer.UseCompatibleTextRendering = true;
            // 
            // PlayerAns
            // 
            this.PlayerAns.BackColor = System.Drawing.Color.White;
            this.PlayerAns.Font = new System.Drawing.Font("Centaur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerAns.Location = new System.Drawing.Point(508, 303);
            this.PlayerAns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlayerAns.Multiline = true;
            this.PlayerAns.Name = "PlayerAns";
            this.PlayerAns.Size = new System.Drawing.Size(424, 56);
            this.PlayerAns.TabIndex = 1;
            // 
            // CompAns
            // 
            this.CompAns.BackColor = System.Drawing.Color.White;
            this.CompAns.Font = new System.Drawing.Font("Centaur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompAns.Location = new System.Drawing.Point(26, 303);
            this.CompAns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CompAns.Multiline = true;
            this.CompAns.Name = "CompAns";
            this.CompAns.ReadOnly = true;
            this.CompAns.Size = new System.Drawing.Size(426, 56);
            this.CompAns.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Centaur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "computer ";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // Test
            // 
            this.Test.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Test.Font = new System.Drawing.Font("Centaur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test.Location = new System.Drawing.Point(706, 20);
            this.Test.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(198, 63);
            this.Test.TabIndex = 0;
            this.Test.Text = "Test";
            this.Test.UseCompatibleTextRendering = true;
            this.Test.UseVisualStyleBackColor = false;
            this.Test.Click += new System.EventHandler(this.button1_Click);
            // 
            // Commit
            // 
            this.Commit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Commit.Font = new System.Drawing.Font("Centaur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Commit.Location = new System.Drawing.Point(701, 248);
            this.Commit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Commit.Name = "Commit";
            this.Commit.Size = new System.Drawing.Size(198, 48);
            this.Commit.TabIndex = 0;
            this.Commit.Text = "Commit";
            this.Commit.UseVisualStyleBackColor = false;
            this.Commit.Click += new System.EventHandler(this.commit_Click);
            // 
            // record
            // 
            this.record.BackColor = System.Drawing.Color.White;
            this.record.Font = new System.Drawing.Font("Centaur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.record.Location = new System.Drawing.Point(20, 505);
            this.record.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.record.MaxLength = 1048575;
            this.record.Multiline = true;
            this.record.Name = "record";
            this.record.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.record.Size = new System.Drawing.Size(914, 354);
            this.record.TabIndex = 4;
            // 
            // EndGame
            // 
            this.EndGame.BackColor = System.Drawing.Color.Silver;
            this.EndGame.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.EndGame.Font = new System.Drawing.Font("Centaur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndGame.Location = new System.Drawing.Point(384, 20);
            this.EndGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EndGame.Name = "EndGame";
            this.EndGame.Size = new System.Drawing.Size(198, 63);
            this.EndGame.TabIndex = 0;
            this.EndGame.Text = "End";
            this.EndGame.UseCompatibleTextRendering = true;
            this.EndGame.UseVisualStyleBackColor = false;
            this.EndGame.Click += new System.EventHandler(this.EndGame_Click);
            // 
            // StartGame
            // 
            this.StartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.StartGame.Font = new System.Drawing.Font("Centaur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGame.Location = new System.Drawing.Point(55, 20);
            this.StartGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(198, 63);
            this.StartGame.TabIndex = 0;
            this.StartGame.Text = "Start";
            this.StartGame.UseCompatibleTextRendering = true;
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // TimeBar
            // 
            this.TimeBar.Location = new System.Drawing.Point(26, 417);
            this.TimeBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TimeBar.Maximum = 60;
            this.TimeBar.Name = "TimeBar";
            this.TimeBar.Size = new System.Drawing.Size(910, 38);
            this.TimeBar.Step = 1;
            this.TimeBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.TimeBar.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Centaur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 376);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "60s counting down";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_tick);
            // 
            // WordGame
            // 
            this.AcceptButton = this.Commit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.EndGame;
            this.ClientSize = new System.Drawing.Size(956, 645);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TimeBar);
            this.Controls.Add(this.record);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.log);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CompAns);
            this.Controls.Add(this.PlayerAns);
            this.Controls.Add(this.Tips);
            this.Controls.Add(this.Commit);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.EndGame);
            this.Controls.Add(this.StartGame);
            this.Font = new System.Drawing.Font("Centaur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WordGame";
            this.Text = "WordGame";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Help_Click);
            this.Load += new System.EventHandler(this.WordGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tips;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.TextBox PlayerAns;
        private System.Windows.Forms.TextBox CompAns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.Button Commit;
        private System.Windows.Forms.TextBox record;
        private System.Windows.Forms.Button EndGame;
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.ProgressBar TimeBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
    }
}

