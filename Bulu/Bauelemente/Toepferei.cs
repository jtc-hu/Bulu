// --------------------------------
// --- Toepferei.cs
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
    class Toepferei : Bauelement
    {
        public Toepferei()
        {
            BildungspunkteProPersonProRunde = 0;
            NahrungspunkteProPersonProRunde = 0;
            GeldProPersonProRunde = 300;
            ErtragsMultiplier = 1;
            MaxPersonenanzahl = 5;
            UpgradeAllowed = true;
            UpgradeBauelement = new ToepfereiGross(); //nix
            UpgradePreis = 7000;
            BuyPreis = 6000;
            BuyNeededBildungspunkte = 0;
            BuyAllowed = true;
            GeliefertePersonen = 0; //nix
            Grafik = Properties.Resources.ingame_toepferei;
            Text = "Töpferei";
            Description = "Töpferei, die pro Runde Geld einbringt.";
            VerfuegbarAbLevelIndex = 2;
            MaximumFieldAmount = 0;
            Identifier = "Toepferei";
        }
    }
}
