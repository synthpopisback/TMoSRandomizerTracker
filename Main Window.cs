﻿using System;
using System.Windows.Forms;

namespace TMoSRandomizerTracker
{
    public partial class mainwindow : Form
    {
        public mainwindow()
        {
            InitializeComponent();
        }

        private void Tracker_Load(object sender, EventArgs e) // Set default values
        {
            string tmos_r_t_version = System.Windows.Forms.Application.ProductVersion;
            this.Text = String.Format("TMoS-R Tracker v{0}", tmos_r_t_version);
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
        }

        private void armor_box_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
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
            else
            {
                if (Properties.Settings.Default.armor_level == 0)
                {
                    Properties.Settings.Default.armor_level = 2;
                    armor_box.Image = Properties.Resources.armor_lightarmor;
                }
                else if (Properties.Settings.Default.armor_level == 1)
                {
                    Properties.Settings.Default.armor_level = 0;
                    armor_box.Image = Properties.Resources.armor_base;
                }
                else if (Properties.Settings.Default.armor_level == 2)
                {
                    Properties.Settings.Default.armor_level = 1;
                    armor_box.Image = Properties.Resources.armor_rarmor;
                }
            }
        }

        private void rod_box_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
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
            else
            {
                if (Properties.Settings.Default.rod_level == 1)
                {
                    Properties.Settings.Default.rod_level = 6;
                    rod_box.Image = Properties.Resources.rod_isfa;
                }
                else if (Properties.Settings.Default.rod_level == 2)
                {
                    Properties.Settings.Default.rod_level = 1;
                    rod_box.Image = Properties.Resources.rod_rod;
                }
                else if (Properties.Settings.Default.rod_level == 3)
                {
                    Properties.Settings.Default.rod_level = 2;
                    rod_box.Image = Properties.Resources.rod_flame;
                }
                else if (Properties.Settings.Default.rod_level == 4)
                {
                    Properties.Settings.Default.rod_level = 3;
                    rod_box.Image = Properties.Resources.rod_stardust;
                }
                else if (Properties.Settings.Default.rod_level == 5)
                {
                    Properties.Settings.Default.rod_level = 4;
                    rod_box.Image = Properties.Resources.rod_cimaron;
                }
                else if (Properties.Settings.Default.rod_level == 6)
                {
                    Properties.Settings.Default.rod_level = 5;
                    rod_box.Image = Properties.Resources.rod_crystal;
                }
            }
        }

        private void sword_box_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
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
            else
            {
                if (Properties.Settings.Default.sword_level == 1)
                {
                    Properties.Settings.Default.sword_level = 6;
                    sword_box.Image = Properties.Resources.sword_legend;
                }
                else if (Properties.Settings.Default.sword_level == 2)
                {
                    Properties.Settings.Default.sword_level = 1;
                    sword_box.Image = Properties.Resources.sword_sword;
                }
                else if (Properties.Settings.Default.sword_level == 3)
                {
                    Properties.Settings.Default.sword_level = 2;
                    sword_box.Image = Properties.Resources.sword_simitar;
                }
                else if (Properties.Settings.Default.sword_level == 4)
                {
                    Properties.Settings.Default.sword_level = 3;
                    sword_box.Image = Properties.Resources.sword_dragoon;
                }
                else if (Properties.Settings.Default.sword_level == 5)
                {
                    Properties.Settings.Default.sword_level = 4;
                    sword_box.Image = Properties.Resources.sword_kashim;
                }
                else if (Properties.Settings.Default.sword_level == 6)
                {
                    Properties.Settings.Default.sword_level = 5;
                    sword_box.Image = Properties.Resources.sword_rostam;
                }
            }
        }

        private void reset_button_MouseClick(object sender, MouseEventArgs e)
        {
            hassan_box.Image = Properties.Resources.char_hassan_bw;
            rainy_box.Image = Properties.Resources.char_rainy_bw;
            gubibi_box.Image = Properties.Resources.char_gubibi_bw;
            mustafa_box.Image = Properties.Resources.char_mustafa_bw;
            pukin_box.Image = Properties.Resources.char_pukin_bw;
            epin_box.Image = Properties.Resources.char_epin_bw;
            supica_box.Image = Properties.Resources.char_supica_bw;
            gunmeca_box.Image = Properties.Resources.char_gunmeca_bw;
            kebabu_box.Image = Properties.Resources.char_kebabu_bw;
            faruk_box.Image = Properties.Resources.char_faruk_bw;
            Properties.Settings.Default.got_faruk = false;
            Properties.Settings.Default.got_kebabu = false;
            Properties.Settings.Default.got_gunmeca = false;
            Properties.Settings.Default.got_supica = false;
            Properties.Settings.Default.got_epin = false;
            Properties.Settings.Default.got_pukin = false;
            Properties.Settings.Default.got_mustafa = false;
            Properties.Settings.Default.got_gubibi = false;
            Properties.Settings.Default.got_rainy = false;
            Properties.Settings.Default.got_hassan = false;

            Properties.Settings.Default.armor_level = 0;
            armor_box.Image = Properties.Resources.armor_base;

            Properties.Settings.Default.rod_level = 1;
            rod_box.Image = Properties.Resources.rod_rod;

            Properties.Settings.Default.sword_level = 1;
            sword_box.Image = Properties.Resources.sword_sword;

            ch1_marker1.Image = Properties.Resources.icon_unchecked;
            ch1_marker2.Text = "0";
            ch1_marker2.Image = Properties.Resources.icon_unchecked;
            ch1_marker3.Text = "0";
            ch1_marker3.Image = Properties.Resources.icon_unchecked;
            ch1_marker4.Text = "0";
            ch1_marker4.Image = Properties.Resources.icon_unchecked;
            ch1_marker5.Text = "0";
            ch1_marker5.Image = Properties.Resources.icon_unchecked;
            ch1_marker6.Text = "0";
            ch1_marker6.Image = Properties.Resources.icon_unchecked;
            ch1_marker7.Text = "0";
            ch1_marker7.Image = Properties.Resources.icon_unchecked;
            ch1_marker8.Text = "0";
            ch1_marker8.Image = Properties.Resources.icon_unchecked;
            ch1_marker9.Text = "0";
            ch1_marker9.Image = Properties.Resources.icon_unchecked;
            ch1_marker10.Text = "0";
            ch1_marker10.Image = Properties.Resources.icon_unchecked;
            ch1_marker11.Text = "0";
            ch1_marker11.Image = Properties.Resources.icon_unchecked;
            ch1_marker12.Text = "0";
            ch1_marker12.Image = Properties.Resources.icon_unchecked;
            ch1_marker13.Text = "0";
            ch1_marker13.Image = Properties.Resources.icon_unchecked;
            ch1_marker14.Text = "0";
            ch1_marker14.Image = Properties.Resources.icon_unchecked;
            ch1_marker15.Text = "0";
            ch1_marker15.Image = Properties.Resources.icon_unchecked;
            ch1_marker16.Text = "0";
            ch1_marker16.Image = Properties.Resources.icon_unchecked;
            ch1_marker17.Text = "0";
            ch1_marker17.Image = Properties.Resources.icon_unchecked;
            ch1_marker18.Text = "0";
            ch1_marker18.Image = Properties.Resources.icon_unchecked;
            ch1_marker19.Text = "0";
            ch1_marker19.Image = Properties.Resources.icon_unchecked;
            ch1_marker20.Text = "0";
            ch1_marker20.Image = Properties.Resources.icon_unchecked;
            ch1_marker21.Text = "0";
            ch1_marker21.Image = Properties.Resources.icon_unchecked;
            ch1_marker22.Text = "0";
            ch1_marker22.Image = Properties.Resources.icon_unchecked;
            ch1_marker23.Text = "0";
            ch1_marker23.Image = Properties.Resources.icon_unchecked;
            ch1_marker24.Text = "0";
            ch1_marker24.Image = Properties.Resources.icon_unchecked;
            ch1_marker25.Text = "0";
            ch1_marker25.Image = Properties.Resources.icon_unchecked;

            ch2_marker1.Text = "0";
            ch2_marker1.Image = Properties.Resources.icon_unchecked;
            ch2_marker2.Text = "0";
            ch2_marker2.Image = Properties.Resources.icon_unchecked;
            ch2_marker3.Text = "0";
            ch2_marker3.Image = Properties.Resources.icon_unchecked;
            ch2_marker4.Text = "0";
            ch2_marker4.Image = Properties.Resources.icon_unchecked;
            ch2_marker5.Text = "0";
            ch2_marker5.Image = Properties.Resources.icon_unchecked;
            ch2_marker6.Text = "0";
            ch2_marker6.Image = Properties.Resources.icon_unchecked;
            ch2_marker7.Text = "0";
            ch2_marker7.Image = Properties.Resources.icon_unchecked;
            ch2_marker8.Text = "0";
            ch2_marker8.Image = Properties.Resources.icon_unchecked;
            ch2_marker9.Text = "0";
            ch2_marker9.Image = Properties.Resources.icon_unchecked;
            ch2_marker10.Text = "0";
            ch2_marker10.Image = Properties.Resources.icon_unchecked;
            ch2_marker11.Text = "0";
            ch2_marker11.Image = Properties.Resources.icon_unchecked;
            ch2_marker12.Text = "0";
            ch2_marker12.Image = Properties.Resources.icon_unchecked;
            ch2_marker13.Text = "0";
            ch2_marker13.Image = Properties.Resources.icon_unchecked;
            ch2_marker14.Text = "0";
            ch2_marker14.Image = Properties.Resources.icon_unchecked;
            ch2_marker15.Text = "0";
            ch2_marker15.Image = Properties.Resources.icon_unchecked;
            ch2_marker16.Text = "0";
            ch2_marker16.Image = Properties.Resources.icon_unchecked;
            ch2_marker17.Text = "0";
            ch2_marker17.Image = Properties.Resources.icon_unchecked;
            ch2_marker18.Text = "0";
            ch2_marker18.Image = Properties.Resources.icon_unchecked;
            ch2_marker19.Text = "0";
            ch2_marker19.Image = Properties.Resources.icon_unchecked;
            ch2_marker20.Text = "0";
            ch2_marker20.Image = Properties.Resources.icon_unchecked;
            ch2_marker21.Text = "0";
            ch2_marker21.Image = Properties.Resources.icon_unchecked;
            ch2_marker22.Text = "0";
            ch2_marker22.Image = Properties.Resources.icon_unchecked;
            ch2_marker23.Text = "0";
            ch2_marker23.Image = Properties.Resources.icon_unchecked;

            ch3_marker1.Text = "0";
            ch3_marker1.Image = Properties.Resources.icon_unchecked;
            ch3_marker2.Text = "0";
            ch3_marker2.Image = Properties.Resources.icon_unchecked;
            ch3_marker3.Text = "0";
            ch3_marker3.Image = Properties.Resources.icon_unchecked;
            ch3_marker5.Text = "0";
            ch3_marker5.Image = Properties.Resources.icon_unchecked;
            ch3_marker6.Text = "0";
            ch3_marker6.Image = Properties.Resources.icon_unchecked;
            ch3_marker7.Text = "0";
            ch3_marker7.Image = Properties.Resources.icon_unchecked;
            ch3_marker8.Text = "0";
            ch3_marker8.Image = Properties.Resources.icon_unchecked;
            ch3_marker9.Text = "0";
            ch3_marker9.Image = Properties.Resources.icon_unchecked;
            ch3_marker10.Text = "0";
            ch3_marker10.Image = Properties.Resources.icon_unchecked;
            ch3_marker11.Text = "0";
            ch3_marker11.Image = Properties.Resources.icon_unchecked;
            ch3_marker12.Text = "0";
            ch3_marker12.Image = Properties.Resources.icon_unchecked;
            ch3_marker13.Text = "0";
            ch3_marker13.Image = Properties.Resources.icon_unchecked;
            ch3_marker14.Text = "0";
            ch3_marker14.Image = Properties.Resources.icon_unchecked;
            ch3_marker15.Text = "0";
            ch3_marker15.Image = Properties.Resources.icon_unchecked;
            ch3_marker16.Text = "0";
            ch3_marker16.Image = Properties.Resources.icon_unchecked;
            ch3_marker17.Text = "0";
            ch3_marker17.Image = Properties.Resources.icon_unchecked;
            ch3_marker18.Text = "0";
            ch3_marker18.Image = Properties.Resources.icon_unchecked;
            ch3_marker19.Text = "0";
            ch3_marker19.Image = Properties.Resources.icon_unchecked;
            ch3_marker20.Text = "0";
            ch3_marker20.Image = Properties.Resources.icon_unchecked;
            ch3_marker21.Text = "0";
            ch3_marker21.Image = Properties.Resources.icon_unchecked;
            ch3_marker22.Text = "0";
            ch3_marker22.Image = Properties.Resources.icon_unchecked;
            ch3_marker23.Text = "0";
            ch3_marker23.Image = Properties.Resources.icon_unchecked;
            ch3_marker24.Text = "0";
            ch3_marker24.Image = Properties.Resources.icon_unchecked;
            ch3_marker25.Text = "0";
            ch3_marker25.Image = Properties.Resources.icon_unchecked;
            ch3_marker26.Text = "0";
            ch3_marker26.Image = Properties.Resources.icon_unchecked;
            ch3_marker27.Text = "0";
            ch3_marker27.Image = Properties.Resources.icon_unchecked;

            ch4_marker1.Text = "0";
            ch4_marker1.Image = Properties.Resources.icon_unchecked;
            ch4_marker2.Text = "0";
            ch4_marker2.Image = Properties.Resources.icon_unchecked;
            ch4_marker3.Text = "0";
            ch4_marker3.Image = Properties.Resources.icon_unchecked;
            ch4_marker4.Text = "0";
            ch4_marker4.Image = Properties.Resources.icon_unchecked;
            ch4_marker5.Text = "0";
            ch4_marker5.Image = Properties.Resources.icon_unchecked;
            ch4_marker6.Text = "0";
            ch4_marker6.Image = Properties.Resources.icon_unchecked;
            ch4_marker7.Text = "0";
            ch4_marker7.Image = Properties.Resources.icon_unchecked;
            ch4_marker8.Text = "0";
            ch4_marker8.Image = Properties.Resources.icon_unchecked;
            ch4_marker9.Text = "0";
            ch4_marker9.Image = Properties.Resources.icon_unchecked;
            ch4_marker10.Text = "0";
            ch4_marker10.Image = Properties.Resources.icon_unchecked;
            ch4_marker11.Text = "0";
            ch4_marker11.Image = Properties.Resources.icon_unchecked;
            ch4_marker12.Text = "0";
            ch4_marker12.Image = Properties.Resources.icon_unchecked;
            ch4_marker13.Text = "0";
            ch4_marker13.Image = Properties.Resources.icon_unchecked;
            ch4_marker14.Text = "0";
            ch4_marker14.Image = Properties.Resources.icon_unchecked;
            ch4_marker15.Text = "0";
            ch4_marker15.Image = Properties.Resources.icon_unchecked;
            ch4_marker16.Text = "0";
            ch4_marker16.Image = Properties.Resources.icon_unchecked;
            ch4_marker17.Text = "0";
            ch4_marker17.Image = Properties.Resources.icon_unchecked;
            ch4_marker18.Text = "0";
            ch4_marker18.Image = Properties.Resources.icon_unchecked;
            ch4_marker19.Text = "0";
            ch4_marker19.Image = Properties.Resources.icon_unchecked;
            ch4_marker20.Text = "0";
            ch4_marker20.Image = Properties.Resources.icon_unchecked;
            ch4_marker21.Text = "0";
            ch4_marker21.Image = Properties.Resources.icon_unchecked;

            ch5_marker1.Text = "0";
            ch5_marker1.Image = Properties.Resources.icon_unchecked;
            ch5_marker2.Text = "0";
            ch5_marker2.Image = Properties.Resources.icon_unchecked;
            ch5_marker3.Text = "0";
            ch5_marker3.Image = Properties.Resources.icon_unchecked;
            ch5_marker4.Text = "0";
            ch5_marker4.Image = Properties.Resources.icon_unchecked;
            ch5_marker5.Text = "0";
            ch5_marker5.Image = Properties.Resources.icon_unchecked;
            ch5_marker6.Text = "0";
            ch5_marker6.Image = Properties.Resources.icon_unchecked;
            ch5_marker7.Text = "0";
            ch5_marker7.Image = Properties.Resources.icon_unchecked;
            ch5_marker8.Text = "0";
            ch5_marker8.Image = Properties.Resources.icon_unchecked;
            ch5_marker9.Text = "0";
            ch5_marker9.Image = Properties.Resources.icon_unchecked;
            ch5_marker10.Text = "0";
            ch5_marker10.Image = Properties.Resources.icon_unchecked;
            ch5_marker11.Text = "0";
            ch5_marker11.Image = Properties.Resources.icon_unchecked;
            ch5_marker12.Text = "0";
            ch5_marker12.Image = Properties.Resources.icon_unchecked;
            ch5_marker13.Text = "0";
            ch5_marker13.Image = Properties.Resources.icon_unchecked;
            ch5_marker14.Text = "0";
            ch5_marker14.Image = Properties.Resources.icon_unchecked;
            ch5_marker15.Text = "0";
            ch5_marker15.Image = Properties.Resources.icon_unchecked;
            ch5_marker16.Text = "0";
            ch5_marker16.Image = Properties.Resources.icon_unchecked;
            ch5_marker17.Text = "0";
            ch5_marker17.Image = Properties.Resources.icon_unchecked;
            ch5_marker18.Text = "0";
            ch5_marker18.Image = Properties.Resources.icon_unchecked;

            map_tabs.SelectedTab = ch1tab;
        }

        private void about_button_Click(object sender, EventArgs e)
        {
            About about_dialog = new About();
            about_dialog.ShowDialog();
        }

        private void ch1_2_5_marker_MouseClick(object sender, MouseEventArgs e) // Suffices for CH2 and CH5 because their lists are the same.
        {
            PictureBox send_box = sender as PictureBox;

            if (e.Button == MouseButtons.Left)
            {
                if (send_box.Text == "0")
                {
                    send_box.Image = Properties.Resources.icon_checked;
                    send_box.Text = "1";
                }
                else if (send_box.Text == "1")
                {
                    send_box.Image = Properties.Resources.icon_coronya;
                    send_box.Text = "2";
                }
                else if (send_box.Text == "2")
                {
                    send_box.Image = Properties.Resources.icon_imam;
                    send_box.Text = "3";
                }
                else if (send_box.Text == "3")
                {
                    send_box.Image = Properties.Resources.icon_hotel;
                    send_box.Text = "4";
                }
                else if (send_box.Text == "4")
                {
                    send_box.Image = Properties.Resources.icon_shop;
                    send_box.Text = "5";
                }
                else if (send_box.Text == "5")
                {
                    send_box.Image = Properties.Resources.icon_unchecked;
                    send_box.Text = "0";
                }
            }
            else
            {
                if (send_box.Text == "0")
                {
                    send_box.Image = Properties.Resources.icon_shop;
                    send_box.Text = "5";
                }
                else if (send_box.Text == "1")
                {
                    send_box.Image = Properties.Resources.icon_unchecked;
                    send_box.Text = "0";
                }
                else if (send_box.Text == "2")
                {
                    send_box.Image = Properties.Resources.icon_checked;
                    send_box.Text = "1";
                }
                else if (send_box.Text == "3")
                {
                    send_box.Image = Properties.Resources.icon_coronya;
                    send_box.Text = "2";
                }
                else if (send_box.Text == "4")
                {
                    send_box.Image = Properties.Resources.icon_imam;
                    send_box.Text = "3";
                }
                else if (send_box.Text == "5")
                {
                    send_box.Image = Properties.Resources.icon_hotel;
                    send_box.Text = "4";
                }
            }
        }

        private void marker_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            PictureBox send_box = sender as PictureBox;
            send_box.Text = "0";
        }


        private void ch3_marker_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox send_box = sender as PictureBox;

            if (e.Button == MouseButtons.Left)
            {
                if (send_box.Text == "0")
                {
                    send_box.Image = Properties.Resources.icon_checked;
                    send_box.Text = "1";
                }
                else if (send_box.Text == "1")
                {
                    send_box.Image = Properties.Resources.icon_coronya;
                    send_box.Text = "2";
                }
                else if (send_box.Text == "2")
                {
                    send_box.Image = Properties.Resources.icon_imam;
                    send_box.Text = "3";
                }
                else if (send_box.Text == "3")
                {
                    send_box.Image = Properties.Resources.icon_hotel;
                    send_box.Text = "4";
                }
                else if (send_box.Text == "4")
                {
                    send_box.Image = Properties.Resources.icon_shop;
                    send_box.Text = "5";
                }
                else if (send_box.Text == "5")
                {
                    send_box.Image = Properties.Resources.icon_cimaron;
                    send_box.Text = "6";
                }
                else if (send_box.Text == "6")
                {
                    send_box.Image = Properties.Resources.icon_pukin;
                    send_box.Text = "7";
                }
                else if (send_box.Text == "7")
                {
                    send_box.Image = Properties.Resources.icon_mustafa;
                    send_box.Text = "8";
                }
                else if (send_box.Text == "8")
                {
                    send_box.Image = Properties.Resources.icon_unchecked;
                    send_box.Text = "0";
                }
            }
            else
            {
                if (send_box.Text == "2")
                {
                    send_box.Image = Properties.Resources.icon_checked;
                    send_box.Text = "1";
                }
                else if (send_box.Text == "3")
                {
                    send_box.Image = Properties.Resources.icon_coronya;
                    send_box.Text = "2";
                }
                else if (send_box.Text == "4")
                {
                    send_box.Image = Properties.Resources.icon_imam;
                    send_box.Text = "3";
                }
                else if (send_box.Text == "5")
                {
                    send_box.Image = Properties.Resources.icon_hotel;
                    send_box.Text = "4";
                }
                else if (send_box.Text == "6")
                {
                    send_box.Image = Properties.Resources.icon_shop;
                    send_box.Text = "5";
                }
                else if (send_box.Text == "7")
                {
                    send_box.Image = Properties.Resources.icon_cimaron;
                    send_box.Text = "6";
                }
                else if (send_box.Text == "8")
                {
                    send_box.Image = Properties.Resources.icon_pukin;
                    send_box.Text = "7";
                }
                else if (send_box.Text == "0")
                {
                    send_box.Image = Properties.Resources.icon_mustafa;
                    send_box.Text = "8";
                }
                else if (send_box.Text == "1")
                {
                    send_box.Image = Properties.Resources.icon_unchecked;
                    send_box.Text = "0";
                }
            }
        }

        private void ch4_marker_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox send_box = sender as PictureBox;

            if (e.Button == MouseButtons.Left)
            {
                if (send_box.Text == "0")
                {
                    send_box.Image = Properties.Resources.icon_checked;
                    send_box.Text = "1";
                }
                else if (send_box.Text == "1")
                {
                    send_box.Image = Properties.Resources.icon_coronya;
                    send_box.Text = "2";
                }
                else if (send_box.Text == "2")
                {
                    send_box.Image = Properties.Resources.icon_imam;
                    send_box.Text = "3";
                }
                else if (send_box.Text == "3")
                {
                    send_box.Image = Properties.Resources.icon_hotel;
                    send_box.Text = "4";
                }
                else if (send_box.Text == "4")
                {
                    send_box.Image = Properties.Resources.icon_shop;
                    send_box.Text = "5";
                }
                else if (send_box.Text == "5")
                {
                    send_box.Image = Properties.Resources.icon_rainy;
                    send_box.Text = "6";
                }
                else if (send_box.Text == "6")
                {
                    send_box.Image = Properties.Resources.icon_unchecked;
                    send_box.Text = "0";
                }
            }
            else
            {
                if (send_box.Text == "0")
                {
                    send_box.Image = Properties.Resources.icon_rainy;
                    send_box.Text = "6";
                }
                else if (send_box.Text == "1")
                {
                    send_box.Image = Properties.Resources.icon_unchecked;
                    send_box.Text = "0";
                }
                else if (send_box.Text == "2")
                {
                    send_box.Image = Properties.Resources.icon_checked;
                    send_box.Text = "1";
                }
                else if (send_box.Text == "3")
                {
                    send_box.Image = Properties.Resources.icon_coronya;
                    send_box.Text = "2";
                }
                else if (send_box.Text == "4")
                {
                    send_box.Image = Properties.Resources.icon_imam;
                    send_box.Text = "3";
                }
                else if (send_box.Text == "5")
                {
                    send_box.Image = Properties.Resources.icon_hotel;
                    send_box.Text = "4";
                }
                else if (send_box.Text == "6")
                {
                    send_box.Image = Properties.Resources.icon_shop;
                    send_box.Text = "5";
                }
            }
        }
    }
}
