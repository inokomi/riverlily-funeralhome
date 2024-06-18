namespace FuneralHome
{
    partial class Form1
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
            this.decedentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decedentMasterlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDecedentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decedentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // decedentToolStripMenuItem
            // 
            this.decedentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decedentMasterlistToolStripMenuItem,
            this.addDecedentToolStripMenuItem});
            this.decedentToolStripMenuItem.Name = "decedentToolStripMenuItem";
            this.decedentToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.decedentToolStripMenuItem.Text = "Decedent";
            // 
            // decedentMasterlistToolStripMenuItem
            // 
            this.decedentMasterlistToolStripMenuItem.Name = "decedentMasterlistToolStripMenuItem";
            this.decedentMasterlistToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.decedentMasterlistToolStripMenuItem.Text = "Decedent Masterlist";
            this.decedentMasterlistToolStripMenuItem.Click += new System.EventHandler(this.decedentMasterlistToolStripMenuItem_Click);
            // 
            // addDecedentToolStripMenuItem
            // 
            this.addDecedentToolStripMenuItem.Name = "addDecedentToolStripMenuItem";
            this.addDecedentToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.addDecedentToolStripMenuItem.Text = "Add Decedent";
            this.addDecedentToolStripMenuItem.Click += new System.EventHandler(this.addDecedentToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FuneralHome.Properties.Resources.baxck1;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem decedentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decedentMasterlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDecedentToolStripMenuItem;
    }
}

