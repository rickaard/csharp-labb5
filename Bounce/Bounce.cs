using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Bounce
{
    public partial class Bounce : Form
    {
        private int amountLeft;
        private double randomWind;
        int points;
        int highscore;
        private bool running;
        Ball b1;
        BackgroundWorker worker;
        private delegate void MoveBallCallback(Ball b);
        private delegate void SetScoreCallback(int newScore);
        private delegate void SetStartingPosition();
        private delegate void SetResetGame();

        private void GetHighScore()
        {
            // Metod som försöker öppna textfilen med highscore
            // Om det finns så sätts variabeln highscore till värdet
            // Om filen ej finns så sätts highscore till 0
            // Skrivs sedanut till highscoreLabel
            try
            {
                using (StreamReader sr = File.OpenText(@"highscore.txt"))
                {
                    string fromFile = sr.ReadLine();
                    highscore = int.Parse(fromFile);
                }
            } catch (IOException)
            {
                highscore = 0;
            }

            highscoreLabel.Text = "Nuvarande highscore: " + highscore;
        }

        public Bounce()
        {

            InitializeComponent();


            pointsLabel.Text = "Poäng: " + points; // Skriv ut points till label
            amountLeft = 5; // Börja med 5 som antal bollar att skjuta
            amountLeftNumber.Text = Convert.ToString(amountLeft);

            Ball.gravity = (double)gravityUpDown.Value;
            Ball.easyWind = true;

            b1 = new Ball(Image.FromFile("Resources/football.png"));
            panel.Controls.Add(b1);
            b1.BringToFront();
            b1.Location = new Point(30, 170);

            randomWind = b1.GetRandomWind(); // Få ett random vindvärde
            windLabel.Text = getWindInHumanText(randomWind); // Skriv ut akutell vind till label


            b1.speedX = 9;
            b1.speedY = 0;


            running = false; // Vid start sätt running till false
            GetHighScore(); // Anropar metoden GetHighScore
            b1.Start();


        }

        private string getWindInHumanText (double wind)
        {
            // Metod som tar det randomiserade vindvärdet och avrundar till 2 decimaler
            // Skriver om det är mot- eller medvind
            string windString;
            var convertedWind = Math.Round(wind, 2); // Avrundar wind till 2 decimaler 
            if (convertedWind > 0) windString = "Akutell vind: " + convertedWind + " motvind";
            else windString = "Aktuell vind: " + convertedWind + " medvind";

            return windString;
        }

        private void startingPosition()
        {
            // Flyttar tillbaka bollen till startposition
            // Och får ny random vind
            randomWind = b1.GetRandomWind();
            windLabel.Text = getWindInHumanText(randomWind);
            b1.speedX = 9;
            b1.Location = new Point(30, 170);
            running = false;

            b1.Start();
        }


        public void resetGame()
        {
            // Återställer värden till ursrpung
            // Sätter antal bollar till värde beroende på svårighetsgrad som är vald
            if (Ball.easyWind) amountLeft = 5;
            else if (!Ball.easyWind) amountLeft = 3;

            randomWind = b1.GetRandomWind();
            amountLeftNumber.Text = Convert.ToString(amountLeft);
            points = 0;
            pointsLabel.Text = "Poäng: " + points;
            highscoreLabel.Text = "Nuvarande highscore: " + highscore;
            startingPosition();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (amountLeft == 0) return; // Om man inte har några bollar kvar att kasta så kan man ej trycka på Skjut-knappen
            if (running) return; // Går inte att trycka på skjutknappen om en boll är i "luften"
            b1.speedY = -Convert.ToDouble(speedUpDown.Value);
            amountLeft -= 1;

            amountLeftNumber.Text = Convert.ToString(amountLeft);
            running = true;

            // Följande kodrader gör så att metoden RunMe körs i en separat tråd
            // så att det inte påverkar applikationens flöde.
            worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(RunMe); // knyt metoden RunMe till worker
            worker.RunWorkerAsync(); // starta
        }

        private void showResult()
        {
            // Metod som körs vid slut på spel
            // Om ens poäng är större än nuvarande highscore så skrivs det till textfilen
            if (points > highscore)
            {
                highscore = points;
                MessageBox.Show("Grattis! Nytt highscore!");
                using (StreamWriter sr = new StreamWriter("highscore.txt", false))
                {
                    sr.Write(highscore);
                    sr.Close();
                }
            }

            // Ens resultat visas upp
            // Och man blir förfrågad om man vill starta om
            DialogResult resultBox = MessageBox.Show("Antal poäng: " + points + "\nNuvarande highscore: " + highscore + "\n\nVill du starta om spelet?", "Resultat", MessageBoxButtons.YesNo);
            if (resultBox == DialogResult.Yes)
            {
                if (Ball.easyWind)
                    amountLeft = 5;
                else
                    amountLeft = 3;
                this.Invoke(new SetResetGame(resetGame));

            }
        }

        void setScore (int newScore)
        {
            // Uppdaterar ens poäng med medskickat värde
            // Och uppdaterar poäng-labeln
            points += newScore;
            pointsLabel.Text = $"Poäng: {points}";
        }

        public void RunMe(object sender, DoWorkEventArgs e)
        {

            while (running)
            {
                if (b1.speedY > 0 && b1.Location.Y > panel.Size.Height - b1.Size.Height)
                {
                    if (amountLeft == 0) showResult(); // Om man inte har några fler bollar kvar att skjuta så anropas showResult-metoden
                    this.Invoke(new SetStartingPosition(startingPosition)); // Anropa metoden startingPosition
                }

                // Om Ball.speedX är större än 0 (i.e färdas till höger)
                // Och Bollens X-location är större än högra väggen (i.e träffar högra väggen)
                if (b1.speedX > 0 && b1.Location.X > panel.Size.Width - b1.Size.Width)
                {
                    this.Invoke(new SetScoreCallback(setScore), 1); // Ge 1 poäng om man träffar högra väggen

                    // Om bollens Y-position är inom 145-275 (i.e är inom målet)
                    if (b1.Location.Y > 145 && b1.Location.Y < 275)
                    {

                        if (Ball.easyWind)
                        {
                            this.Invoke(new SetScoreCallback(setScore), 2); // Ge 2 poäng extra om det är inom målet, vid lätt svårighetsgrad
                        }
                        else
                        {
                            this.Invoke(new SetScoreCallback(setScore), 3); // Ge 3 poäng extra om det är inom målet, vid svår svårighetsgrad
                        }
                            
                    }

                    this.Invoke(new SetStartingPosition(startingPosition));
                    if (amountLeft == 0) showResult();


                }
                if (b1.speedX < 0 && b1.Location.X < 0)
                {
                    if (amountLeft == 0) showResult();
                    this.Invoke(new SetStartingPosition(startingPosition));
                }

                b1.speedX -= 0.01 * randomWind;
                this.Invoke(new MoveBallCallback(MoveBall), b1);
                Thread.Sleep(10);
            }

        }

        void MoveBall(Ball b)
        {
            b.MoveBall();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogForm dialogForm = new dialogForm();
            dialogForm.Owner = this;
            dialogForm.ShowDialog();
            if (dialogForm.DialogResult == DialogResult.OK)
            {
                // Om man har tryckt på OK i inställning-dialogen så anropas metoden resetGame som resetar spelet
                resetGame();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string aboutMsg = 
                "Skjut bollen i mål!\n\n" +
                "Vid lätt svårighetsgrad: 2 poäng per träff i mål\n" +
                "Vid svår svråghetsgrad: 1 poäng per  träff i mål\n\n" +
                "Ändra svårighetsgrad under Meny - Inställningar.";
            MessageBox.Show(aboutMsg, "Om", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gravityUpDown_ValueChanged(object sender, EventArgs e)
        {
            Ball.gravity = (double)gravityUpDown.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void restartGameButton_Click(object sender, EventArgs e)
        {
            resetGame();
        }
    }
}
