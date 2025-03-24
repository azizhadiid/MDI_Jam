namespace Jam.GUI
{
    partial class Jam_App
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolBarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_stopwatch = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_timer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1264, 48);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // toolBarMenu
            // 
            this.toolBarMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_stopwatch,
            this.submenu_timer});
            this.toolBarMenu.Name = "toolBarMenu";
            this.toolBarMenu.Size = new System.Drawing.Size(149, 40);
            this.toolBarMenu.Text = "&Pilih Menu";
            // 
            // submenu_stopwatch
            // 
            this.submenu_stopwatch.Name = "submenu_stopwatch";
            this.submenu_stopwatch.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.submenu_stopwatch.Size = new System.Drawing.Size(413, 44);
            this.submenu_stopwatch.Text = "&Stop Watch";
            this.submenu_stopwatch.Click += new System.EventHandler(this.submenu_stopwatch_Click);
            // 
            // submenu_timer
            // 
            this.submenu_timer.Name = "submenu_timer";
            this.submenu_timer.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.submenu_timer.Size = new System.Drawing.Size(413, 44);
            this.submenu_timer.Text = "&Timer";
            this.submenu_timer.Click += new System.EventHandler(this.submenu_timer_Click);
            // 
            // Jam_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jam.Properties.Resources.technology_background_analog_clock_time_vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 871);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Jam_App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jam";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.ToolStripMenuItem toolBarMenu;
        protected System.Windows.Forms.ToolStripMenuItem submenu_stopwatch;
        private System.Windows.Forms.ToolStripMenuItem submenu_timer;
    }
}



