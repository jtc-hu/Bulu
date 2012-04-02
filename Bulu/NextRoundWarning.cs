// --------------------------------
// --- NextRoundWarning.cs
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
    public partial class NextRoundWarning : Form
    {
        Form1 senderForm;
        public NextRoundWarning(string warningText, Object sender)
        {
            InitializeComponent();
            senderForm = (Form1)sender;
            warning.Text = warningText;
        }

        private void NextRoundWarning_Load(object sender, EventArgs e)
        {

        }

        private void NextRoundWarning_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            senderForm.RoundUp();
            this.Close();
        }

        #region PopOver Fenster Resize-Pfeile deaktivieren
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            //Spezialmethode zum Deaktivieren der "Resize"-Pfeile an den Fensterenden
            //Wird in den PopOver-Fenstern benötigt
            base.WndProc(ref m);
            if (m.Msg == 0x84)
            {
                switch (m.Result.ToInt64())
                {
                    case 10L:
                        m.Result = new IntPtr(18L);
                        break;
                    case 11L:
                        m.Result = new IntPtr(18L);
                        break;
                    case 12L:
                        m.Result = new IntPtr(18L);
                        break;
                    case 13L:
                        m.Result = new IntPtr(18L);
                        break;
                    case 14L:
                        m.Result = new IntPtr(18L);
                        break;
                    case 15L:
                        m.Result = new IntPtr(18L);
                        break;
                    case 16L:
                        m.Result = new IntPtr(18L);
                        break;
                    case 17L:
                        m.Result = new IntPtr(18L);
                        break;
                }
            }
        }
        #endregion
    }
}
