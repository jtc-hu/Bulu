namespace Bulu
{
    partial class BauelementEditor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.upgradeButton = new System.Windows.Forms.Button();
            this.benoetigtebp = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.npprorunde = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bpprorunde = new System.Windows.Forms.Label();
            this.bpdescr = new System.Windows.Forms.Label();
            this.personen = new System.Windows.Forms.Label();
            this.personendescr = new System.Windows.Forms.Label();
            this.descr = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.perspanel = new System.Windows.Forms.Panel();
            this.perschangertext = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.abrissPanel = new System.Windows.Forms.Panel();
            this.abrissButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.perspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.abrissPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.upgradeButton);
            this.panel1.Controls.Add(this.benoetigtebp);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.npprorunde);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.bpprorunde);
            this.panel1.Controls.Add(this.bpdescr);
            this.panel1.Controls.Add(this.personen);
            this.panel1.Controls.Add(this.personendescr);
            this.panel1.Controls.Add(this.descr);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 130);
            this.panel1.TabIndex = 1;
            // 
            // upgradeButton
            // 
            this.upgradeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.upgradeButton.Location = new System.Drawing.Point(12, 101);
            this.upgradeButton.Name = "upgradeButton";
            this.upgradeButton.Size = new System.Drawing.Size(283, 23);
            this.upgradeButton.TabIndex = 11;
            this.upgradeButton.Text = "Upgade auf % für % Dalasi";
            this.upgradeButton.UseVisualStyleBackColor = true;
            this.upgradeButton.Click += new System.EventHandler(this.upgradeButton_Click);
            this.upgradeButton.MouseEnter += new System.EventHandler(this.upgradeButton_MouseEnter);
            this.upgradeButton.MouseLeave += new System.EventHandler(this.upgradeButton_MouseLeave);
            // 
            // benoetigtebp
            // 
            this.benoetigtebp.AutoEllipsis = true;
            this.benoetigtebp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benoetigtebp.Location = new System.Drawing.Point(197, 80);
            this.benoetigtebp.Name = "benoetigtebp";
            this.benoetigtebp.Size = new System.Drawing.Size(104, 18);
            this.benoetigtebp.TabIndex = 10;
            this.benoetigtebp.Text = "0";
            this.benoetigtebp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Benötigte Bildungspunkte:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // npprorunde
            // 
            this.npprorunde.AutoEllipsis = true;
            this.npprorunde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npprorunde.Location = new System.Drawing.Point(197, 62);
            this.npprorunde.Name = "npprorunde";
            this.npprorunde.Size = new System.Drawing.Size(104, 18);
            this.npprorunde.TabIndex = 8;
            this.npprorunde.Text = "0";
            this.npprorunde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nahrungspunkte pro Runde:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bpprorunde
            // 
            this.bpprorunde.AutoEllipsis = true;
            this.bpprorunde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpprorunde.Location = new System.Drawing.Point(197, 44);
            this.bpprorunde.Name = "bpprorunde";
            this.bpprorunde.Size = new System.Drawing.Size(104, 18);
            this.bpprorunde.TabIndex = 6;
            this.bpprorunde.Text = "0";
            this.bpprorunde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bpdescr
            // 
            this.bpdescr.AutoEllipsis = true;
            this.bpdescr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpdescr.Location = new System.Drawing.Point(9, 44);
            this.bpdescr.Name = "bpdescr";
            this.bpdescr.Size = new System.Drawing.Size(182, 18);
            this.bpdescr.TabIndex = 5;
            this.bpdescr.Text = "Bildungspunkte pro Runde:";
            this.bpdescr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // personen
            // 
            this.personen.AutoEllipsis = true;
            this.personen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personen.Location = new System.Drawing.Point(197, 26);
            this.personen.Name = "personen";
            this.personen.Size = new System.Drawing.Size(104, 18);
            this.personen.TabIndex = 4;
            this.personen.Text = "0";
            this.personen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // personendescr
            // 
            this.personendescr.AutoEllipsis = true;
            this.personendescr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personendescr.Location = new System.Drawing.Point(9, 26);
            this.personendescr.Name = "personendescr";
            this.personendescr.Size = new System.Drawing.Size(182, 18);
            this.personendescr.TabIndex = 3;
            this.personendescr.Text = "--personen--";
            this.personendescr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // descr
            // 
            this.descr.AutoEllipsis = true;
            this.descr.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descr.ForeColor = System.Drawing.Color.Navy;
            this.descr.Location = new System.Drawing.Point(3, 3);
            this.descr.Name = "descr";
            this.descr.Size = new System.Drawing.Size(286, 20);
            this.descr.TabIndex = 2;
            this.descr.Text = "Informationen";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 1);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Personen:";
            // 
            // perspanel
            // 
            this.perspanel.Controls.Add(this.perschangertext);
            this.perspanel.Controls.Add(this.trackBar1);
            this.perspanel.Controls.Add(this.label1);
            this.perspanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.perspanel.Enabled = false;
            this.perspanel.Location = new System.Drawing.Point(0, 0);
            this.perspanel.Name = "perspanel";
            this.perspanel.Size = new System.Drawing.Size(307, 59);
            this.perspanel.TabIndex = 3;
            // 
            // perschangertext
            // 
            this.perschangertext.AutoSize = true;
            this.perschangertext.Location = new System.Drawing.Point(271, 22);
            this.perschangertext.Name = "perschangertext";
            this.perschangertext.Size = new System.Drawing.Size(24, 15);
            this.perschangertext.TabIndex = 4;
            this.perschangertext.Text = "0/5";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(66, 18);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(199, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 1);
            this.panel3.TabIndex = 4;
            // 
            // abrissPanel
            // 
            this.abrissPanel.Controls.Add(this.abrissButton);
            this.abrissPanel.Controls.Add(this.panel3);
            this.abrissPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.abrissPanel.Location = new System.Drawing.Point(0, 189);
            this.abrissPanel.Name = "abrissPanel";
            this.abrissPanel.Size = new System.Drawing.Size(307, 39);
            this.abrissPanel.TabIndex = 6;
            // 
            // abrissButton
            // 
            this.abrissButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.abrissButton.Location = new System.Drawing.Point(12, 8);
            this.abrissButton.Name = "abrissButton";
            this.abrissButton.Size = new System.Drawing.Size(283, 23);
            this.abrissButton.TabIndex = 12;
            this.abrissButton.Text = "Abreißen für % Dalasi";
            this.abrissButton.UseVisualStyleBackColor = true;
            this.abrissButton.Click += new System.EventHandler(this.abrissButton_Click);
            this.abrissButton.MouseEnter += new System.EventHandler(this.abrissButton_MouseEnter);
            this.abrissButton.MouseLeave += new System.EventHandler(this.abrissButton_MouseLeave);
            // 
            // BauelementEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(307, 227);
            this.ControlBox = false;
            this.Controls.Add(this.abrissPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.perspanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(323, 243);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(323, 205);
            this.Name = "BauelementEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Deactivate += new System.EventHandler(this.BauelementEditor_Deactivate);
            this.panel1.ResumeLayout(false);
            this.perspanel.ResumeLayout(false);
            this.perspanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.abrissPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label npprorunde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label bpprorunde;
        private System.Windows.Forms.Label bpdescr;
        private System.Windows.Forms.Label personen;
        private System.Windows.Forms.Label personendescr;
        private System.Windows.Forms.Label descr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label benoetigtebp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button upgradeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel perspanel;
        private System.Windows.Forms.Label perschangertext;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel abrissPanel;
        private System.Windows.Forms.Button abrissButton;
    }
}