// --------------------------------
// --- ShadowLabel.cs
// --------------------------------

// Copyright (C) 2012  JTC Humboldtschule

// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.

// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.

// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-
// 1307, USA.

// --------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//ShadowLabel by nkreipke

namespace Bulu.Grafik
{
    class ShadowLabel : System.Windows.Forms.UserControl
    {

        public ShadowLabel() {
            DoubleBuffered = true;
            base.Text = "";
        }
        string inttext = "";
        public override string Text
        {
            get
            {
                return inttext;
            }
            set
            {
                base.Text = "";
                inttext = value;
                AutoSize = false;
                Invalidate();
            }
        }
        public bool lightsUp { get; set; }
        public string atext {
            get {
                return Text;
            }
            set {
                Text = value;
            }
        }
        public System.Drawing.ContentAlignment TextAlign { get; set; }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            int xcoord = 0,ycoord = 0;
            System.Drawing.SizeF measurement = e.Graphics.MeasureString(Text, Font);
            int center = Width / 2;
            int xcenter = center - ((int)measurement.Width / 2);
            int ycenter = (Height / 2) - ((int)measurement.Height / 2);
            int xbot = Width - (int)measurement.Width;
            int ybot = Height - (int)measurement.Height;
            switch (TextAlign)
            {
                case System.Drawing.ContentAlignment.BottomCenter:
                    xcoord = xcenter;
                    ycoord = ybot;
                    break;
                case System.Drawing.ContentAlignment.BottomLeft:
                    xcoord = 0;
                    ycoord = ybot;
                    break;
                case System.Drawing.ContentAlignment.BottomRight:
                    xcoord = xbot;
                    ycoord = ybot;
                    break;
                case System.Drawing.ContentAlignment.MiddleCenter:
                    xcoord = xcenter;
                    ycoord = ycenter;
                    break;
                case System.Drawing.ContentAlignment.MiddleLeft:
                    xcoord = 0;
                    ycoord = ycenter;
                    break;
                case System.Drawing.ContentAlignment.MiddleRight:
                    xcoord = xbot;
                    ycoord = ycenter;
                    break;
                case System.Drawing.ContentAlignment.TopCenter:
                    xcoord = xcenter;
                    ycoord = 0;
                    break;
                case System.Drawing.ContentAlignment.TopLeft:
                    xcoord = 0;
                    ycoord = 0;
                    break;
                case System.Drawing.ContentAlignment.TopRight:
                    ycoord = 0;
                    xcoord = xbot;
                    break;
                default:
                    break;
            }
            e.Graphics.DrawString(Text, Font, new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(150,0,0,0)), new System.Drawing.PointF(xcoord, ycoord - 1));
            e.Graphics.DrawString(Text, Font, new System.Drawing.SolidBrush(ForeColor), new System.Drawing.PointF(xcoord, ycoord));
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            if (lightsUp)
            {
                ForeColor = System.Drawing.Color.CornflowerBlue;
            }
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (lightsUp)
            {
                ForeColor = System.Drawing.Color.White;
            }
        }
    }
}
