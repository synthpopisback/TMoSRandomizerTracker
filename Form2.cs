using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMoSRandomizerTracker
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string tmos_r_t_version = System.Windows.Forms.Application.ProductVersion;
            version_label.Text = String.Format("Version: {0}", tmos_r_t_version);
        }

        private void website_link_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.github.com/synthpopisback/TMoSRandomizerTracker/releases");
        }

        private void tracker_link_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitch.tv/synthpopisback");
        }

        private void maps_link_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitch.tv/rbarbaloot");
        }

        private void rando_link_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitch.tv/ct187");
        }
    }
}
