// --------------------------------
// --- BauelementAuflistung.cs
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
using System.Windows.Forms;
using System.Drawing;

namespace Bulu
{
    class BauelementAuflistung : System.Windows.Forms.UserControl
    {
        private Panel content;

        public BauelementAuflistung(List<Bauelement> bauelemente) {
            content = new Panel();
            content.AutoScroll = true;
            content.Dock = DockStyle.Fill;
            this.Controls.Add(content);
            foreach (Bauelement b in bauelemente) {
                string descr = b.Text;
                if (!b.BuyAllowed) {
                    descr = descr + " (Upgrade)";
                }
                BauelementAuflistung_DataRow row = new BauelementAuflistung_DataRow(descr, b.Grafik);
                row.Dock = DockStyle.Top;
                row.Visible = true;
                content.Controls.Add(row);
            }
        }
    }

    class BauelementAuflistung_DataRow : System.Windows.Forms.UserControl
    {
        public PictureBox prevPic;
        public Label descr;

        public BauelementAuflistung_DataRow(string description, Image picture) {
            prevPic = new PictureBox();
            descr = new Label();
            Height = 36;
            Width = 100;
            prevPic.SizeMode = PictureBoxSizeMode.StretchImage;
            prevPic.Top = 2;
            prevPic.Left = 10;
            prevPic.Width = 32;
            prevPic.Height = 32;
            descr.AutoSize = false;
            descr.AutoEllipsis = true;
            descr.Top = 2;
            descr.Left = 46;
            descr.Width = this.Width - 48;
            descr.Height = 32;
            descr.TextAlign = ContentAlignment.MiddleLeft;
            descr.Font = new Font("Segoe UI", 12);
            prevPic.Image = picture;
            descr.Text = description;
            prevPic.Visible = true;
            descr.Visible = true;
            this.Controls.Add(prevPic);
            this.Controls.Add(descr);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            descr.Width = this.Width - 40;
        }
    }
}
