namespace Bulu
{
    partial class Beduerfnisse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Beduerfnisse));
            this.geldLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nahrungspunkteLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.infolabel = new System.Windows.Forms.Label();
            this.buluButton1 = new Bulu.BuluButton();
            this.buluButton2 = new Bulu.BuluButton();
            this.SuspendLayout();
            // 
            // geldLabel
            // 
            this.geldLabel.AutoEllipsis = true;
            this.geldLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geldLabel.ForeColor = System.Drawing.Color.White;
            this.geldLabel.Location = new System.Drawing.Point(138, 23);
            this.geldLabel.Name = "geldLabel";
            this.geldLabel.Size = new System.Drawing.Size(114, 18);
            this.geldLabel.TabIndex = 14;
            this.geldLabel.Text = "0 (Gesamt: 0)";
            this.geldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Geld:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nahrungspunkteLabel
            // 
            this.nahrungspunkteLabel.AutoEllipsis = true;
            this.nahrungspunkteLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nahrungspunkteLabel.ForeColor = System.Drawing.Color.White;
            this.nahrungspunkteLabel.Location = new System.Drawing.Point(138, 5);
            this.nahrungspunkteLabel.Name = "nahrungspunkteLabel";
            this.nahrungspunkteLabel.Size = new System.Drawing.Size(114, 18);
            this.nahrungspunkteLabel.TabIndex = 12;
            this.nahrungspunkteLabel.Text = "1 (Gesamt: 2)";
            this.nahrungspunkteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nahrungspunkte:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // infolabel
            // 
            this.infolabel.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infolabel.ForeColor = System.Drawing.Color.White;
            this.infolabel.Location = new System.Drawing.Point(300, 0);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(256, 49);
            this.infolabel.TabIndex = 2;
            this.infolabel.Text = "Deine Bevölkerung verbraucht pro Runde Nahrung und Geld. Wenn du nicht auf die Be" +
                "dürfnisse achtest können Personen sterben oder du verschuldest dich. Die Bedürfn" +
                "isse ändern sich bei jedem Level.";
            this.infolabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buluButton1
            // 
            this.buluButton1.arrowed = false;
            this.buluButton1.Caption = "";
            this.buluButton1.FocusedImage = null;
            this.buluButton1.FocusedImageLeftCapWidth = 6;
            this.buluButton1.FocusedImageTopCapHeight = 6;
            this.buluButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buluButton1.ForeColor = System.Drawing.Color.White;
            this.buluButton1.ForeColorFocused = System.Drawing.Color.White;
            this.buluButton1.ForeColorMouseDown = System.Drawing.Color.White;
            this.buluButton1.ForeColorMouseOver = System.Drawing.Color.White;
            this.buluButton1.Location = new System.Drawing.Point(258, 3);
            this.buluButton1.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("buluButton1.MouseDownImage")));
            this.buluButton1.MouseDownImageLeftCapWidth = 6;
            this.buluButton1.MouseDownImageTopCapHeight = 6;
            this.buluButton1.MouseOverImage = null;
            this.buluButton1.MouseOverImageLeftCapWidth = 6;
            this.buluButton1.MouseOverImageTopCapHeight = 6;
            this.buluButton1.Name = "buluButton1";
            this.buluButton1.NormalImage = ((System.Drawing.Image)(resources.GetObject("buluButton1.NormalImage")));
            this.buluButton1.NormalImageLeftCapWidth = 6;
            this.buluButton1.NormalImageTopCapHeight = 6;
            this.buluButton1.Picture = global::Bulu.Properties.Resources.arrowright;
            this.buluButton1.Size = new System.Drawing.Size(37, 22);
            this.buluButton1.TabIndex = 16;
            this.buluButton1.Click += new System.EventHandler(this.buluButton1_Click);
            // 
            // buluButton2
            // 
            this.buluButton2.arrowed = false;
            this.buluButton2.Caption = "OK";
            this.buluButton2.FocusedImage = null;
            this.buluButton2.FocusedImageLeftCapWidth = 6;
            this.buluButton2.FocusedImageTopCapHeight = 6;
            this.buluButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buluButton2.ForeColor = System.Drawing.Color.White;
            this.buluButton2.ForeColorFocused = System.Drawing.Color.White;
            this.buluButton2.ForeColorMouseDown = System.Drawing.Color.White;
            this.buluButton2.ForeColorMouseOver = System.Drawing.Color.White;
            this.buluButton2.Location = new System.Drawing.Point(258, 26);
            this.buluButton2.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("buluButton2.MouseDownImage")));
            this.buluButton2.MouseDownImageLeftCapWidth = 6;
            this.buluButton2.MouseDownImageTopCapHeight = 6;
            this.buluButton2.MouseOverImage = null;
            this.buluButton2.MouseOverImageLeftCapWidth = 6;
            this.buluButton2.MouseOverImageTopCapHeight = 6;
            this.buluButton2.Name = "buluButton2";
            this.buluButton2.NormalImage = ((System.Drawing.Image)(resources.GetObject("buluButton2.NormalImage")));
            this.buluButton2.NormalImageLeftCapWidth = 6;
            this.buluButton2.NormalImageTopCapHeight = 6;
            this.buluButton2.Picture = null;
            this.buluButton2.Size = new System.Drawing.Size(37, 20);
            this.buluButton2.TabIndex = 15;
            this.buluButton2.Text = "OK";
            this.buluButton2.Click += new System.EventHandler(this.buluButton2_Click);
            // 
            // Beduerfnisse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.Controls.Add(this.buluButton1);
            this.Controls.Add(this.buluButton2);
            this.Controls.Add(this.infolabel);
            this.Controls.Add(this.geldLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nahrungspunkteLabel);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Beduerfnisse";
            this.Size = new System.Drawing.Size(298, 49);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label geldLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nahrungspunkteLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label infolabel;
        private BuluButton buluButton2;
        private BuluButton buluButton1;
    }
}