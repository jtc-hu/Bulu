// --------------------------------
// --- BauelementEditor.cs
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
    public partial class BauelementEditor : Form
    {
        bool disableAutoClose = false;
        Bauelement zuBearbeitendesBauelement;
        Feld senderFeld;
        Form1 senderForm1;
        public BauelementEditor(Bauelement element, Object sender)
        {
            InitializeComponent();
            zuBearbeitendesBauelement = element;
            senderFeld = (Feld)sender;
            senderForm1 = (Form1)senderFeld.Parent;
            if (zuBearbeitendesBauelement.MaxPersonenanzahl > 0)
            {
                if (zuBearbeitendesBauelement.MaxPersonenanzahl < senderForm1.FreiePersonen + senderFeld.MomentanePersonen)
                {
                    trackBar1.Maximum = zuBearbeitendesBauelement.MaxPersonenanzahl;
                }
                else {
                    trackBar1.Maximum = senderForm1.FreiePersonen + senderFeld.MomentanePersonen;
                }
                if (trackBar1.Maximum > 0) {
                    trackBar1.Value = senderFeld.MomentanePersonen;
                    perspanel.Enabled = true;
                }
                perschangertext.Text = senderFeld.MomentanePersonen.ToString() + "/" +
                         zuBearbeitendesBauelement.MaxPersonenanzahl.ToString();
                personendescr.Text = "Maximale Personen:";
                personen.Text = zuBearbeitendesBauelement.MaxPersonenanzahl.ToString();
            }
            else {
                if (zuBearbeitendesBauelement.GeliefertePersonen > 0) {
                    trackBar1.Maximum = zuBearbeitendesBauelement.GeliefertePersonen;
                    trackBar1.Value = zuBearbeitendesBauelement.GeliefertePersonen;
                    perschangertext.Text = zuBearbeitendesBauelement.GeliefertePersonen.ToString() + "/" +
                        zuBearbeitendesBauelement.GeliefertePersonen.ToString();
                }
                if (zuBearbeitendesBauelement.ErtragsMultiplier > 1)
                {
                    personendescr.Text = "Ertrags-Steigerung:";
                    personen.Text = zuBearbeitendesBauelement.ErtragsMultiplier.ToString() + "fach";
                }
                else
                {
                    personendescr.Text = "Enthaltene Personen:";
                    if (senderFeld.diedCounter > 0)
                    {
                        int died = senderFeld.diedCounter;
                        personen.Text = zuBearbeitendesBauelement.GeliefertePersonen.ToString() + " (-" + died.ToString() + ")";
                    }
                    else
                    {
                        personen.Text = zuBearbeitendesBauelement.GeliefertePersonen.ToString();
                    }
                }
                perschangertext.Text = "-/-";
                trackBar1.Maximum = 0;
            }
            if (zuBearbeitendesBauelement.GeldProPersonProRunde > 0)
            {
                bpdescr.Text = "Geld pro Runde:";
                int gprorunde = zuBearbeitendesBauelement.GeldProPersonProRunde * senderFeld.MomentanePersonen;
                bpprorunde.Text = gprorunde.ToString();
            }
            else {
                bpdescr.Text = "Bildungspunkte pro Runde:";
                int bpprorundeint = zuBearbeitendesBauelement.BildungspunkteProPersonProRunde * senderFeld.MomentanePersonen;
                bpprorunde.Text = bpprorundeint.ToString();
            }
            int npprorundeint = zuBearbeitendesBauelement.NahrungspunkteProPersonProRunde * senderFeld.MomentanePersonen;
            npprorunde.Text = npprorundeint.ToString();
            benoetigtebp.Text = zuBearbeitendesBauelement.BuyNeededBildungspunkte.ToString();
            if (zuBearbeitendesBauelement.UpgradeAllowed && zuBearbeitendesBauelement.UpgradeBauelement.VerfuegbarAbLevelIndex <= senderForm1.MomentanesLevel.LevelIndex)
            {
                upgradeButton.Text = "Upgrade auf " + zuBearbeitendesBauelement.UpgradeBauelement.Text + " für " +
                    zuBearbeitendesBauelement.UpgradePreis.ToString() + " " + senderForm1.startSettings.Waehrung;
                upgradeButton.Enabled = true;
            }
            else {
                upgradeButton.Text = "Kein Upgrade verfügbar.";
                upgradeButton.Enabled = false;
            }
            descr.Text = zuBearbeitendesBauelement.Text;
            if (senderForm1.MomentanesLevel.AbrissPreis > 0)
            {
                abrissButton.Text = "Abreißen für " + senderForm1.MomentanesLevel.AbrissPreis + " " + senderForm1.startSettings.Waehrung;
            }
            else {
                abrissPanel.Visible = false;
                this.Height = 202;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            perschangertext.Text = trackBar1.Value.ToString() + "/" + zuBearbeitendesBauelement.MaxPersonenanzahl.ToString();
            senderFeld.MomentanePersonen = trackBar1.Value;
            if (zuBearbeitendesBauelement.GeldProPersonProRunde > 0)
            {
                int gprorunde = zuBearbeitendesBauelement.GeldProPersonProRunde * senderFeld.MomentanePersonen;
                bpprorunde.Text = gprorunde.ToString();
            }
            else
            {
                int bpprorundeint = zuBearbeitendesBauelement.BildungspunkteProPersonProRunde * senderFeld.MomentanePersonen;
                bpprorunde.Text = bpprorundeint.ToString();
            }
            int npprorundeint = zuBearbeitendesBauelement.NahrungspunkteProPersonProRunde * senderFeld.MomentanePersonen;
            npprorunde.Text = npprorundeint.ToString();
            senderForm1.ReCalculateAvailablePeople();
        }

        private void BauelementEditor_Deactivate(object sender, EventArgs e)
        {
            if (!disableAutoClose)
            {
                senderFeld.parentOpened = false;
                senderForm1.ReCalculatePunktestand();
                this.Close();
            }
        }

        private void upgradeButton_MouseEnter(object sender, EventArgs e)
        {
            Color c = Color.Green;
            if (zuBearbeitendesBauelement.UpgradeAllowed)
            {
                if (senderForm1.IstGeldmengeAusreichend(zuBearbeitendesBauelement.UpgradePreis) == false) {
                    upgradeButton.Text = "Nicht genügend Geld.";
                    c = Color.Red;
                }
                if (zuBearbeitendesBauelement.UpgradeBauelement.BuyNeededBildungspunkte > senderForm1.MomentaneBildungspunkte) {
                    upgradeButton.Text = "Nicht genügend Bildungspunkte.";
                    c = Color.Red;
                }
            }
            descr.Text = "Upgrade auf " + zuBearbeitendesBauelement.UpgradeBauelement.Text + ":";
            descr.ForeColor = c;
            personen.ForeColor = c;
            bpprorunde.ForeColor = c;
            npprorunde.ForeColor = c;
            benoetigtebp.ForeColor = c;
            if (zuBearbeitendesBauelement.UpgradeBauelement.MaxPersonenanzahl > 0)
            {
                personendescr.Text = "Maximale Personen:";
                personen.Text = zuBearbeitendesBauelement.UpgradeBauelement.MaxPersonenanzahl.ToString();
            }
            else
            {
                if (zuBearbeitendesBauelement.UpgradeBauelement.ErtragsMultiplier > 1)
                {
                    personendescr.Text = "Ertrags-Steigerung:";
                    personen.Text = zuBearbeitendesBauelement.UpgradeBauelement.ErtragsMultiplier.ToString() + "fach";
                }
                else
                {
                    personendescr.Text = "Enthaltene Personen:";
                    personen.Text = zuBearbeitendesBauelement.UpgradeBauelement.GeliefertePersonen.ToString();
                }
            }
            if (zuBearbeitendesBauelement.GeldProPersonProRunde > 0)
            {
                bpdescr.Text = "Geld pro Runde:";
                int gprorunde = zuBearbeitendesBauelement.UpgradeBauelement.GeldProPersonProRunde * senderFeld.MomentanePersonen;
                bpprorunde.Text = gprorunde.ToString();
            }
            else
            {
                bpdescr.Text = "Bildungspunkte pro Runde:";
                int bpprorundeint = zuBearbeitendesBauelement.UpgradeBauelement.BildungspunkteProPersonProRunde * senderFeld.MomentanePersonen;
                bpprorunde.Text = bpprorundeint.ToString();
            }
            int npprorundeint = zuBearbeitendesBauelement.UpgradeBauelement.NahrungspunkteProPersonProRunde * senderFeld.MomentanePersonen;
            npprorunde.Text = npprorundeint.ToString();
            benoetigtebp.Text = zuBearbeitendesBauelement.UpgradeBauelement.BuyNeededBildungspunkte.ToString();
            if (zuBearbeitendesBauelement.UpgradeBauelement.BuyNeededBildungspunkte > senderForm1.MomentaneBildungspunkte)
            {
                benoetigtebp.Text = benoetigtebp.Text + " (!)";
            }
        }

        private void upgradeButton_MouseLeave(object sender, EventArgs e)
        {
            if (zuBearbeitendesBauelement.UpgradeAllowed)
            {
                upgradeButton.Text = "Upgrade auf " + zuBearbeitendesBauelement.UpgradeBauelement.Text + " für " +
                    zuBearbeitendesBauelement.UpgradePreis.ToString() + " " + senderForm1.startSettings.Waehrung;
            }
            descr.Text = zuBearbeitendesBauelement.Text;
            descr.ForeColor = Color.Navy;
            personen.ForeColor = Color.Black;
            bpprorunde.ForeColor = Color.Black;
            npprorunde.ForeColor = Color.Black;
            benoetigtebp.ForeColor = Color.Black;
            if (zuBearbeitendesBauelement.MaxPersonenanzahl > 0)
            {
                personendescr.Text = "Maximale Personen:";
                personen.Text = zuBearbeitendesBauelement.MaxPersonenanzahl.ToString();
            }
            else
            {
                if (zuBearbeitendesBauelement.ErtragsMultiplier > 1)
                {
                    personendescr.Text = "Ertrags-Steigerung:";
                    personen.Text = zuBearbeitendesBauelement.ErtragsMultiplier.ToString() + "fach";
                }
                else
                {
                    personendescr.Text = "Enthaltene Personen:";
                    if (senderFeld.diedCounter > 0)
                    {
                        int died = senderFeld.diedCounter;
                        personen.Text = zuBearbeitendesBauelement.GeliefertePersonen.ToString() + " (-" + died.ToString() + ")";
                    }
                    else
                    {
                        personen.Text = zuBearbeitendesBauelement.GeliefertePersonen.ToString();
                    }
                }
            }
            if (zuBearbeitendesBauelement.GeldProPersonProRunde > 0)
            {
                bpdescr.Text = "Geld pro Runde:";
                int gprorunde = zuBearbeitendesBauelement.GeldProPersonProRunde * senderFeld.MomentanePersonen;
                bpprorunde.Text = gprorunde.ToString();
            }
            else
            {
                bpdescr.Text = "Bildungspunkte pro Runde:";
                int bpprorundeint = zuBearbeitendesBauelement.BildungspunkteProPersonProRunde * senderFeld.MomentanePersonen;
                bpprorunde.Text = bpprorundeint.ToString();
            }
            int npprorundeint = zuBearbeitendesBauelement.NahrungspunkteProPersonProRunde * senderFeld.MomentanePersonen;
            npprorunde.Text = npprorundeint.ToString();
            benoetigtebp.Text = zuBearbeitendesBauelement.BuyNeededBildungspunkte.ToString();
        }

        private void upgradeButton_Click(object sender, EventArgs e)
        {
            if (senderForm1.IstGeldmengeAusreichend(zuBearbeitendesBauelement.UpgradePreis) && zuBearbeitendesBauelement.UpgradeBauelement.BuyNeededBildungspunkte <= senderForm1.MomentaneBildungspunkte)
            {
                if (senderForm1.GeldTransaktion(Form1.Transaktionsart.Kauf, zuBearbeitendesBauelement.UpgradePreis))
                {
                    senderFeld.MomentanesBauelement = zuBearbeitendesBauelement.UpgradeBauelement.returnClonedVersion(zuBearbeitendesBauelement.UpgradeBauelement);
                    senderForm1.ReCalculatePunktestand();
                    senderForm1.ReCalculateAvailablePeople();
                    this.Close();
                }
            }
            else {
                System.Media.SystemSounds.Beep.Play();
            }
        }

        #region PopOver Fenster Resize-Pfeile deaktivieren
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            //Spezialmethode zum Deaktivieren der "Resize"-Pfeile an den Fensterenden
            //Wird in den PopOver-Fenstern benötigt
            base.WndProc(ref m);
            if (m.Msg == 0x84)
            {
                switch (m.Result.ToInt64())
                {
                    case 10L:
                        m.Result = new IntPtr(18L);
                        break;
                    case 11L:
                        m.Result = new IntPtr(18L);
                        break;
                    case 12L:
                        m.Result = new IntPtr(18L);
                        break;
                    case 13L:
                        m.Result = new IntPtr(18L);
                        break;
                    case 14L:
                        m.Result = new IntPtr(18L);
                        break;
                    case 15L:
                        m.Result = new IntPtr(18L);
                        break;
                    case 16L:
                        m.Result = new IntPtr(18L);
                        break;
                    case 17L:
                        m.Result = new IntPtr(18L);
                        break;
                }
            }
        }
#endregion

        private void abrissButton_MouseEnter(object sender, EventArgs e)
        {
            if (senderForm1.IstGeldmengeAusreichend(senderForm1.MomentanesLevel.AbrissPreis) == false)
            {
                abrissButton.Text = "Nicht genügend Geld.";
            }
        }

        private void abrissButton_MouseLeave(object sender, EventArgs e)
        {
            abrissButton.Text = "Abreißen für " + senderForm1.MomentanesLevel.AbrissPreis + " " + senderForm1.startSettings.Waehrung;

        }

        private void abrissButton_Click(object sender, EventArgs e)
        {
            disableAutoClose = true;
            if (senderForm1.IstGeldmengeAusreichend(senderForm1.MomentanesLevel.AbrissPreis))
            {
                //Haus-Check
                if (zuBearbeitendesBauelement.GeliefertePersonen > 0)
                {
                    if (senderForm1.FreiePersonen < zuBearbeitendesBauelement.GeliefertePersonen)
                    {
                        MessageBox.Show("Die Personen, die auf diesem Feld leben, dürfen in keinem Feld mehr beschäftigt sein bevor das Feld abgerissen wird.", "Bulu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        disableAutoClose = false;
                        return;
                    }
                }
                //Ertragsfeld-Check
                if (zuBearbeitendesBauelement.MaxPersonenanzahl > 0)
                {
                    if (senderFeld.MomentanePersonen > 0)
                    {
                        MessageBox.Show("Auf einem Feld dürfen keine Personen mehr beschäftigt sein, bevor es abgerissen wird.", "Bulu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        disableAutoClose = false;
                        return;
                    }
                }
                //Abriss okay!
                if (MessageBox.Show("Willst du dieses Feld wirklich abreißen?","Bulu",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    //Letzte Erträge durchrechnen
                    if (zuBearbeitendesBauelement.NahrungspunkteProPersonProRunde > 0)
                    {
                        senderForm1.MomentaneNahrungspunkte += zuBearbeitendesBauelement.NahrungspunkteProPersonProRunde * zuBearbeitendesBauelement.MaxPersonenanzahl;
                    }
                    //Abreißen
                    senderForm1.GeldTransaktion(Form1.Transaktionsart.Kauf, senderForm1.MomentanesLevel.AbrissPreis);
                    senderFeld.MomentanesBauelement = null;
                    senderForm1.nc.nc_notificate(NotificationCenter.nc_props.nc_destroy, senderFeld);
                    senderFeld.parentOpened = false;
                    senderForm1.ReCalculatePunktestand();
                    senderForm1.ReCalculateAvailablePeople();
                    this.Close();
                }
            }
            else
            {
                System.Media.SystemSounds.Beep.Play();
            }
            disableAutoClose = false;
        }
    }
}
