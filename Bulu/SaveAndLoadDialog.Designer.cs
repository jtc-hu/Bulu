namespace Bulu
{
    partial class SaveAndLoadDialog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveAndLoadDialog));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveGameListView = new Bulu.ListViewAero();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.spielstandLoeschenButton = new nKF.Controls.nKButton();
            this.nKButton1 = new nKF.Controls.nKButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gradientPanel = new System.Windows.Forms.Panel();
            this.buluButton1 = new Bulu.BuluButton();
            this.savegameLabel = new System.Windows.Forms.Label();
            this.savegameName = new System.Windows.Forms.TextBox();
            this.savecmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.unterNeuemNamenSpeichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gradientPanel.SuspendLayout();
            this.savecmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SaveGameListView);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 339);
            this.panel1.TabIndex = 1;
            // 
            // SaveGameListView
            // 
            this.SaveGameListView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SaveGameListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SaveGameListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1});
            this.SaveGameListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveGameListView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveGameListView.FullRowSelect = true;
            this.SaveGameListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.SaveGameListView.Location = new System.Drawing.Point(0, 0);
            this.SaveGameListView.MultiSelect = false;
            this.SaveGameListView.Name = "SaveGameListView";
            this.SaveGameListView.Size = new System.Drawing.Size(384, 304);
            this.SaveGameListView.TabIndex = 1;
            this.SaveGameListView.UseCompatibleStateImageBehavior = false;
            this.SaveGameListView.View = System.Windows.Forms.View.Details;
            this.SaveGameListView.SelectedIndexChanged += new System.EventHandler(this.SaveGameListView_SelectedIndexChanged);
            this.SaveGameListView.DoubleClick += new System.EventHandler(this.SaveGameListView_DoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Spielname";
            this.columnHeader3.Width = 229;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Datum";
            this.columnHeader1.Width = 151;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.spielstandLoeschenButton);
            this.panel2.Controls.Add(this.nKButton1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 304);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 35);
            this.panel2.TabIndex = 2;
            // 
            // spielstandLoeschenButton
            // 
            this.spielstandLoeschenButton.FocusedImage = null;
            this.spielstandLoeschenButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spielstandLoeschenButton.ForeColor = System.Drawing.Color.White;
            this.spielstandLoeschenButton.ForeColorFocused = System.Drawing.Color.White;
            this.spielstandLoeschenButton.ForeColorMouseDown = System.Drawing.Color.White;
            this.spielstandLoeschenButton.ForeColorMouseOver = System.Drawing.Color.White;
            this.spielstandLoeschenButton.Location = new System.Drawing.Point(6, 6);
            this.spielstandLoeschenButton.MouseDownImage = global::Bulu.Properties.Resources.achwdwbuttondown;
            this.spielstandLoeschenButton.MouseDownImageLeftCapWidth = 5;
            this.spielstandLoeschenButton.MouseDownImageTopCapHeight = 5;
            this.spielstandLoeschenButton.MouseOverImage = null;
            this.spielstandLoeschenButton.Name = "spielstandLoeschenButton";
            this.spielstandLoeschenButton.NormalImage = global::Bulu.Properties.Resources.achwdwbutton;
            this.spielstandLoeschenButton.NormalImageLeftCapWidth = 5;
            this.spielstandLoeschenButton.NormalImageTopCapHeight = 5;
            this.spielstandLoeschenButton.Size = new System.Drawing.Size(132, 23);
            this.spielstandLoeschenButton.TabIndex = 3;
            this.spielstandLoeschenButton.Text = "Spielstand löschen";
            this.spielstandLoeschenButton.Visible = false;
            this.spielstandLoeschenButton.Click += new System.EventHandler(this.spielstandLoeschenButton_Click);
            // 
            // nKButton1
            // 
            this.nKButton1.FocusedImage = null;
            this.nKButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nKButton1.ForeColor = System.Drawing.Color.White;
            this.nKButton1.ForeColorFocused = System.Drawing.Color.White;
            this.nKButton1.ForeColorMouseDown = System.Drawing.Color.White;
            this.nKButton1.ForeColorMouseOver = System.Drawing.Color.White;
            this.nKButton1.Location = new System.Drawing.Point(294, 6);
            this.nKButton1.MouseDownImage = global::Bulu.Properties.Resources.achwdwbuttondown;
            this.nKButton1.MouseDownImageLeftCapWidth = 5;
            this.nKButton1.MouseDownImageTopCapHeight = 5;
            this.nKButton1.MouseOverImage = null;
            this.nKButton1.Name = "nKButton1";
            this.nKButton1.NormalImage = global::Bulu.Properties.Resources.achwdwbutton;
            this.nKButton1.NormalImageLeftCapWidth = 5;
            this.nKButton1.NormalImageTopCapHeight = 5;
            this.nKButton1.Size = new System.Drawing.Size(84, 23);
            this.nKButton1.TabIndex = 2;
            this.nKButton1.Text = "Schließen";
            this.nKButton1.Click += new System.EventHandler(this.nKButton1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 1);
            this.panel3.TabIndex = 0;
            // 
            // gradientPanel
            // 
            this.gradientPanel.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel.Controls.Add(this.buluButton1);
            this.gradientPanel.Controls.Add(this.savegameLabel);
            this.gradientPanel.Controls.Add(this.savegameName);
            this.gradientPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel.Name = "gradientPanel";
            this.gradientPanel.Size = new System.Drawing.Size(384, 62);
            this.gradientPanel.TabIndex = 0;
            this.gradientPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel_Paint);
            this.gradientPanel.Resize += new System.EventHandler(this.gradientPanel_Resize);
            // 
            // buluButton1
            // 
            this.buluButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buluButton1.arrowed = false;
            this.buluButton1.BackColor = System.Drawing.Color.Transparent;
            this.buluButton1.Caption = "Aktuelles Spiel speichern";
            this.buluButton1.FocusedImage = null;
            this.buluButton1.FocusedImageLeftCapWidth = 6;
            this.buluButton1.FocusedImageTopCapHeight = 6;
            this.buluButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buluButton1.ForeColor = System.Drawing.Color.Black;
            this.buluButton1.ForeColorFocused = System.Drawing.Color.Black;
            this.buluButton1.ForeColorMouseDown = System.Drawing.Color.Black;
            this.buluButton1.ForeColorMouseOver = System.Drawing.Color.Black;
            this.buluButton1.Location = new System.Drawing.Point(12, 12);
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
            this.buluButton1.Size = new System.Drawing.Size(360, 37);
            this.buluButton1.TabIndex = 0;
            this.buluButton1.Text = "Aktuelles Spiel speichern";
            this.buluButton1.Click += new System.EventHandler(this.buluButton1_Click);
            // 
            // savegameLabel
            // 
            this.savegameLabel.AutoSize = true;
            this.savegameLabel.BackColor = System.Drawing.Color.Transparent;
            this.savegameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savegameLabel.Location = new System.Drawing.Point(12, 5);
            this.savegameLabel.Name = "savegameLabel";
            this.savegameLabel.Size = new System.Drawing.Size(163, 20);
            this.savegameLabel.TabIndex = 1;
            this.savegameLabel.Text = "Name des Spielstandes";
            this.savegameLabel.Visible = false;
            // 
            // savegameName
            // 
            this.savegameName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.savegameName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savegameName.Location = new System.Drawing.Point(12, 26);
            this.savegameName.Name = "savegameName";
            this.savegameName.Size = new System.Drawing.Size(360, 27);
            this.savegameName.TabIndex = 1;
            this.savegameName.Visible = false;
            this.savegameName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.savegameName_KeyDown);
            // 
            // savecmenu
            // 
            this.savecmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unterNeuemNamenSpeichernToolStripMenuItem});
            this.savecmenu.Name = "savecmenu";
            this.savecmenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.savecmenu.ShowImageMargin = false;
            this.savecmenu.Size = new System.Drawing.Size(215, 26);
            // 
            // unterNeuemNamenSpeichernToolStripMenuItem
            // 
            this.unterNeuemNamenSpeichernToolStripMenuItem.Name = "unterNeuemNamenSpeichernToolStripMenuItem";
            this.unterNeuemNamenSpeichernToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.unterNeuemNamenSpeichernToolStripMenuItem.Text = "Unter neuem Namen speichern";
            this.unterNeuemNamenSpeichernToolStripMenuItem.Click += new System.EventHandler(this.unterNeuemNamenSpeichernToolStripMenuItem_Click);
            // 
            // SaveAndLoadDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gradientPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SaveAndLoadDialog";
            this.Size = new System.Drawing.Size(384, 401);
            this.Load += new System.EventHandler(this.SaveAndLoadDialog_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gradientPanel.ResumeLayout(false);
            this.gradientPanel.PerformLayout();
            this.savecmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gradientPanel;
        private System.Windows.Forms.Label savegameLabel;
        private System.Windows.Forms.TextBox savegameName;
        private BuluButton buluButton1;
        private System.Windows.Forms.Panel panel1;
        private ListViewAero SaveGameListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ContextMenuStrip savecmenu;
        private System.Windows.Forms.ToolStripMenuItem unterNeuemNamenSpeichernToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private nKF.Controls.nKButton spielstandLoeschenButton;
        private nKF.Controls.nKButton nKButton1;
    }
}