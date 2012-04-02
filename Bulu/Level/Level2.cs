// --------------------------------
// --- Level2.cs
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
    class Level2 : Level
    {
        public Level2()
        {
            LevelIndex = 2;
            LevelUpPreis = 350000;
            LevelUpNeededBildungspunkte = 500;
            VerbrauchteNahrungProPersonProRunde = 4;
            VerbrauchtesGeldProPersonProRunde = 0;
            GeldProNahrungspunkt = 100;
            Rundenanzahl = 40;
            AbrissPreis = 20000;
            LevelUpLevel = new Level3();
        }
    }
}
