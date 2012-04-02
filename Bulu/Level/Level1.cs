// --------------------------------
// --- Level1.cs
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

namespace Bulu.Levels
{
    class Level1 : Level
    {
        public Level1()
        {
            LevelIndex = 1;
            LevelUpPreis = 100000; //gilt immer für LevelUpLevel (also wie auch beim Bauelement für das FollowUp-Item)
            LevelUpNeededBildungspunkte = 50;
            VerbrauchteNahrungProPersonProRunde = 1;
            VerbrauchtesGeldProPersonProRunde = 0;
            GeldProNahrungspunkt = 100;
            Rundenanzahl = 50;
            AbrissPreis = 0; //wenn 0 kein Abriss
            LevelUpLevel = new Level2();
        }
    }
}
