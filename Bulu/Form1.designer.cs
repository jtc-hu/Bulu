namespace Bulu
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolBarPanel = new System.Windows.Forms.Panel();
            this.mainHUD = new Bulu.HUDPanel();
            this.mainHUDContent = new System.Windows.Forms.Panel();
            this.bildungspunkteLabel = new Bulu.Grafik.ShadowLabel();
            this.nahrungspunkteLabel = new Bulu.Grafik.ShadowLabel();
            this.label1 = new Bulu.Grafik.ShadowLabel();
            this.label2 = new Bulu.Grafik.ShadowLabel();
            this.label5 = new Bulu.Grafik.ShadowLabel();
            this.gestpsLabel = new Bulu.Grafik.ShadowLabel();
            this.label3 = new Bulu.Grafik.ShadowLabel();
            this.personenLabel = new Bulu.Grafik.ShadowLabel();
            this.hudPanel1 = new Bulu.HUDPanel();
            this.geldsumme = new Bulu.Grafik.ShadowLabel();
            this.buluButton1 = new Bulu.BuluButton();
            this.updateButton = new Bulu.BuluButton();
            this.saveAndLoadButton = new Bulu.BuluButton();
            this.beduerfnisButton = new Bulu.BuluButton();
            this.infoButton = new Bulu.BuluButton();
            this.lvlupButton = new Bulu.BuluButton();
            this.rndupButton = new Bulu.BuluButton();
            this.sellButton = new Bulu.BuluButton();
            this.BuluUpdater = new updateSystemDotNet.updateController();
            this.f15 = new Bulu.Feld();
            this.f14 = new Bulu.Feld();
            this.f13 = new Bulu.Feld();
            this.f12 = new Bulu.Feld();
            this.f11 = new Bulu.Feld();
            this.f10 = new Bulu.Feld();
            this.f9 = new Bulu.Feld();
            this.f8 = new Bulu.Feld();
            this.f7 = new Bulu.Feld();
            this.f6 = new Bulu.Feld();
            this.f5 = new Bulu.Feld();
            this.f4 = new Bulu.Feld();
            this.f3 = new Bulu.Feld();
            this.f2 = new Bulu.Feld();
            this.f1 = new Bulu.Feld();
            this.toolBarPanel.SuspendLayout();
            this.mainHUD.SuspendLayout();
            this.mainHUDContent.SuspendLayout();
            this.hudPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBarPanel
            // 
            this.toolBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.toolBarPanel.Controls.Add(this.mainHUD);
            this.toolBarPanel.Controls.Add(this.hudPanel1);
            this.toolBarPanel.Controls.Add(this.buluButton1);
            this.toolBarPanel.Controls.Add(this.updateButton);
            this.toolBarPanel.Controls.Add(this.saveAndLoadButton);
            this.toolBarPanel.Controls.Add(this.beduerfnisButton);
            this.toolBarPanel.Controls.Add(this.infoButton);
            this.toolBarPanel.Controls.Add(this.lvlupButton);
            this.toolBarPanel.Controls.Add(this.rndupButton);
            this.toolBarPanel.Controls.Add(this.sellButton);
            this.toolBarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolBarPanel.Location = new System.Drawing.Point(0, 555);
            this.toolBarPanel.Name = "toolBarPanel";
            this.toolBarPanel.Size = new System.Drawing.Size(920, 58);
            this.toolBarPanel.TabIndex = 26;
            // 
            // mainHUD
            // 
            this.mainHUD.BackColor = System.Drawing.Color.Transparent;
            this.mainHUD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainHUD.BackgroundImage")));
            this.mainHUD.Controls.Add(this.mainHUDContent);
            this.mainHUD.Location = new System.Drawing.Point(282, 4);
            this.mainHUD.Name = "mainHUD";
            this.mainHUD.Size = new System.Drawing.Size(298, 49);
            this.mainHUD.TabIndex = 34;
            // 
            // mainHUDContent
            // 
            this.mainHUDContent.Controls.Add(this.bildungspunkteLabel);
            this.mainHUDContent.Controls.Add(this.nahrungspunkteLabel);
            this.mainHUDContent.Controls.Add(this.label1);
            this.mainHUDContent.Controls.Add(this.label2);
            this.mainHUDContent.Controls.Add(this.label5);
            this.mainHUDContent.Controls.Add(this.gestpsLabel);
            this.mainHUDContent.Controls.Add(this.label3);
            this.mainHUDContent.Controls.Add(this.personenLabel);
            this.mainHUDContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainHUDContent.Location = new System.Drawing.Point(0, 0);
            this.mainHUDContent.Name = "mainHUDContent";
            this.mainHUDContent.Size = new System.Drawing.Size(298, 49);
            this.mainHUDContent.TabIndex = 0;
            // 
            // bildungspunkteLabel
            // 
            this.bildungspunkteLabel.atext = "";
            this.bildungspunkteLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bildungspunkteLabel.ForeColor = System.Drawing.Color.White;
            this.bildungspunkteLabel.lightsUp = false;
            this.bildungspunkteLabel.Location = new System.Drawing.Point(87, 27);
            this.bildungspunkteLabel.Name = "bildungspunkteLabel";
            this.bildungspunkteLabel.Size = new System.Drawing.Size(55, 18);
            this.bildungspunkteLabel.TabIndex = 30;
            this.bildungspunkteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nahrungspunkteLabel
            // 
            this.nahrungspunkteLabel.atext = "";
            this.nahrungspunkteLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nahrungspunkteLabel.ForeColor = System.Drawing.Color.White;
            this.nahrungspunkteLabel.lightsUp = false;
            this.nahrungspunkteLabel.Location = new System.Drawing.Point(87, 4);
            this.nahrungspunkteLabel.Name = "nahrungspunkteLabel";
            this.nahrungspunkteLabel.Size = new System.Drawing.Size(55, 18);
            this.nahrungspunkteLabel.TabIndex = 29;
            this.nahrungspunkteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.atext = "Nahrung";
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.lightsUp = true;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 32;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.atext = "Bildung";
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.lightsUp = true;
            this.label2.Location = new System.Drawing.Point(2, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 33;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.atext = "Freie Personen";
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.lightsUp = true;
            this.label5.Location = new System.Drawing.Point(147, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 36;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gestpsLabel
            // 
            this.gestpsLabel.atext = "";
            this.gestpsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestpsLabel.ForeColor = System.Drawing.Color.White;
            this.gestpsLabel.lightsUp = false;
            this.gestpsLabel.Location = new System.Drawing.Point(256, 4);
            this.gestpsLabel.Name = "gestpsLabel";
            this.gestpsLabel.Size = new System.Drawing.Size(39, 18);
            this.gestpsLabel.TabIndex = 31;
            this.gestpsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.atext = "Gestorbene";
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.lightsUp = true;
            this.label3.Location = new System.Drawing.Point(150, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 34;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // personenLabel
            // 
            this.personenLabel.atext = "";
            this.personenLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personenLabel.ForeColor = System.Drawing.Color.White;
            this.personenLabel.lightsUp = false;
            this.personenLabel.Location = new System.Drawing.Point(256, 27);
            this.personenLabel.Name = "personenLabel";
            this.personenLabel.Size = new System.Drawing.Size(39, 18);
            this.personenLabel.TabIndex = 35;
            this.personenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hudPanel1
            // 
            this.hudPanel1.BackColor = System.Drawing.Color.Transparent;
            this.hudPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hudPanel1.BackgroundImage")));
            this.hudPanel1.Controls.Add(this.geldsumme);
            this.hudPanel1.Location = new System.Drawing.Point(118, 14);
            this.hudPanel1.Name = "hudPanel1";
            this.hudPanel1.Size = new System.Drawing.Size(119, 32);
            this.hudPanel1.TabIndex = 33;
            // 
            // geldsumme
            // 
            this.geldsumme.atext = "Geld";
            this.geldsumme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.geldsumme.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geldsumme.ForeColor = System.Drawing.Color.White;
            this.geldsumme.lightsUp = true;
            this.geldsumme.Location = new System.Drawing.Point(0, 0);
            this.geldsumme.Name = "geldsumme";
            this.geldsumme.Size = new System.Drawing.Size(119, 32);
            this.geldsumme.TabIndex = 15;
            this.geldsumme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buluButton1
            // 
            this.buluButton1.arrowed = false;
            this.buluButton1.Caption = "";
            this.buluButton1.FocusedImage = null;
            this.buluButton1.FocusedImageLeftCapWidth = 6;
            this.buluButton1.FocusedImageTopCapHeight = 6;
            this.buluButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buluButton1.ForeColor = System.Drawing.Color.White;
            this.buluButton1.ForeColorFocused = System.Drawing.Color.White;
            this.buluButton1.ForeColorMouseDown = System.Drawing.Color.White;
            this.buluButton1.ForeColorMouseOver = System.Drawing.Color.White;
            this.buluButton1.Location = new System.Drawing.Point(48, 4);
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
            this.buluButton1.Picture = global::Bulu.Properties.Resources.ach;
            this.buluButton1.ShadowColorFocused = System.Drawing.Color.Transparent;
            this.buluButton1.ShadowColorMouseDown = System.Drawing.Color.Transparent;
            this.buluButton1.ShadowColorMouseOver = System.Drawing.Color.Transparent;
            this.buluButton1.ShadowColorNormal = System.Drawing.Color.Transparent;
            this.buluButton1.ShadowOffsetFocused = new System.Drawing.Point(0, 0);
            this.buluButton1.ShadowOffsetMouseDown = new System.Drawing.Point(0, 0);
            this.buluButton1.ShadowOffsetMouseOver = new System.Drawing.Point(0, 0);
            this.buluButton1.ShadowOffsetNormal = new System.Drawing.Point(0, 0);
            this.buluButton1.Size = new System.Drawing.Size(31, 23);
            this.buluButton1.TabIndex = 32;
            this.buluButton1.Click += new System.EventHandler(this.buluButton1_Click);
            // 
            // updateButton
            // 
            this.updateButton.arrowed = false;
            this.updateButton.Caption = "";
            this.updateButton.FocusedImage = null;
            this.updateButton.FocusedImageLeftCapWidth = 6;
            this.updateButton.FocusedImageTopCapHeight = 6;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.ForeColorFocused = System.Drawing.Color.White;
            this.updateButton.ForeColorMouseDown = System.Drawing.Color.White;
            this.updateButton.ForeColorMouseOver = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(48, 30);
            this.updateButton.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("updateButton.MouseDownImage")));
            this.updateButton.MouseDownImageLeftCapWidth = 6;
            this.updateButton.MouseDownImageTopCapHeight = 6;
            this.updateButton.MouseOverImage = null;
            this.updateButton.MouseOverImageLeftCapWidth = 6;
            this.updateButton.MouseOverImageTopCapHeight = 6;
            this.updateButton.Name = "updateButton";
            this.updateButton.NormalImage = ((System.Drawing.Image)(resources.GetObject("updateButton.NormalImage")));
            this.updateButton.NormalImageLeftCapWidth = 6;
            this.updateButton.NormalImageTopCapHeight = 6;
            this.updateButton.Picture = global::Bulu.Properties.Resources.upd;
            this.updateButton.ShadowColorFocused = System.Drawing.Color.Transparent;
            this.updateButton.ShadowColorMouseDown = System.Drawing.Color.Transparent;
            this.updateButton.ShadowColorMouseOver = System.Drawing.Color.Transparent;
            this.updateButton.ShadowColorNormal = System.Drawing.Color.Transparent;
            this.updateButton.ShadowOffsetFocused = new System.Drawing.Point(0, 0);
            this.updateButton.ShadowOffsetMouseDown = new System.Drawing.Point(0, 0);
            this.updateButton.ShadowOffsetMouseOver = new System.Drawing.Point(0, 0);
            this.updateButton.ShadowOffsetNormal = new System.Drawing.Point(0, 0);
            this.updateButton.Size = new System.Drawing.Size(31, 23);
            this.updateButton.TabIndex = 31;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // saveAndLoadButton
            // 
            this.saveAndLoadButton.arrowed = false;
            this.saveAndLoadButton.Caption = "";
            this.saveAndLoadButton.FocusedImage = null;
            this.saveAndLoadButton.FocusedImageLeftCapWidth = 6;
            this.saveAndLoadButton.FocusedImageTopCapHeight = 6;
            this.saveAndLoadButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAndLoadButton.ForeColor = System.Drawing.Color.White;
            this.saveAndLoadButton.ForeColorFocused = System.Drawing.Color.White;
            this.saveAndLoadButton.ForeColorMouseDown = System.Drawing.Color.White;
            this.saveAndLoadButton.ForeColorMouseOver = System.Drawing.Color.White;
            this.saveAndLoadButton.Location = new System.Drawing.Point(12, 4);
            this.saveAndLoadButton.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("saveAndLoadButton.MouseDownImage")));
            this.saveAndLoadButton.MouseDownImageLeftCapWidth = 6;
            this.saveAndLoadButton.MouseDownImageTopCapHeight = 6;
            this.saveAndLoadButton.MouseOverImage = null;
            this.saveAndLoadButton.MouseOverImageLeftCapWidth = 6;
            this.saveAndLoadButton.MouseOverImageTopCapHeight = 6;
            this.saveAndLoadButton.Name = "saveAndLoadButton";
            this.saveAndLoadButton.NormalImage = ((System.Drawing.Image)(resources.GetObject("saveAndLoadButton.NormalImage")));
            this.saveAndLoadButton.NormalImageLeftCapWidth = 6;
            this.saveAndLoadButton.NormalImageTopCapHeight = 6;
            this.saveAndLoadButton.Picture = global::Bulu.Properties.Resources.disk;
            this.saveAndLoadButton.ShadowColorFocused = System.Drawing.Color.Transparent;
            this.saveAndLoadButton.ShadowColorMouseDown = System.Drawing.Color.Transparent;
            this.saveAndLoadButton.ShadowColorMouseOver = System.Drawing.Color.Transparent;
            this.saveAndLoadButton.ShadowColorNormal = System.Drawing.Color.Transparent;
            this.saveAndLoadButton.ShadowOffsetFocused = new System.Drawing.Point(0, 0);
            this.saveAndLoadButton.ShadowOffsetMouseDown = new System.Drawing.Point(0, 0);
            this.saveAndLoadButton.ShadowOffsetMouseOver = new System.Drawing.Point(0, 0);
            this.saveAndLoadButton.ShadowOffsetNormal = new System.Drawing.Point(0, 0);
            this.saveAndLoadButton.Size = new System.Drawing.Size(31, 23);
            this.saveAndLoadButton.TabIndex = 30;
            this.saveAndLoadButton.Click += new System.EventHandler(this.saveAndLoadButton_Click);
            // 
            // beduerfnisButton
            // 
            this.beduerfnisButton.arrowed = false;
            this.beduerfnisButton.Caption = "Bedürfnisse";
            this.beduerfnisButton.FocusedImage = null;
            this.beduerfnisButton.FocusedImageLeftCapWidth = 6;
            this.beduerfnisButton.FocusedImageTopCapHeight = 6;
            this.beduerfnisButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beduerfnisButton.ForeColor = System.Drawing.Color.White;
            this.beduerfnisButton.ForeColorFocused = System.Drawing.Color.White;
            this.beduerfnisButton.ForeColorMouseDown = System.Drawing.Color.White;
            this.beduerfnisButton.ForeColorMouseOver = System.Drawing.Color.White;
            this.beduerfnisButton.Location = new System.Drawing.Point(717, 4);
            this.beduerfnisButton.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("beduerfnisButton.MouseDownImage")));
            this.beduerfnisButton.MouseDownImageLeftCapWidth = 6;
            this.beduerfnisButton.MouseDownImageTopCapHeight = 6;
            this.beduerfnisButton.MouseOverImage = null;
            this.beduerfnisButton.MouseOverImageLeftCapWidth = 6;
            this.beduerfnisButton.MouseOverImageTopCapHeight = 6;
            this.beduerfnisButton.Name = "beduerfnisButton";
            this.beduerfnisButton.NormalImage = ((System.Drawing.Image)(resources.GetObject("beduerfnisButton.NormalImage")));
            this.beduerfnisButton.NormalImageLeftCapWidth = 6;
            this.beduerfnisButton.NormalImageTopCapHeight = 6;
            this.beduerfnisButton.Picture = null;
            this.beduerfnisButton.ShadowColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.beduerfnisButton.ShadowColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.beduerfnisButton.ShadowColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.beduerfnisButton.ShadowColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.beduerfnisButton.ShadowOffsetFocused = new System.Drawing.Point(0, 1);
            this.beduerfnisButton.ShadowOffsetMouseDown = new System.Drawing.Point(0, 1);
            this.beduerfnisButton.ShadowOffsetMouseOver = new System.Drawing.Point(0, 1);
            this.beduerfnisButton.ShadowOffsetNormal = new System.Drawing.Point(0, 1);
            this.beduerfnisButton.Size = new System.Drawing.Size(72, 49);
            this.beduerfnisButton.TabIndex = 29;
            this.beduerfnisButton.Text = "Bedürfnisse";
            this.beduerfnisButton.Click += new System.EventHandler(this.beduerfnisButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.arrowed = false;
            this.infoButton.Caption = "";
            this.infoButton.FocusedImage = null;
            this.infoButton.FocusedImageLeftCapWidth = 6;
            this.infoButton.FocusedImageTopCapHeight = 6;
            this.infoButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoButton.ForeColor = System.Drawing.Color.White;
            this.infoButton.ForeColorFocused = System.Drawing.Color.White;
            this.infoButton.ForeColorMouseDown = System.Drawing.Color.White;
            this.infoButton.ForeColorMouseOver = System.Drawing.Color.White;
            this.infoButton.Location = new System.Drawing.Point(12, 30);
            this.infoButton.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("infoButton.MouseDownImage")));
            this.infoButton.MouseDownImageLeftCapWidth = 6;
            this.infoButton.MouseDownImageTopCapHeight = 6;
            this.infoButton.MouseOverImage = null;
            this.infoButton.MouseOverImageLeftCapWidth = 6;
            this.infoButton.MouseOverImageTopCapHeight = 6;
            this.infoButton.Name = "infoButton";
            this.infoButton.NormalImage = ((System.Drawing.Image)(resources.GetObject("infoButton.NormalImage")));
            this.infoButton.NormalImageLeftCapWidth = 6;
            this.infoButton.NormalImageTopCapHeight = 6;
            this.infoButton.Picture = global::Bulu.Properties.Resources.info;
            this.infoButton.ShadowColorFocused = System.Drawing.Color.Transparent;
            this.infoButton.ShadowColorMouseDown = System.Drawing.Color.Transparent;
            this.infoButton.ShadowColorMouseOver = System.Drawing.Color.Transparent;
            this.infoButton.ShadowColorNormal = System.Drawing.Color.Transparent;
            this.infoButton.ShadowOffsetFocused = new System.Drawing.Point(0, 0);
            this.infoButton.ShadowOffsetMouseDown = new System.Drawing.Point(0, 0);
            this.infoButton.ShadowOffsetMouseOver = new System.Drawing.Point(0, 0);
            this.infoButton.ShadowOffsetNormal = new System.Drawing.Point(0, 0);
            this.infoButton.Size = new System.Drawing.Size(31, 23);
            this.infoButton.TabIndex = 26;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // lvlupButton
            // 
            this.lvlupButton.arrowed = true;
            this.lvlupButton.Caption = "Level up";
            this.lvlupButton.FocusedImage = null;
            this.lvlupButton.FocusedImageLeftCapWidth = 30;
            this.lvlupButton.FocusedImageTopCapHeight = 6;
            this.lvlupButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlupButton.ForeColor = System.Drawing.Color.White;
            this.lvlupButton.ForeColorFocused = System.Drawing.Color.White;
            this.lvlupButton.ForeColorMouseDown = System.Drawing.Color.White;
            this.lvlupButton.ForeColorMouseOver = System.Drawing.Color.White;
            this.lvlupButton.Location = new System.Drawing.Point(793, 4);
            this.lvlupButton.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("lvlupButton.MouseDownImage")));
            this.lvlupButton.MouseDownImageLeftCapWidth = 30;
            this.lvlupButton.MouseDownImageTopCapHeight = 6;
            this.lvlupButton.MouseOverImage = null;
            this.lvlupButton.MouseOverImageLeftCapWidth = 30;
            this.lvlupButton.MouseOverImageTopCapHeight = 6;
            this.lvlupButton.Name = "lvlupButton";
            this.lvlupButton.NormalImage = ((System.Drawing.Image)(resources.GetObject("lvlupButton.NormalImage")));
            this.lvlupButton.NormalImageLeftCapWidth = 30;
            this.lvlupButton.NormalImageTopCapHeight = 6;
            this.lvlupButton.Picture = null;
            this.lvlupButton.ShadowColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvlupButton.ShadowColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvlupButton.ShadowColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvlupButton.ShadowColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvlupButton.ShadowOffsetFocused = new System.Drawing.Point(0, 1);
            this.lvlupButton.ShadowOffsetMouseDown = new System.Drawing.Point(0, 1);
            this.lvlupButton.ShadowOffsetMouseOver = new System.Drawing.Point(0, 1);
            this.lvlupButton.ShadowOffsetNormal = new System.Drawing.Point(0, 1);
            this.lvlupButton.Size = new System.Drawing.Size(115, 23);
            this.lvlupButton.TabIndex = 16;
            this.lvlupButton.Text = "Level up";
            this.lvlupButton.Click += new System.EventHandler(this.lvlupButton_Click);
            // 
            // rndupButton
            // 
            this.rndupButton.arrowed = true;
            this.rndupButton.Caption = "";
            this.rndupButton.FocusedImage = null;
            this.rndupButton.FocusedImageLeftCapWidth = 30;
            this.rndupButton.FocusedImageTopCapHeight = 6;
            this.rndupButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rndupButton.ForeColor = System.Drawing.Color.White;
            this.rndupButton.ForeColorFocused = System.Drawing.Color.White;
            this.rndupButton.ForeColorMouseDown = System.Drawing.Color.White;
            this.rndupButton.ForeColorMouseOver = System.Drawing.Color.White;
            this.rndupButton.Location = new System.Drawing.Point(793, 30);
            this.rndupButton.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("rndupButton.MouseDownImage")));
            this.rndupButton.MouseDownImageLeftCapWidth = 30;
            this.rndupButton.MouseDownImageTopCapHeight = 6;
            this.rndupButton.MouseOverImage = null;
            this.rndupButton.MouseOverImageLeftCapWidth = 30;
            this.rndupButton.MouseOverImageTopCapHeight = 6;
            this.rndupButton.Name = "rndupButton";
            this.rndupButton.NormalImage = ((System.Drawing.Image)(resources.GetObject("rndupButton.NormalImage")));
            this.rndupButton.NormalImageLeftCapWidth = 30;
            this.rndupButton.NormalImageTopCapHeight = 6;
            this.rndupButton.Picture = null;
            this.rndupButton.ShadowColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rndupButton.ShadowColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rndupButton.ShadowColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rndupButton.ShadowColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rndupButton.ShadowOffsetFocused = new System.Drawing.Point(0, 1);
            this.rndupButton.ShadowOffsetMouseDown = new System.Drawing.Point(0, 1);
            this.rndupButton.ShadowOffsetMouseOver = new System.Drawing.Point(0, 1);
            this.rndupButton.ShadowOffsetNormal = new System.Drawing.Point(0, 1);
            this.rndupButton.Size = new System.Drawing.Size(115, 23);
            this.rndupButton.TabIndex = 18;
            this.rndupButton.Click += new System.EventHandler(this.rndupButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.arrowed = false;
            this.sellButton.Caption = "Nahrung\nverkaufen";
            this.sellButton.FocusedImage = null;
            this.sellButton.FocusedImageLeftCapWidth = 6;
            this.sellButton.FocusedImageTopCapHeight = 6;
            this.sellButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellButton.ForeColor = System.Drawing.Color.White;
            this.sellButton.ForeColorFocused = System.Drawing.Color.White;
            this.sellButton.ForeColorMouseDown = System.Drawing.Color.White;
            this.sellButton.ForeColorMouseOver = System.Drawing.Color.White;
            this.sellButton.Location = new System.Drawing.Point(645, 4);
            this.sellButton.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("sellButton.MouseDownImage")));
            this.sellButton.MouseDownImageLeftCapWidth = 6;
            this.sellButton.MouseDownImageTopCapHeight = 6;
            this.sellButton.MouseOverImage = null;
            this.sellButton.MouseOverImageLeftCapWidth = 6;
            this.sellButton.MouseOverImageTopCapHeight = 6;
            this.sellButton.Name = "sellButton";
            this.sellButton.NormalImage = ((System.Drawing.Image)(resources.GetObject("sellButton.NormalImage")));
            this.sellButton.NormalImageLeftCapWidth = 6;
            this.sellButton.NormalImageTopCapHeight = 6;
            this.sellButton.Picture = null;
            this.sellButton.ShadowColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sellButton.ShadowColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sellButton.ShadowColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sellButton.ShadowColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sellButton.ShadowOffsetFocused = new System.Drawing.Point(0, 1);
            this.sellButton.ShadowOffsetMouseDown = new System.Drawing.Point(0, 1);
            this.sellButton.ShadowOffsetMouseOver = new System.Drawing.Point(0, 1);
            this.sellButton.ShadowOffsetNormal = new System.Drawing.Point(0, 1);
            this.sellButton.Size = new System.Drawing.Size(68, 49);
            this.sellButton.TabIndex = 22;
            this.sellButton.Text = "Nahrung\nverkaufen";
            this.sellButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // BuluUpdater
            // 
            this.BuluUpdater.applicationLocation = "";
            this.BuluUpdater.authenticationMode = updateSystemDotNet.authenticationModes.Credentials;
            this.BuluUpdater.authenticationPassword = "bulu";
            this.BuluUpdater.authenticationUsername = "jtc";
            this.BuluUpdater.projectId = "a983e832-6875-4256-891a-9e4a982d2aff";
            this.BuluUpdater.proxyPassword = null;
            this.BuluUpdater.proxyUrl = null;
            this.BuluUpdater.proxyUsername = null;
            this.BuluUpdater.publicKey = resources.GetString("BuluUpdater.publicKey");
            this.BuluUpdater.releaseFilter.checkForAlpha = true;
            this.BuluUpdater.releaseFilter.checkForBeta = true;
            this.BuluUpdater.releaseFilter.checkForFinal = true;
            this.BuluUpdater.releaseInfo.Version = "";
            this.BuluUpdater.requestElevation = true;
            this.BuluUpdater.restartApplication = true;
            this.BuluUpdater.retrieveHostVersion = true;
            this.BuluUpdater.updateUrl = "http://bulu.program-art.com/updater";
            this.BuluUpdater.updateFound += new updateSystemDotNet.updateFoundEventHandler(this.BuluUpdater_updateFound_1);
            this.BuluUpdater.updateInstallerStarted += new updateSystemDotNet.updateInstallerStartedEventHandler(this.BuluUpdater_updateInstallerStarted_1);
            // 
            // f15
            // 
            this.f15.HideInformationString = false;
            this.f15.Image = ((System.Drawing.Image)(resources.GetObject("f15.Image")));
            this.f15.Location = new System.Drawing.Point(736, 370);
            this.f15.MomentanePersonen = 0;
            this.f15.MomentanesBauelement = null;
            this.f15.Name = "f15";
            this.f15.parentOpened = false;
            this.f15.Size = new System.Drawing.Size(175, 175);
            this.f15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.f15.TabIndex = 14;
            this.f15.TabStop = false;
            // 
            // f14
            // 
            this.f14.HideInformationString = false;
            this.f14.Image = ((System.Drawing.Image)(resources.GetObject("f14.Image")));
            this.f14.Location = new System.Drawing.Point(555, 370);
            this.f14.MomentanePersonen = 0;
            this.f14.MomentanesBauelement = null;
            this.f14.Name = "f14";
            this.f14.parentOpened = false;
            this.f14.Size = new System.Drawing.Size(175, 175);
            this.f14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.f14.TabIndex = 13;
            this.f14.TabStop = false;
            // 
            // f13
            // 
            this.f13.HideInformationString = false;
            this.f13.Image = ((System.Drawing.Image)(resources.GetObject("f13.Image")));
            this.f13.Location = new System.Drawing.Point(374, 370);
            this.f13.MomentanePersonen = 0;
            this.f13.MomentanesBauelement = null;
            this.f13.Name = "f13";
            this.f13.parentOpened = false;
            this.f13.Size = new System.Drawing.Size(175, 175);
            this.f13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.f13.TabIndex = 12;
            this.f13.TabStop = false;
            // 
            // f12
            // 
            this.f12.HideInformationString = false;
            this.f12.Image = ((System.Drawing.Image)(resources.GetObject("f12.Image")));
            this.f12.Location = new System.Drawing.Point(193, 370);
            this.f12.MomentanePersonen = 0;
            this.f12.MomentanesBauelement = null;
            this.f12.Name = "f12";
            this.f12.parentOpened = false;
            this.f12.Size = new System.Drawing.Size(175, 175);
            this.f12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.f12.TabIndex = 11;
            this.f12.TabStop = false;
            // 
            // f11
            // 
            this.f11.HideInformationString = false;
            this.f11.Image = ((System.Drawing.Image)(resources.GetObject("f11.Image")));
            this.f11.Location = new System.Drawing.Point(12, 370);
            this.f11.MomentanePersonen = 0;
            this.f11.MomentanesBauelement = null;
            this.f11.Name = "f11";
            this.f11.parentOpened = false;
            this.f11.Size = new System.Drawing.Size(175, 175);
            this.f11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.f11.TabIndex = 10;
            this.f11.TabStop = false;
            // 
            // f10
            // 
            this.f10.HideInformationString = false;
            this.f10.Image = ((System.Drawing.Image)(resources.GetObject("f10.Image")));
            this.f10.Location = new System.Drawing.Point(736, 189);
            this.f10.MomentanePersonen = 0;
            this.f10.MomentanesBauelement = null;
            this.f10.Name = "f10";
            this.f10.parentOpened = false;
            this.f10.Size = new System.Drawing.Size(175, 175);
            this.f10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.f10.TabIndex = 9;
            this.f10.TabStop = false;
            // 
            // f9
            // 
            this.f9.HideInformationString = false;
            this.f9.Image = ((System.Drawing.Image)(resources.GetObject("f9.Image")));
            this.f9.Location = new System.Drawing.Point(555, 189);
            this.f9.MomentanePersonen = 0;
            this.f9.MomentanesBauelement = null;
            this.f9.Name = "f9";
            this.f9.parentOpened = false;
            this.f9.Size = new System.Drawing.Size(175, 175);
            this.f9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.f9.TabIndex = 8;
            this.f9.TabStop = false;
            // 
            // f8
            // 
            this.f8.HideInformationString = false;
            this.f8.Image = ((System.Drawing.Image)(resources.GetObject("f8.Image")));
            this.f8.Location = new System.Drawing.Point(374, 189);
            this.f8.MomentanePersonen = 0;
            this.f8.MomentanesBauelement = null;
            this.f8.Name = "f8";
            this.f8.parentOpened = false;
            this.f8.Size = new System.Drawing.Size(175, 175);
            this.f8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.f8.TabIndex = 7;
            this.f8.TabStop = false;
            // 
            // f7
            // 
            this.f7.HideInformationString = false;
            this.f7.Image = ((System.Drawing.Image)(resources.GetObject("f7.Image")));
            this.f7.Location = new System.Drawing.Point(193, 189);
            this.f7.MomentanePersonen = 0;
            this.f7.MomentanesBauelement = null;
            this.f7.Name = "f7";
            this.f7.parentOpened = false;
            this.f7.Size = new System.Drawing.Size(175, 175);
            this.f7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.f7.TabIndex = 6;
            this.f7.TabStop = false;
            // 
            // f6
            // 
            this.f6.HideInformationString = false;
            this.f6.Image = ((System.Drawing.Image)(resources.GetObject("f6.Image")));
            this.f6.Location = new System.Drawing.Point(12, 189);
            this.f6.MomentanePersonen = 0;
            this.f6.MomentanesBauelement = null;
            this.f6.Name = "f6";
            this.f6.parentOpened = false;
            this.f6.Size = new System.Drawing.Size(175, 175);
            this.f6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.f6.TabIndex = 5;
            this.f6.TabStop = false;
            // 
            // f5
            // 
            this.f5.HideInformationString = false;
            this.f5.Image = ((System.Drawing.Image)(resources.GetObject("f5.Image")));
            this.f5.Location = new System.Drawing.Point(736, 8);
            this.f5.MomentanePersonen = 0;
            this.f5.MomentanesBauelement = null;
            this.f5.Name = "f5";
            this.f5.parentOpened = false;
            this.f5.Size = new System.Drawing.Size(175, 175);
            this.f5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.f5.TabIndex = 4;
            this.f5.TabStop = false;
            // 
            // f4
            // 
            this.f4.HideInformationString = false;
            this.f4.Image = ((System.Drawing.Image)(resources.GetObject("f4.Image")));
            this.f4.Location = new System.Drawing.Point(555, 8);
            this.f4.MomentanePersonen = 0;
            this.f4.MomentanesBauelement = null;
            this.f4.Name = "f4";
            this.f4.parentOpened = false;
            this.f4.Size = new System.Drawing.Size(175, 175);
            this.f4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.f4.TabIndex = 3;
            this.f4.TabStop = false;
            // 
            // f3
            // 
            this.f3.HideInformationString = false;
            this.f3.Image = ((System.Drawing.Image)(resources.GetObject("f3.Image")));
            this.f3.Location = new System.Drawing.Point(374, 8);
            this.f3.MomentanePersonen = 0;
            this.f3.MomentanesBauelement = null;
            this.f3.Name = "f3";
            this.f3.parentOpened = false;
            this.f3.Size = new System.Drawing.Size(175, 175);
            this.f3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.f3.TabIndex = 2;
            this.f3.TabStop = false;
            // 
            // f2
            // 
            this.f2.HideInformationString = false;
            this.f2.Image = ((System.Drawing.Image)(resources.GetObject("f2.Image")));
            this.f2.Location = new System.Drawing.Point(193, 8);
            this.f2.MomentanePersonen = 0;
            this.f2.MomentanesBauelement = null;
            this.f2.Name = "f2";
            this.f2.parentOpened = false;
            this.f2.Size = new System.Drawing.Size(175, 175);
            this.f2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.f2.TabIndex = 1;
            this.f2.TabStop = false;
            // 
            // f1
            // 
            this.f1.HideInformationString = false;
            this.f1.Image = ((System.Drawing.Image)(resources.GetObject("f1.Image")));
            this.f1.Location = new System.Drawing.Point(12, 8);
            this.f1.MomentanePersonen = 0;
            this.f1.MomentanesBauelement = null;
            this.f1.Name = "f1";
            this.f1.parentOpened = false;
            this.f1.Size = new System.Drawing.Size(175, 175);
            this.f1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.f1.TabIndex = 0;
            this.f1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(920, 613);
            this.Controls.Add(this.toolBarPanel);
            this.Controls.Add(this.f15);
            this.Controls.Add(this.f14);
            this.Controls.Add(this.f13);
            this.Controls.Add(this.f12);
            this.Controls.Add(this.f11);
            this.Controls.Add(this.f10);
            this.Controls.Add(this.f9);
            this.Controls.Add(this.f8);
            this.Controls.Add(this.f7);
            this.Controls.Add(this.f6);
            this.Controls.Add(this.f5);
            this.Controls.Add(this.f4);
            this.Controls.Add(this.f3);
            this.Controls.Add(this.f2);
            this.Controls.Add(this.f1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolBarPanel.ResumeLayout(false);
            this.mainHUD.ResumeLayout(false);
            this.mainHUDContent.ResumeLayout(false);
            this.hudPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.f15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Feld f1;
        private Feld f2;
        private Feld f3;
        private Feld f4;
        private Feld f5;
        private Feld f10;
        private Feld f9;
        private Feld f8;
        private Feld f7;
        private Feld f6;
        private Feld f15;
        private Feld f14;
        private Feld f13;
        private Feld f12;
        private Feld f11;
        private Bulu.Grafik.ShadowLabel geldsumme;
        private BuluButton lvlupButton;
        private BuluButton rndupButton;
        private BuluButton sellButton;
        private System.Windows.Forms.Panel toolBarPanel;
        private BuluButton infoButton;
        private BuluButton beduerfnisButton;
        private BuluButton saveAndLoadButton;
        private BuluButton updateButton;
        private updateSystemDotNet.updateController BuluUpdater;
        private BuluButton buluButton1;
        private HUDPanel hudPanel1;
        private HUDPanel mainHUD;
        private System.Windows.Forms.Panel mainHUDContent;
        private Bulu.Grafik.ShadowLabel bildungspunkteLabel;
        private Bulu.Grafik.ShadowLabel nahrungspunkteLabel;
        private Bulu.Grafik.ShadowLabel label1;
        private Bulu.Grafik.ShadowLabel label2;
        private Bulu.Grafik.ShadowLabel label5;
        private Bulu.Grafik.ShadowLabel gestpsLabel;
        private Bulu.Grafik.ShadowLabel label3;
        private Bulu.Grafik.ShadowLabel personenLabel;
    }
}

