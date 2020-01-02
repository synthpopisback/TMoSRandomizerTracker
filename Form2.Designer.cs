namespace TMoSRandomizerTracker
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.title_label = new System.Windows.Forms.Label();
            this.version_label = new System.Windows.Forms.Label();
            this.tracker_label = new System.Windows.Forms.Label();
            this.copyright_label = new System.Windows.Forms.Label();
            this.maps_label = new System.Windows.Forms.Label();
            this.rando_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_label.Location = new System.Drawing.Point(0, 0);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(241, 13);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "The Magic of Scheherazade Randomizer Tracker";
            // 
            // version_label
            // 
            this.version_label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.version_label.Location = new System.Drawing.Point(0, 69);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(270, 13);
            this.version_label.TabIndex = 1;
            this.version_label.Text = "Version: ";
            this.version_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tracker_label
            // 
            this.tracker_label.AutoSize = true;
            this.tracker_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.tracker_label.Location = new System.Drawing.Point(0, 13);
            this.tracker_label.Name = "tracker_label";
            this.tracker_label.Size = new System.Drawing.Size(124, 13);
            this.tracker_label.TabIndex = 2;
            this.tracker_label.Text = "Tracker: synthpopisback";
            // 
            // copyright_label
            // 
            this.copyright_label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.copyright_label.Location = new System.Drawing.Point(0, 82);
            this.copyright_label.Name = "copyright_label";
            this.copyright_label.Size = new System.Drawing.Size(270, 13);
            this.copyright_label.TabIndex = 3;
            this.copyright_label.Text = "Copyright ©2020";
            this.copyright_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maps_label
            // 
            this.maps_label.AutoSize = true;
            this.maps_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.maps_label.Location = new System.Drawing.Point(0, 26);
            this.maps_label.Name = "maps_label";
            this.maps_label.Size = new System.Drawing.Size(84, 13);
            this.maps_label.TabIndex = 4;
            this.maps_label.Text = "Maps: aaron2u2";
            // 
            // rando_label
            // 
            this.rando_label.AutoSize = true;
            this.rando_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.rando_label.Location = new System.Drawing.Point(0, 39);
            this.rando_label.Name = "rando_label";
            this.rando_label.Size = new System.Drawing.Size(96, 13);
            this.rando_label.TabIndex = 5;
            this.rando_label.Text = "Randomizer: ct187";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 95);
            this.Controls.Add(this.rando_label);
            this.Controls.Add(this.version_label);
            this.Controls.Add(this.maps_label);
            this.Controls.Add(this.tracker_label);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.copyright_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label version_label;
        private System.Windows.Forms.Label tracker_label;
        private System.Windows.Forms.Label copyright_label;
        private System.Windows.Forms.Label maps_label;
        private System.Windows.Forms.Label rando_label;
    }
}