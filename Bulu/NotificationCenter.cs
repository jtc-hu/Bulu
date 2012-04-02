// --------------------------------
// --- NotificationCenter.cs
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


/* Bulu Notification Center
 * 
 * Klasse für das interne Logging von Ereignissen
 * 
 * von Nico */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bulu
{
    public class NotificationCenter
    {
        Form1 mainForm;

        public struct ncGeldNotificationStucture
        {
            public int oldGeld;
            public int newGeld;
        }

        public NotificationCenter(object mainClass) {
            mainForm = (Form1)mainClass;
            nc_notificate(nc_props.nc_startup, null);
        }

        public enum nc_props {      //Objekte:
            nc_build_field,         //Bauelement
            nc_build_freefields,    //int
            nc_destroy,             //Feld
            nc_startup,             //null
            nc_nsell,               //int
            nc_reset,               //null
            nc_changebusypeople,    //int
            nc_save,                //null
            nc_lvlup,               //Level
            nc_chmoney              //ncGeldNotificationStructure
        }

        public void nc_notificate(nc_props prop, object obj) {
            if (mainForm.devconsole != null)
            {
                mainForm.devconsole.nc_verbose_output("received " + prop.ToString() + " with object " + (obj == null ? "(null)" : obj.ToString()));
            }
            if (prop == nc_props.nc_startup)
            {
                Properties.Settings.Default.starts += 1;
                Properties.Settings.Default.Save();
            }
            mainForm.ac.analyze_nc_notification(prop, obj);
        }
    }
}
