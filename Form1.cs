using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGame
{
    public partial class Form1: Form
    {
        private Game currentGame;
        private int lives = 3;

        public Form1()
        {
            InitializeComponent();
            currentGame = new WordScrambleGame("words.txt");
            LoadNewWord();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_Result.Text = "";
        }
        private void LoadNewWord()
        {
            currentGame.GenerateNewWord();
            lbl_ScrambledWord.Text = $"Karıştırılmış Kelime: {currentGame.ScrambledWord}";
            txt_Guess.Clear();
            lives = 3;
            lbl_Hint.Text = "";
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            SubmitGuess();
        }

        private void txt_Guess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SubmitGuess();
                e.SuppressKeyPress = true;
            }
        }
        private void SubmitGuess()
        {
            bool isCorrect = currentGame.CheckGuess(txt_Guess.Text);

            if (isCorrect)
            {
                lbl_Result.Text = "Doğru!";
                LoadNewWord();
            }
            else
            {
                lives--;
                if (lives == 1)
                {
                    lbl_Hint.Text = $"İpucu: Kelimenin ilk harfi '{currentGame.CurrentWord[0]}'";
                }
                if (lives > 0)
                {
                    lbl_Result.Text = $"Yanlış! Kalan can: {lives}";
                }
                else
                {
                    lbl_Result.Text = $"Can kalmadı! Kelime {currentGame.CurrentWord} idi";
                    currentGame.SubstractScoreByOne();
                    LoadNewWord();
                }
            }

            lbl_Score.Text = $"Skor: {currentGame.Score}";
        }
    }
}
