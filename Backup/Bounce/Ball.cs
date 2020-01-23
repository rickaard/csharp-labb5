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
        public static double gravity = 0;
        public static int collissions = 0;
        public double speedX, speedY;
        public double posX, posY;

        public Ball(Image image)
        {
            Image = image;
            BackColor = Color.Transparent;
            Size = new Size(60, 60);
            Visible = true;
        }
        public void MoveBall()
        {
            speedY += gravity;
            posX += speedX;
            posY += speedY;
            Location = new Point((int)(posX), (int)(posY));
        }
        public void BounceY()
        {
            speedY = -(speedY + gravity); // dont add gravity when bouncing
        }
        public void BounceX()
        {
            speedX = -speedX;
        }
        public void Start()
        {
            posX = Location.X;
            posY = Location.Y;
        }
        public double P
        {
            get
            {
                return Math.Sqrt(speedX * speedX + speedY * speedY);
            }
        }
        public bool IsColliding(Ball b)
        {
            double dx = posX - b.posX;
            double dy = posY - b.posY;
            return (dx * dx + dy * dy < 60 * 60);
        }
        // Du behöver inte beskriva Collide i detalj. I synnerhet inte vad de olika räkningarna gör.
        public void Collide(Ball b)
        {
            double x1 = posX;
            double y1 = posY;
            double x2 = b.posX;
            double y2 = b.posY;
            double a = Math.Atan2(y1 - y2, x1 - x2);
            double a1 = Math.Atan2(speedY, speedX);
            double a2 = Math.Atan2(b.speedY, b.speedX);

            double p1 = P;
            double cmx1 = p1 * Math.Cos(a1 - a);
            double cmy1 = p1 * Math.Sin(a1 - a);

            double p2 = b.P;
            double cmx2 = p2 * Math.Cos(a2 - a);
            double cmy2 = p2 * Math.Sin(a2 - a);

            speedX = Math.Cos(a) * cmx2 + Math.Cos(a + Math.PI / 2) * cmy1;
            speedY = Math.Sin(a) * cmx2 + Math.Sin(a + Math.PI / 2) * cmy1;
            b.speedX = Math.Cos(a) * cmx1 + Math.Cos(a + Math.PI / 2) * cmy2;
            b.speedY = Math.Sin(a) * cmx1 + Math.Sin(a + Math.PI / 2) * cmy2;
        }
    }
}