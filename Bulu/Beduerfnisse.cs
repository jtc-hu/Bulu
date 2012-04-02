// --------------------------------
// --- Beduerfnisse.cs
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bulu
{
    public partial class Beduerfnisse : UserControl
    {
        nKF.Animation.ControlFrameAnimator nkk = new nKF.Animation.ControlFrameAnimator();
        Form1 senderForm;
        public Beduerfnisse(Level actualLevel, Object sender)
        {
            InitializeComponent();
            senderForm = (Form1)sender;
            int gesps = senderForm.Gesamtpersonen;
            int gesamtnahrung = actualLevel.VerbrauchteNahrungProPersonProRunde * gesps;
            int gesamtgeld = actualLevel.VerbrauchtesGeldProPersonProRunde * gesps;
            nahrungspunkteLabel.Text = actualLevel.VerbrauchteNahrungProPersonProRunde.ToString() + " (Gesamt: " + gesamtnahrung.ToString() + ")";
            geldLabel.Text = actualLevel.VerbrauchtesGeldProPersonProRunde.ToString() + " (Gesamt: " + gesamtgeld.ToString() + ")";
        }

        bool open = false;
        private void buluButton1_Click(object sender, EventArgs e)
        {
            if (!open)
            {
                buluButton1.Picture = Properties.Resources.arrowleft;
                nKF.Controls.Frame f = new nKF.Controls.Frame(infolabel);
                f.x = 1;
                nkk.SetFrameAnimated(infolabel, f, nKF.Animation.Animator.AnimationCurve.EaseInAndOut, 400);
            }
            else
            {
                buluButton1.Picture = Properties.Resources.arrowright;
                nKF.Controls.Frame f = new nKF.Controls.Frame(infolabel);
                f.x = 300;
                nkk.SetFrameAnimated(infolabel, f, nKF.Animation.Animator.AnimationCurve.EaseInAndOut, 400);
            }
            open = !open;
        }

        private void buluButton2_Click(object sender, EventArgs e)
        {
            senderForm.hideHUD();
        }
    }
}
