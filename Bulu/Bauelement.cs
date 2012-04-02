// --------------------------------
// --- Bauelement.cs
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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Bulu
{

    //KLOTZKONFIGURATION (DELLE)
    //Version 1.0


    public class Bauelement
    {
        /* !!!ACHTUNG!!!
         * Wenn hier angepasst wird, müssen die gleichen Anpassungen auch angewendet werden in:
         * - Jeder vom Bauelement erbenden Klasse
         * - Der Funktion returnClonedVersion() in dieser Klasse */
        public int BildungspunkteProPersonProRunde { set; get; }
        public int NahrungspunkteProPersonProRunde { set; get; }
        public bool Selbstversorgend { set; get; }
        public int GeldProPersonProRunde { set; get; }
        public double ErtragsMultiplier { set; get; }
        public int MaxPersonenanzahl { set; get; }
        public bool UpgradeAllowed { set; get; }
        public Bauelement UpgradeBauelement { set; get; }
        public int UpgradePreis { set; get; }
        public int BuyPreis { set; get; }
        public int BuyNeededBildungspunkte { set; get; }
        public bool BuyAllowed { set; get; }
        public int GeliefertePersonen { set; get; }
        public System.Drawing.Image Grafik { set; get; }
        public string Text { set; get; }
        public string Description { set; get; }
        public int VerfuegbarAbLevelIndex { set; get; }
        public int MaximumFieldAmount { set; get; } //wenn 0 dann unendlich!
        public string Identifier { set; get; } //Eindeutige, einmalige Identifizierungskennung (optimalerweise der Klassenname)

        public Bauelement returnClonedVersion(Bauelement toClone) {
            Bauelement be = new Bauelement();
            be.BildungspunkteProPersonProRunde = toClone.BildungspunkteProPersonProRunde;
            be.NahrungspunkteProPersonProRunde = toClone.NahrungspunkteProPersonProRunde;
            be.Selbstversorgend = toClone.Selbstversorgend;
            be.GeldProPersonProRunde = toClone.GeldProPersonProRunde;
            be.ErtragsMultiplier = toClone.ErtragsMultiplier;
            be.MaxPersonenanzahl = toClone.MaxPersonenanzahl;
            be.UpgradeAllowed = toClone.UpgradeAllowed;
            be.UpgradeBauelement = toClone.UpgradeBauelement;
            be.UpgradePreis = toClone.UpgradePreis;
            be.BuyPreis = toClone.BuyPreis;
            be.BuyNeededBildungspunkte = toClone.BuyNeededBildungspunkte;
            be.BuyAllowed = toClone.BuyAllowed;
            be.GeliefertePersonen = toClone.GeliefertePersonen;
            be.Grafik = toClone.Grafik;
            be.Text = toClone.Text;
            be.Description = toClone.Description;
            be.VerfuegbarAbLevelIndex = toClone.VerfuegbarAbLevelIndex;
            be.MaximumFieldAmount = toClone.MaximumFieldAmount;
            be.Identifier = toClone.Identifier;
            return be;
        }
    }


}
