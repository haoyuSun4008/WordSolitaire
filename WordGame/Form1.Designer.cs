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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.timervalue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ComputerScore = new System.Windows.Forms.Button();
            this.PlayerScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tips
            // 
            this.Tips.BackColor = System.Drawing.Color.White;
            this.Tips.Enabled = false;
            this.Tips.Font = new System.Drawing.Font("Consolas", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tips.Location = new System.Drawing.Point(15, 77);
            this.Tips.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tips.Multiline = true;
            this.Tips.Name = "Tips";
            this.Tips.ReadOnly = true;
            this.Tips.Size = new System.Drawing.Size(666, 75);
            this.Tips.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "tips";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 35);
            this.label5.TabIndex = 3;
            this.label5.Text = "history log";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(422, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = " player";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // PlayerAns
            // 
            this.PlayerAns.BackColor = System.Drawing.Color.White;
            this.PlayerAns.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerAns.Location = new System.Drawing.Point(365, 257);
            this.PlayerAns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlayerAns.Multiline = true;
            this.PlayerAns.Name = "PlayerAns";
            this.PlayerAns.Size = new System.Drawing.Size(309, 36);
            this.PlayerAns.TabIndex = 1;
            this.PlayerAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CompAns
            // 
            this.CompAns.BackColor = System.Drawing.Color.White;
            this.CompAns.Enabled = false;
            this.CompAns.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompAns.Location = new System.Drawing.Point(15, 257);
            this.CompAns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CompAns.Multiline = true;
            this.CompAns.Name = "CompAns";
            this.CompAns.ReadOnly = true;
            this.CompAns.Size = new System.Drawing.Size(311, 36);
            this.CompAns.TabIndex = 1;
            this.CompAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = " computer ";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // Test
            // 
            this.Test.BackColor = System.Drawing.Color.Transparent;
            this.Test.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Test.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test.ForeColor = System.Drawing.Color.Yellow;
            this.Test.Location = new System.Drawing.Point(537, 13);
            this.Test.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(144, 27);
            this.Test.TabIndex = 0;
            this.Test.Text = "Test";
            this.Test.UseCompatibleTextRendering = true;
            this.Test.UseVisualStyleBackColor = false;
            this.Test.Click += new System.EventHandler(this.button1_Click);
            // 
            // Commit
            // 
            this.Commit.BackColor = System.Drawing.Color.Transparent;
            this.Commit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Commit.FlatAppearance.BorderSize = 0;
            this.Commit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Commit.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Commit.ForeColor = System.Drawing.Color.Yellow;
            this.Commit.Location = new System.Drawing.Point(506, 211);
            this.Commit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Commit.Name = "Commit";
            this.Commit.Size = new System.Drawing.Size(144, 37);
            this.Commit.TabIndex = 0;
            this.Commit.Text = "Commit";
            this.Commit.UseCompatibleTextRendering = true;
            this.Commit.UseVisualStyleBackColor = false;
            this.Commit.Click += new System.EventHandler(this.commit_Click);
            // 
            // record
            // 
            this.record.BackColor = System.Drawing.Color.White;
            this.record.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.record.Location = new System.Drawing.Point(18, 415);
            this.record.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.record.MaxLength = 1048575;
            this.record.Multiline = true;
            this.record.Name = "record";
            this.record.ReadOnly = true;
            this.record.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.record.Size = new System.Drawing.Size(324, 152);
            this.record.TabIndex = 4;
            // 
            // EndGame
            // 
            this.EndGame.BackColor = System.Drawing.Color.Transparent;
            this.EndGame.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.EndGame.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.EndGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EndGame.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndGame.ForeColor = System.Drawing.Color.Yellow;
            this.EndGame.Location = new System.Drawing.Point(303, 13);
            this.EndGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EndGame.Name = "EndGame";
            this.EndGame.Size = new System.Drawing.Size(144, 27);
            this.EndGame.TabIndex = 0;
            this.EndGame.Text = "End";
            this.EndGame.UseCompatibleTextRendering = true;
            this.EndGame.UseVisualStyleBackColor = false;
            this.EndGame.Click += new System.EventHandler(this.EndGame_Click);
            // 
            // StartGame
            // 
            this.StartGame.BackColor = System.Drawing.Color.Transparent;
            this.StartGame.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.StartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartGame.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGame.ForeColor = System.Drawing.Color.Yellow;
            this.StartGame.Location = new System.Drawing.Point(64, 13);
            this.StartGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(144, 27);
            this.StartGame.TabIndex = 0;
            this.StartGame.Text = "Start";
            this.StartGame.UseCompatibleTextRendering = true;
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // TimeBar
            // 
            this.TimeBar.Location = new System.Drawing.Point(15, 343);
            this.TimeBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TimeBar.Maximum = 60;
            this.TimeBar.Name = "TimeBar";
            this.TimeBar.Size = new System.Drawing.Size(662, 29);
            this.TimeBar.Step = 1;
            this.TimeBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.TimeBar.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(584, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = " 60s counting down                                            Left Time:";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_tick);
            // 
            // timervalue
            // 
            this.timervalue.BackColor = System.Drawing.Color.White;
            this.timervalue.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timervalue.Location = new System.Drawing.Point(613, 305);
            this.timervalue.Name = "timervalue";
            this.timervalue.ReadOnly = true;
            this.timervalue.Size = new System.Drawing.Size(37, 34);
            this.timervalue.TabIndex = 7;
            this.timervalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(365, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 35);
            this.label6.TabIndex = 8;
            this.label6.Text = "Score";
            this.label6.UseCompatibleTextRendering = true;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(376, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 31);
            this.label7.TabIndex = 9;
            this.label7.Text = " computer ";
            this.label7.UseCompatibleTextRendering = true;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(565, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 31);
            this.label8.TabIndex = 10;
            this.label8.Text = " player";
            this.label8.UseCompatibleTextRendering = true;
            // 
            // ComputerScore
            // 
            this.ComputerScore.BackColor = System.Drawing.Color.Transparent;
            this.ComputerScore.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ComputerScore.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.ComputerScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComputerScore.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerScore.ForeColor = System.Drawing.Color.Yellow;
            this.ComputerScore.Location = new System.Drawing.Point(365, 446);
            this.ComputerScore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComputerScore.Name = "ComputerScore";
            this.ComputerScore.Size = new System.Drawing.Size(127, 117);
            this.ComputerScore.TabIndex = 11;
            this.ComputerScore.Text = "0";
            this.ComputerScore.UseCompatibleTextRendering = true;
            this.ComputerScore.UseVisualStyleBackColor = false;
            // 
            // PlayerScore
            // 
            this.PlayerScore.BackColor = System.Drawing.Color.Transparent;
            this.PlayerScore.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.PlayerScore.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.PlayerScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerScore.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerScore.ForeColor = System.Drawing.Color.Yellow;
            this.PlayerScore.Location = new System.Drawing.Point(537, 446);
            this.PlayerScore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.Size = new System.Drawing.Size(127, 117);
            this.PlayerScore.TabIndex = 12;
            this.PlayerScore.Text = "0";
            this.PlayerScore.UseCompatibleTextRendering = true;
            this.PlayerScore.UseVisualStyleBackColor = false;
            // 
            // WordGame
            // 
            this.AcceptButton = this.Commit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.EndGame;
            this.ClientSize = new System.Drawing.Size(693, 576);
            this.Controls.Add(this.PlayerScore);
            this.Controls.Add(this.ComputerScore);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.timervalue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TimeBar);
            this.Controls.Add(this.record);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CompAns);
            this.Controls.Add(this.PlayerAns);
            this.Controls.Add(this.Tips);
            this.Controls.Add(this.Commit);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.EndGame);
            this.Controls.Add(this.StartGame);
            this.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WordGame";
            this.Text = "Solitaire English Word";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Help_Click);
            this.Load += new System.EventHandler(this.WordGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tips;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.TextBox timervalue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ComputerScore;
        private System.Windows.Forms.Button PlayerScore;
    }
}

