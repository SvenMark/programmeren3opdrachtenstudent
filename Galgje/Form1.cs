using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galgje
{
    public partial class Form1 : Form
    {
        private Label[] labels;
        private Hangman hangman;
        private WordManager wm;

        public Form1()
        {
            InitializeComponent();

            wm = new WordManager();
            StartNewGame();
        }

        private void StartNewGame() {
            //Random r = new Random();
            //string word = wm.GetWord(r.Next(6, 12));            
            //hangman = new Hangman(word, maxTurns: 11);
            //string wordForDisplay = hangman.GetWordForDisplay();
            //CreateLetters(hangman.GetWordForDisplay());
            //Refresh(); //om repaint te triggeren
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //bool result = hangman.Guess(inputTextbox.Text[0]);
            //if (result)
            //{
            //    button1.BackColor = Color.Green;
            //}
            //else
            //{
            //    button1.BackColor = Color.Red;
            //}
            //inputTextbox.Text = "";
            //inputTextbox.Focus();


            //UpdateLabels(hangman.GetWordForDisplay());
            //Refresh(); //om repaint te triggeren

            //if (hangman.Won())
            //{
            //    MessageBox.Show("Je hebt gewonnen!");
            //    StartNewGame();
            //}
            //else if (hangman.Lose())
            //{
            //    MessageBox.Show("Je hebt verloren!");
            //    StartNewGame();
            //}
        }

        private void UpdateLabels(string word)
        {            
            for (int i = 0; i < word.Length; i++)
            {
                labels[i].Text = word[i].ToString();
            }
        }

        private void CreateLetters(string word)
        {
            if (labels != null)
            {
                foreach (Label l in labels)
                {
                    Controls.Remove(l);
                }
            }

            int xOffset = 56;
            int xStart = 18;

            labels = new Label[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                Label label = new Label();
                label.AutoSize = true;
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.Size = new System.Drawing.Size(48, 46);

                label.Location = new System.Drawing.Point(xOffset * i + xStart, 18);
                label.Name = "label " + i;
                label.Text = word[i].ToString();

                labels[i] = label;

                this.Controls.Add(label);
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //hangManImages.Draw(e.Graphics, 100, 150, hangman.TurnNumber);
        }
    }
}
