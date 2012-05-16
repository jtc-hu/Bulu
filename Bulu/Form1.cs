// --------------------------------
// --- Form1.cs
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
using Bulu.Bauelemente;
using Bulu.Levels;

namespace Bulu
{
    public partial class Form1 : Form
    {
        #region Deklarationen
        public bool startup = true;
        public bool donotclose = false;
        Timer moneyAnimationTimer = new Timer();
        public DeveloperConsole devconsole;
        public NotificationCenter nc;
        public AchievementsCenter ac;
        public AchievedWindow achievedWindow;
        nKF.Animation.ControlFrameAnimator nKFcfa;
        nKF.Animation.ControlAttributeAnimator nKFcaa;
        public bool InstantClose = false;       // Deaktivieren der Schließbestätigung (Verwendung bei Update)
        public bool IsActivated { set; get; }   // Triggered durch Form1_(de)activated
        public List<Bauelement> BauelementeList;// Enthält ale (@Nico verfügbaren? - jop) Bauelemente
        public bool eastereggEnabled = false;
        public Level MomentanesLevel {
            get {
                return curlevel;
            }
            set {
                curlevel = value;
                ActualizeWindowTitle();
                if (value.LevelUpLevel != null)
                {
                    lvlupButton.Caption = "Nächstes Level";
                    lvlupButton.Enabled = true;
                }
                else {
                    lvlupButton.Caption = "Kein nächstes Level";
                    lvlupButton.Enabled = false;
                }
                lvlupButton.ForeColor = lvlupButton.Enabled ? Color.White : Color.Gray; //nKButton unterstützt dies noch nicht
                MomentaneRunde = 1;
            }
        }
        public string SaveGamePath { set; get; }
        string sgtitle;                                         //@Nico warum doppelt?
        public string SaveGameTitle {                           //weil er die interne Variable verwalten muss
            get {
                return sgtitle;
            }
            set {
                sgtitle = value;
                ActualizeWindowTitle();
            }
        }
        public Settings startSettings;                          //Nahrungs-/Blidunngspunkte, Währung, etc
        public List<Feld> FelderList;
        Level curlevel;
        int curnp;                                              //@Nico schon wieder doppelt?
        public int MomentaneNahrungspunkte {                    //s.o.
            get {
                return curnp;
            }
            set {
                curnp = value;
                nahrungspunkteLabel.Text = curnp.ToString();
                if (curnp > 0) {
                    sellButton.Enabled = true;
                }
                else {
                    sellButton.Enabled = false;
                }
                //sellButton.ForeColor = sellButton.Enabled ? Color.White : Color.Gray;
            }
        }
        public int Gesamtpersonen {
            get {
                int gesps = 0;
                foreach (Feld f in FelderList) {
                    if (f.MomentanesBauelement != null) {
                        gesps += f.MomentanesBauelement.GeliefertePersonen;
                    }
                }
                return gesps;
            }
        }
        public int FreiePersonen {
            get {
                int besps = 0;
                foreach (Feld f in FelderList) {
                    if (f.MomentanesBauelement != null) {
                        if (f.MomentanesBauelement.GeliefertePersonen == 0) { 
                            besps += f.MomentanePersonen;                     // Er errechnet die beschäftigten Personen
                        }                                                     // Da braucht man Häuser nicht
                    }
                }
                return Gesamtpersonen - besps;
            }
        }
        public int FreieFelder {
            get {
                int frfe = 0;
                foreach (Feld f in FelderList)
                {
                    if (f.MomentanesBauelement == null)
                    {
                        frfe += 1;
                    }
                }
                return frfe;
            }
        }
        int curbp;
        public int MomentaneBildungspunkte {
            get {
                return curbp;
            }
            set {
                curbp = value;
                bildungspunkteLabel.Text = curbp.ToString();
            }
        }
        int curgestps;
        public int GestorbenePersonen {
            get {
                return curgestps;
            }
            set {
                curgestps = value;
                gestpsLabel.Text = curgestps.ToString();
            }
        }
        public int reCalculateGestorbenePersonen() {
                int geps = 0;
                foreach (Feld f in FelderList) {
                    if (f.MomentanesBauelement != null) {
                        geps += f.diedCounter;
                    }
                }
                return geps;
        }
        int currunde;
        public int MomentaneRunde {
            get {
                return currunde;
            }
            set {
                currunde = value;
                rndupButton.Text = "Runde " + value.ToString() + " von " + MomentanesLevel.Rundenanzahl.ToString();
                if (value < MomentanesLevel.Rundenanzahl)
                {
                    rndupButton.Enabled = true; // (Ent)sperrung des Nächste-Runde-Buttons
                }
                else {
                    rndupButton.Enabled = false;
                }
                rndupButton.ForeColor = rndupButton.Enabled ? Color.White : Color.Gray;
            }
        }
        public int AmountOfActiveBauelemente(Bauelement element) {
            int amo = 0;
            foreach (Feld f in FelderList)
            {
                if (f.MomentanesBauelement != null)
                {
                    if (f.MomentanesBauelement.Identifier == element.Identifier)
                    {
                        amo += 1;
                    }
                }
            }
            return amo;
        }
        public int Punktestand {
            get {
                PunkteCalculator pointCalc = new PunkteCalculator(this);
                return pointCalc.AktuellePunktzahl;
            }
        }
        public void ReCalculatePunktestand() {
            //punkteLabel.Text = Punktestand.ToString();
        }
        public void ReCalculateAvailablePeople() {
            personenLabel.Text = FreiePersonen.ToString();
            nc.nc_notificate(NotificationCenter.nc_props.nc_changebusypeople, Gesamtpersonen - FreiePersonen);
        }
        int geld;
        #endregion

        #region Initialisierung (Bauelement-Liste)
        public Form1()
        {
            InitializeComponent();
            toolBarPanel.BackColor = Color.Transparent;
            startSettings = new Settings();
            ac = new AchievementsCenter(this);
            nc = new NotificationCenter(this);
            nKFcfa = new nKF.Animation.ControlFrameAnimator();
            nKFcfa.AnimationFinished += new nKF.Animation.ControlFrameAnimator.AnimationFinishedEventHandler(nKFcfa_AnimationFinished);
            nKFcaa = new nKF.Animation.ControlAttributeAnimator();
            moneyAnimationTimer = new Timer(); moneyAnimationTimer.Tick += new EventHandler(moneyAnimationWaitEnd); moneyAnimationTimer.Interval = 1000;
            FelderList = new List<Feld>();
            FelderList.Add(f1);
            FelderList.Add(f2);
            FelderList.Add(f3);
            FelderList.Add(f4);
            FelderList.Add(f5);
            FelderList.Add(f6);
            FelderList.Add(f7);
            FelderList.Add(f8);
            FelderList.Add(f9);
            FelderList.Add(f10);
            FelderList.Add(f11);
            FelderList.Add(f12);
            FelderList.Add(f13);
            FelderList.Add(f14);
            FelderList.Add(f15);
            BauelementeList = new List<Bauelement>();
            //----------INITIALISIERUNG ALLER VERFÜGBAREN BAUELEMENTE------------
            BauelementeList.Add(new Hirsefeld());
            BauelementeList.Add(new Haus());
            BauelementeList.Add(new HausMittel());
            BauelementeList.Add(new HausGross());
            BauelementeList.Add(new Rinderfeld());
            BauelementeList.Add(new RinderfeldMittel());
            BauelementeList.Add(new RinderfeldGross());
            BauelementeList.Add(new Schule());
            BauelementeList.Add(new SchuleMittel());
            BauelementeList.Add(new Wasserversorgung());
            BauelementeList.Add(new WasserversorgungMittel());
            BauelementeList.Add(new Erdnussfeld());
            BauelementeList.Add(new Toepferei());
            BauelementeList.Add(new HausMehrfamilien());
            BauelementeList.Add(new SchuleWeiterfuehrend());
            BauelementeList.Add(new Kaffee());
            BauelementeList.Add(new KaffeeMittel());
            BauelementeList.Add(new KaffeeGross());
            BauelementeList.Add(new Textilfabrik());
            BauelementeList.Add(new ErdnussfeldMittel());
            BauelementeList.Add(new ErdnussfeldGross());
            BauelementeList.Add(new ToepfereiGross());
            //----------ENDE DER INITIALISIERUNG---------------------------------
            initStartSettings();
        }

        public void initStartSettings() {
            GeldTransaktion(Transaktionsart.Festlegung, startSettings.Startgeld);
            MomentaneNahrungspunkte = startSettings.StartNahrung;
            MomentaneBildungspunkte = startSettings.StartBildungspunkte;
            GestorbenePersonen = 0;
        }
        #endregion

        #region Geld-Management
        public enum Transaktionsart {
            Einzahlung,
            Kauf,
            Festlegung
        }
        public int Ausgaben { set; get; }
        public int Einnahmen { set; get; }
        public bool GeldDeaktivieren = false;
        public int MomentanesGeld()
        {
            return geld;
        }
        public bool IstGeldmengeAusreichend(int Kaufpreis)
        {
            if (GeldDeaktivieren) return true;
            if (Kaufpreis > MomentanesGeld())
            {
                return false;
            }
            else {
                return true;
            }
        }
        public bool GeldTransaktion(Transaktionsart art, int summe) {
            int alterwert = geld;
            bool success = false;
            if (art == Transaktionsart.Kauf)
            {
                //if (IstGeldmengeAusreichend(summe))
                //{
                    geld = geld - summe;
                    Ausgaben += summe;
                    geldsumme.Text = geld.ToString() + " " + startSettings.Waehrung;
                   success = true;
                   moneyAnimation(false);
                //}
                //else
                //{
                //    return false;
                //}
                // Auskommentiert um negative Werte zu erlauben
            }
            else if (art == Transaktionsart.Einzahlung)
            {
                geld = geld + summe;
                Einnahmen += summe;
                geldsumme.Text = geld.ToString() + " " + startSettings.Waehrung;
                success = true;
                moneyAnimation(true);
            }
            else {
                geld = summe;
                geldsumme.Text = geld.ToString() + " " + startSettings.Waehrung;
                success = true;
            }
            if (success)
            {
                NotificationCenter.ncGeldNotificationStucture ncgeld = new NotificationCenter.ncGeldNotificationStucture();
                ncgeld.oldGeld = alterwert;
                ncgeld.newGeld = geld;
                nc.nc_notificate(NotificationCenter.nc_props.nc_chmoney, ncgeld);
            }
            return success;
        }
        #endregion

        #region Runden- und Levelzyklus
        private void rndupButton_Click(object sender, EventArgs e)
        {
            hideHUD();
            //Es folgt eine theoretische Überprüfung der Gegebenheiten.
            #region Überprüfung
            int addnahrung = 0;
            int addgeld = 0;
            double multiplier = 1;
            int theoreticalnahrung = 0;
            int theoreticalgeld = 0;
            int theoreticaldied = 0;
            foreach (Feld f in FelderList)
            {
                if (f.MomentanesBauelement != null)
                {
                    addnahrung += f.MomentanesBauelement.NahrungspunkteProPersonProRunde * f.MomentanePersonen;
                    addgeld += f.MomentanesBauelement.GeldProPersonProRunde * f.MomentanePersonen;
                    multiplier = multiplier * f.MomentanesBauelement.ErtragsMultiplier;
                    if (f.MomentanesBauelement.Selbstversorgend)
                    {
                        addnahrung += MomentanesLevel.VerbrauchteNahrungProPersonProRunde * f.MomentanePersonen;
                    }
                }
            }
            theoreticalnahrung += MomentaneNahrungspunkte + (int)((double)addnahrung * multiplier);
            theoreticalgeld = (MomentanesGeld() > 0 ? MomentanesGeld() : 0) + addgeld;
            int removenahrung = MomentanesLevel.VerbrauchteNahrungProPersonProRunde * Gesamtpersonen;
            if (removenahrung > theoreticalnahrung)
            {
                //Personen sterben
                bool endRemove = false;
                foreach (Feld f in FelderList)
                {
                    if (f.MomentanesBauelement != null)
                    {
                        if (f.MomentanesBauelement.GeliefertePersonen > 0 && endRemove == false)
                        {
                            if (f.MomentanesBauelement.GeliefertePersonen * MomentanesLevel.VerbrauchteNahrungProPersonProRunde < removenahrung -
                                theoreticalnahrung - (theoreticaldied * MomentanesLevel.VerbrauchteNahrungProPersonProRunde))
                            {
                                theoreticaldied += f.MomentanesBauelement.GeliefertePersonen;
                            }
                            else
                            {
                                theoreticaldied += (removenahrung - theoreticalnahrung - 
                                    (theoreticaldied * MomentanesLevel.VerbrauchteNahrungProPersonProRunde)) / 
                                    MomentanesLevel.VerbrauchteNahrungProPersonProRunde;
                                endRemove = true;
                            }
                        }
                    }
                }
            }
            #endregion
            if (theoreticaldied > 0) {
                NextRoundWarning nrw = new NextRoundWarning("Aufgrund von Nahrungsknappheit würde(n) " +
                    theoreticaldied.ToString() + " Person(en) in deinem Dorf sterben.", this);
                showOverlayWindow(nrw, rndupButton);
            }
            else if (MomentanesLevel.VerbrauchtesGeldProPersonProRunde * Gesamtpersonen > theoreticalgeld)
            {
                NextRoundWarning nrw = new NextRoundWarning("Du würdest " + (MomentanesLevel.VerbrauchtesGeldProPersonProRunde
                    * Gesamtpersonen - theoreticalgeld) + " " + startSettings.Waehrung + " Schulden machen.", this);
                showOverlayWindow(nrw, rndupButton);
            }
            else {
                RoundUp();
            }
        }

        public void RoundUp() {
            int addnahrung = 0;
            int addbildungspunkte = 0;
            int addgeld = 0;
            double multiplier = 1;
            //Produzierte Nahrung, Bildungspunkte und Geld anrechnen und Multiplier festlegen
            foreach (Feld f in FelderList)
            {
                if (f.MomentanesBauelement != null)
                {
                    addnahrung += f.MomentanesBauelement.NahrungspunkteProPersonProRunde * f.MomentanePersonen;
                    addbildungspunkte += f.MomentanesBauelement.BildungspunkteProPersonProRunde * f.MomentanePersonen;
                    addgeld += f.MomentanesBauelement.GeldProPersonProRunde * f.MomentanePersonen;
                    multiplier = multiplier * f.MomentanesBauelement.ErtragsMultiplier;
                    if (f.MomentanesBauelement.Selbstversorgend)
                    {
                        addnahrung += MomentanesLevel.VerbrauchteNahrungProPersonProRunde * f.MomentanePersonen;
                    }
                }
            }
            MomentaneNahrungspunkte += (int)((double)addnahrung * multiplier);
            MomentaneBildungspunkte += addbildungspunkte;
            //Verbesserter Geldalgorithmus damit die geile Animation auch klappt
            if (MomentanesLevel.VerbrauchtesGeldProPersonProRunde > 0)
            {
                addgeld -= MomentanesLevel.VerbrauchtesGeldProPersonProRunde * Gesamtpersonen;
            }
            if (addgeld != 0)
            {
                if (addgeld > 0)
                {
                    GeldTransaktion(Transaktionsart.Einzahlung, addgeld);
                }
                else
                {
                    GeldTransaktion(Transaktionsart.Kauf, -1 * addgeld);
                }
            }
            int removenahrung = MomentanesLevel.VerbrauchteNahrungProPersonProRunde * Gesamtpersonen;
            if (removenahrung > MomentaneNahrungspunkte)
            {
                //Personen sterben
                int removedpeople = 0;
                bool endRemove = false;
                foreach (Feld f in FelderList)
                {
                    if (f.MomentanesBauelement != null)
                    {
                        if (f.MomentanesBauelement.GeliefertePersonen > 0 && endRemove == false) //@Nico && !endRemove
                        {                                                                        //Ist true wenn er meint, genug entfernt zu haben
                            if (f.MomentanesBauelement.GeliefertePersonen * MomentanesLevel.VerbrauchteNahrungProPersonProRunde
                                < removenahrung - MomentaneNahrungspunkte - (removedpeople * MomentanesLevel.VerbrauchteNahrungProPersonProRunde))
                            {
                                removedpeople += f.MomentanesBauelement.GeliefertePersonen;
                                f.diedCounter += f.MomentanesBauelement.GeliefertePersonen;
                                f.MomentanesBauelement.GeliefertePersonen = 0;
                            }
                            else
                            {
                                f.diedCounter += (removenahrung - MomentaneNahrungspunkte - (removedpeople * MomentanesLevel.VerbrauchteNahrungProPersonProRunde)) / MomentanesLevel.VerbrauchteNahrungProPersonProRunde;
                                f.MomentanesBauelement.GeliefertePersonen -= (removenahrung - MomentaneNahrungspunkte - (removedpeople * MomentanesLevel.VerbrauchteNahrungProPersonProRunde)) / MomentanesLevel.VerbrauchteNahrungProPersonProRunde;
                                removedpeople += (removenahrung - MomentaneNahrungspunkte - (removedpeople * MomentanesLevel.VerbrauchteNahrungProPersonProRunde)) / MomentanesLevel.VerbrauchteNahrungProPersonProRunde;
                                endRemove = true;                                                // !!! hier !!!
                            }
                            f.Invalidate(); //Neu zeichnen lassen um Personenzahl zu aktualisieren
                        }
                    }
                }
                GestorbenePersonen += removedpeople;
                removenahrung -= removedpeople * MomentanesLevel.VerbrauchteNahrungProPersonProRunde;
            }
            //Serious Fallback Strategy !!!!!!!1111einself
            if (FreiePersonen < 0)
            {
                int toKill = 0 - FreiePersonen;
                foreach (Feld feld in FelderList)
                {
                    if (feld.MomentanesBauelement != null)
                    {
                        if (feld.MomentanePersonen > 0 && feld.MomentanesBauelement.GeliefertePersonen == 0)
                        {
                            if (toKill > feld.MomentanePersonen)
                            {
                                toKill -= feld.MomentanePersonen;
                                feld.MomentanePersonen = 0;
                            }
                            else
                            {
                                feld.MomentanePersonen -= toKill;
                                toKill = 0;
                            }
                        }
                    }
                }
            }
            //Sicherheitsmechanismus, damit Nahrung niemals negativ wird
            if (MomentaneNahrungspunkte - removenahrung < 0)
            {
                MomentaneNahrungspunkte = 0;
            }
            else
            {
                MomentaneNahrungspunkte -= removenahrung;
            }
            //Nächste Runde
            MomentaneRunde += 1;
            ReCalculatePunktestand();
            ReCalculateAvailablePeople();
        }

        public List<Bauelement> levelUp() {
            if (MomentaneBildungspunkte >= MomentanesLevel.LevelUpNeededBildungspunkte &&
                IstGeldmengeAusreichend(MomentanesLevel.LevelUpPreis))
            {
                GeldTransaktion(Transaktionsart.Kauf, MomentanesLevel.LevelUpPreis);
                Level nxtLevel = MomentanesLevel.LevelUpLevel;
                MomentanesLevel = nxtLevel;
                nc.nc_notificate(NotificationCenter.nc_props.nc_lvlup, nxtLevel);
                ReCalculatePunktestand();
                List<Bauelement> newElements = new List<Bauelement>();
                foreach (Bauelement element in BauelementeList) {
                    if (element.VerfuegbarAbLevelIndex == MomentanesLevel.LevelIndex) {
                        newElements.Add(element);
                    }
                }
                return newElements;
            }
            return null;
        }

        private void lvlupButton_Click(object sender, EventArgs e)
        {
            hideHUD();
            LevelUp lvlup = new LevelUp(MomentanesLevel, this);
            showOverlayWindow(lvlup, lvlupButton);
        }
        #endregion

        #region Grafische Gestaltung
        private void showOverlayWindow(Form wdw, Control onControl) {
            wdw.TopMost = true;
            int tp = this.Top + toolBarPanel.Top + onControl.Top + onControl.Height + 24;
            if (tp > System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - wdw.Height)
            {
                wdw.Top = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - wdw.Height;
            }
            else
            {
                wdw.Top = tp;
            }
            int lft = this.Left + onControl.Left + (onControl.Width / 2) - (wdw.Width / 2);
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

        public void ActualizeWindowTitle() {
            if (SaveGameTitle != "" && SaveGameTitle != null)
            {
                this.Text = startSettings.HauptfensterTitel + " - " + SaveGameTitle + " (Level " + MomentanesLevel.LevelIndex.ToString() + ")";
            }
            else {
                this.Text = startSettings.HauptfensterTitel + " - Level " + MomentanesLevel.LevelIndex.ToString();
            }
        }

        UserControl hudWindow;
        public void showHUD(UserControl hud) {
            bool animated = !nKFcaa.isBusy;
            //mainHUD.BackColor = Color.White;
            if (animated) nKFcaa.BeginAnimation(mainHUD);
            //mainHUD.BackColor = Color.Transparent;
            mainHUDContent.Visible = false;
            if (hudWindow != null)
            {
                mainHUD.Controls.Remove(hudWindow);
                hudWindow = null;
            }
            hudWindow = hud;
            hudWindow.Dock = DockStyle.Fill;
            hudWindow.BackColor = Color.Transparent;
            mainHUD.Controls.Add(hudWindow);
            hudWindow.BringToFront();
            if (animated) nKFcaa.CommitAnimation(300); //<-- scheint hier noch einen Bug zu haben...
        }
        public void hideHUD() {
            if (hudWindow == null)
            {
                return;
            }
            nKFcaa.BeginAnimation(mainHUD);
            mainHUD.Controls.Remove(hudWindow);
            mainHUDContent.Visible = true;
            hudWindow = null;
            nKFcaa.CommitAnimation(300);
        }

        public void moneyAnimation(bool got) {
            geldsumme.ForeColor = got ? Color.Yellow : Color.Red;

            //wir verschaffen uns ein zeitliches "polster", weil ansonsten mehrere animationen zugleich ablaufen würden
            //selbstverständlich kommt windows damit überhaupt nicht klar

            if (moneyAnimationTimer.Enabled)
            {
                moneyAnimationTimer.Stop();
            }
            moneyAnimationTimer.Start();
        }

        void moneyAnimationWaitEnd(object sender, EventArgs e)
        {
            Timer s = (Timer)sender;
            s.Stop();
            if (!nKFcaa.isBusy)
            {
                nKFcaa.BeginAnimation(geldsumme);
                geldsumme.ForeColor = Color.White;
                nKFcaa.CommitAnimation(1000);
            }
            else {
                geldsumme.ForeColor = Color.White;
            }
            s.Dispose(); //an den armen speicher denken
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            System.Drawing.RectangleF backRect = new RectangleF(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height);
            System.Drawing.Drawing2D.LinearGradientBrush backBrush =
                new System.Drawing.Drawing2D.LinearGradientBrush(backRect, Color.FromArgb(255, 255, 207, 0), Color.FromArgb(255, 247, 127, 7),
                    System.Drawing.Drawing2D.LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(backBrush, backRect);
            //Unteres Panel zeichnen
            //Rectangle botPanel = new Rectangle(0, toolBarPanel.Top, this.Width, toolBarPanel.Height);
            //System.Drawing.Drawing2D.LinearGradientBrush botBrush = new System.Drawing.Drawing2D.LinearGradientBrush(botPanel, Color.FromArgb(50, 0, 0, 0), Color.Transparent, System.Drawing.Drawing2D.LinearGradientMode.Vertical);
            //e.Graphics.FillRectangle(botBrush, botPanel);
            //e.Graphics.DrawLine(new Pen(Color.FromArgb(100, 0, 0, 0)), 0, toolBarPanel.Top-1, this.Width, toolBarPanel.Top-1);
            e.Graphics.DrawImageUnscaled(Properties.Resources.mwdwBottom, -1, this.ClientRectangle.Height - 62);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            IsActivated = true;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            IsActivated = false;
        }
        #endregion

        #region Casting
        public string castBauelementIntoEncodableString(Bauelement be)
        {
            if (be != null)
            {
                return be.Identifier;
            }
            else {
                return null;
            }
        }
        public Bauelement castEncodableStringIntoBauelement(string encodableString)
        {
            if (encodableString != "")
            {
                foreach (Bauelement be in BauelementeList) {
                    if (be.Identifier == encodableString) {
                        return be.returnClonedVersion(be);
                    }
                }
            }
            else {
                return null;
            }
            return null;
        }
        public Level getLevelByLevelIndex(int index)
        {
            Level testlevel = new Level1();
            while (testlevel != null) {
                if (testlevel.LevelIndex == index) {
                    return testlevel;
                }
                testlevel = testlevel.LevelUpLevel;
            }
            return null;
        }
        public void mergeFelderLists(List<Feld> oldList, List<Feld> newList)
        {
            for (int i = 0; i < oldList.Count; i++)
            {
                oldList[i].MomentanesBauelement = newList[i].MomentanesBauelement;
                oldList[i].MomentanePersonen = newList[i].MomentanePersonen;
                oldList[i].diedCounter = newList[i].diedCounter;
            }
        }
        #endregion

        #region Speichern und laden
        public bool saveActualGame(string title, string destinationPath) {
            SaveAndLoadManager salm = new SaveAndLoadManager();
            SaveAndLoadManager.Game actualGame = new SaveAndLoadManager.Game();
            actualGame.FelderList = FelderList;
            actualGame.Level = MomentanesLevel.LevelIndex;
            actualGame.Runde = MomentaneRunde;
            actualGame.Money = MomentanesGeld();
            actualGame.Nahrung = MomentaneNahrungspunkte;
            actualGame.Bildung = MomentaneBildungspunkte;
            nc.nc_notificate(NotificationCenter.nc_props.nc_save, null);
            return salm.SaveGameToXMLFile(this, actualGame, title, destinationPath);
        }
        public bool loadGameFromFile(string path) {
            try
            {
                SaveAndLoadManager salm = new SaveAndLoadManager();
                SaveAndLoadManager.Game newGame = salm.OpenGameFromXMLFile(this, path);
                MomentanesLevel = getLevelByLevelIndex(newGame.Level);
                mergeFelderLists(FelderList, newGame.FelderList);
                GeldTransaktion(Transaktionsart.Festlegung, newGame.Money);
                MomentaneNahrungspunkte = newGame.Nahrung;
                MomentaneBildungspunkte = newGame.Bildung;
                MomentaneRunde = newGame.Runde;
                SaveGamePath = path;
                SaveGameTitle = newGame.Title;
                GestorbenePersonen = reCalculateGestorbenePersonen();
                nc.nc_notificate(NotificationCenter.nc_props.nc_reset, null);
                ReCalculatePunktestand();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Allgemein
        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialisierung von Level 1
            MomentanesLevel = new Level1();
            //Initialisierung der Startfelder
            f1.MomentanesBauelement = new Haus();
            f2.MomentanesBauelement = new Hirsefeld();
            f2.MomentanePersonen = 5;
            ReCalculateAvailablePeople();
            //Developer Console einblenden
            devconsole = new DeveloperConsole(this);
            if (startSettings.DeveloperMode) {
                showDevConsole();
            }
            startup = false;
        }

        public void showDevConsole()
        {
            if (devconsole == null || devconsole.IsDisposed)
            {
                devconsole = new DeveloperConsole(this);
            }
            devconsole.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NahrungVerkaufen wdw = new NahrungVerkaufen(this);
            showHUD(wdw);
        }


        private void infoButton_Click(object sender, EventArgs e)
        {
            About aboutWindow = new About();
            nKF.Dialog.FormSheet s = new nKF.Dialog.FormSheet(aboutWindow, this);
            s.DisableFormFunctions = true;
            s.ShowSheet();
        }

        private void beduerfnisButton_Click(object sender, EventArgs e)
        {
            Beduerfnisse bWdw = new Beduerfnisse(MomentanesLevel, this);
            showHUD(bWdw);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (donotclose && !InstantClose)
            {
                //präsimodus
                if (MessageBox.Show("Willst du dein Spiel wirklich beenden?", "Beenden", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    devconsole.runCommand("clearall");
                    devconsole.runCommand("initstartsettings");
                    devconsole.runCommand("resetlevel");
                    devconsole.runCommand("build 0, haus");
                    devconsole.runCommand("build 1, hirsefeld");
                    devconsole.runCommand("setpeople 1, 5");
                    devconsole.runCommand("closesavegame");
                }
                e.Cancel = true;
                return;
            }
            if (!InstantClose) {
                //Savegame-Meldung anzeigen
                if (SaveGameTitle == "" || SaveGameTitle == null) {
                    //Kein Savegame erstellt
                    if (MessageBox.Show("Wenn du das Spiel beendest, gehen alle Fortschritte verloren. Willst du Bulu wirklich beenden?",
                      "Beenden", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                     //Nicht aktuelles Savegame
                    DialogResult diagres = MessageBox.Show("Soll das aktuelle Spiel '" + SaveGameTitle + "' vor dem Beenden gespeichert werden?", "Beenden", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                    if (diagres == System.Windows.Forms.DialogResult.Yes) {
                        saveActualGame(SaveGameTitle, SaveGamePath);
                    }
                    else if (diagres == System.Windows.Forms.DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void saveAndLoadButton_Click(object sender, EventArgs e)
        {
            SaveAndLoadDialog sald = new SaveAndLoadDialog(this);
            nKF.Dialog.FormSheet s = new nKF.Dialog.FormSheet(sald, this);
            s.DisableFormFunctions = true;
            s.ShowSheet();
        }

        private void buluButton1_Click(object sender, EventArgs e)
        {
            Achievements ach = new Achievements(this);
            ach.sheet = new nKF.Dialog.FormSheet(ach, this);
            ach.sheet.DisableFormFunctions = true;
            ach.sheet.ShowSheet();
        }

        bool killAchWindowAfterAnimation = false;
        public void showAchievementOverlay(string content) {
            if (achievedWindow != null)
            {
                achievedWindow.setContent(content);
                return;
            }
            achievedWindow = new AchievedWindow(this);
            achievedWindow.Top = this.ClientRectangle.Height;
            achievedWindow.Left = this.ClientRectangle.Width - achievedWindow.Width;
            achievedWindow.setContent(content);
            this.Controls.Add(achievedWindow);
            achievedWindow.BringToFront();
            nKF.Controls.Frame f = new nKF.Controls.Frame(achievedWindow);
            f.y = this.ClientRectangle.Height - f.height;
            killAchWindowAfterAnimation = false;
            try
            {
                nKFcfa.SetFrameAnimated(achievedWindow, f, nKF.Animation.Animator.AnimationCurve.EaseOut, 300);
            }
            catch
            {

                f.ApplyToControl(achievedWindow);
            }
        }
        public void hideAchievementOverlay() {
            if (achievedWindow == null)
            {
                return;
            }
            nKF.Controls.Frame f = new nKF.Controls.Frame(achievedWindow);
            f.y = this.ClientRectangle.Height;
            killAchWindowAfterAnimation = true;
            nKFcfa.SetFrameAnimated(achievedWindow, f, nKF.Animation.Animator.AnimationCurve.EaseIn, 300);
        }
        void nKFcfa_AnimationFinished(nKF.Animation.ControlFrameAnimator sender)
        {
            if (killAchWindowAfterAnimation)
            {
                this.Controls.Remove(achievedWindow);
                achievedWindow.Dispose();
                achievedWindow = null;
                killAchWindowAfterAnimation = false;
            }
        }

        public void playTetris() {
            foreach (Feld feld in FelderList)
            {
                feld.Visible = false;
            }
            TetrisPanel t = new TetrisPanel();
            t.Top = 0;
            t.Left = 0;
            this.Controls.Add(t);
        }
        #endregion

        #region Update
        private void BuluUpdater_updateInstallerStarted_1(object sender, updateSystemDotNet.appEventArgs.updateInstallerStartedEventArgs e)
        {
            //Wenn Updates gefunden wurden, Bulu schließen
            InstantClose = true;
            this.Close();
            Application.Exit();
        }

        private void BuluUpdater_updateFound_1(object sender, updateSystemDotNet.appEventArgs.updateFoundEventArgs e)
        {
            if (BuluUpdater.showUpdateDialog() == DialogResult.OK)
            {
                if (BuluUpdater.downloadUpdatesDialog() == DialogResult.OK)
                {
                    BuluUpdater.applyUpdate();
                }
            }
        }
        public void checkForUpdates() {
            //Update durchführen mit UpdateSystem.net
            // http://updatesystem.net
            if (BuluUpdater.checkForUpdatesDialog() == DialogResult.OK)
            {
                if (BuluUpdater.showUpdateDialog() == DialogResult.OK)
                {
                    if (BuluUpdater.downloadUpdatesDialog() == DialogResult.OK)
                    {
                        BuluUpdater.applyUpdate();
                    }
                }
            }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            checkForUpdates();
        }
        #endregion
    }
}
