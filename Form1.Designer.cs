namespace WordGame
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
            this.lbl_ScrambledWord = new System.Windows.Forms.Label();
            this.txt_Guess = new System.Windows.Forms.TextBox();
            this.btn_Check = new System.Windows.Forms.Button();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.lbl_Hint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ScrambledWord
            // 
            this.lbl_ScrambledWord.AutoSize = true;
            this.lbl_ScrambledWord.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ScrambledWord.Location = new System.Drawing.Point(12, 41);
            this.lbl_ScrambledWord.Name = "lbl_ScrambledWord";
            this.lbl_ScrambledWord.Size = new System.Drawing.Size(293, 38);
            this.lbl_ScrambledWord.TabIndex = 0;
            this.lbl_ScrambledWord.Text = "Karıştırılmış Kelime: ";
            // 
            // txt_Guess
            // 
            this.txt_Guess.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Guess.Location = new System.Drawing.Point(184, 157);
            this.txt_Guess.Name = "txt_Guess";
            this.txt_Guess.Size = new System.Drawing.Size(417, 30);
            this.txt_Guess.TabIndex = 1;
            this.txt_Guess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Guess_KeyDown);
            // 
            // btn_Check
            // 
            this.btn_Check.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Check.Location = new System.Drawing.Point(327, 193);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(116, 23);
            this.btn_Check.TabIndex = 2;
            this.btn_Check.Text = "Kontrol Et";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Result.Location = new System.Drawing.Point(16, 92);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(46, 18);
            this.lbl_Result.TabIndex = 3;
            this.lbl_Result.Text = "label2";
            this.lbl_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.Location = new System.Drawing.Point(648, 9);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(56, 23);
            this.lbl_Score.TabIndex = 4;
            this.lbl_Score.Text = "Skor: ";
            // 
            // lbl_Hint
            // 
            this.lbl_Hint.AutoSize = true;
            this.lbl_Hint.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hint.Location = new System.Drawing.Point(16, 122);
            this.lbl_Hint.Name = "lbl_Hint";
            this.lbl_Hint.Size = new System.Drawing.Size(51, 18);
            this.lbl_Hint.TabIndex = 5;
            this.lbl_Hint.Text = "İpucu: ";
            this.lbl_Hint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 323);
            this.Controls.Add(this.lbl_Hint);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.txt_Guess);
            this.Controls.Add(this.lbl_ScrambledWord);
            this.Name = "Form1";
            this.Text = "WordGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ScrambledWord;
        private System.Windows.Forms.TextBox txt_Guess;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Label lbl_Hint;
    }
}

