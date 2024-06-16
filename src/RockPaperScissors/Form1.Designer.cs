namespace RockPaperScissors
{
    partial class RockPaperScissorsForm
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
            components = new System.ComponentModel.Container();
            rockButton = new Button();
            paperButton = new Button();
            scissorsButton = new Button();
            compPickImg = new PictureBox();
            secondsLabel = new Label();
            roundsLabel = new Label();
            youLabel = new Label();
            cpuLabel = new Label();
            playerPointsLabel = new Label();
            compPointsLabel = new Label();
            pickTimer = new System.Windows.Forms.Timer(components);
            playerPickImg = new PictureBox();
            restartButton = new Button();
            label1 = new Label();
            label2 = new Label();
            winsLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)compPickImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerPickImg).BeginInit();
            SuspendLayout();
            // 
            // rockButton
            // 
            rockButton.BackColor = SystemColors.ActiveCaption;
            rockButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            rockButton.Location = new Point(131, 160);
            rockButton.Margin = new Padding(1, 2, 1, 2);
            rockButton.Name = "rockButton";
            rockButton.Size = new Size(213, 62);
            rockButton.TabIndex = 0;
            rockButton.Text = "Rock";
            rockButton.UseVisualStyleBackColor = false;
            rockButton.Click += rockButton_Click;
            // 
            // paperButton
            // 
            paperButton.BackColor = SystemColors.ActiveCaption;
            paperButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            paperButton.Location = new Point(131, 292);
            paperButton.Margin = new Padding(1, 2, 1, 2);
            paperButton.Name = "paperButton";
            paperButton.Size = new Size(213, 62);
            paperButton.TabIndex = 1;
            paperButton.Text = "Paper";
            paperButton.UseVisualStyleBackColor = false;
            paperButton.Click += paperButton_Click;
            // 
            // scissorsButton
            // 
            scissorsButton.BackColor = SystemColors.ActiveCaption;
            scissorsButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            scissorsButton.Location = new Point(131, 425);
            scissorsButton.Margin = new Padding(1, 2, 1, 2);
            scissorsButton.Name = "scissorsButton";
            scissorsButton.Size = new Size(213, 62);
            scissorsButton.TabIndex = 4;
            scissorsButton.Text = "Scissors";
            scissorsButton.UseVisualStyleBackColor = false;
            scissorsButton.Click += scissorsButton_Click;
            // 
            // compPickImg
            // 
            compPickImg.Image = Properties.Resources.qq;
            compPickImg.Location = new Point(1059, 137);
            compPickImg.Margin = new Padding(1, 2, 1, 2);
            compPickImg.Name = "compPickImg";
            compPickImg.Size = new Size(329, 305);
            compPickImg.SizeMode = PictureBoxSizeMode.Zoom;
            compPickImg.TabIndex = 6;
            compPickImg.TabStop = false;
            // 
            // secondsLabel
            // 
            secondsLabel.AutoSize = true;
            secondsLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            secondsLabel.Location = new Point(920, 263);
            secondsLabel.Margin = new Padding(1, 0, 1, 0);
            secondsLabel.Name = "secondsLabel";
            secondsLabel.Size = new Size(54, 65);
            secondsLabel.TabIndex = 7;
            secondsLabel.Text = "5";
            // 
            // roundsLabel
            // 
            roundsLabel.AutoSize = true;
            roundsLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            roundsLabel.Location = new Point(813, 608);
            roundsLabel.Margin = new Padding(1, 0, 1, 0);
            roundsLabel.Name = "roundsLabel";
            roundsLabel.Size = new Size(54, 65);
            roundsLabel.TabIndex = 8;
            roundsLabel.Text = "5";
            // 
            // youLabel
            // 
            youLabel.AutoSize = true;
            youLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            youLabel.Location = new Point(654, 82);
            youLabel.Margin = new Padding(1, 0, 1, 0);
            youLabel.Name = "youLabel";
            youLabel.Size = new Size(67, 41);
            youLabel.TabIndex = 10;
            youLabel.Text = "You";
            // 
            // cpuLabel
            // 
            cpuLabel.AutoSize = true;
            cpuLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cpuLabel.Location = new Point(1194, 82);
            cpuLabel.Margin = new Padding(1, 0, 1, 0);
            cpuLabel.Name = "cpuLabel";
            cpuLabel.Size = new Size(54, 41);
            cpuLabel.TabIndex = 11;
            cpuLabel.Text = "PC";
            // 
            // playerPointsLabel
            // 
            playerPointsLabel.AutoSize = true;
            playerPointsLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            playerPointsLabel.Location = new Point(654, 454);
            playerPointsLabel.Margin = new Padding(1, 0, 1, 0);
            playerPointsLabel.Name = "playerPointsLabel";
            playerPointsLabel.Size = new Size(54, 65);
            playerPointsLabel.TabIndex = 12;
            playerPointsLabel.Text = "0";
            // 
            // compPointsLabel
            // 
            compPointsLabel.AutoSize = true;
            compPointsLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            compPointsLabel.Location = new Point(1194, 454);
            compPointsLabel.Margin = new Padding(1, 0, 1, 0);
            compPointsLabel.Name = "compPointsLabel";
            compPointsLabel.Size = new Size(54, 65);
            compPointsLabel.TabIndex = 13;
            compPointsLabel.Text = "0";
            // 
            // pickTimer
            // 
            pickTimer.Interval = 1000;
            pickTimer.Tick += timer1_Tick;
            // 
            // playerPickImg
            // 
            playerPickImg.Image = Properties.Resources.qq;
            playerPickImg.Location = new Point(526, 137);
            playerPickImg.Margin = new Padding(1, 2, 1, 2);
            playerPickImg.Name = "playerPickImg";
            playerPickImg.Size = new Size(330, 305);
            playerPickImg.SizeMode = PictureBoxSizeMode.Zoom;
            playerPickImg.TabIndex = 14;
            playerPickImg.TabStop = false;
            // 
            // restartButton
            // 
            restartButton.BackColor = Color.Aqua;
            restartButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            restartButton.Location = new Point(101, 561);
            restartButton.Margin = new Padding(1, 2, 1, 2);
            restartButton.Name = "restartButton";
            restartButton.Size = new Size(270, 112);
            restartButton.TabIndex = 17;
            restartButton.Text = "Restart";
            restartButton.UseVisualStyleBackColor = false;
            restartButton.Click += restartButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(546, 608);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(277, 65);
            label1.TabIndex = 18;
            label1.Text = "Rounds left:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1078, 608);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 65);
            label2.TabIndex = 20;
            label2.Text = "Wins:";
            // 
            // winsLabel
            // 
            winsLabel.AutoSize = true;
            winsLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            winsLabel.Location = new Point(1219, 608);
            winsLabel.Margin = new Padding(1, 0, 1, 0);
            winsLabel.Name = "winsLabel";
            winsLabel.Size = new Size(54, 65);
            winsLabel.TabIndex = 19;
            winsLabel.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(694, 475);
            label3.Name = "label3";
            label3.Size = new Size(93, 38);
            label3.TabIndex = 21;
            label3.Text = "points";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1237, 475);
            label4.Name = "label4";
            label4.Size = new Size(93, 38);
            label4.TabIndex = 22;
            label4.Text = "points";
            // 
            // RockPaperScissorsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1451, 723);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(winsLabel);
            Controls.Add(label1);
            Controls.Add(restartButton);
            Controls.Add(playerPickImg);
            Controls.Add(compPointsLabel);
            Controls.Add(playerPointsLabel);
            Controls.Add(cpuLabel);
            Controls.Add(youLabel);
            Controls.Add(roundsLabel);
            Controls.Add(secondsLabel);
            Controls.Add(compPickImg);
            Controls.Add(scissorsButton);
            Controls.Add(paperButton);
            Controls.Add(rockButton);
            Margin = new Padding(1, 2, 1, 2);
            Name = "RockPaperScissorsForm";
            Text = "RockPaperScissors";
            ((System.ComponentModel.ISupportInitialize)compPickImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerPickImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button rockButton;
        private Button paperButton;
        private Button scissorsButton;
        private PictureBox compPickImg;
        private Label secondsLabel;
        private Label roundsLabel;
        private Label youLabel;
        private Label cpuLabel;
        private Label playerPointsLabel;
        private Label compPointsLabel;
        private System.Windows.Forms.Timer pickTimer;
        private PictureBox playerPickImg;
        private Button restartButton;
        private Label label1;
        private Label label2;
        private Label winsLabel;
        private Label label3;
        private Label label4;
    }
}