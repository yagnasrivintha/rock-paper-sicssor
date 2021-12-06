
namespace rock_paper_sicssor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rockBtn = new System.Windows.Forms.Button();
            this.paperBtn = new System.Windows.Forms.Button();
            this.scissorBtn = new System.Windows.Forms.Button();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.playerLbl = new System.Windows.Forms.Label();
            this.cpuLbl = new System.Windows.Forms.Label();
            this.playerScoreLbl = new System.Windows.Forms.Label();
            this.roundLbl = new System.Windows.Forms.Label();
            this.winnerLbl = new System.Windows.Forms.Label();
            this.playerPicture = new System.Windows.Forms.PictureBox();
            this.cpuPicture = new System.Windows.Forms.PictureBox();
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            this.cpuScoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // rockBtn
            // 
            this.rockBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rockBtn.Location = new System.Drawing.Point(44, 134);
            this.rockBtn.Name = "rockBtn";
            this.rockBtn.Size = new System.Drawing.Size(74, 25);
            this.rockBtn.TabIndex = 0;
            this.rockBtn.Text = "Rock";
            this.rockBtn.UseVisualStyleBackColor = true;
            this.rockBtn.Click += new System.EventHandler(this.rockBtn_Click);
            // 
            // paperBtn
            // 
            this.paperBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paperBtn.Location = new System.Drawing.Point(44, 183);
            this.paperBtn.Name = "paperBtn";
            this.paperBtn.Size = new System.Drawing.Size(74, 25);
            this.paperBtn.TabIndex = 1;
            this.paperBtn.Text = "Paper";
            this.paperBtn.UseVisualStyleBackColor = true;
            this.paperBtn.Click += new System.EventHandler(this.paperBtn_Click);
            // 
            // scissorBtn
            // 
            this.scissorBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scissorBtn.Location = new System.Drawing.Point(44, 234);
            this.scissorBtn.Name = "scissorBtn";
            this.scissorBtn.Size = new System.Drawing.Size(74, 25);
            this.scissorBtn.TabIndex = 2;
            this.scissorBtn.Text = "Scissor";
            this.scissorBtn.UseVisualStyleBackColor = true;
            this.scissorBtn.Click += new System.EventHandler(this.scissorBtn_Click);
            // 
            // newGameBtn
            // 
            this.newGameBtn.AutoSize = true;
            this.newGameBtn.Location = new System.Drawing.Point(629, 362);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(110, 25);
            this.newGameBtn.TabIndex = 3;
            this.newGameBtn.Text = "New Game";
            this.newGameBtn.UseVisualStyleBackColor = true;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // button5
            // 
            this.button5.AllowDrop = true;
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(629, 393);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 25);
            this.button5.TabIndex = 4;
            this.button5.Text = "Close Application";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.closeApplicationBtn_Click);
            // 
            // playerLbl
            // 
            this.playerLbl.AutoSize = true;
            this.playerLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playerLbl.Location = new System.Drawing.Point(236, 71);
            this.playerLbl.Name = "playerLbl";
            this.playerLbl.Size = new System.Drawing.Size(67, 25);
            this.playerLbl.TabIndex = 6;
            this.playerLbl.Text = "Player";
            // 
            // cpuLbl
            // 
            this.cpuLbl.AutoSize = true;
            this.cpuLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cpuLbl.Location = new System.Drawing.Point(603, 71);
            this.cpuLbl.Name = "cpuLbl";
            this.cpuLbl.Size = new System.Drawing.Size(50, 25);
            this.cpuLbl.TabIndex = 6;
            this.cpuLbl.Text = "CPU";
            // 
            // playerScoreLbl
            // 
            this.playerScoreLbl.AutoSize = true;
            this.playerScoreLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playerScoreLbl.Location = new System.Drawing.Point(404, 134);
            this.playerScoreLbl.Name = "playerScoreLbl";
            this.playerScoreLbl.Size = new System.Drawing.Size(89, 25);
            this.playerScoreLbl.TabIndex = 6;
            this.playerScoreLbl.Text = "Player: 0";
            // 
            // roundLbl
            // 
            this.roundLbl.AutoSize = true;
            this.roundLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundLbl.Location = new System.Drawing.Point(413, 310);
            this.roundLbl.Name = "roundLbl";
            this.roundLbl.Size = new System.Drawing.Size(93, 25);
            this.roundLbl.TabIndex = 6;
            this.roundLbl.Text = "Round: 3";
            // 
            // winnerLbl
            // 
            this.winnerLbl.AutoSize = true;
            this.winnerLbl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.winnerLbl.Location = new System.Drawing.Point(234, 374);
            this.winnerLbl.Name = "winnerLbl";
            this.winnerLbl.Size = new System.Drawing.Size(202, 37);
            this.winnerLbl.TabIndex = 6;
            this.winnerLbl.Text = "PLAYER WINS!";
            // 
            // playerPicture
            // 
            this.playerPicture.BackgroundImage = global::rock_paper_sicssor.Properties.Resources.qq;
            this.playerPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerPicture.Location = new System.Drawing.Point(169, 106);
            this.playerPicture.Name = "playerPicture";
            this.playerPicture.Size = new System.Drawing.Size(191, 164);
            this.playerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPicture.TabIndex = 7;
            this.playerPicture.TabStop = false;
            // 
            // cpuPicture
            // 
            this.cpuPicture.BackgroundImage = global::rock_paper_sicssor.Properties.Resources.qq;
            this.cpuPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cpuPicture.Location = new System.Drawing.Point(538, 106);
            this.cpuPicture.Name = "cpuPicture";
            this.cpuPicture.Size = new System.Drawing.Size(191, 164);
            this.cpuPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cpuPicture.TabIndex = 7;
            this.cpuPicture.TabStop = false;
            // 
            // countDownTimer
            // 
            this.countDownTimer.Interval = 1000;
            this.countDownTimer.Tick += new System.EventHandler(this.countDownTimer_Tick);
            // 
            // cpuScoreLabel
            // 
            this.cpuScoreLabel.AutoSize = true;
            this.cpuScoreLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cpuScoreLabel.Location = new System.Drawing.Point(413, 202);
            this.cpuScoreLabel.Name = "cpuScoreLabel";
            this.cpuScoreLabel.Size = new System.Drawing.Size(71, 25);
            this.cpuScoreLabel.TabIndex = 6;
            this.cpuScoreLabel.Text = "CPU: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cpuPicture);
            this.Controls.Add(this.playerPicture);
            this.Controls.Add(this.cpuLbl);
            this.Controls.Add(this.winnerLbl);
            this.Controls.Add(this.roundLbl);
            this.Controls.Add(this.cpuScoreLabel);
            this.Controls.Add(this.playerScoreLbl);
            this.Controls.Add(this.playerLbl);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.newGameBtn);
            this.Controls.Add(this.scissorBtn);
            this.Controls.Add(this.paperBtn);
            this.Controls.Add(this.rockBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rockBtn;
        private System.Windows.Forms.Button paperBtn;
        private System.Windows.Forms.Button scissorBtn;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label playerLbl;
        private System.Windows.Forms.Label cpuLbl;
        private System.Windows.Forms.Label playerScoreLbl;
        private System.Windows.Forms.Label roundLbl;
        private System.Windows.Forms.Label winnerLbl;
        private System.Windows.Forms.PictureBox playerPicture;
        private System.Windows.Forms.PictureBox cpuPicture;
        private System.Windows.Forms.Timer countDownTimer;
        private System.Windows.Forms.Label countDownLbl;
        private System.Windows.Forms.Label cpuScoreLabel;
    }
}

