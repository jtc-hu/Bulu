// --------------------------------
// --- SaveAndLoadManager.cs
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
using System.Xml.Linq;
using System.IO;

/* Save and Load Manager
 * Kümmert sich um das Speichern und Laden des momentanen Spiels.
 * Momentan in Entwicklung und noch nicht funktionsfähig!
 * 
 * Arbeitet mit der Linq-Technik, weshalb Bulu ab sofort .net Framework 4 zwingend erfordert.
 */

namespace Bulu
{
    class SaveAndLoadManager
    {
        public struct SaveGame
        {
            public string Path;
            public string Title;
            public string Date;
        }
        public struct Game
        {
            public string Title;
            public List<Feld> FelderList;
            public int Money;
            public int Nahrung;
            public int Level;
            public int Runde;
            public int Bildung;
        }
        public string GetCurrentSaveGamePath()
        {
            return System.IO.Path.Combine(System.Windows.Forms.Application.UserAppDataPath, "save");
        }

        public bool SaveGameToXMLFile(Object MainFormObject, Game gameInstance, string saveGameTitle, string destinationPath)
        {
            try
            {
                Form1 senderForm = (Form1)MainFormObject;
                XDocument savegame = new XDocument(
                    new XElement("Bulu",
                        new XElement("SaveGame",
                            new XElement("Title", saveGameTitle),
                            new XElement("Timestamp", DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString()),
                            new XElement("Money", gameInstance.Money),
                            new XElement("Nahrung", gameInstance.Nahrung),
                            new XElement("Level", gameInstance.Level),
                            new XElement("Runde", gameInstance.Runde),
                            new XElement("Bildung", gameInstance.Bildung)
                            ),
                        new XElement("Felder")));
                foreach (Feld f in gameInstance.FelderList)
                {
                    savegame.Element("Bulu").Element("Felder").Add(new XElement("Feld", f.encodeToString(senderForm)));
                }
                savegame.Save(destinationPath);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Game OpenGameFromXMLFile(Object MainFormObject, string path) {
            try
            {
                Form1 senderForm = (Form1)MainFormObject;
                XDocument savegame = XDocument.Load(path);
                Game newGame = new Game();
                newGame.Title = savegame.Element("Bulu").Element("SaveGame").Element("Title").Value;
                newGame.Money = Convert.ToInt32(savegame.Element("Bulu").Element("SaveGame").Element("Money").Value);
                newGame.Nahrung = Convert.ToInt32(savegame.Element("Bulu").Element("SaveGame").Element("Nahrung").Value);
                newGame.Level = Convert.ToInt32(savegame.Element("Bulu").Element("SaveGame").Element("Level").Value);
                newGame.Runde = Convert.ToInt32(savegame.Element("Bulu").Element("SaveGame").Element("Runde").Value);
                newGame.Bildung = Convert.ToInt32(savegame.Element("Bulu").Element("SaveGame").Element("Bildung").Value);
                newGame.FelderList = new List<Feld>();
                var elements = from xe in savegame.Element("Bulu").Element("Felder").Elements()
                               where xe != null
                               select xe;
                foreach (XElement element in elements) {
                    Feld f = new Feld();
                    newGame.FelderList.Add(f.decodeFromString(senderForm, element.Value));
                }
                return newGame;
            }
            catch (Exception ex){
                throw ex;
            }
        }

        public List<SaveGame> ReturnListOfSaveGames(string path) {
            //Savegame-Ordner überprüfen und, wenn nötig, anlegen
            if (System.IO.Directory.Exists(GetCurrentSaveGamePath()) == false) {
                System.IO.Directory.CreateDirectory(GetCurrentSaveGamePath());
            }
            //Savegame-Liste...
            List<SaveGame> savegames = new List<SaveGame>();
            foreach(string filepath in System.IO.Directory.GetFiles(path, "*.xml", SearchOption.TopDirectoryOnly)) {
                XDocument savegame = XDocument.Load(filepath);
                SaveGame savegameobject = new SaveGame();
                savegameobject.Title = savegame.Element("Bulu").Element("SaveGame").Element("Title").Value;
                savegameobject.Date = savegame.Element("Bulu").Element("SaveGame").Element("Timestamp").Value;
                savegameobject.Path = filepath;
                savegames.Add(savegameobject);
            }
            return savegames;
        }

        public string ConvertIntoValidFileName(string title, string extension) {
           //Illegale Zeichen (und Kraftmesser) entfernen
            string filename = title;
            foreach (char c in System.IO.Path.GetInvalidFileNameChars())
            {
                filename = filename.Replace(c, '_');
            }
            filename = filename.Replace(" ", "");
            //Ext
            filename = filename + "." + extension;
            return filename;
        }
    }
}
