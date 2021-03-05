using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiperLine
{
    public partial class PiperLine : Form
    {
        private Graphics g;
        private readonly Color LineColor = Color.Black;
        private readonly Color FormBackgroundColor = Color.White;
        private int movement = 3;
        private int thickness = 3;
        private bool leftSideOfTheLine = true;
        private const string PointSwitcherLeftText = "Left";
        private const string PointSwitcherRightText = "Right";
        private const int Border = 100;

        private Bitmap bLine;

        private Point leftPoint;
        private Point rightPoint;

        public PiperLine()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();

            this.BackColor = Color.LightGray;

            leftPoint = new Point(this.ClientSize.Width/2 - (this.ClientSize.Width/2)/2,
                                  (this.ClientSize.Height - Border)/2);

            rightPoint = new Point(this.ClientSize.Width/2 + (this.ClientSize.Width/2)/2,
                                    (this.ClientSize.Height - Border)/2);

            pictureBoxLine.Width = ClientSize.Width;
            pictureBoxLine.Height = ClientSize.Height - Border;

            buttonLeft.Tag = Directions.left;
            buttonUp.Tag = Directions.up;
            buttonRight.Tag = Directions.right;
            buttonDown.Tag = Directions.down;

            trackBarThickness.Value = thickness;

            DrawLine(leftPoint,rightPoint);
        }

        private void MoveLine(object sender, EventArgs e)
        {
            Button senButton = sender as Button;

            switch(senButton.Tag)
            {
                case Directions.left:
                    if (leftSideOfTheLine)
                    {
                        leftPoint.X -= movement;
                    }
                    else rightPoint.X -= movement;
                    break;
                case Directions.up:
                    if (leftSideOfTheLine)
                    {
                        leftPoint.Y -= movement;
                    }
                    else rightPoint.Y -= movement;
                    break;
                case Directions.right:
                    if (leftSideOfTheLine)
                    {
                        leftPoint.X += movement;
                    }
                    else rightPoint.X +=movement;
                    break;
                case Directions.down:
                    if (leftSideOfTheLine)
                    {
                        leftPoint.Y += movement;
                    }
                    else rightPoint.Y += movement;
                    break;
            }

            DrawLine(leftPoint, rightPoint);
        }

        private void buttonLinePointSwitch_Click(object sender, EventArgs e)
        {
            leftSideOfTheLine = !leftSideOfTheLine;
            buttonLinePointSwitch.Text = leftSideOfTheLine ? PointSwitcherLeftText : PointSwitcherRightText;
        }

        private void DrawLine(Point pointLeft, Point pointRight)
        {
            bLine = new Bitmap(ClientSize.Width,ClientSize.Height - Border);
            g = Graphics.FromImage(bLine);

            g.Clear(FormBackgroundColor);
            Pen penForLine = new Pen(LineColor,thickness);
            g.DrawLine(penForLine,pointLeft,pointRight);

            pictureBoxLine.BackgroundImage = bLine;
        }

        private void trackBarThickness_Scroll(object sender, EventArgs e)
        {
            thickness = trackBarThickness.Value;
        }
    }
}
