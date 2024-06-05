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
            this.components = new System.ComponentModel.Container();
            this.rockButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.scissorsButton = new System.Windows.Forms.Button();
            this.compPickImg = new System.Windows.Forms.PictureBox();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.roundsLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.youLabel = new System.Windows.Forms.Label();
            this.cpuLabel = new System.Windows.Forms.Label();
            this.playerPointsLabel = new System.Windows.Forms.Label();
            this.compPointsLabel = new System.Windows.Forms.Label();
            this.pickTimer = new System.Windows.Forms.Timer(this.components);
            this.playerPickImg = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.compPickImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPickImg)).BeginInit();
            this.SuspendLayout();
            // 
            // rockButton
            // 
            this.rockButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rockButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rockButton.Location = new System.Drawing.Point(92, 96);
            this.rockButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(149, 35);
            this.rockButton.TabIndex = 0;
            this.rockButton.Text = "Rock";
            this.rockButton.UseVisualStyleBackColor = false;
            // 
            // paperButton
            // 
            this.paperButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.paperButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paperButton.Location = new System.Drawing.Point(92, 175);
            this.paperButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(149, 35);
            this.paperButton.TabIndex = 1;
            this.paperButton.Text = "Paper";
            this.paperButton.UseVisualStyleBackColor = false;
            // 
            // scissorsButton
            // 
            this.scissorsButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.scissorsButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scissorsButton.Location = new System.Drawing.Point(92, 255);
            this.scissorsButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.scissorsButton.Name = "scissorsButton";
            this.scissorsButton.Size = new System.Drawing.Size(149, 35);
            this.scissorsButton.TabIndex = 4;
            this.scissorsButton.Text = "Scissors";
            this.scissorsButton.UseVisualStyleBackColor = false;
            // 
            // compPickImg
            // 
            this.compPickImg.Image = global::RockPaperScissors.Properties.Resources.qq;
            this.compPickImg.Location = new System.Drawing.Point(741, 82);
            this.compPickImg.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.compPickImg.Name = "compPickImg";
            this.compPickImg.Size = new System.Drawing.Size(230, 183);
            this.compPickImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.compPickImg.TabIndex = 6;
            this.compPickImg.TabStop = false;
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondsLabel.Location = new System.Drawing.Point(644, 158);
            this.secondsLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(37, 45);
            this.secondsLabel.TabIndex = 7;
            this.secondsLabel.Text = "5";
            // 
            // roundsLabel
            // 
            this.roundsLabel.AutoSize = true;
            this.roundsLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundsLabel.Location = new System.Drawing.Point(487, 352);
            this.roundsLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.roundsLabel.Name = "roundsLabel";
            this.roundsLabel.Size = new System.Drawing.Size(37, 45);
            this.roundsLabel.TabIndex = 8;
            this.roundsLabel.Text = "5";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(634, 352);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(182, 45);
            this.resultLabel.TabIndex = 9;
            this.resultLabel.Text = "You:    - PC:";
            // 
            // youLabel
            // 
            this.youLabel.AutoSize = true;
            this.youLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.youLabel.Location = new System.Drawing.Point(458, 49);
            this.youLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.youLabel.Name = "youLabel";
            this.youLabel.Size = new System.Drawing.Size(44, 28);
            this.youLabel.TabIndex = 10;
            this.youLabel.Text = "You";
            // 
            // cpuLabel
            // 
            this.cpuLabel.AutoSize = true;
            this.cpuLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpuLabel.Location = new System.Drawing.Point(836, 49);
            this.cpuLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(35, 28);
            this.cpuLabel.TabIndex = 11;
            this.cpuLabel.Text = "PC";
            // 
            // playerPointsLabel
            // 
            this.playerPointsLabel.AutoSize = true;
            this.playerPointsLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerPointsLabel.Location = new System.Drawing.Point(703, 353);
            this.playerPointsLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.playerPointsLabel.Name = "playerPointsLabel";
            this.playerPointsLabel.Size = new System.Drawing.Size(37, 45);
            this.playerPointsLabel.TabIndex = 12;
            this.playerPointsLabel.Text = "0";
            // 
            // compPointsLabel
            // 
            this.compPointsLabel.AutoSize = true;
            this.compPointsLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.compPointsLabel.Location = new System.Drawing.Point(810, 353);
            this.compPointsLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.compPointsLabel.Name = "compPointsLabel";
            this.compPointsLabel.Size = new System.Drawing.Size(37, 45);
            this.compPointsLabel.TabIndex = 13;
            this.compPointsLabel.Text = "0";
            // 
            // pickTimer
            // 
            this.pickTimer.Interval = 1000;
            // 
            // playerPickImg
            // 
            this.playerPickImg.Image = global::RockPaperScissors.Properties.Resources.qq;
            this.playerPickImg.Location = new System.Drawing.Point(368, 82);
            this.playerPickImg.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.playerPickImg.Name = "playerPickImg";
            this.playerPickImg.Size = new System.Drawing.Size(231, 183);
            this.playerPickImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerPickImg.TabIndex = 14;
            this.playerPickImg.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Chartreuse;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(29, 344);
            this.startButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(189, 67);
            this.startButton.TabIndex = 15;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.Aqua;
            this.restartButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.restartButton.Location = new System.Drawing.Point(891, 344);
            this.restartButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(189, 67);
            this.restartButton.TabIndex = 17;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(300, 352);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 45);
            this.label1.TabIndex = 18;
            this.label1.Text = "Rounds left:";
            // 
            // RockPaperScissorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1107, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.playerPickImg);
            this.Controls.Add(this.compPointsLabel);
            this.Controls.Add(this.playerPointsLabel);
            this.Controls.Add(this.cpuLabel);
            this.Controls.Add(this.youLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.roundsLabel);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.compPickImg);
            this.Controls.Add(this.scissorsButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.rockButton);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "RockPaperScissorsForm";
            this.Text = "RockPaperScissors";
            ((System.ComponentModel.ISupportInitialize)(this.compPickImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPickImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button rockButton;
        private Button paperButton;
        private Button scissorsButton;
        private PictureBox compPickImg;
        private Label secondsLabel;
        private Label roundsLabel;
        private Label resultLabel;
        private Label youLabel;
        private Label cpuLabel;
        private Label playerPointsLabel;
        private Label compPointsLabel;
        private System.Windows.Forms.Timer pickTimer;
        private PictureBox playerPickImg;
        private Button startButton;
        private Button restartButton;
        private Label label1;
    }
}