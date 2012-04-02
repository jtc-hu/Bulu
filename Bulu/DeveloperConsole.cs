// --------------------------------
// --- DeveloperConsole.cs
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
using Bulu.Levels;

namespace Bulu
{
    public partial class DeveloperConsole : Form
    {
        Form1 senderForm1;
        bool immediateClose = false;
        bool strict = false;
        bool nc_verbose = false;

        //Präsimodus-Vars:
        Form presForm;
        Form1 f;

        public DeveloperConsole(Object sender)
        {
            InitializeComponent();
            senderForm1 = (Form1)sender;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void nc_verbose_output(string text) {
            if (nc_verbose)
            {
                appendLine(" > " + DateTime.Now.ToShortTimeString() + " nc: " + text);
            }
        }

        void appendLine(string text) {
            if (text == " > ~")
            {
                return;
            }
            try
            {
                /*if (richTextBox1.Text == "")
                {
                    richTextBox1.AppendText(text);
                }
                else
                {
                    richTextBox1.AppendText("\n" + text);
                }*/
                richTextBox1.AppendText(text + "\n");
            }
            catch {
            }
        }

        public string runCommand(string command) {
            string answer = "syntax error";
            bool scrolltextbox = true;
            try
            {
                command = command.Replace(" ", "");

               /* if (command == "h31p")
                {
                    answer = "Hilfe\r\n"
                        + "cls                  -   Ausgabe leeren\r\n"
                        + "setmoney,x           -   Geld festlegen\r\n"
                        + "setbp,x              -   Bildungspunkte festlegen\r\n"
                        + "setnp,x              -   Nahrungspunkte festlegen\r\n"
                        + "setround,x           -   Runde festlegen\r\n"
                        + "levelup              -   Level erhöhen\r\n"
                        + "clearall             -   Alle Spielfelder leeren\r\n"
                        + "build,x,x            -   Feld bebauen\r\n"
                        + "initstartsettings    -   Starteinstellungen\r\n"
                        + "resetlevel           -   Level 1\r\n"
                        + "restart              -   Bulu neustarten\r\n"
                        + "exit                 -   Konsole beenden\r\n"
                        + "shutdown             -   Bulu beenden\r\n"
                        + "crash                -   xDD\r\n";
                }*/
                
                
                if (command.StartsWith("script")) //Script laden
                {
                    string scriptid = command.Replace("script", "").ToLower();
                    string script = getScript(scriptid);
                    if (script != "")
                    {
                        textBox1.Text = script;
                        textBox1.SelectAll();
                        answer = "script " + scriptid + " loaded";
                    }
                    else {
                        answer = "script " + scriptid + " doesn't exist";
                    }
                }
                if (command == "cls") //Ausgabe leeren
                {
                    richTextBox1.Text = "";
                    answer = "~";
                }
                if (command == "gpl") //+++added in 0.8.1
                {
                    richTextBox1.Text = "";
                    answer = Properties.Resources.License + "\n\n";
                    scrolltextbox = false;
                }
                if (command == "changelog") //+++added in 0.8.1
                {
                    richTextBox1.Text = "";
                    answer = Properties.Resources.Changelog + "\n\n";
                    scrolltextbox = false;
                }
                if (command == "donotclose") // +++added in 0.8.0
                {
                    senderForm1.donotclose = true;
                    answer = "do not close mode activated";
                }
                if (command == "closesavegame") // +++added in 0.8.0
                {
                    senderForm1.SaveGamePath = null;
                    senderForm1.SaveGameTitle = null;
                    senderForm1.ActualizeWindowTitle();
                    answer = "savegame closed";
                }
                if (command == "blackout") // +++added in 0.8.0
                {
                    if (!senderForm1.TopMost)
                    {
                        answer = "error: run 'top' before this command";
                    }
                    else
                    {
                        Form black = new Form();
                        black.FormBorderStyle = FormBorderStyle.None;
                        black.Text = "";
                        black.BackColor = Color.Black;
                        black.WindowState = FormWindowState.Maximized;
                        black.Show();
                        answer = "blackout successful";
                    }
                }
                if (command == "top") // +++added in 0.8.0
                {
                    senderForm1.TopMost = true;
                    this.TopMost = true;
                    senderForm1.MinimizeBox = false;
                    answer = "top successful";
                }
                if (command == "cebit") // +++added in 0.8.0
                {
                    _runCommands("donotclose;top;blackout;exit", false);
                    answer = "CEBIT MODE";
                }
                if (command == "missingartwork") // +++added in 0.8.2
                {
                    foreach (Bauelement element in senderForm1.BauelementeList)
                    {
                        if (element.Grafik == null)
                        {
                            appendLine(" > " + element.Identifier);
                        }
                    }
                    answer = "~";
                }
                if (command.StartsWith("bauelemente")) // +++added in 0.8.0
                {
                    answer = "~";
                    if (command == "bauelemente")
                    {
                        generateBauelementOutput(null, " > ");
                    }
                    else {
                        string bauelementIdentifier = command.Replace("bauelemente", "");
                        Bauelement resultElement = null;
                        foreach (Bauelement element in senderForm1.BauelementeList)
                        {
                            if (resultElement == null)
                            {
                                if (element.Identifier.ToUpper() == bauelementIdentifier.ToUpper())
                                {
                                    resultElement = element;
                                }
                            }
                        }
                        if (resultElement != null)
                        {
                            generateBauelementOutput(resultElement, " > ");
                        }
                        else
                        {
                            answer = "there is no " + bauelementIdentifier;
                        }
                    }
                }
                if (command.StartsWith("setmoney")) //Geld festlegen
                {
                    int summe = Convert.ToInt32(command.Replace("setmoney", ""));
                    senderForm1.GeldTransaktion(Form1.Transaktionsart.Festlegung, summe);
                    answer = "money set to " + summe.ToString();
                }
                if (command.StartsWith("setbp")) //Bildungspunkte festlegen
                {
                    int summe = Convert.ToInt32(command.Replace("setbp", ""));
                    senderForm1.MomentaneBildungspunkte = summe;
                    answer = "bp set to " + summe.ToString();
                }
                if (command.StartsWith("setnp")) //Nahrungspunkte festlegen
                {
                    int summe = Convert.ToInt32(command.Replace("setnp", ""));
                    senderForm1.MomentaneNahrungspunkte = summe;
                    answer = "np set to " + summe.ToString();
                }
                if (command.StartsWith("setround")) //Runde festlegen
                {
                    int summe = Convert.ToInt32(command.Replace("setround", ""));
                    senderForm1.MomentaneRunde = summe;
                    answer = "round set to " + summe.ToString();
                }
                if (command == "updater") {
                    senderForm1.checkForUpdates();
                    answer = "checking for updates";
                }
                if (command == "nc_verbose")
                {
                    nc_verbose = true;
                    answer = "nc_verbose is on";
                }
                if (command == "levelup") //Nächstes Level (durch Levelpolitik kein "setlevel" möglich...)
                {
                    if (senderForm1.MomentanesLevel.LevelUpLevel != null)
                    {
                        Level nxtLevel = senderForm1.MomentanesLevel.LevelUpLevel;
                        senderForm1.MomentanesLevel = nxtLevel;
                        answer = "level set to " + nxtLevel.LevelIndex.ToString();
                    }
                    else {
                        answer = "there is no next level";
                    }
                }
                if (command.StartsWith("build")) //Auf ein Feld bauen, es spielt keine Rolle ob Element verfügbar (also Geld etc. egal)
                { //Wenn als Feldname empty eingegeben wird, wird das Feld geleert oder bleibt leer.
                    //Syntax: build feldindex, bauelementidentifier
                    string comstr = command.Replace("build", "");
                    string[] splits = comstr.Split(',');
                    int fieldIndex = Convert.ToInt32(splits[0]);
                    string bauelementIdentifier = splits[1];
                    Bauelement resultElement = null;
                    foreach (Bauelement element in senderForm1.BauelementeList) {
                        if (resultElement == null) {
                            if (element.Identifier.ToUpper() == bauelementIdentifier.ToUpper()) {
                                resultElement = element;
                            }
                        }
                    }
                    if (bauelementIdentifier.ToLower() == "empty") {
                        senderForm1.FelderList[fieldIndex].MomentanesBauelement = null;
                        answer = "built nothing on field " + fieldIndex.ToString();
                    }
                    else if (resultElement != null)
                    {
                        senderForm1.FelderList[fieldIndex].MomentanesBauelement = resultElement.returnClonedVersion(resultElement);
                        answer = "built " + resultElement.Identifier + " on field " + fieldIndex.ToString();
                    }
                    else {
                        answer = "there is no " + bauelementIdentifier;
                    }
                }
                if (command.StartsWith("savegame")) //Runde festlegen
                {
                    string comstr = command.Replace("savegame", "");
                    if (comstr == "")
                    {
                        answer = "no savegame title specified";
                    }
                    else
                    {
                        SaveFileDialog sd = new SaveFileDialog();
                        sd.Filter = "XML|*.xml";
                        sd.ShowDialog();
                        if (senderForm1.saveActualGame(comstr, sd.FileName))
                        {
                            answer = "saved successfully to " + sd.FileName;
                        }
                        else
                        {
                            answer = "could not save to " + sd.FileName;
                        }
                    }
                }
                if (command.StartsWith("loadgame")) //Runde festlegen
                {
                    OpenFileDialog sd = new OpenFileDialog();
                    sd.Filter = "XML|*.xml";
                    sd.ShowDialog();
                    if (senderForm1.loadGameFromFile(sd.FileName))
                    {
                        answer = "game data file " + sd.FileName + " load successfully";
                    }
                    else
                    {
                        answer = "could not load game data file " + sd.FileName;
                    }
                }
                if (command.StartsWith("initstartsettings"))
                {
                    senderForm1.initStartSettings();
                    answer = "start settings initialized";
                }
                if (command.StartsWith("clearall")) //Leert alle Spielfelder.
                {
                    foreach (Feld feld in senderForm1.FelderList) {
                        feld.MomentanesBauelement = null;
                    }
                    answer = "destroyed everything.";
                }
                if (command.StartsWith("setpeople")) //Legt Leute in einem Spielfeld fest (mehr Leute als vom Feld tragbar kann zu Fehlern führen)
                { //Syntax: setpeople feldindex, personenanzahl
                    string comstr = command.Replace("setpeople", "");
                    string[] splits = comstr.Split(',');
                    int fieldIndex = Convert.ToInt32(splits[0]);
                    int newPeople =Convert.ToInt32(splits[1]);
                    if (senderForm1.FelderList[fieldIndex].MomentanesBauelement != null)
                    {
                        senderForm1.FelderList[fieldIndex].MomentanePersonen = newPeople;
                        answer = "set people on field " + fieldIndex.ToString() + " to " + newPeople.ToString();
                    }
                    else {
                        answer = "field " + fieldIndex.ToString() + " is empty";
                    }
                }
                if (command.StartsWith("showachoverlay"))
                {
                    string comstr = command.Replace("showachoverlay", "");
                    senderForm1.showAchievementOverlay(comstr);
                    answer = "achievement overlay opened.";
                }
                if (command == "clearach")
                {
                    senderForm1.ac.UnArchieve();
                    answer = "achievements deleted";
                }
                if (command == "moneyoff")
                {
                    senderForm1.GeldDeaktivieren = true;
                    answer = "turned off money management";
                }
                if (command == "showstarts")
                {
                    answer = "bulu was started " + Properties.Settings.Default.starts.ToString() + " times.";
                }
                if (command == "datetime") {
                    answer = "local time stamp for savegames is " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
                }
                if (command == "presentation")
                {
                    presForm = new Form();
                    presForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    presForm.WindowState = FormWindowState.Maximized;
                    presForm.BackColor = Color.Black;
                    ContextMenu c = new ContextMenu();
                    MenuItem d = new MenuItem("Präsentation beenden");
                    d.Click += new EventHandler(d_Click);
                    c.MenuItems.Add(d);
                    presForm.ContextMenu = c;
                    presForm.Show();
                    //senderForm1.Owner = presForm;
                    f = new Form1();
                    f.Move += new EventHandler(f_Move);
                    f.ControlBox = false;
                    f.StartPosition = FormStartPosition.CenterScreen;
                    f.Show(presForm);
                    senderForm1.Visible = false;
                    senderForm1.ShowInTaskbar = false;
                    //content.Controls.Add();
                    //foreach (Control c in senderForm1.Controls)
                    //{
                    //    senderForm1.Controls.Remove(c);
                    //    presForm.Controls.Add(c);
                    //}
                    //immediateClose = true;
                    //this.Close();
                    //presForm.ShowDialog();
                    answer = "presentation mode activated.";
                } //funktioniert nicht...
                if (command == "resetlevel") //setzt level auf Level1
                {
                    senderForm1.MomentanesLevel = new Level1();
                    answer = "level set to 1";
                }
                if (command == "strict")
                {
                    strict = true;
                    answer = "being strict in this console session.";
                }
                if (command == "-crash") //spezielle Testmethode für Error-Handling - im errorblock
                {
                    int a = 500;
                    int b = 200;
                    int c = 100 * 2;
                    int d = b - c;
                    int e = a / d;
                    answer = "you should not be able to read this :-)";
                }
                if (command == "restart") {
                    answer = "restart sent";
                    senderForm1.InstantClose = true;
                    Application.Restart();
                    senderForm1.Close();
                }
                else if (command == "exit")
                {
                    answer = "exit sent";
                    this.Close();
                }
                else if (command == "closeconsole")
                {
                    answer = "closeconsole sent";
                    immediateClose = true;
                    this.Close();
                }
                else if (command == "shutdown")
                {
                    answer = "trying to terminate bulu.";
                    senderForm1.InstantClose = true;
                    senderForm1.Close();
                }
            }
            catch(Exception ex)
            {
                if (!strict)
                {
                    answer = "error";
                }
                else
                {
                    answer = "CRITICAL ERROR\r\n > Strict Mode Stack Trace\r\n > --------------\r\n > " + ex.Message + "\r\n > " + ex.StackTrace +  "\r\n > ---------------";
                }
            }
            if (command == "crash") //spezielle Testmethode für Error-Handling - außerhalb des errorblocks
            {
                int a = 500;
                int b = 200;
                int c = 100 * 2;
                int d = b - c;
                int e = a / d;
                answer = "you should not be able to read this :-)";
            }
            if (scrolltextbox)
            {
                //hack zum scrollen des textfelds nach unten
                richTextBox1.Focus();
                textBox1.Focus();
            }
            return answer;
        }

        void d_Click(object sender, EventArgs e)
        {
            presForm.Close();
            immediateClose = true;
            senderForm1.Close();
        }

        void f_Move(object sender, EventArgs e)
        {
            //Präsimodus
            f.Top = (presForm.Height / 2) - (f.Height / 2);
            f.Left = (presForm.Width / 2) - (f.Width / 2);
        }

        public void _runCommands(string command, bool appendcmds) {
            if (command.IndexOf(';') != -1)
            {
                string[] cmds = command.Split(';');
                foreach (string cmd in cmds)
                {
                    if (appendcmds) appendLine(cmd);
                    appendLine(" > " + runCommand(cmd));
                }
            }
            else
            {
                if (appendcmds) appendLine(command);
                appendLine(" > " + runCommand(command));
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                string command = textBox1.Text;
                textBox1.Text = "";
                _runCommands(command,true);
            }
        }

        void generateBauelementOutput(Bauelement root, string prefix) {
            if (root == null)
            {
                foreach (Bauelement element in senderForm1.BauelementeList)
                {
                    if (element.BuyAllowed) generateBauelementOutput(element, prefix);
                }
            }
            else
            {
                appendLine(prefix + "--- " + root.Text + " / id: " + root.Identifier);
                appendLine(prefix + root.Description);
                appendLine(prefix + "buy:" + root.BuyPreis + " buybp:" + root.BuyNeededBildungspunkte + " lvlindex:" + root.VerfuegbarAbLevelIndex);
                appendLine(prefix + "ertrMl:" + root.ErtragsMultiplier + " geldprPs:" + root.GeldProPersonProRunde + " gPs:" + root.GeliefertePersonen);
                if (root.Grafik == null)
                {
                    appendLine(prefix + "grafik fehlt!!!!11");
                }
                if (root.UpgradeBauelement != null)
                {
                    appendLine(prefix + "upgrade preis:" + root.UpgradePreis + " :");
                    generateBauelementOutput(root.UpgradeBauelement, prefix + " > ");
                }
                else
                {
                    appendLine(prefix + "no upgrade");
                }
            }
        }

        private string getScript(string identifier) {
            //Scripts generieren Abfolgen von Befehlen, die von der Konsole ausgeführt werden können.
            //Ein fertiges Script kann mit "script skriptname" geöffnet werden.
            //Das generierte Script wird dann in das Eingabefeld geschrieben.
            //Befehle werden mit einem Semikolon getrennt und hintereinander ausgeführt.
            string resultscript = "";
            if (identifier == "mhaus")
            {
                resultscript = "clearall;build 0, hausmittel;build 1, hausmittel;build2, hausmittel;build 3, hausmittel;build 4, hausmittel;build 5, hausmittel;build 6, hausmittel;build 7, hausmittel;build 8, hausmittel;build 9, hausmittel;build 10, hausmittel;build 11, hausmittel;build 12, hausmittel;build 13, hausmittel;build 14, hausmittel; setround 50; setmoney 1000000; setbp 50000";
            }
            else if (identifier == "load") //Zustand nach dem Laden wiederherstellen
            {
                resultscript = "clearall;initstartsettings;resetlevel;build 0, haus;build 1, hirsefeld;setpeople 1, 5";
            }
            else if (identifier == "moneybp")
            {
                resultscript = "setmoney10000000;setbp1000;exit";
            }
            else if (identifier == "test1")
            {
                resultscript = "clearall;build 0, hausgross;build 1, hirsefeld;build2, hausgross";
            }
            else if (identifier == "lvl")
            {
                resultscript = "setmoney 40000; setbp 100";
            }
            else if (identifier == "vl3")
            {
                resultscript = "setmoney 1000000; setbp 1000; levelup";
            }
            return resultscript;
        }

        private void DeveloperConsole_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!immediateClose) {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void DeveloperConsole_Load(object sender, EventArgs e)
        {
            appendLine(" > Bulu version " + Application.ProductVersion.ToString() + ", Copyright (C) 2012 JTC Humboldtschule");
            appendLine(" > Bulu comes with ABSOLUTELY NO WARRANTY. This is free software,");
            appendLine(" > and you are welcome to redistribute it under certain contitions;");
            appendLine(" > type `gpl' for details.");
        }
    }
}
