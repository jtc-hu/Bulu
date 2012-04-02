// --------------------------------
// --- BuluButton.cs
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
using System.Drawing;
using System.ComponentModel;

namespace Bulu
{
    [DefaultEvent("Click")]
    class BuluButton : nKF.Controls.nKButton
    {
        public BuluButton() {
            arrowed = false;
            this.ForeColor = Color.White;
        }
        //string t;
        Image im;
        //int state;
        //bool overed;
        bool arr;
        public bool arrowed {
            get {
                return arr;
            }
            set {
                arr = value;
                if (arr)
                {
                    this.NormalImage = Properties.Resources.mwdwFwdbutton;
                    this.MouseDownImage = Properties.Resources.mwdwFwdbuttonDown;
                    this.NormalImageLeftCapWidth = 40;
                    this.NormalImageTopCapHeight = 6;
                    this.MouseDownImageLeftCapWidth = 40;
                    this.MouseDownImageTopCapHeight = 6;
                    this.FocusedImageLeftCapWidth = 40;
                    this.FocusedImageTopCapHeight = 6;
                    this.MouseOverImageLeftCapWidth = 40;
                    this.MouseOverImageTopCapHeight = 6;
                }
                else
                {
                    this.NormalImage = Properties.Resources.mwdwButton;
                    this.MouseDownImage = Properties.Resources.mwdwButtonDown;
                    this.NormalImageLeftCapWidth = 6;
                    this.NormalImageTopCapHeight = 6;
                    this.MouseDownImageLeftCapWidth = 6;
                    this.MouseDownImageTopCapHeight = 6;
                    this.FocusedImageLeftCapWidth = 6;
                    this.FocusedImageTopCapHeight = 6;
                    this.MouseOverImageLeftCapWidth = 6;
                    this.MouseOverImageTopCapHeight = 6;
                }
            }
        }
        public string Caption
        {
            get
            {
                return this.Text;
            }
            set
            {
                this.Text = value;
            }
        }
        public Image Picture
        {
            get
            {
                return im;
            }
            set
            {
                im = value;
                this.Invalidate();
            }
        }
        

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            if (im != null && this.Text == "")
            {
                e.Graphics.DrawImage(im, this.Width / 2 - 8, this.Height / 2 - 8, 16, 16);
            }
        }

        //protected override void OnMouseEnter(EventArgs e)
        //{
        //    base.OnMouseEnter(e);
        //    try
        //    {
        //        Form1 senderForm = (Form1)FindForm();
        //        if (senderForm != null)
        //        {
        //            if (senderForm.IsActivated)
        //            {
        //                state = 1;
        //                overed = true;
        //                this.Invalidate();
        //            }
        //        }
        //    }
        //    catch {
        //        state = 1;
        //        overed = true;
        //        this.Invalidate();
        //    }
        //}

        //protected override void OnMouseLeave(EventArgs e)
        //{
        //    base.OnMouseLeave(e);
        //    state = 0;
        //    overed = false;
        //    this.Invalidate();
        //}

        //protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        //{
        //    base.OnMouseDown(e);
        //    state = 2;
        //    this.Invalidate();
        //}

        //protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e)
        //{
        //    base.OnMouseUp(e);
        //    if (overed)
        //    {
        //        state = 1;
        //    }
        //    else {
        //        state = 0;
        //    }
        //    this.Invalidate();
        //}
    }
}
