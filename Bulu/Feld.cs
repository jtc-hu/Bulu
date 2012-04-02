// --------------------------------
// --- Feld.cs
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


namespace Bulu
{
    public class Feld : System.Windows.Forms.PictureBox
    {
        #region Casting
        public string encodeToString(Object MainFormObject) {
            //Wichtige Methode zum Speichern des Spiels. Wandelt das gesamte Objekt in eine Zeichenkette um.
            // Schema: momentanepersonen;bauelementencodestring;diedcounter;bauelementgeliefertepersonen
            Form1 senderForm = (Form1)MainFormObject;
            int gelieferteps;
            if (MomentanesBauelement != null)
            {
                gelieferteps = MomentanesBauelement.GeliefertePersonen;
            }
            else {
                gelieferteps = 0;
            }
            return momentanepersonen.ToString() + ";" + senderForm.castBauelementIntoEncodableString(MomentanesBauelement) + ";" + diedCounter.ToString() + ";" + gelieferteps;
        }
        public Feld decodeFromString(Object MainFormObject, string encodeString) {
            //Wichtige Methode zum Laden des Spiels. Wandelt eine Zeichenkette in ein Objekt um.
            // Achtung: Zuerst Bauelement zuweisen, Zuweisung leert alle Variablen, wäre andersherum also sinnlos.
            if (encodeString != "")
            {
                Form1 senderForm = (Form1)MainFormObject;
                string[] splitter = { ";" };
                string[] encodeStringArray = encodeString.Split(splitter, StringSplitOptions.None);
                MomentanesBauelement = senderForm.castEncodableStringIntoBauelement(encodeStringArray[1]);
                if (MomentanesBauelement != null) {
                    MomentanesBauelement.GeliefertePersonen = Convert.ToInt32(encodeStringArray[3]);
                }
                MomentanePersonen = Convert.ToInt32(encodeStringArray[0]);
                diedCounter = Convert.ToInt32(encodeStringArray[2]);
                return this;
            }
            else {
                return null;
            }
        }
        #endregion

        int momentanepersonen;
        public int diedCounter;
        Bauelement momentanesbauelement;
        int alphaval = 150;
        bool overed = false;
        bool down = false;
        nKF.Animation.ControlAttributeAnimator nKFcaa;
        public bool parentOpened {
            get {
                return down;
            }
            set {
                down = value;
                this.Invalidate();
            }
        }
        public Feld() {
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            nKFcaa = new nKF.Animation.ControlAttributeAnimator();
            nKFcaa.AnimationFinished += new nKF.Animation.ControlAttributeAnimator.AnimationFinishedEventHandler(nKFcaa_AnimationFinished);
        }

        void nKFcaa_AnimationFinished(nKF.Animation.ControlAttributeAnimator sender)
        {

        }
        public Bauelement MomentanesBauelement {
            set {
                momentanesbauelement = value;
                MomentanePersonen = 0;
                diedCounter = 0;
                bool aniFail = false;
                try
                {
                    if (!((Form1)this.Parent).startup)
                    {

                        nKFcaa.BeginAnimation(this);
                    }
                    else
                    {
                        aniFail = true;
                    }
                }
                catch
                {
                    aniFail = true;
                }
                if (value != null)
                {
                    if (value.Grafik != null) {
                        this.Image = value.Grafik;
                    }
                    else
                    {
                        this.Image = Properties.Resources.leer;
                    }
                    //Form1 senderForm1 = (Form1)this.Parent;
                    //if (momentanesbauelement.MaxPersonenanzahl > 0 && senderForm1.FreiePersonen > 0) {
                    //    BauelementEditor editor = new BauelementEditor(MomentanesBauelement, this);
                    //    showOverlayWindow(editor);
                    //} code scheint defekt zu sein, könnte ein .net framework bug sein
                    if (value.MaxPersonenanzahl == 0)
                    {
                        HideInformationString = true;
                    }
                    else {
                        HideInformationString = false;
                    }
                }
                else {
                    this.Image = Properties.Resources.leer;
                    HideInformationString = false;
                }
                if (!aniFail)
                {
                    nKFcaa.CommitAnimation(300);
                }
            }
            get {
                return momentanesbauelement;
            }
        }
        public int MomentanePersonen {
            set {
                momentanepersonen = value;
                this.Invalidate();
            }
            get {
                if (MomentanesBauelement != null)
                {
                    if (MomentanesBauelement.MaxPersonenanzahl == 0 && MomentanesBauelement.GeliefertePersonen > 0)
                    {
                        return MomentanesBauelement.GeliefertePersonen;
                    }
                    else
                    {
                        return momentanepersonen;
                    }
                }
                else {
                    return momentanepersonen;
                }
            }
        }
        public bool HideInformationString { set; get; }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs pe)
        {
            base.OnPaint(pe);
            if (overed || down) {
                RectangleF highlightRect = new RectangleF(0, 0, this.Width, this.Height);
                if (down) {
                    pe.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(50, 0, 0, 0)), highlightRect);
                }
                else if (overed) {
                    pe.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(50, 255, 255, 255)), highlightRect);
                }
            }
            if (MomentanesBauelement != null) {
                if (MomentanesBauelement.Grafik == null)
                {
                    //Notstring zeichnen
                    pe.Graphics.DrawString("Grafik fehlt!!!", new Font("Arial", 9), Brushes.Red, 0, 0);
                    pe.Graphics.DrawString(MomentanesBauelement.Text, new Font("Arial", 9), Brushes.Red, 0, 14);
                }
            }
            string stringToDraw = MomentanePersonen.ToString();
            if (HideInformationString || MomentanesBauelement == null)
            {
                stringToDraw = "";
            }
            pe.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            System.Drawing.Drawing2D.LinearGradientBrush lgb;
            if (stringToDraw != "") {
                //so viel Code für so ein kleines Kästchen...
                DrawingFunctions df = new DrawingFunctions();
                float msval = pe.Graphics.MeasureString(stringToDraw,
                    new System.Drawing.Font("Arial", 12)).Width;
                int xval = this.Width - 5 - (int)msval;
                RectangleF r = new RectangleF(xval, this.Height - 23, 50, 25);
                lgb = new System.Drawing.Drawing2D.LinearGradientBrush(r,
                    Color.FromArgb(alphaval, 255, 255, 255), Color.FromArgb(alphaval - 125, 255, 255, 255),
                    System.Drawing.Drawing2D.LinearGradientMode.Vertical);
                df.DrawRoundedRectangle(pe.Graphics, xval, this.Height - 23, 50, 30, 8, lgb,
                    new System.Drawing.Pen(new SolidBrush(Color.FromArgb(200, 60, 60, 60))));
                pe.Graphics.DrawString(stringToDraw, new System.Drawing.Font("Arial", 12),
                    new SolidBrush(Color.FromArgb(100,Color.White)), this.Width - pe.Graphics.MeasureString(stringToDraw,
                    new System.Drawing.Font("Arial", 12)).Width, this.Height - pe.Graphics.MeasureString(stringToDraw,
                    new System.Drawing.Font("Arial", 12)).Height + 1);
                pe.Graphics.DrawString(stringToDraw, new System.Drawing.Font("Arial", 12),
                    System.Drawing.Brushes.Black, this.Width - pe.Graphics.MeasureString(stringToDraw,
                    new System.Drawing.Font("Arial", 12)).Width, this.Height - pe.Graphics.MeasureString(stringToDraw,
                    new System.Drawing.Font("Arial", 12)).Height);
            } else if (stringToDraw == "" && diedCounter > 0) {
                DrawingFunctions df = new DrawingFunctions();
                int msval = (int)pe.Graphics.MeasureString("-" + diedCounter.ToString(),
                    new System.Drawing.Font("Arial", 12)).Width;
                RectangleF r = new RectangleF(-5, this.Height - 23, msval+8, 25);
                lgb = new System.Drawing.Drawing2D.LinearGradientBrush(r,
                       Color.FromArgb(alphaval - 125, 255, 0, 0), Color.FromArgb(alphaval, 255, 0, 0),
                        System.Drawing.Drawing2D.LinearGradientMode.Vertical);
                df.DrawRoundedRectangle(pe.Graphics, - 5, this.Height - 23, msval + 8, 30, 8, lgb,
                    new System.Drawing.Pen(new SolidBrush(Color.FromArgb(200, 60, 60, 60))));
                pe.Graphics.DrawString("-" + diedCounter.ToString(), new System.Drawing.Font("Arial", 12),
                    new SolidBrush(Color.FromArgb(150, Color.Black)), 2, this.Height - pe.Graphics.MeasureString("-" + diedCounter.ToString(),
                    new System.Drawing.Font("Arial", 12)).Height + 1);
                pe.Graphics.DrawString("-" + diedCounter.ToString(), new System.Drawing.Font("Arial", 12),
                    System.Drawing.Brushes.White, 2, this.Height - pe.Graphics.MeasureString("-" + diedCounter.ToString(),
                    new System.Drawing.Font("Arial", 12)).Height);
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Form1 senderForm = (Form1)FindForm();
            if (senderForm != null) {
                if (senderForm.IsActivated) {
                    alphaval = 200;
                    overed = true;
                    this.Invalidate();
                }
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            alphaval = 150;
            overed = false;
            this.Invalidate();
        }

        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseDown(e);
            parentOpened = true;
            Form1 parentForm = (Form1)this.Parent;
            System.Windows.Forms.Form wdw = null;
            if (MomentanesBauelement == null)
            {
                wdw = new BauelementSelector(parentForm.BauelementeList, this);
            }
            else
            {
                wdw = new BauelementEditor(this.MomentanesBauelement, this);
            }
            showOverlayWindow(wdw);
        }

        public void showOverlayWindow(System.Windows.Forms.Form wdw) {
            wdw.TopMost = true;
            Form1 parentForm = (Form1)this.Parent;
            int tp = parentForm.Top + this.Top + this.Height + 20;
            if (tp > System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - wdw.Height)
            {
                wdw.Top = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - wdw.Height;
            }
            else
            {
                wdw.Top = tp;
            }
            int lft = parentForm.Left + this.Left;
            if (lft < 0)
            {
                lft = 0;
            }
            if ((lft + wdw.Width) > System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width)
            {
                wdw.Left = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - wdw.Width;
            }
            else
            {
                wdw.Left = lft;
            }
            wdw.Show();
        }
    }
}
