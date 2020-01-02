using System;
using System.Windows.Forms;

namespace TMoSRandomizerTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Tracker_Load(object sender, EventArgs e) // Set default values
        {
            string tmos_r_t_version = System.Windows.Forms.Application.ProductVersion;
            this.Text = String.Format("TMoS-R Tracker v.{0}", tmos_r_t_version);
            //bool got_faruk = false;
            //bool got_kebabu = false;
            //bool got_gunmeca = false;
            //bool got_supica = false;
            //bool got_epin = false;
            //bool got_pukin= false;
            //bool got_mustafa = false;
            //bool got_gubibi = false;
            //bool got_rainy = false;
            //bool got_hassan = false;
            //int armor_level = 0;
            //int rod_level = 1;
            //int sword_level = 1;
        }

        private void faruk_box_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.got_faruk == true)
            {
                faruk_box.Image = Properties.Resources.char_faruk_bw;
            }
            else
            {
                faruk_box.Image = Properties.Resources.char_faruk;
            }
            Properties.Settings.Default.got_faruk = !Properties.Settings.Default.got_faruk;
            faruk_box.Refresh();
        }

        private void kebabu_box_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.got_kebabu == true)
            {
                kebabu_box.Image = Properties.Resources.char_kebabu_bw;
            }
            else
            {
                kebabu_box.Image = Properties.Resources.char_kebabu;
            }
            Properties.Settings.Default.got_kebabu = !Properties.Settings.Default.got_kebabu;
            kebabu_box.Refresh();
        }

        private void gunmeca_box_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.got_gunmeca == true)
            {
                gunmeca_box.Image = Properties.Resources.char_gunmeca_bw;
            }
            else
            {
                gunmeca_box.Image = Properties.Resources.char_gunmeca;
            }
            Properties.Settings.Default.got_gunmeca = !Properties.Settings.Default.got_gunmeca;
            gunmeca_box.Refresh();
        }

        private void supica_box_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.got_supica == true)
            {
                supica_box.Image = Properties.Resources.char_supica_bw;
            }
            else
            {
                supica_box.Image = Properties.Resources.char_supica;
            }
            Properties.Settings.Default.got_supica = !Properties.Settings.Default.got_supica;
            supica_box.Refresh();
        }

        private void epin_box_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.got_epin == true)
            {
                epin_box.Image = Properties.Resources.char_epin_bw;
            }
            else
            {
                epin_box.Image = Properties.Resources.char_epin;
            }
            Properties.Settings.Default.got_epin = !Properties.Settings.Default.got_epin;
            epin_box.Refresh();
        }

        private void pukin_box_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.got_pukin == true)
            {
                pukin_box.Image = Properties.Resources.char_pukin_bw;
            }
            else
            {
                pukin_box.Image = Properties.Resources.char_pukin;
            }
            Properties.Settings.Default.got_pukin = !Properties.Settings.Default.got_pukin;
            pukin_box.Refresh();
        }

        private void mustafa_box_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.got_mustafa == true)
            {
                mustafa_box.Image = Properties.Resources.char_mustafa_bw;
            }
            else
            {
                mustafa_box.Image = Properties.Resources.char_mustafa;
            }
            Properties.Settings.Default.got_mustafa = !Properties.Settings.Default.got_mustafa;
            mustafa_box.Refresh();
        }

        private void gubibi_box_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.got_gubibi == true)
            {
                gubibi_box.Image = Properties.Resources.char_gubibi_bw;
            }
            else
            {
                gubibi_box.Image = Properties.Resources.char_gubibi;
            }
            Properties.Settings.Default.got_gubibi = !Properties.Settings.Default.got_gubibi;
            gubibi_box.Refresh();
        }

        private void rainy_box_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.got_rainy == true)
            {
                rainy_box.Image = Properties.Resources.char_rainy_bw;
            }
            else
            {
                rainy_box.Image = Properties.Resources.char_rainy;
            }
            Properties.Settings.Default.got_rainy = !Properties.Settings.Default.got_rainy;
            rainy_box.Refresh();
        }

        private void hassan_box_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.got_hassan == true)
            {
                hassan_box.Image = Properties.Resources.char_hassan_bw;
            }
            else
            {
                hassan_box.Image = Properties.Resources.char_hassan;
            }
            Properties.Settings.Default.got_hassan = !Properties.Settings.Default.got_hassan;
            hassan_box.Refresh();
        }

        private void armor_box_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.armor_level == 0)
            {
                Properties.Settings.Default.armor_level++;
                armor_box.Image = Properties.Resources.armor_rarmor;
            }
            else if (Properties.Settings.Default.armor_level == 1)
            {
                Properties.Settings.Default.armor_level++;
                armor_box.Image = Properties.Resources.armor_lightarmor;
            }
            else if (Properties.Settings.Default.armor_level == 2)
            {
                Properties.Settings.Default.armor_level = 0;
                armor_box.Image = Properties.Resources.armor_base;
            }
        }

        private void rod_box_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.rod_level == 1)
            {
                Properties.Settings.Default.rod_level++;
                rod_box.Image = Properties.Resources.rod_flame;
            }
            else if (Properties.Settings.Default.rod_level == 2)
            {
                Properties.Settings.Default.rod_level++;
                rod_box.Image = Properties.Resources.rod_stardust;
            }
            else if (Properties.Settings.Default.rod_level == 3)
            {
                Properties.Settings.Default.rod_level++;
                rod_box.Image = Properties.Resources.rod_cimaron;
            }
            else if (Properties.Settings.Default.rod_level == 4)
            {
                Properties.Settings.Default.rod_level++;
                rod_box.Image = Properties.Resources.rod_crystal;
            }
            else if (Properties.Settings.Default.rod_level == 5)
            {
                Properties.Settings.Default.rod_level++;
                rod_box.Image = Properties.Resources.rod_isfa;
            }
            else if (Properties.Settings.Default.rod_level == 6)
            {
                Properties.Settings.Default.rod_level = 1;
                rod_box.Image = Properties.Resources.rod_rod;
            }
        }

        private void sword_box_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.sword_level == 1)
            {
                Properties.Settings.Default.sword_level++;
                sword_box.Image = Properties.Resources.sword_simitar;
            }
            else if (Properties.Settings.Default.sword_level == 2)
            {
                Properties.Settings.Default.sword_level++;
                sword_box.Image = Properties.Resources.sword_dragoon;
            }
            else if (Properties.Settings.Default.sword_level == 3)
            {
                Properties.Settings.Default.sword_level++;
                sword_box.Image = Properties.Resources.sword_kashim;
            }
            else if (Properties.Settings.Default.sword_level == 4)
            {
                Properties.Settings.Default.sword_level++;
                sword_box.Image = Properties.Resources.sword_rostam;
            }
            else if (Properties.Settings.Default.sword_level == 5)
            {
                Properties.Settings.Default.sword_level++;
                sword_box.Image = Properties.Resources.sword_legend;
            }
            else if (Properties.Settings.Default.sword_level == 6)
            {
                Properties.Settings.Default.sword_level = 1;
                sword_box.Image = Properties.Resources.sword_sword;
            }
        }
    }
}
