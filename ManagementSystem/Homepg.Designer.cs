
namespace ManagementSystem
{
    partial class Homepg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepg));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.associateDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.getReportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1178, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDetailsToolStripMenuItem,
            this.showDetailsToolStripMenuItem,
            this.updateDetailsToolStripMenuItem,
            this.deleteDetailsToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(128, 31);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // getReportsToolStripMenuItem
            // 
            this.getReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.associateDetailsToolStripMenuItem,
            this.batchDetailsToolStripMenuItem,
            this.trainerDetailsToolStripMenuItem});
            this.getReportsToolStripMenuItem.Name = "getReportsToolStripMenuItem";
            this.getReportsToolStripMenuItem.Size = new System.Drawing.Size(135, 31);
            this.getReportsToolStripMenuItem.Text = "Get Reports";
            // 
            // addDetailsToolStripMenuItem
            // 
            this.addDetailsToolStripMenuItem.Name = "addDetailsToolStripMenuItem";
            this.addDetailsToolStripMenuItem.Size = new System.Drawing.Size(274, 36);
            this.addDetailsToolStripMenuItem.Text = "Training Modules";
            this.addDetailsToolStripMenuItem.Click += new System.EventHandler(this.addDetailsToolStripMenuItem_Click);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(274, 36);
            this.showDetailsToolStripMenuItem.Text = "Trainers Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // updateDetailsToolStripMenuItem
            // 
            this.updateDetailsToolStripMenuItem.Name = "updateDetailsToolStripMenuItem";
            this.updateDetailsToolStripMenuItem.Size = new System.Drawing.Size(274, 36);
            this.updateDetailsToolStripMenuItem.Text = "Associate Details";
            this.updateDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateDetailsToolStripMenuItem_Click);
            // 
            // deleteDetailsToolStripMenuItem
            // 
            this.deleteDetailsToolStripMenuItem.Name = "deleteDetailsToolStripMenuItem";
            this.deleteDetailsToolStripMenuItem.Size = new System.Drawing.Size(274, 36);
            this.deleteDetailsToolStripMenuItem.Text = "Batch Details";
            this.deleteDetailsToolStripMenuItem.Click += new System.EventHandler(this.deleteDetailsToolStripMenuItem_Click);
            // 
            // associateDetailsToolStripMenuItem
            // 
            this.associateDetailsToolStripMenuItem.Name = "associateDetailsToolStripMenuItem";
            this.associateDetailsToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.associateDetailsToolStripMenuItem.Text = "Associate details";
            this.associateDetailsToolStripMenuItem.Click += new System.EventHandler(this.associateDetailsToolStripMenuItem_Click);
            // 
            // batchDetailsToolStripMenuItem
            // 
            this.batchDetailsToolStripMenuItem.Name = "batchDetailsToolStripMenuItem";
            this.batchDetailsToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.batchDetailsToolStripMenuItem.Text = "Batch Details";
            this.batchDetailsToolStripMenuItem.Click += new System.EventHandler(this.batchDetailsToolStripMenuItem_Click);
            // 
            // trainerDetailsToolStripMenuItem
            // 
            this.trainerDetailsToolStripMenuItem.Name = "trainerDetailsToolStripMenuItem";
            this.trainerDetailsToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.trainerDetailsToolStripMenuItem.Text = "Trainer Details";
            this.trainerDetailsToolStripMenuItem.Click += new System.EventHandler(this.trainerDetailsToolStripMenuItem_Click);
            // 
            // Homepg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1178, 843);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Lavender;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Homepg";
            this.Text = "Homepg";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem associateDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainerDetailsToolStripMenuItem;
    }
}