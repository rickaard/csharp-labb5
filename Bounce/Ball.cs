using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace Bounce
{
    class Ball : Label
    {
        public static int AmountLeft { get; set; }
        public static double gravity = 0;
        public static int collissions = 0;
        public static double speedX, speedY;
        public double posX, posY;
        public static bool easyWind;

        public Ball(Image image)
        {
            Image = image;
            BackColor = Color.Transparent;
            Size = new Size(60, 60);
            Visible = true;
            AmountLeft = 5;
        }

        public double GetRandomWind()
        {
            int minimumWind;
            int maximumWind;
            if (easyWind)
            {
                minimumWind = -2;
                maximumWind = 2;
            }
            else
            {
                minimumWind = -5;
                maximumWind = 5;
            }

            // Randomisera ett tal mellan minumumWind och maximumWind (värde beror på om easyWind är true eller false) vinden
            var randomWind = new Random();
            var wind = randomWind.NextDouble() * (maximumWind - minimumWind) + minimumWind;
            return wind;
        }


        public void MoveBall()
        {
            speedY += gravity;
            posX += speedX;
            posY += speedY;
            Location = new Point((int)(posX), (int)(posY));
        }

        public void Start()
        {
            posX = Location.X;
            posY = Location.Y;
        }
    }
}