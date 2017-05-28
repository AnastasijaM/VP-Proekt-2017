using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Proekt_Besilka
{
    public partial class PlayGame : Form
    {
        private string wordToGuess;
        private Category selectedCategory;
        Label[] labelsLetters;
        public int points { get; set; }
        private int misses;
        private Graphics g;
        private bool isLost;

        public PlayGame(Form1 form)
        {
            InitializeComponent();
            DoubleBuffered = true;
            g = panel1.CreateGraphics();
            Form1 homeWindow = form;
            isLost = false;
            selectedCategory = homeWindow.selectedCategory;
           
                wordToGuess = homeWindow.newGame.GetWordFromCategory(selectedCategory).Word.ToUpper();
                int wordLength = wordToGuess.Length;
                labelsLetters = new Label[wordLength];
                points = 0;
                for (int i = 0; i < wordLength; i++)
                {
                    labelsLetters[i] = new Label
                    {
                        Text = "- ",
                        Width = 30,
                        Height = 30,
                        Font = new Font("Comic Sans MS", 14)
                    };
                    flowLayoutPanel1.Controls.Add(labelsLetters[i]);
                }

            
            misses = 0;
            labelCategory.Text = selectedCategory.Name;
           
        }

        protected void guessLetter(Button buttonLetter)
        {
           
            char letterSuggestion = buttonLetter.Text[0];
            List<int> positions = findCharInWord(letterSuggestion);
            if (positions.Count > 0)
            {
                foreach (int position in positions)
                {
                    labelsLetters[position].Text = wordToGuess[position].ToString();
                    points += 5;
                }

            }
            else
            {
                ++misses;
                drawMiss(misses);
                points -= 1;
            }
            buttonLetter.Enabled = false;
            LostGame();
            if (isLost== false && IsWholeWordGuesed())
            {
                CongratsForm cf = new CongratsForm(points);
                cf.ShowDialog();
                this.Close();
            }
            

        }

        private void drawMiss(int miss)
        {
            Pen pen = new Pen(Color.White, 3);
            if (miss == 1)
            {
                //draw head
                g.DrawEllipse(pen, 25, 25, 75, 75);
            }
            if (miss == 2)
            {
                //draw body
                g.DrawLine(pen, 60, 92, 60, 182);
            }
            if (miss == 3)
            {
                //draw one leg
                g.DrawLine(pen, 60, 180, 35, 220);
            }
            if (miss == 4)
            {
                //draw other leg
                g.DrawLine(pen, 60, 180, 85, 220);
            }
            if (miss == 5)
            {
                //draw one arm
                g.DrawLine(pen, 60, 140, 30, 100);
            }
            if (miss == 6)
            {
                //draw other arm
                g.DrawLine(pen, 60, 140, 90, 100);
            }
            
            pen.Dispose();
        }

        protected List<int> findCharInWord(char letter)
        {
            //returns positions of the character in the word

            List<int> resultIndexes = new List<int>();

            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (wordToGuess[i] == letter)
                {
                    resultIndexes.Add(i);
                }
            }

            return resultIndexes;
        }

        private void buttonА_Click(object sender, EventArgs e)
        {
            guessLetter(buttonA);
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            guessLetter(buttonB);
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            guessLetter(buttonV);
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            guessLetter(buttonG);
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            guessLetter(buttonD);
        }

        private void buttonGj_Click(object sender, EventArgs e)
        {
            guessLetter(buttonGj);
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            guessLetter(buttonE);
        }

        private void buttonZh_Click(object sender, EventArgs e)
        {
            guessLetter(buttonZh);
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            guessLetter(buttonZ);
        }

        private void buttonDz_Click(object sender, EventArgs e)
        {
            guessLetter(buttonDz);
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            guessLetter(buttonI);
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            guessLetter(buttonJ);
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            guessLetter(buttonK);
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            guessLetter(buttonL);
        }

        private void buttonLj_Click(object sender, EventArgs e)
        {
            guessLetter(buttonLj);
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            guessLetter(buttonM);
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            guessLetter(buttonN);
        }

        private void buttonNj_Click(object sender, EventArgs e)
        {
            guessLetter(buttonNj);
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            guessLetter(buttonO);
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            guessLetter(buttonP);
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            guessLetter(buttonR);
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            guessLetter(buttonS);
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            guessLetter(buttonT);
        }

        private void buttonKj_Click(object sender, EventArgs e)
        {
            guessLetter(buttonKj);
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            guessLetter(buttonU);
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            guessLetter(buttonF);
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            guessLetter(buttonH);
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            guessLetter(buttonC);
        }

        private void buttonCh_Click(object sender, EventArgs e)
        {
            guessLetter(buttonCh);
        }

        private void buttonJJ_Click(object sender, EventArgs e)
        {
            guessLetter(buttonJJ);
        }

        private void buttonSh_Click(object sender, EventArgs e)
        {
            guessLetter(buttonSh);
        }

        private bool IsWholeWordGuesed()
        {

            for (int i = 0; i < labelsLetters.Count(); i++)
            {
                if (labelsLetters[i].Text == "- ")
                {
                    return false;
                }
            }
            return true;
        }
        private void LostGame()
        {
            if (misses >= 6)
            {
                GameOver gameOver = new GameOver(wordToGuess);
                gameOver.ShowDialog();
                this.Close();
                isLost= true;
                
            }
            
        }

        private void PlayGame_Paint(object sender, PaintEventArgs e)
        {
            //crtnje na besilkata
            Pen pen = new Pen(Color.White,3);
            g.DrawLine(pen, 10, 10, 65, 10);
            g.DrawLine(pen, 10, 10, 10, 250);
            g.DrawLine(pen, 65, 10, 65, 30);
            pen.Dispose();
        }

        private void buttonHint_Click(object sender, EventArgs e)
        {
            List<int> nepogodeniPozicii = new List<int>();
            for (int i = 0; i < labelsLetters.Count(); i++)
            {
                if (labelsLetters[i].Text == "- ")
                {
                    nepogodeniPozicii.Add(i);
                }
            }

            Random r = new Random();
            if (nepogodeniPozicii != null)
            {
                int index = r.Next(0, nepogodeniPozicii.Count);
                int position = nepogodeniPozicii[index];
                labelsLetters[position].Text = wordToGuess[position].ToString();
                buttonHint.Enabled = false;
                points -= 5;
            }
            
        }
    }
}

