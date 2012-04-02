namespace Bulu
{
    partial class LevelUpNewItems
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.fDescr = new System.Windows.Forms.Label();
            this.faehigkeitenLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(95, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Schließen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dir stehen jetzt neue Bau-Elemente zur Verfügung:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.contentPanel.Location = new System.Drawing.Point(0, 32);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(331, 230);
            this.contentPanel.TabIndex = 2;
            // 
            // fDescr
            // 
            this.fDescr.Dock = System.Windows.Forms.DockStyle.Top;
            this.fDescr.Location = new System.Drawing.Point(0, 262);
            this.fDescr.Name = "fDescr";
            this.fDescr.Size = new System.Drawing.Size(331, 21);
            this.fDescr.TabIndex = 3;
            this.fDescr.Text = "Außerdem kannst du eine neu erlernte Fähigkeit nutzen:";
            this.fDescr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // faehigkeitenLabel
            // 
            this.faehigkeitenLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.faehigkeitenLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faehigkeitenLabel.Location = new System.Drawing.Point(0, 283);
            this.faehigkeitenLabel.Name = "faehigkeitenLabel";
            this.faehigkeitenLabel.Size = new System.Drawing.Size(331, 40);
            this.faehigkeitenLabel.TabIndex = 4;
            this.faehigkeitenLabel.Text = "%Fähigkeit";
            this.faehigkeitenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LevelUpNewItems
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(331, 364);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.faehigkeitenLabel);
            this.Controls.Add(this.fDescr);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LevelUpNewItems";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label fDescr;
        private System.Windows.Forms.Label faehigkeitenLabel;
    }
}