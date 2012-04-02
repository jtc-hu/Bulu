// --------------------------------
// --- NahrungVerkaufen.cs
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
    public partial class NahrungVerkaufen : UserControl
    {
        Form1 senderForm1;
        public NahrungVerkaufen(Object sender)
        {
            InitializeComponent();
            senderForm1 = (Form1)sender;
            mengelbl.Text = senderForm1.MomentaneNahrungspunkte.ToString();
            int preis = senderForm1.MomentaneNahrungspunkte * senderForm1.MomentanesLevel.GeldProNahrungspunkt;
            preislbl.Text = preis.ToString() + " " + senderForm1.startSettings.Waehrung;
        }

        private void buluButton1_Click(object sender, EventArgs e)
        {
            int preis = senderForm1.MomentaneNahrungspunkte * senderForm1.MomentanesLevel.GeldProNahrungspunkt;
            senderForm1.MomentaneNahrungspunkte = 0;
            senderForm1.GeldTransaktion(Form1.Transaktionsart.Einzahlung, preis);
            senderForm1.nc.nc_notificate(NotificationCenter.nc_props.nc_nsell, preis);
            senderForm1.ReCalculatePunktestand();
            senderForm1.hideHUD();
        }

        private void buluButton2_Click(object sender, EventArgs e)
        {
            senderForm1.ReCalculatePunktestand();
            senderForm1.hideHUD();
        }
    }
}
