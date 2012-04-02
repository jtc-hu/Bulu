// --------------------------------
// --- PunkteCalculator.cs
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

namespace Bulu
{
    class PunkteCalculator
    {
        #region Interne Funktionen
        Form1 senderForm;
        public PunkteCalculator(Object sender) {
            senderForm = (Form1)sender;
        }
        public int AktuellePunktzahl {
            get {
                Personen = senderForm.Gesamtpersonen;
                FreiePersonen = senderForm.FreiePersonen;
                GestorbenePersonen = senderForm.GestorbenePersonen;
                Bildungspunkte = senderForm.MomentaneBildungspunkte;
                Nahrungspunkte = senderForm.MomentaneNahrungspunkte;
                Geld = senderForm.MomentanesGeld();
                Gesamtausgaben = senderForm.Ausgaben;
                Gesamteinnahmen = senderForm.Einnahmen;
                Level = senderForm.MomentanesLevel.LevelIndex;
                Runde = senderForm.MomentaneRunde;
                return Formel();
            }
        }
        #endregion

        //Diese Variablen sind nutzbar:
        int Personen;
        int FreiePersonen;
        int GestorbenePersonen;
        int Bildungspunkte;
        int Nahrungspunkte;
        int Geld;
        int Gesamtausgaben;
        int Gesamteinnahmen;
        int Level;
        int Runde;

        //Hier befindet sich die Punkteformel:
        int Formel() {
            return Geld //@Nico
                + Personen * 600 + Personen * Bildungspunkte
                - GestorbenePersonen * 1200;


            //return 1; //noch keine Formel...
        }
    }
}
