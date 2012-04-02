// --------------------------------
// --- SaveAndLoadDialog.cs
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
    public partial class SaveAndLoadDialog : nKF.Controls.OverlayUserControl
    {
        Form1 senderForm1;
        nKF.Animation.ControlFrameAnimator nKFcfa = new nKF.Animation.ControlFrameAnimator();
        nKF.Animation.ControlAttributeAnimator nKFcaa = new nKF.Animation.ControlAttributeAnimator();

        public SaveAndLoadDialog(Object sender)
        {
            InitializeComponent();
            senderForm1 = (Form1)sender;
            nKFcfa.AnimationFinished += new nKF.Animation.ControlFrameAnimator.AnimationFinishedEventHandler(nKFcfa_AnimationFinished);
            nKFcaa.AnimationFinished += new nKF.Animation.ControlAttributeAnimator.AnimationFinishedEventHandler(nKFcaa_AnimationFinished);
        }
        
        private void gradientPanel_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            System.Drawing.RectangleF backRect = new RectangleF(0, 0, gradientPanel.Width, gradientPanel.Height);
            System.Drawing.Drawing2D.LinearGradientBrush backBrush =
                new System.Drawing.Drawing2D.LinearGradientBrush(backRect, Color.FromArgb(255, 255, 207, 0), Color.FromArgb(255, 247, 127, 7),
                    System.Drawing.Drawing2D.LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(backBrush, backRect);
        }

        private void buluButton1_Click(object sender, EventArgs e)
        {
            if (buluButton1.Tag == null)
            {
                PrepareSavingNewGame();
            }
            else if ((string)buluButton1.Tag == "newgame")
            {
                SaveNewGame();
            }
            else {
                SaveExistingGame();
            }
        }


        bool animationGrow;
        void nKFcfa_AnimationFinished(nKF.Animation.ControlFrameAnimator sender)
        {
            if (animationGrow)
            {
                nKFcaa.BeginAnimation(gradientPanel);
                buluButton1.Caption = "Speichern";
                savegameLabel.Visible = true;
                savegameName.Visible = true;
                nKFcaa.CommitAnimation(200);
            }
        }

        void nKFcaa_AnimationFinished(nKF.Animation.ControlAttributeAnimator sender)
        {
            savegameName.Select();
            savegameName.SelectAll();
        }

        private void PrepareSavingNewGame() {
            animationGrow = true;
            nKF.Controls.Frame f = new nKF.Controls.Frame(gradientPanel);
            f.height = 113;
            nKFcfa.SetFrameAnimated(gradientPanel, f, nKF.Animation.Animator.AnimationCurve.EaseInAndOut, 200);
            buluButton1.Tag = "newgame";
        }

        public void SaveExistingGame() {
            senderForm1.saveActualGame(senderForm1.SaveGameTitle, senderForm1.SaveGamePath);
            buluButton1.Caption = "Aktuelles Spiel gespeichert.";
            buluButton1.Enabled = false;
            ReloadSaveGameList();
        }

        private void SaveNewGame() {
            if (savegameName.Text == "")
            {
                System.Media.SystemSounds.Beep.Play();
                return;
            }
            if (savegameName.Text == "Bulu ist scheiße, ich will Tetris")
            {
                senderForm1.eastereggEnabled = true;
            }
            SaveAndLoadManager salm = new SaveAndLoadManager();
            string destpath =  System.IO.Path.Combine(salm.GetCurrentSaveGamePath(), salm.ConvertIntoValidFileName(savegameName.Text, "xml"));
            senderForm1.saveActualGame(savegameName.Text, destpath);
            senderForm1.SaveGamePath = destpath;
            senderForm1.SaveGameTitle = savegameName.Text;
            ReloadSaveGameList();
            savegameName.Visible = false;
            savegameLabel.Visible = false;
            buluButton1.Caption = "Aktuelles Spiel gespeichert.";
            buluButton1.Enabled = false;
            animationGrow = false;
            nKF.Controls.Frame f = new nKF.Controls.Frame(gradientPanel);
            f.height = 62;
            nKFcfa.SetFrameAnimated(gradientPanel, f, nKF.Animation.Animator.AnimationCurve.EaseInAndOut, 300);
        }

        private void gradientPanel_Resize(object sender, EventArgs e)
        {
            gradientPanel.Invalidate();
        }

        private void SaveAndLoadDialog_Load(object sender, EventArgs e)
        {
            ReloadSaveGameList();
            if (senderForm1.SaveGameTitle != "" && senderForm1.SaveGameTitle != null)
            {
                buluButton1.Caption = "'" + senderForm1.SaveGameTitle + "' speichern";
                buluButton1.Tag = senderForm1.SaveGamePath;
                buluButton1.ContextMenuStrip = savecmenu;
            }
        }

        private void ReloadSaveGameList() {
            SaveGameListView.Items.Clear();
            ListViewItem ng = new ListViewItem("Neues Spiel");
            ng.Tag = "newgame";
            ng.ForeColor = Color.Blue;
            SaveGameListView.Items.Add(ng);
            SaveAndLoadManager salm = new SaveAndLoadManager();
            foreach (SaveAndLoadManager.SaveGame savegame in salm.ReturnListOfSaveGames(salm.GetCurrentSaveGamePath()))
            {
                ListViewItem li = new ListViewItem(savegame.Title);
                li.SubItems.Add(savegame.Date);
                li.Tag = savegame.Path;
                SaveGameListView.Items.Add(li);
            }
        }

        private void savegameName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                if (savegameName.Text.ToLower() == "developer")
                { //Geheime Funktion, um die Developer Console auch ohne aktivierten Developer Mode zu öffnen.
                    senderForm1.showDevConsole();
                    return;
                }
                SaveNewGame();
            }
        }

        private void SaveGameListView_DoubleClick(object sender, EventArgs e)
        {
            //Sicherstellen ob ein Savegame ausgewählt ist
            string savegamepath;
            try
            {
                savegamepath = (string)SaveGameListView.SelectedItems[0].Tag;
            }
            catch {
                return;
            }
            //Ausgewähltes Savegame laden, vorher fragen usw.
            if (buluButton1.Enabled == true) {
                if (buluButton1.Tag == null || (string)buluButton1.Tag == "newgame")
                {
                    //Spiel noch nicht gespeichert
                    DialogResult warndiag = MessageBox.Show("Das aktuelle Spiel wurde noch nicht gespeichert. Möchtest du es vor dem Laden speichern?", "Speichern", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                    if (warndiag == System.Windows.Forms.DialogResult.Yes)
                    {
                        PrepareSavingNewGame();
                        return;
                    }
                    else if (warndiag == System.Windows.Forms.DialogResult.Cancel)
                    {
                        return;
                    }
                }
                else {
                    //Spieldatei nicht aktuell
                    DialogResult warndiag = MessageBox.Show("Das Spiel '" + senderForm1.SaveGameTitle + "' wurde noch nicht gespeichert. Möchtest du es vor dem Laden speichern?", "Speichern", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                    if (warndiag == System.Windows.Forms.DialogResult.Yes)
                    {
                        SaveExistingGame();
                    }
                    else if (warndiag == System.Windows.Forms.DialogResult.Cancel)
                    {
                        return;
                    }
                }
            }
            //Nachdem wir sichergestellt haben, dass "User" das neue Savegame laden will, können wir anfangen
            if (savegamepath == "newgame") {
                //Hier machen wir uns mal die "integrierte Konsole" zum Nutzen.
                //Das spart Code und Zeit. Und Zeit haben wir echt nicht viel.
                DeveloperConsole devcon = new DeveloperConsole(senderForm1);
                devcon.runCommand("clearall");
                devcon.runCommand("initstartsettings");
                devcon.runCommand("resetlevel");
                devcon.runCommand("build 0, haus");
                devcon.runCommand("build 1, hirsefeld");
                devcon.runCommand("setpeople 1, 5");
                senderForm1.SaveGamePath = "";
                senderForm1.SaveGameTitle = "";
                senderForm1.ReCalculatePunktestand();
            }
            else
            {
                senderForm1.loadGameFromFile(savegamepath);
            }
            this.HideOverlay(false);
        }

        private void spielstandLoeschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void unterNeuemNamenSpeichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrepareSavingNewGame();
            buluButton1.ContextMenuStrip = null;
        }

        private void nKButton1_Click(object sender, EventArgs e)
        {
            this.HideOverlay(true);
        }

        private void SaveGameListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (SaveGameListView.SelectedItems[0] != null && SaveGameListView.SelectedIndices[0] != 0)
                {
                    spielstandLoeschenButton.Visible = true;
                }
                else
                {
                    spielstandLoeschenButton.Visible = false;
                }
            }
            catch
            {
                spielstandLoeschenButton.Visible = false;
            }
        }

        private void spielstandLoeschenButton_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = SaveGameListView.SelectedItems[0];
                if (MessageBox.Show("Soll der Spielstand '" + item.Text + "' wirklich gelöscht werden?","Bulu",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    System.IO.File.Delete((string)item.Tag);
                    ReloadSaveGameList();
                }
            }
            catch { }
        }
    }
}
