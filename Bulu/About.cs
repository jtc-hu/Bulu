// --------------------------------
// --- About.cs
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bulu
{
    public partial class About : nKF.Controls.OverlayUserControl
    {

        const string Z_UMB = "\n"; //gebt's zu, es sieht einfach schöner aus

        public About() {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            versionLabel.Text = "Version " + System.Windows.Forms.Application.ProductVersion;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void buluButton1_Click(object sender, EventArgs e)
        {
            this.HideOverlay(true);
        }

        private void buluButton2_Click(object sender, EventArgs e)
        {
            string gplv2 = "Copyright (C) 2012  JTC Humboldtschule" + Z_UMB + Z_UMB +

                "This program is free software; you can redistribute it and/or" + Z_UMB +
                "modify it under the terms of the GNU General Public License" + Z_UMB +
                "as published by the Free Software Foundation; either version 2" + Z_UMB +
                "of the License, or (at your option) any later version." + Z_UMB + Z_UMB +

                "This program is distributed in the hope that it will be useful," + Z_UMB +
                "but WITHOUT ANY WARRANTY; without even the implied warranty of" + Z_UMB +
                "MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the" + Z_UMB +
                "GNU General Public License for more details." + Z_UMB + Z_UMB +

                "You should have received a copy of the GNU General Public License" + Z_UMB +
                "along with this program; if not, write to the Free Software" + Z_UMB +
                "Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-" + Z_UMB +
                "1307, USA." + Z_UMB + Z_UMB +

                "Copyleft holder: Nico Kreipke" + Z_UMB +
                "Contact: bulu@nkreipke.de" + Z_UMB + Z_UMB +

                "Type `gpl' into the Developer Console to show the whole license.";

            MessageBox.Show(gplv2);
        }

        private void buluButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/jtc-hu/Bulu");
        }

        private void buluButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://bulu.program-art.com");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://nkreipke.de/rdir/nkf");
        }
    }
}
