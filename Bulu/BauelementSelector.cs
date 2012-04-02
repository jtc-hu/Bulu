// --------------------------------
// --- BauelementSelector.cs
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
    public partial class BauelementSelector : Form
    {
        List<Bauelement> Bauelemente;
        Feld parentFeld;
        Form1 parentForm1;
        public BauelementSelector(List<Bauelement> arrayVonBauelementen, Object sender)
        {
            InitializeComponent();
            Bauelemente = arrayVonBauelementen;
            parentFeld = (Feld)sender;
            parentForm1 = (Form1)parentFeld.Parent;
            foreach (Bauelement be in Bauelemente) { 
                if (be.BuyAllowed && be.VerfuegbarAbLevelIndex <= parentForm1.MomentanesLevel.LevelIndex) {
                    ListViewItem item = new ListViewItem(be.Text);
                    item.SubItems.Add(be.BuyPreis.ToString());
                    Image thumbgrafik = Properties.Resources.leer;
                    if (be.Grafik != null) { thumbgrafik = be.Grafik; }
                    bauemelentThumbnails.Images.Add(be.Text, thumbgrafik);
                    item.ImageKey = be.Text;
                    item.Tag = be;
                    if (parentForm1.IstGeldmengeAusreichend(be.BuyPreis) == false) {
                        item.ForeColor = Color.Gray;
                    }
                    if (be.BuyNeededBildungspunkte > parentForm1.MomentaneBildungspunkte) {
                        item.ForeColor = Color.Gray;
                    }
                    if (be.MaximumFieldAmount > 0) {
                        if (parentForm1.AmountOfActiveBauelemente(be) >= be.MaximumFieldAmount) {
                            item.ForeColor = Color.Gray;
                        }
                    }
                    listViewAero1.Items.Add(item);
                }
            }
            if (parentForm1.eastereggEnabled)
            {
                ListViewItem item = new ListViewItem("Tetris");
                item.SubItems.Add("π");
                item.Tag = null;
                listViewAero1.Items.Add(item);
            }
        }

        private void BauelementSelector_Deactivate(object sender, EventArgs e)
        { 
            parentFeld.parentOpened = false;
            parentForm1.ReCalculatePunktestand();
            this.Close();
        }

        private void listViewAero1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewItem selectedItem = listViewAero1.SelectedItems[0];
                needs.ForeColor = Color.Black;
                if (selectedItem.Tag == null && selectedItem.Text == "Tetris")
                {
                    descr.Text = "Wenn Bulu zu langweilig ist kannst du auch Tetris spielen!!!";
                    return;
                }
                Bauelement be = (Bauelement)selectedItem.Tag;
                descr.Text = be.Description;
                if (parentForm1.IstGeldmengeAusreichend(be.BuyPreis) == false) {
                    needs.Text = "Geldmenge nicht ausreichend.";
                    needs.ForeColor = Color.Red;
                }
                else if (be.BuyNeededBildungspunkte > parentForm1.MomentaneBildungspunkte) {
                    needs.Text = "Zu wenig Bildungspunkte. Benötigt: " + be.BuyNeededBildungspunkte.ToString();
                    needs.ForeColor = Color.Red;
                }
                else if (be.MaximumFieldAmount > 0 && parentForm1.AmountOfActiveBauelemente(be) >= be.MaximumFieldAmount)
                {
                    needs.Text = "Maximale Anzahl erreicht.";
                    needs.ForeColor = Color.Red;
                }
                else if (be.MaxPersonenanzahl == 0 && be.ErtragsMultiplier > 1)
                {
                    needs.Text = "Verbessert Erträge um das " + be.ErtragsMultiplier.ToString() + "-fache.";
                }
                else if (be.BuyNeededBildungspunkte > 0 && be.MaxPersonenanzahl > 0)
                {
                    needs.Text = "Benötigt " + be.BuyNeededBildungspunkte.ToString() + " Bildungspunkte und " + be.MaxPersonenanzahl.ToString() + "freie Personen.";
                }
                else if (be.BuyNeededBildungspunkte > 0 && be.MaxPersonenanzahl == 0)
                {
                    needs.Text = "Benötigt " + be.BuyNeededBildungspunkte.ToString() + " Bildungspunkte.";
                }
                else if (be.BuyNeededBildungspunkte == 0 && be.MaxPersonenanzahl > 0)
                {
                    needs.Text = "Benötigt " + be.MaxPersonenanzahl.ToString() + " freie Personen.";
                }
                else
                {
                    needs.Text = "";
                }
            }
            catch { 
            
            }
        }

        private void listViewAero1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ListViewItem selectedItem = listViewAero1.SelectedItems[0];
                if (selectedItem.Tag == null && selectedItem.Text == "Tetris")
                {
                    parentForm1.playTetris();
                    this.Close();
                    return;
                }
                Bauelement be = (Bauelement)selectedItem.Tag;
                if (be.MaximumFieldAmount > 0 && parentForm1.AmountOfActiveBauelemente(be) >= be.MaximumFieldAmount)
                {
                    System.Media.SystemSounds.Beep.Play();
                }
                else if (be.BuyNeededBildungspunkte > parentForm1.MomentaneBildungspunkte)
                {
                    System.Media.SystemSounds.Beep.Play();
                }
                else if (parentForm1.IstGeldmengeAusreichend(be.BuyPreis))
                {
                    if (parentForm1.GeldTransaktion(Form1.Transaktionsart.Kauf, be.BuyPreis))
                    {
                        parentFeld.MomentanesBauelement = be.returnClonedVersion(be);
                        parentForm1.ReCalculatePunktestand();
                        parentForm1.ReCalculateAvailablePeople();
                        parentForm1.nc.nc_notificate(NotificationCenter.nc_props.nc_build_field, be);
                        parentForm1.nc.nc_notificate(NotificationCenter.nc_props.nc_build_freefields, parentForm1.FreieFelder);
                        this.Close();
                    }
                }
                else
                {
                    System.Media.SystemSounds.Beep.Play();
                }
            }
            catch { 
            
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
    }
}
