// --------------------------------
// --- WasserversorgungMittel.cs
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

namespace Bulu.Bauelemente
{
    class WasserversorgungMittel : Bauelement
    {
        public WasserversorgungMittel()
        {
            BildungspunkteProPersonProRunde = 0;
            NahrungspunkteProPersonProRunde = 0;
            GeldProPersonProRunde = 0;
            ErtragsMultiplier = 2;
            MaxPersonenanzahl = 0;
            UpgradeAllowed = false;
            UpgradeBauelement = null;
            UpgradePreis = 0;
            BuyPreis = 0;
            BuyNeededBildungspunkte = 75;
            BuyAllowed = false;
            GeliefertePersonen = 0; //nix
            Grafik = Properties.Resources.ingame_wasserversorgungmittel;
            Text = "Wasserversorgung 2"; //"mittlere Wasserversorgung" war suboptimal, da der Text zu lang war und im Editor katastrophal aussah
            Description = "Bewässert alle Felder und sorgt damit für bessere Erträge.";
            VerfuegbarAbLevelIndex = 2;
            MaximumFieldAmount = 1;
            Identifier = "WasserversorgungMittel";
        }
    }
}
