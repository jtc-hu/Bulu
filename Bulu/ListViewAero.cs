﻿// --------------------------------
// --- ListViewAero.cs
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
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Bulu
{
    static class NativeMethods
    {
        public const int WM_CREATE = 0x1;

        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        public extern static int SetWindowTheme(
            IntPtr hWnd, string pszSubAppName, string pszSubIdList);
    }

    class ListViewAero : System.Windows.Forms.ListView
    {
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == NativeMethods.WM_CREATE)
            {
                NativeMethods.SetWindowTheme(this.Handle, "Explorer", null);
            }
            base.WndProc(ref m);
        }
    }

}
