// --------------------------------
// --- AchievementsCenter.cs
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


/* Bulu Achievements Center
 * 
 * Analyse von nc_notifications, Managing der Achievements
 * 
 * von Nico */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bulu
{
    public class AchievementsCenter
    {
        Form1 senderForm;
        public AchievementsCenter(object sender) {
            senderForm = (Form1)sender;
            achievements = new List<Achievement>();
            achievements.Add(new Achievement("Schnellstarter", "Baue ein Haus.", "schnellstarter"));
            achievements.Add(new Achievement("Geschäftsmann", "Verkaufe Nahrung gegen Geld.", "geschftsmann"));
            achievements.Add(new Achievement("Lizenz zum Bauen", "Baue 5 Objekte in einem Spiel.", "lizzumbauen"));
            achievements.Add(new Achievement("Bevölkerungsmaximierung", "Beschäftige 30 Leute in einem Spiel.", "bevmax"));
            achievements.Add(new Achievement("Datensicherung", "Speichere ein Spiel.", "datensicherung"));
            achievements.Add(new Achievement("Level Up", "Erreiche Level 2.", "lvlup"));
            achievements.Add(new Achievement("Flipchart", "Mache Schulden.", "dispo"));
            achievements.Add(new Achievement("Peter Zwegat", "Raus aus den Schulden!", "peter"));
            achievements.Add(new Achievement("Reiches Dorf", "Habe mehr als 100.000 Dalasi auf dem Konto.", "reichesdorf"));
            achievements.Add(new Achievement("Platz schaffen", "Reiße ein Feld ab.","platzschaffen"));
            achievements.Add(new Achievement("Maximum erreicht", "Bebaue alle verfügbaren Felder.", "maxerreicht"));
            achievements.Add(new Achievement("Ertragssteigerung", "Steigere deine Erträge mit einer Bewässerung.", "ertragssteigerung"));
            achievements.Add(new Achievement("Zu viel Zeit", "Starte Bulu 50 mal.","zuvielzeit"));
            //achievements.Add(new Achievement("1337 h4x0r", "Baue zur richtigen Zeit das richtige Feld.","leethaxor"));
        }

        public List<Achievement> achievements;

        public void Achieve(string id) {
            if (Properties.Settings.Default.achievements == null)
            {
                Properties.Settings.Default.achievements = new System.Collections.Specialized.StringCollection();
            }
            if (!Properties.Settings.Default.achievements.Contains(id))
            {
                System.Collections.Specialized.StringCollection aList = Properties.Settings.Default.achievements;
                aList.Add(id);
                Properties.Settings.Default.achievements = aList;
                Properties.Settings.Default.Save();
                presentAchievementNotification(id);
            }
        }
        public void UnArchieve() {
            if (Properties.Settings.Default.achievements == null)
            {
                return;
            }
            Properties.Settings.Default.achievements.Clear();
            Properties.Settings.Default.Save();
        }
        public bool IsAchieved(string id) {
            if (Properties.Settings.Default.achievements == null)
            {
                return false;
            }
            if (Properties.Settings.Default.achievements.Contains(id))
            {
                    return true;
            }
            return false;
        }

        void presentAchievementNotification(string id) {
            //zuerst passendes achievement-objekt fetchen
            Achievement a = null;
            foreach (Achievement ach in achievements)
            {
                if (ach.id == id)
                {
                    a = ach;
                }
            }
            if (a == null)
            {
                return;
            }
            senderForm.showAchievementOverlay(a.title + " - " + a.description);
        }

        int builtobjects = 0;
        public void analyze_nc_notification(NotificationCenter.nc_props props, object obj) {
            //Analyse von nc_notifications. This is where the magic happens^^
            switch (props)
            {
                case NotificationCenter.nc_props.nc_build_field:
                    builtobjects += 1;
                    if ((Bauelement)obj is Bauelemente.Haus)
                    {
                        Achieve("schnellstarter");
                    }
                    if ((Bauelement)obj is Bauelemente.Wasserversorgung || (Bauelement)obj is Bauelemente.WasserversorgungMittel)
                    {
                        Achieve("ertragssteigerung");
                    }
                    if (builtobjects > 4)
                    {
                        Achieve("lizzumbauen");
                    }
                    break;
                case NotificationCenter.nc_props.nc_build_freefields:
                    if ((int)obj == 0)
                    {
                        Achieve("maxerreicht");
                    }
                    break;
                case NotificationCenter.nc_props.nc_destroy:
                    Achieve("platzschaffen");
                    break;
                case NotificationCenter.nc_props.nc_startup:
                    if (Properties.Settings.Default.starts > 49)
                    {
                        Achieve("zuvielzeit");
                    }
                    break;
                case NotificationCenter.nc_props.nc_nsell:
                    Achieve("geschftsmann");
                    break;
                case NotificationCenter.nc_props.nc_reset:
                    builtobjects = 0;
                    break;
                case NotificationCenter.nc_props.nc_changebusypeople:
                    if ((int)obj > 29)
                    {
                        Achieve("bevmax");
                    }
                    break;
                case NotificationCenter.nc_props.nc_save:
                    Achieve("datensicherung");
                    break;
                case NotificationCenter.nc_props.nc_lvlup:
                    Achieve("lvlup");
                    break;
                case NotificationCenter.nc_props.nc_chmoney:
                    NotificationCenter.ncGeldNotificationStucture money = (NotificationCenter.ncGeldNotificationStucture)obj;
                    if (money.newGeld < 0)
                    {
                        Achieve("dispo");
                    }
                    if (money.newGeld > 100000)
                    {
                        Achieve("reichesdorf");
                    }
                    if (money.oldGeld < 0 && money.newGeld >= 0)
                    {
                        Achieve("peter");
                    }
                    break;
                default:
                    break;
            }
        }

    }

    public class Achievement
    {
        public string id;
        public string title;
        public string description;
        public Achievement(string aTitle, string aDescription, string aID) {
            title = aTitle;
            description = aDescription;
            id = aID;
        }
    }
}
