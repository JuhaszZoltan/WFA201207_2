namespace WFA201207_2
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.utasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idegenvezetőToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szállásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szerkesztésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keresésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utasToolStripMenuItem,
            this.idegenvezetőToolStripMenuItem,
            this.szállásToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 92);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // utasToolStripMenuItem
            // 
            this.utasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szerkesztésToolStripMenuItem,
            this.keresésToolStripMenuItem});
            this.utasToolStripMenuItem.Image = global::WFA201207_2.Properties.Resources.utas1;
            this.utasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.utasToolStripMenuItem.Name = "utasToolStripMenuItem";
            this.utasToolStripMenuItem.Size = new System.Drawing.Size(78, 88);
            this.utasToolStripMenuItem.Text = "Utas";
            this.utasToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // idegenvezetőToolStripMenuItem
            // 
            this.idegenvezetőToolStripMenuItem.Image = global::WFA201207_2.Properties.Resources.idegenvezeto;
            this.idegenvezetőToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.idegenvezetőToolStripMenuItem.Name = "idegenvezetőToolStripMenuItem";
            this.idegenvezetőToolStripMenuItem.Size = new System.Drawing.Size(113, 88);
            this.idegenvezetőToolStripMenuItem.Text = "Idegenvezető";
            this.idegenvezetőToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // szállásToolStripMenuItem
            // 
            this.szállásToolStripMenuItem.Image = global::WFA201207_2.Properties.Resources.szallas;
            this.szállásToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.szállásToolStripMenuItem.Name = "szállásToolStripMenuItem";
            this.szállásToolStripMenuItem.Size = new System.Drawing.Size(78, 88);
            this.szállásToolStripMenuItem.Text = "Szállás";
            this.szállásToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // szerkesztésToolStripMenuItem
            // 
            this.szerkesztésToolStripMenuItem.Name = "szerkesztésToolStripMenuItem";
            this.szerkesztésToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.szerkesztésToolStripMenuItem.Text = "Szerkesztés";
            // 
            // keresésToolStripMenuItem
            // 
            this.keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            this.keresésToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.keresésToolStripMenuItem.Text = "Keresés";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem utasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idegenvezetőToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szállásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szerkesztésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keresésToolStripMenuItem;
    }
}

