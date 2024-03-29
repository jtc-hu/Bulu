﻿// --------------------------------
// --- ToepfereiGross.cs
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
    class ToepfereiGross : Bauelement
    {
        public ToepfereiGross()
        {
            BildungspunkteProPersonProRunde = 0;
            NahrungspunkteProPersonProRunde = 0;
            GeldProPersonProRunde = 450;
            ErtragsMultiplier = 1;
            MaxPersonenanzahl = 20;
            UpgradeAllowed = false;
            UpgradeBauelement = null; //nix
            UpgradePreis = 0;
            BuyPreis = 0;
            BuyNeededBildungspunkte = 700;
            BuyAllowed = false;
            GeliefertePersonen = 0; //nix
            Grafik = loadImageFromFile("bilder\\toepfereigross.png");
            Text = "Große Töpferei";
            Description = "Große Töpferei, die pro Runde Geld einbringt.";
            VerfuegbarAbLevelIndex = 3;
            MaximumFieldAmount = 0;
            Identifier = "ToepfereiGross";
        }
    }
}
