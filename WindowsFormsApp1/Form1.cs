using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
            
            Refresh();
            Thread.Sleep(1000);
            label1.ForeColor = Color.White;
            label1.Text = "Game will start in..... 3";

            Refresh();
            Thread.Sleep(1000);
            label1.ForeColor = Color.White;
            label1.Text = "Game will start in..... 2";

            Refresh();
            Thread.Sleep(1000);
            label1.ForeColor = Color.White;
            label1.Text = "Game will start in..... 1";

            Refresh();
            Thread.Sleep(1000);
            label1.ForeColor = Color.White;
            label1.Text = "NO.";
            this.BackColor = Color.Red;
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.Red;
            SoundPlayer SCREAM = new SoundPlayer(Properties.Resources.heheheha_made_with_Voicemod_technology);
            SCREAM.Play();
            Refresh();
            Thread.Sleep(1000);
            this.Close();

        }
    }
}
