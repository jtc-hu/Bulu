// --------------------------------
// --- KaffeeGross.cs
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
    class KaffeeGross : Bauelement
    {
        public KaffeeGross()
        {
            BildungspunkteProPersonProRunde = 0;
            NahrungspunkteProPersonProRunde = 0;
            GeldProPersonProRunde = 500;
            ErtragsMultiplier = 1;
            MaxPersonenanzahl = 15;
            UpgradeAllowed = false;
            UpgradeBauelement = null; //nix
            UpgradePreis = 0;
            BuyPreis = 0;
            BuyNeededBildungspunkte = 500;
            BuyAllowed = false;
            GeliefertePersonen = 0; //nix
            Grafik = loadImageFromFile("bilder\\kaffeegross.png");
            Text = "Großes Kaffeefeld";
            Description = "Großes Feld, auf dem Kaffeebohnen angebaut und verkauft werden.";
            VerfuegbarAbLevelIndex = 3;
            MaximumFieldAmount = 0;
            Identifier = "KaffeeGross";
        }
    }
}
