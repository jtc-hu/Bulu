// --------------------------------
// --- HausMehrfamilien.cs
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
    class HausMehrfamilien : Bauelement
    {
        public HausMehrfamilien()
        {
            BildungspunkteProPersonProRunde = 0;
            NahrungspunkteProPersonProRunde = 0;
            GeldProPersonProRunde = 0;
            ErtragsMultiplier = 1;
            MaxPersonenanzahl = 0;
            UpgradeAllowed = false;
            UpgradeBauelement = null;
            UpgradePreis = 0;
            BuyPreis = 10000;
            BuyNeededBildungspunkte = 650;
            BuyAllowed = true;
            GeliefertePersonen = 25;
            Grafik = loadImageFromFile("bilder\\hausmehrfamilien.png");
            Text = "Mehrfamilienhaus";
            Description = "Modernes Mehrfamilienhaus zur Unterbringung von 25 Personen.";
            VerfuegbarAbLevelIndex = 3;
            MaximumFieldAmount = 0;
            Identifier = "HausMehrfamilien";
        }
    }
}