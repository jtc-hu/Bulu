// --------------------------------
// --- DrawingFunctions.cs
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
using System.Drawing;
using System.Drawing.Drawing2D;


namespace Bulu
{
    public class DrawingFunctions
    {
        // **********************************************
        // Dies ist eines der 322 Rezepte aus dem
        // C# 2005 Premium Codebook. 
        // Das Snippet wurde vom Autor mit freundlicher 
        // Genehmigung von Addison Wesley 
        // bei dotnet-snippets.de veröffentlicht.
        // **********************************************


        /// <summary>
        /// Zeichnet ein Rechteck mit abgerundeten Ecken
        /// </summary>
        /// <param name="g">Referenz auf das Graphics-Objekt, auf dem gezeichnet werden soll</param>
        /// <param name="x">X-Position des Rechtecks</param>
        /// <param name="y">Y-Position des Rechtecks</param>
        /// <param name="width">Breite des Rechtecks</param>
        /// <param name="height">Höhe des Rechtecks</param>
        /// <param name="cornerRadius">Radius der abgerundeten Ecken</param>
        /// <param name="fillBrush">Brush, der für das Füllen des Rechtecks verwendet wird. Kann null sein.</param>
        /// <param name="linePen">Pen, der für das Zeichnen des Rechteck-Randes verwendet wird. Kann null sein.</param>
        public void DrawRoundedRectangle(Graphics g,
           int x, int y, int width, int height,
           int cornerRadius, Brush fillBrush, Pen linePen)
        {
            // Neuen GraphicsPath erzeugen ...
            GraphicsPath gp = new GraphicsPath();

            // ... und die Linien der Figur hinzufügen
            // Oben
            gp.AddLine(x + cornerRadius, y, x + width - cornerRadius, y);
            // Ecke rechts oben
            gp.AddArc(x + width - cornerRadius, y, cornerRadius,
               cornerRadius, 270, 90);
            // Rechts
            gp.AddLine(x + width, y + cornerRadius, x + width,
               y + height - cornerRadius);
            // Ecke rechts unten
            gp.AddArc(x + width - cornerRadius, y + height - cornerRadius,
               cornerRadius, cornerRadius, 0, 90);
            // Unten
            gp.AddLine(x + width - cornerRadius, y + height,
               x + cornerRadius, y + height);
            // Ecke links unten
            gp.AddArc(x, y + height - cornerRadius, cornerRadius,
               cornerRadius, 90, 90);
            // Links
            gp.AddLine(x, y + height - cornerRadius, x, y + cornerRadius);
            // Ecke links oben
            gp.AddArc(x, y, cornerRadius, cornerRadius, 180, 90);

            // Die Figur abschließen
            gp.CloseFigure();

            // Den Pfad mit dem übergebenen Pinsel füllen
            if (fillBrush != null)
            {
                g.FillPath(fillBrush, gp);
            }

            // Die Linien des Pfades zeichnen
            if (linePen != null)
            {
                g.DrawPath(linePen, gp);
            }
        }

    }
}
