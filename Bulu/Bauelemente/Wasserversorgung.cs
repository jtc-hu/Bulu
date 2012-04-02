// --------------------------------
// --- Wasserversorgung.cs
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
    class Wasserversorgung : Bauelement
    {
        public Wasserversorgung()
        {
            BildungspunkteProPersonProRunde = 0;
            NahrungspunkteProPersonProRunde = 0;
            GeldProPersonProRunde = 0;
            ErtragsMultiplier = 1.5;
            MaxPersonenanzahl = 0;
            UpgradeAllowed = true;
            UpgradeBauelement = new WasserversorgungMittel();
            UpgradePreis = 10000;
            BuyPreis = 7500;
            BuyNeededBildungspunkte = 25;
            BuyAllowed = true;
            GeliefertePersonen = 0; //nix
            Grafik = loadImageFromFile("bilder\\wasserversorgung.png");
            Text = "Wasserversorgung";
            Description = "Bewässert alle Felder und sorgt damit für bessere Erträge.";
            VerfuegbarAbLevelIndex = 1;
            MaximumFieldAmount = 1;
            Identifier = "Wasserversorgung";
        }
    }
}
