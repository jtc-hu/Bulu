namespace Bulu
{
    partial class NextRoundWarning
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
            this.descr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.warning = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descr
            // 
            this.descr.AutoEllipsis = true;
            this.descr.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descr.ForeColor = System.Drawing.Color.Maroon;
            this.descr.Location = new System.Drawing.Point(0, 0);
            this.descr.Name = "descr";
            this.descr.Size = new System.Drawing.Size(305, 20);
            this.descr.TabIndex = 4;
            this.descr.Text = "Achtung!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nicht alle Bedürfnisse der Personen sind gedeckt!";
            // 
            // warning
            // 
            this.warning.Location = new System.Drawing.Point(1, 38);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(298, 41);
            this.warning.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(51, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Nächste Runde";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NextRoundWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 112);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descr);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(316, 128);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(316, 128);
            this.Name = "NextRoundWarning";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Deactivate += new System.EventHandler(this.NextRoundWarning_Deactivate);
            this.Load += new System.EventHandler(this.NextRoundWarning_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.Button button1;
    }
}