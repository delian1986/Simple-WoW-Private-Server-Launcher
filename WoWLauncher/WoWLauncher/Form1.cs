using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace WoWLauncher
{
    public partial class Form1 : Form
    {
        string realmList = "set realmlist logon.warmane.com";
        string res = "enUS";

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Insert(0,"enUS");
            comboBox1.Items.Add("enGB");
            comboBox1.Items.Add("deDE");
            comboBox1.Items.Add("esES");
            comboBox1.Items.Add("frFR");
            comboBox1.Items.Add("ruRU");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void Warmane_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                realmList = "set realmlist logon.warmane.com";

            }
        }

        private void GamerDistrict_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {

                realmList = "set realmlist wow.gamer-district.org";
            }
        }



        private void StartButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText($@"Data\{res}\realmlist.wtf", realmList);

            Process startGame = new Process();
            startGame.StartInfo.FileName = "C:\\World of Warcraft Wrath of the Lich King 3.3.5 enUS\\Wow.exe";
            startGame.Start();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            res = comboBox1.Text.ToString();
        }
    }
}
