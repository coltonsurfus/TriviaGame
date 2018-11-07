namespace TriviaGame
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.firstAnswerRadBtn = new System.Windows.Forms.RadioButton();
            this.secondAnswerRadBtn = new System.Windows.Forms.RadioButton();
            this.guessButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.testLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(12, 81);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(331, 31);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "Hit start to begin the game";
            // 
            // firstAnswerRadBtn
            // 
            this.firstAnswerRadBtn.AutoSize = true;
            this.firstAnswerRadBtn.Location = new System.Drawing.Point(121, 154);
            this.firstAnswerRadBtn.Name = "firstAnswerRadBtn";
            this.firstAnswerRadBtn.Size = new System.Drawing.Size(14, 13);
            this.firstAnswerRadBtn.TabIndex = 2;
            this.firstAnswerRadBtn.TabStop = true;
            this.firstAnswerRadBtn.UseVisualStyleBackColor = true;
            // 
            // secondAnswerRadBtn
            // 
            this.secondAnswerRadBtn.AutoSize = true;
            this.secondAnswerRadBtn.Location = new System.Drawing.Point(121, 192);
            this.secondAnswerRadBtn.Name = "secondAnswerRadBtn";
            this.secondAnswerRadBtn.Size = new System.Drawing.Size(14, 13);
            this.secondAnswerRadBtn.TabIndex = 3;
            this.secondAnswerRadBtn.TabStop = true;
            this.secondAnswerRadBtn.UseVisualStyleBackColor = true;
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(133, 263);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(75, 23);
            this.guessButton.TabIndex = 4;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(62, 339);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 24);
            this.resultLabel.TabIndex = 5;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(226, 12);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 25);
            this.scoreLabel.TabIndex = 6;
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(118, 415);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(0, 13);
            this.testLabel.TabIndex = 7;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(332, 339);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 31);
            this.timerLabel.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.secondAnswerRadBtn);
            this.Controls.Add(this.firstAnswerRadBtn);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Trivia Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.RadioButton firstAnswerRadBtn;
        private System.Windows.Forms.RadioButton secondAnswerRadBtn;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

