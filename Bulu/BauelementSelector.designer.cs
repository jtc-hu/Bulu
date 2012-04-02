namespace Bulu
{
    partial class BauelementSelector
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
            this.bauemelentThumbnails = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.needs = new System.Windows.Forms.Label();
            this.descr = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewAero1 = new Bulu.ListViewAero();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bauemelentThumbnails
            // 
            this.bauemelentThumbnails.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.bauemelentThumbnails.ImageSize = new System.Drawing.Size(32, 32);
            this.bauemelentThumbnails.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.needs);
            this.panel1.Controls.Add(this.descr);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 54);
            this.panel1.TabIndex = 0;
            // 
            // needs
            // 
            this.needs.AutoEllipsis = true;
            this.needs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.needs.Location = new System.Drawing.Point(3, 35);
            this.needs.Name = "needs";
            this.needs.Size = new System.Drawing.Size(286, 20);
            this.needs.TabIndex = 3;
            // 
            // descr
            // 
            this.descr.AutoEllipsis = true;
            this.descr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descr.Location = new System.Drawing.Point(3, 3);
            this.descr.Name = "descr";
            this.descr.Size = new System.Drawing.Size(286, 31);
            this.descr.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 1);
            this.panel2.TabIndex = 0;
            // 
            // listViewAero1
            // 
            this.listViewAero1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewAero1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewAero1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAero1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewAero1.FullRowSelect = true;
            this.listViewAero1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewAero1.Location = new System.Drawing.Point(0, 0);
            this.listViewAero1.MultiSelect = false;
            this.listViewAero1.Name = "listViewAero1";
            this.listViewAero1.Size = new System.Drawing.Size(292, 250);
            this.listViewAero1.SmallImageList = this.bauemelentThumbnails;
            this.listViewAero1.TabIndex = 0;
            this.listViewAero1.UseCompatibleStateImageBehavior = false;
            this.listViewAero1.View = System.Windows.Forms.View.Details;
            this.listViewAero1.SelectedIndexChanged += new System.EventHandler(this.listViewAero1_SelectedIndexChanged);
            this.listViewAero1.DoubleClick += new System.EventHandler(this.listViewAero1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Feld";
            this.columnHeader1.Width = 215;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kosten";
            this.columnHeader2.Width = 77;
            // 
            // BauelementSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 304);
            this.ControlBox = false;
            this.Controls.Add(this.listViewAero1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(308, 320);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(308, 320);
            this.Name = "BauelementSelector";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Deactivate += new System.EventHandler(this.BauelementSelector_Deactivate);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListViewAero listViewAero1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ImageList bauemelentThumbnails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label needs;
        private System.Windows.Forms.Label descr;
        private System.Windows.Forms.Panel panel2;
    }
}