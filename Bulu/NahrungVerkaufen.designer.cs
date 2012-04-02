namespace Bulu
{
    partial class NahrungVerkaufen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NahrungVerkaufen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.preislbl = new System.Windows.Forms.Label();
            this.mengelbl = new System.Windows.Forms.Label();
            this.buluButton2 = new Bulu.BuluButton();
            this.buluButton1 = new Bulu.BuluButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menge:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Verkaufspreis:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // preislbl
            // 
            this.preislbl.BackColor = System.Drawing.Color.Transparent;
            this.preislbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preislbl.ForeColor = System.Drawing.Color.White;
            this.preislbl.Location = new System.Drawing.Point(116, 20);
            this.preislbl.Name = "preislbl";
            this.preislbl.Size = new System.Drawing.Size(99, 26);
            this.preislbl.TabIndex = 2;
            this.preislbl.Text = "100 Dalasi";
            this.preislbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mengelbl
            // 
            this.mengelbl.BackColor = System.Drawing.Color.Transparent;
            this.mengelbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mengelbl.ForeColor = System.Drawing.Color.White;
            this.mengelbl.Location = new System.Drawing.Point(116, -2);
            this.mengelbl.Name = "mengelbl";
            this.mengelbl.Size = new System.Drawing.Size(99, 26);
            this.mengelbl.TabIndex = 8;
            this.mengelbl.Text = "1";
            this.mengelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buluButton2
            // 
            this.buluButton2.arrowed = false;
            this.buluButton2.Caption = "Abbrechen";
            this.buluButton2.FocusedImage = null;
            this.buluButton2.FocusedImageLeftCapWidth = 6;
            this.buluButton2.FocusedImageTopCapHeight = 6;
            this.buluButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buluButton2.ForeColor = System.Drawing.Color.White;
            this.buluButton2.ForeColorFocused = System.Drawing.Color.White;
            this.buluButton2.ForeColorMouseDown = System.Drawing.Color.White;
            this.buluButton2.ForeColorMouseOver = System.Drawing.Color.White;
            this.buluButton2.Location = new System.Drawing.Point(218, 26);
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
            this.buluButton2.Size = new System.Drawing.Size(77, 20);
            this.buluButton2.TabIndex = 7;
            this.buluButton2.Text = "Abbrechen";
            this.buluButton2.Click += new System.EventHandler(this.buluButton2_Click);
            // 
            // buluButton1
            // 
            this.buluButton1.arrowed = false;
            this.buluButton1.Caption = "Verkaufen";
            this.buluButton1.FocusedImage = null;
            this.buluButton1.FocusedImageLeftCapWidth = 6;
            this.buluButton1.FocusedImageTopCapHeight = 6;
            this.buluButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buluButton1.ForeColor = System.Drawing.Color.White;
            this.buluButton1.ForeColorFocused = System.Drawing.Color.White;
            this.buluButton1.ForeColorMouseDown = System.Drawing.Color.White;
            this.buluButton1.ForeColorMouseOver = System.Drawing.Color.White;
            this.buluButton1.Location = new System.Drawing.Point(218, 4);
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
            this.buluButton1.Picture = null;
            this.buluButton1.Size = new System.Drawing.Size(77, 20);
            this.buluButton1.TabIndex = 6;
            this.buluButton1.Text = "Verkaufen";
            this.buluButton1.Click += new System.EventHandler(this.buluButton1_Click);
            // 
            // NahrungVerkaufen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.Controls.Add(this.mengelbl);
            this.Controls.Add(this.buluButton2);
            this.Controls.Add(this.buluButton1);
            this.Controls.Add(this.preislbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "NahrungVerkaufen";
            this.Size = new System.Drawing.Size(298, 49);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label preislbl;
        private BuluButton buluButton1;
        private BuluButton buluButton2;
        private System.Windows.Forms.Label mengelbl;
    }
}