using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Bounce
{
    public partial class Bounce : Form
    {
        int points;
        private bool running;
        Ball b1;
        BackgroundWorker worker;
        private delegate void MoveBallCallback(Ball b);
        public Bounce()
        {

            InitializeComponent();
            Ball.gravity = (double)gravityUpDown.Value;
            Ball.easyWind = true;

            // FromFile kräver att man ställer in filerna i Projektet att Copy to Output Directory.
            // högerklicka bilderna / Properties 
            b1 = new Ball(Image.FromFile("Resources/football.png"));

            panel.Controls.Add(b1);
            b1.BringToFront();
            b1.Location = new Point(30, 170);
            Ball.speedX = (double)speedUpDown.Value;

            
            Ball.speedY = b1.GetRandomWind(); // Sätt speedY till random vind
            windLabel.Text = getWindInHumanText(Ball.speedY); // och skriv ut till label
            pointsLabel.Text = "Poäng: " + points; // Skriv ut points till label

            running = false; // Vid start sätt running till false
            b1.Start();

            amountLeftNumber.Text = Convert.ToString(Ball.AmountLeft);
        }

        private string getWindInHumanText (double wind)
        {
            var convertedWind = Convert.ToString(Math.Round(wind, 2)); // Avrundar wind till 2 decimaler och konverterar till string
            return "Aktuell vind: " + convertedWind; 
        }

        private void startingPosition()
        {
            // Sätt speedY till ny random vind och skriv ut till label
            // Flyttar tillbaka bollen till startposition
            Ball.speedY = b1.GetRandomWind();
            windLabel.Text = getWindInHumanText(Ball.speedY);

            b1.Location = new Point(30, 170);
            running = false;

            b1.Start();
        }


        public void resetGame()
        {
            // Återställer värden till ursrpung
            // Sätter antal bollar till värde beroende på svårighetsgrad som är vald
            if (Ball.easyWind) Ball.AmountLeft = 5;
            else if (!Ball.easyWind) Ball.AmountLeft = 3;


            amountLeftNumber.Text = Convert.ToString(Ball.AmountLeft);
            points = 0;
            pointsLabel.Text = "Poäng: " + points;
            startingPosition();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            /*
             * En eventlyssnare som anropas vid klick på goButton
             * En koll görs om running är satt till true;
             * Om den är true så återställs allt till hur det är från början och running sätts till false
             * 
             * Om den inte är true så sätts running till true och spelet börjar köras. 
            */
            if (Ball.AmountLeft == 0) return;

            Ball.AmountLeft -= 1;
            amountLeftNumber.Text = Convert.ToString(Ball.AmountLeft);
            if (running == true)
            {
                startingPosition();
                return;
            }
            
            running = true;

            // Följande kodrader gör så att metoden RunMe körs i en separat tråd
            // så att det inte påverkar applikationens flöde.
            worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(RunMe); // knyt metoden RunMe till worker
            worker.RunWorkerAsync(); // starta
        }

        private void showResult()
        {
            DialogResult resultBox = MessageBox.Show("Antal poäng: " + points + "\n\nVill du starta om spelet?", "Resultat", MessageBoxButtons.YesNo);
            if (resultBox == DialogResult.Yes) resetGame();
        }

        public void RunMe(object sender, DoWorkEventArgs e)
        {

            while (running)
            {
                if (Ball.speedY > 0 && b1.Location.Y > panel.Size.Height - b1.Size.Height)
                {
                    if (Ball.AmountLeft == 0) showResult();
                    startingPosition();
                }

                // Om Ball.speedX är större än 0 (i.e färdas till höger)
                // Och Bollens X-location är större än högra väggen
                if (Ball.speedX > 0 && b1.Location.X > panel.Size.Width - b1.Size.Width)
                {
                    // Om bollens Y-position är inom 145-275
                    if (b1.Location.Y > 145 && b1.Location.Y < 275)
                    {
                        if (Ball.easyWind) points += 2;
                        else points += 1;
                        pointsLabel.Text = "Poäng: " + points;
                    }

                    startingPosition();
                    if (Ball.AmountLeft == 0) showResult();


                }
                if (Ball.speedX < 0 && b1.Location.X < 0)
                {
                    if (Ball.AmountLeft == 0) showResult();
                    startingPosition();
                }

                
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

        private void speedUpDown_ValueChanged(object sender, EventArgs e)
        {
            Ball.speedX = (double)speedUpDown.Value;
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
