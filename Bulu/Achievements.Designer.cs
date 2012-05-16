namespace Bulu
{
    partial class Achievements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Achievements));
            this.nKAchievements = new nKF.Controls.nKListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nKButton1 = new nKF.Controls.nKButton();
            this.achBottomBar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nKAchievements
            // 
            this.nKAchievements.BackColor = System.Drawing.Color.Orange;
            this.nKAchievements.CellBackgroundHover = ((System.Drawing.Image)(resources.GetObject("nKAchievements.CellBackgroundHover")));
            this.nKAchievements.CellBackgroundHoverLeftCapWidth = 5;
            this.nKAchievements.CellBackgroundHoverTopCapHeight = 5;
            this.nKAchievements.CellBackgroundNormal = ((System.Drawing.Image)(resources.GetObject("nKAchievements.CellBackgroundNormal")));
            this.nKAchievements.CellBackgroundNormalLeftCapWidth = 5;
            this.nKAchievements.CellBackgroundNormalTopCapHeight = 5;
            this.nKAchievements.CellBackgroundSelected = ((System.Drawing.Image)(resources.GetObject("nKAchievements.CellBackgroundSelected")));
            this.nKAchievements.CellBackgroundSelectedLeftCapWidth = 5;
            this.nKAchievements.CellBackgroundSelectedTopCapHeight = 5;
            this.nKAchievements.CellHeight = 50;
            this.nKAchievements.DetailForeColor = System.Drawing.Color.Gray;
            this.nKAchievements.DetailForeColorHover = System.Drawing.Color.Gray;
            this.nKAchievements.DetailForeColorSelected = System.Drawing.Color.Gray;
            this.nKAchievements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nKAchievements.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nKAchievements.ForeColor = System.Drawing.Color.Black;
            this.nKAchievements.ForeColorHover = System.Drawing.Color.Black;
            this.nKAchievements.ForeColorSelected = System.Drawing.Color.Black;
            this.nKAchievements.Location = new System.Drawing.Point(0, 0);
            this.nKAchievements.Name = "nKAchievements";
            this.nKAchievements.ScrollBarAnimation = false;
            this.nKAchievements.SelectedCell = null;
            this.nKAchievements.Size = new System.Drawing.Size(532, 454);
            this.nKAchievements.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.nKButton1);
            this.panel1.Controls.Add(this.achBottomBar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 454);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 35);
            this.panel1.TabIndex = 1;
            // 
            // nKButton1
            // 
            this.nKButton1.FocusedImage = null;
            this.nKButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nKButton1.ForeColor = System.Drawing.Color.White;
            this.nKButton1.ForeColorFocused = System.Drawing.Color.White;
            this.nKButton1.ForeColorMouseDown = System.Drawing.Color.White;
            this.nKButton1.ForeColorMouseOver = System.Drawing.Color.White;
            this.nKButton1.Location = new System.Drawing.Point(442, 6);
            this.nKButton1.MouseDownImage = global::Bulu.Properties.Resources.achwdwbuttondown;
            this.nKButton1.MouseDownImageLeftCapWidth = 5;
            this.nKButton1.MouseDownImageTopCapHeight = 5;
            this.nKButton1.MouseOverImage = null;
            this.nKButton1.Name = "nKButton1";
            this.nKButton1.NormalImage = global::Bulu.Properties.Resources.achwdwbutton;
            this.nKButton1.NormalImageLeftCapWidth = 5;
            this.nKButton1.NormalImageTopCapHeight = 5;
            this.nKButton1.ShadowColorFocused = System.Drawing.Color.Transparent;
            this.nKButton1.ShadowColorMouseDown = System.Drawing.Color.Transparent;
            this.nKButton1.ShadowColorMouseOver = System.Drawing.Color.Transparent;
            this.nKButton1.ShadowColorNormal = System.Drawing.Color.Transparent;
            this.nKButton1.ShadowOffsetFocused = new System.Drawing.Point(0, 0);
            this.nKButton1.ShadowOffsetMouseDown = new System.Drawing.Point(0, 0);
            this.nKButton1.ShadowOffsetMouseOver = new System.Drawing.Point(0, 0);
            this.nKButton1.ShadowOffsetNormal = new System.Drawing.Point(0, 0);
            this.nKButton1.Size = new System.Drawing.Size(84, 23);
            this.nKButton1.TabIndex = 2;
            this.nKButton1.Text = "Schließen";
            this.nKButton1.Click += new System.EventHandler(this.nKButton1_Click);
            // 
            // achBottomBar
            // 
            this.achBottomBar.AutoEllipsis = true;
            this.achBottomBar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.achBottomBar.ForeColor = System.Drawing.Color.White;
            this.achBottomBar.Location = new System.Drawing.Point(12, 9);
            this.achBottomBar.Name = "achBottomBar";
            this.achBottomBar.Size = new System.Drawing.Size(508, 15);
            this.achBottomBar.TabIndex = 1;
            this.achBottomBar.Text = "Erreicht: 0/0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 1);
            this.panel2.TabIndex = 0;
            // 
            // Achievements
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.nKAchievements);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Achievements";
            this.Size = new System.Drawing.Size(532, 489);
            this.Load += new System.EventHandler(this.Achievements_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private nKF.Controls.nKListBox nKAchievements;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label achBottomBar;
        private System.Windows.Forms.Panel panel2;
        private nKF.Controls.nKButton nKButton1;

    }
}