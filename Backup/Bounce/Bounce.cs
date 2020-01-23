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
        private bool running;
        Ball b1, b2;
        BackgroundWorker worker;
        private delegate void MoveBallCallback(Ball b);
        public Bounce()
        {
            InitializeComponent();
            Ball.gravity = (double)gravityUpDown.Value;

            // FromFile kräver att man ställer in filerna i Projektet att Copy to Output Directory.
            // högerklicka bilderna / Properties 
            b1 = new Ball(Image.FromFile("images/chrome.png"));
            b2 = new Ball(Image.FromFile("images/ff.png"));
            panel.Controls.Add(b1);
            panel.Controls.Add(b2);
            b1.Location = new Point(40, 40);
            b1.speedX = 3;
            b1.speedY = 1;
            b2.Location = new Point(200, 50);
            b2.speedX = -2;
            b2.speedY = +1.5;
            running = false;
            b1.Start();
            b2.Start();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (running == true)
            {
                b1.Location = new Point(40, 40);
                b1.speedX = 3;
                b1.speedY = 1;
                b2.Location = new Point(200, 50);
                b2.speedX = -2;
                b2.speedY = +1.5;
                running = false;
                b1.Start();
                b2.Start();
                return;
            }
            running = true;

            // Följande kodrader gör så att metoden RunMe körs i en separat tråd
            // så att det inte påverkar applikationens flöde.
            worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(RunMe); // knyt metoden RunMe till worker
            worker.RunWorkerAsync(); // starta
        }

        public void RunMe(object sender, DoWorkEventArgs e)
        {
            while (running)
            {
                if (b1.speedY > 0 && b1.Location.Y > panel.Size.Height - b1.Size.Height)
                {
                    b1.BounceY();
                    b1.posY = panel.Size.Height - b1.Size.Height;
                }
                if (b1.speedX > 0 && b1.Location.X > panel.Size.Width - b1.Size.Width)
                {
                    b1.BounceX();
                }
                if (b1.speedX < 0 && b1.Location.X < 0)
                {
                    b1.BounceX();
                }
                if (b2.speedY > 0 && b2.Location.Y > panel.Size.Height - b2.Size.Height)
                {
                    b2.BounceY();
                    b2.posY = panel.Size.Height - b2.Size.Height;
                }
                if (b2.speedX > 0 && b2.Location.X > panel.Size.Width - b2.Size.Width)
                {
                    b2.BounceX();
                }
                if (b2.speedX < 0 && b2.Location.X < 0)
                {
                    b2.BounceX();
                }

                if (b1.IsColliding(b2))
                {
                    b1.Collide(b2);
                }

                
                this.Invoke(new MoveBallCallback(MoveBall), b1);
                this.Invoke(new MoveBallCallback(MoveBall), b2);
                Thread.Sleep(10);
            }

        }

        void MoveBall(Ball b)
        {
            b.MoveBall();
        }

        private void gravityUpDown_ValueChanged(object sender, EventArgs e)
        {
            Ball.gravity = (double)gravityUpDown.Value;
        }
    }
}
