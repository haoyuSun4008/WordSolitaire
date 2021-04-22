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
            this.SuspendLayout();
            // 
            // Tips
            // 
            this.Tips.BackColor = System.Drawing.Color.White;
            this.Tips.Font = new System.Drawing.Font("Consolas", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tips.Location = new System.Drawing.Point(15, 108);
            this.Tips.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tips.Multiline = true;
            this.Tips.Name = "Tips";
            this.Tips.Size = new System.Drawing.Size(666, 75);
            this.Tips.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(18, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "tips";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(18, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 35);
            this.label5.TabIndex = 3;
            this.label5.Text = "history log";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(369, 196);
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
            this.PlayerAns.Location = new System.Drawing.Point(369, 236);
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
            this.CompAns.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompAns.Location = new System.Drawing.Point(19, 236);
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
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(15, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = " computer ";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // Test
            // 
            this.Test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Test.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test.Location = new System.Drawing.Point(513, 15);
            this.Test.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(144, 48);
            this.Test.TabIndex = 0;
            this.Test.Text = "Test";
            this.Test.UseCompatibleTextRendering = true;
            this.Test.UseVisualStyleBackColor = false;
            this.Test.Click += new System.EventHandler(this.button1_Click);
            // 
            // Commit
            // 
            this.Commit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Commit.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Commit.Location = new System.Drawing.Point(510, 190);
            this.Commit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Commit.Name = "Commit";
            this.Commit.Size = new System.Drawing.Size(144, 37);
            this.Commit.TabIndex = 0;
            this.Commit.Text = "Commit";
            this.Commit.UseVisualStyleBackColor = false;
            this.Commit.Click += new System.EventHandler(this.commit_Click);
            // 
            // record
            // 
            this.record.BackColor = System.Drawing.Color.White;
            this.record.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.record.Location = new System.Drawing.Point(15, 389);
            this.record.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.record.MaxLength = 1048575;
            this.record.Multiline = true;
            this.record.Name = "record";
            this.record.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.record.Size = new System.Drawing.Size(666, 152);
            this.record.TabIndex = 4;
            // 
            // EndGame
            // 
            this.EndGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EndGame.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.EndGame.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndGame.Location = new System.Drawing.Point(279, 15);
            this.EndGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EndGame.Name = "EndGame";
            this.EndGame.Size = new System.Drawing.Size(144, 48);
            this.EndGame.TabIndex = 0;
            this.EndGame.Text = "End";
            this.EndGame.UseCompatibleTextRendering = true;
            this.EndGame.UseVisualStyleBackColor = false;
            this.EndGame.Click += new System.EventHandler(this.EndGame_Click);
            // 
            // StartGame
            // 
            this.StartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.StartGame.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGame.Location = new System.Drawing.Point(40, 15);
            this.StartGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(144, 48);
            this.StartGame.TabIndex = 0;
            this.StartGame.Text = "Start";
            this.StartGame.UseCompatibleTextRendering = true;
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // TimeBar
            // 
            this.TimeBar.Location = new System.Drawing.Point(19, 317);
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
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(15, 281);
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
            this.timervalue.Location = new System.Drawing.Point(617, 279);
            this.timervalue.Name = "timervalue";
            this.timervalue.ReadOnly = true;
            this.timervalue.Size = new System.Drawing.Size(37, 34);
            this.timervalue.TabIndex = 7;
            this.timervalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WordGame
            // 
            this.AcceptButton = this.Commit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CancelButton = this.EndGame;
            this.ClientSize = new System.Drawing.Size(695, 554);
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
            this.Text = "WordGame";
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
    }
}

