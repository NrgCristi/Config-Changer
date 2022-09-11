using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Config_Changer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConfigPath = "C://Users//User//AppData//Local//FortniteGame//Saved//Config//WindowsClient";
            System.Diagnostics.Process.Start(ConfigPath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome!");
            MessageBox.Show("Please Click the change fortnite config button to change your fortnite config");
            MessageBox.Show("I reccomend using this tool only if you know what are you doing, if you don't know how to use it then don't use it al all");
            MessageBox.Show("enjoy using this tool :)");
        }
    }
}
