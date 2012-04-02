namespace Bulu
{
    partial class About
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
            this.versionLabel = new System.Windows.Forms.Label();
            this.devName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buluButton1 = new Bulu.BuluButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shadowLabel2 = new Bulu.Grafik.ShadowLabel();
            this.shadowLabel1 = new Bulu.Grafik.ShadowLabel();
            this.buluButton2 = new Bulu.BuluButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buluButton3 = new Bulu.BuluButton();
            this.buluButton4 = new Bulu.BuluButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // versionLabel
            // 
            this.versionLabel.BackColor = System.Drawing.Color.Transparent;
            this.versionLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ForeColor = System.Drawing.Color.Black;
            this.versionLabel.Location = new System.Drawing.Point(133, 65);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(214, 22);
            this.versionLabel.TabIndex = 1;
            this.versionLabel.Text = "Version x.x.x.x";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // devName
            // 
            this.devName.BackColor = System.Drawing.Color.Transparent;
            this.devName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devName.ForeColor = System.Drawing.Color.Black;
            this.devName.Location = new System.Drawing.Point(15, 119);
            this.devName.Name = "devName";
            this.devName.Size = new System.Drawing.Size(320, 39);
            this.devName.TabIndex = 2;
            this.devName.Text = "Nico Kreipke [dev,gui], Jan Wittler [dev], Patrick Czaja [pic], Robin Schmidt [pi" +
                "c], Alexander Krause [beta], Tobias Niemeyer [coord], Susan Ester [coord,proj]";
            this.devName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Bulu.Properties.Resources.bulu_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bulu";
            // 
            // buluButton1
            // 
            this.buluButton1.arrowed = false;
            this.buluButton1.BackColor = System.Drawing.Color.Transparent;
            this.buluButton1.Caption = "Schließen";
            this.buluButton1.FocusedImage = null;
            this.buluButton1.FocusedImageLeftCapWidth = 6;
            this.buluButton1.FocusedImageTopCapHeight = 6;
            this.buluButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buluButton1.ForeColor = System.Drawing.Color.Black;
            this.buluButton1.ForeColorFocused = System.Drawing.Color.Black;
            this.buluButton1.ForeColorMouseDown = System.Drawing.Color.Black;
            this.buluButton1.ForeColorMouseOver = System.Drawing.Color.Black;
            this.buluButton1.Location = new System.Drawing.Point(247, 12);
            this.buluButton1.MouseDownImage = global::Bulu.Properties.Resources.achwdwbuttondown;
            this.buluButton1.MouseDownImageLeftCapWidth = 6;
            this.buluButton1.MouseDownImageTopCapHeight = 6;
            this.buluButton1.MouseOverImage = null;
            this.buluButton1.MouseOverImageLeftCapWidth = 6;
            this.buluButton1.MouseOverImageTopCapHeight = 6;
            this.buluButton1.Name = "buluButton1";
            this.buluButton1.NormalImage = global::Bulu.Properties.Resources.achwdwbutton;
            this.buluButton1.NormalImageLeftCapWidth = 6;
            this.buluButton1.NormalImageTopCapHeight = 6;
            this.buluButton1.Picture = null;
            this.buluButton1.Size = new System.Drawing.Size(97, 24);
            this.buluButton1.TabIndex = 13;
            this.buluButton1.Text = "Schließen";
            this.buluButton1.Click += new System.EventHandler(this.buluButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Bulu.Properties.Resources.mwdwBottom;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.shadowLabel2);
            this.panel1.Controls.Add(this.shadowLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 304);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 40);
            this.panel1.TabIndex = 14;
            // 
            // shadowLabel2
            // 
            this.shadowLabel2.atext = "der Humboldtschule Hannover.";
            this.shadowLabel2.BackColor = System.Drawing.Color.Transparent;
            this.shadowLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadowLabel2.ForeColor = System.Drawing.Color.White;
            this.shadowLabel2.lightsUp = false;
            this.shadowLabel2.Location = new System.Drawing.Point(0, 19);
            this.shadowLabel2.Name = "shadowLabel2";
            this.shadowLabel2.Size = new System.Drawing.Size(357, 15);
            this.shadowLabel2.TabIndex = 1;
            this.shadowLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // shadowLabel1
            // 
            this.shadowLabel1.atext = "Bulu wurde entwickelt von einer Arbeitsgemeinschaft";
            this.shadowLabel1.BackColor = System.Drawing.Color.Transparent;
            this.shadowLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadowLabel1.ForeColor = System.Drawing.Color.White;
            this.shadowLabel1.lightsUp = false;
            this.shadowLabel1.Location = new System.Drawing.Point(0, 5);
            this.shadowLabel1.Name = "shadowLabel1";
            this.shadowLabel1.Size = new System.Drawing.Size(357, 15);
            this.shadowLabel1.TabIndex = 0;
            this.shadowLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buluButton2
            // 
            this.buluButton2.arrowed = false;
            this.buluButton2.BackColor = System.Drawing.Color.Transparent;
            this.buluButton2.Caption = "Lizenz anzeigen";
            this.buluButton2.FocusedImage = null;
            this.buluButton2.FocusedImageLeftCapWidth = 6;
            this.buluButton2.FocusedImageTopCapHeight = 6;
            this.buluButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buluButton2.ForeColor = System.Drawing.Color.Black;
            this.buluButton2.ForeColorFocused = System.Drawing.Color.Black;
            this.buluButton2.ForeColorMouseDown = System.Drawing.Color.Black;
            this.buluButton2.ForeColorMouseOver = System.Drawing.Color.Black;
            this.buluButton2.Location = new System.Drawing.Point(67, 186);
            this.buluButton2.MouseDownImage = global::Bulu.Properties.Resources.achwdwbuttondown;
            this.buluButton2.MouseDownImageLeftCapWidth = 6;
            this.buluButton2.MouseDownImageTopCapHeight = 6;
            this.buluButton2.MouseOverImage = null;
            this.buluButton2.MouseOverImageLeftCapWidth = 6;
            this.buluButton2.MouseOverImageTopCapHeight = 6;
            this.buluButton2.Name = "buluButton2";
            this.buluButton2.NormalImage = global::Bulu.Properties.Resources.achwdwbutton;
            this.buluButton2.NormalImageLeftCapWidth = 6;
            this.buluButton2.NormalImageTopCapHeight = 6;
            this.buluButton2.Picture = null;
            this.buluButton2.Size = new System.Drawing.Size(222, 26);
            this.buluButton2.TabIndex = 15;
            this.buluButton2.Text = "Lizenz anzeigen";
            this.buluButton2.Click += new System.EventHandler(this.buluButton2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Dieses Programm ist Open Source und steht unter GPLv2.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buluButton3
            // 
            this.buluButton3.arrowed = false;
            this.buluButton3.BackColor = System.Drawing.Color.Transparent;
            this.buluButton3.Caption = "Quelltext anzeigen";
            this.buluButton3.FocusedImage = null;
            this.buluButton3.FocusedImageLeftCapWidth = 6;
            this.buluButton3.FocusedImageTopCapHeight = 6;
            this.buluButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buluButton3.ForeColor = System.Drawing.Color.Black;
            this.buluButton3.ForeColorFocused = System.Drawing.Color.Black;
            this.buluButton3.ForeColorMouseDown = System.Drawing.Color.Black;
            this.buluButton3.ForeColorMouseOver = System.Drawing.Color.Black;
            this.buluButton3.Location = new System.Drawing.Point(67, 218);
            this.buluButton3.MouseDownImage = global::Bulu.Properties.Resources.achwdwbuttondown;
            this.buluButton3.MouseDownImageLeftCapWidth = 6;
            this.buluButton3.MouseDownImageTopCapHeight = 6;
            this.buluButton3.MouseOverImage = null;
            this.buluButton3.MouseOverImageLeftCapWidth = 6;
            this.buluButton3.MouseOverImageTopCapHeight = 6;
            this.buluButton3.Name = "buluButton3";
            this.buluButton3.NormalImage = global::Bulu.Properties.Resources.achwdwbutton;
            this.buluButton3.NormalImageLeftCapWidth = 6;
            this.buluButton3.NormalImageTopCapHeight = 6;
            this.buluButton3.Picture = null;
            this.buluButton3.Size = new System.Drawing.Size(222, 26);
            this.buluButton3.TabIndex = 17;
            this.buluButton3.Text = "Quelltext anzeigen";
            this.buluButton3.Click += new System.EventHandler(this.buluButton3_Click);
            // 
            // buluButton4
            // 
            this.buluButton4.arrowed = false;
            this.buluButton4.BackColor = System.Drawing.Color.Transparent;
            this.buluButton4.Caption = "bulu.program-art.com";
            this.buluButton4.FocusedImage = null;
            this.buluButton4.FocusedImageLeftCapWidth = 6;
            this.buluButton4.FocusedImageTopCapHeight = 6;
            this.buluButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buluButton4.ForeColor = System.Drawing.Color.Black;
            this.buluButton4.ForeColorFocused = System.Drawing.Color.Black;
            this.buluButton4.ForeColorMouseDown = System.Drawing.Color.Black;
            this.buluButton4.ForeColorMouseOver = System.Drawing.Color.Black;
            this.buluButton4.Location = new System.Drawing.Point(67, 250);
            this.buluButton4.MouseDownImage = global::Bulu.Properties.Resources.achwdwbuttondown;
            this.buluButton4.MouseDownImageLeftCapWidth = 6;
            this.buluButton4.MouseDownImageTopCapHeight = 6;
            this.buluButton4.MouseOverImage = null;
            this.buluButton4.MouseOverImageLeftCapWidth = 6;
            this.buluButton4.MouseOverImageTopCapHeight = 6;
            this.buluButton4.Name = "buluButton4";
            this.buluButton4.NormalImage = global::Bulu.Properties.Resources.achwdwbutton;
            this.buluButton4.NormalImageLeftCapWidth = 6;
            this.buluButton4.NormalImageTopCapHeight = 6;
            this.buluButton4.Picture = null;
            this.buluButton4.Size = new System.Drawing.Size(222, 26);
            this.buluButton4.TabIndex = 18;
            this.buluButton4.Text = "bulu.program-art.com";
            this.buluButton4.Click += new System.EventHandler(this.buluButton4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Bulu.Properties.Resources.nkfnew;
            this.pictureBox2.Location = new System.Drawing.Point(305, 282);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bulu.Properties.Resources.linenbkgnorepeat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buluButton4);
            this.Controls.Add(this.buluButton3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buluButton2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buluButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.devName);
            this.Controls.Add(this.versionLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "About";
            this.Size = new System.Drawing.Size(357, 344);
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label versionLabel;
        public System.Windows.Forms.Label devName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private BuluButton buluButton1;
        private System.Windows.Forms.Panel panel1;
        private Grafik.ShadowLabel shadowLabel1;
        private BuluButton buluButton2;
        public System.Windows.Forms.Label label1;
        private BuluButton buluButton3;
        private BuluButton buluButton4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Grafik.ShadowLabel shadowLabel2;
    }
}