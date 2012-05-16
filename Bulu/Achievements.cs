// --------------------------------
// --- Achievements.cs
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
    public partial class Achievements : UserControl
    {
        Form1 senderForm;
        public nKF.Dialog.FormSheet sheet;
        nKF.Picture.StretchableImage achsi = new nKF.Picture.StretchableImage(Properties.Resources.achieved, 5, 5);

        public Achievements(object sender)
        {
            InitializeComponent();
            senderForm = (Form1)sender;
        }

        private void Achievements_Load(object sender, EventArgs e)
        {
            /* Die Deklaration der Achievements ist nicht hier!
             * Neue Achievements können in der Klasse AchievenmentsCenter.cs deklariert werden. */

            nKAchievements.SetDesign(new nKF.Picture.StretchableImage(Properties.Resources.buluscrollerb,0,10), new nKF.Picture.StretchableImage(Properties.Resources.buluscroller, 0, 10));

            int achieved = 0;
            foreach (Achievement ach in senderForm.ac.achievements)
            {
                if (senderForm.ac.IsAchieved(ach.id))
                {
                    nKF.Controls.nKListBoxCell cell = new nKF.Controls.nKListBoxCell();
                    cell.Text = ach.title + " (Erreicht)";
                    cell.DetailText = ach.description;
                    cell.Font = new Font(this.Font, FontStyle.Bold);
                    cell.NormalBackground = achsi;
                    cell.MouseOverBackground = achsi;
                    cell.SelectedBackground = achsi;
                    cell.IsSelectable = false;
                    nKAchievements.AddCell(cell);
                    achieved += 1;
                }
                else
                {
                    nKF.Controls.nKListBoxCell cell = new nKF.Controls.nKListBoxCell();
                    cell.Text = ach.title;
                    cell.DetailText = ach.description;
                    cell.IsSelectable = false;
                    nKAchievements.AddCell(cell);
                }
            }
            achBottomBar.Text = "Erreicht: " + achieved.ToString() + "/" + senderForm.ac.achievements.Count();

        }

        private void nKButton1_Click(object sender, EventArgs e)
        {
            sheet.HideSheet(true);
        }
    }
}
