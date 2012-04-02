namespace Bulu
{
    partial class AchievedWindow
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.nKButton1 = new nKF.Controls.nKButton();
            this.label1 = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nKButton1
            // 
            this.nKButton1.FocusedImage = null;
            this.nKButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nKButton1.ForeColor = System.Drawing.Color.White;
            this.nKButton1.ForeColorFocused = System.Drawing.Color.White;
            this.nKButton1.ForeColorMouseDown = System.Drawing.Color.White;
            this.nKButton1.ForeColorMouseOver = System.Drawing.Color.White;
            this.nKButton1.Location = new System.Drawing.Point(204, 5);
            this.nKButton1.MouseDownImage = global::Bulu.Properties.Resources.achwdwbuttondown;
            this.nKButton1.MouseDownImageLeftCapWidth = 5;
            this.nKButton1.MouseDownImageTopCapHeight = 5;
            this.nKButton1.MouseOverImage = null;
            this.nKButton1.Name = "nKButton1";
            this.nKButton1.NormalImage = global::Bulu.Properties.Resources.achwdwbutton;
            this.nKButton1.NormalImageLeftCapWidth = 5;
            this.nKButton1.NormalImageTopCapHeight = 5;
            this.nKButton1.Size = new System.Drawing.Size(70, 18);
            this.nKButton1.TabIndex = 0;
            this.nKButton1.Text = "Schließen";
            this.nKButton1.Click += new System.EventHandler(this.nKButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Errungenschaft erreicht!";
            // 
            // content
            // 
            this.content.ForeColor = System.Drawing.Color.White;
            this.content.Location = new System.Drawing.Point(6, 23);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(269, 33);
            this.content.TabIndex = 2;
            this.content.Text = "Achievement Name - This is a very long achievement description to test text behav" +
                "ior.";
            // 
            // AchievedWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Bulu.Properties.Resources.achwdw;
            this.Controls.Add(this.content);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nKButton1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AchievedWindow";
            this.Size = new System.Drawing.Size(278, 58);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private nKF.Controls.nKButton nKButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label content;
    }
}
