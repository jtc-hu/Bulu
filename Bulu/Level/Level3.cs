// --------------------------------
// --- Level3.cs
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
    class Level3 : Level
    {
        public Level3()
        {
            LevelIndex = 3;
            LevelUpPreis = 0;
            LevelUpNeededBildungspunkte = 0;
            VerbrauchteNahrungProPersonProRunde = 4;
            VerbrauchtesGeldProPersonProRunde = 20;
            GeldProNahrungspunkt = 90;
            Rundenanzahl = 45;
            AbrissPreis = 22000;
            LevelUpLevel = null;
        }
    }
}
