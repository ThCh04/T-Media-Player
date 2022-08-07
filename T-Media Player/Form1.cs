using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_Media_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ch = new OpenFileDialog();
            ch.FileName = "";
            ch.Filter = "archivo mp3 |*.mp3|archivo mp4 |*.mp4|archivo m4a |*.m4a |archivo flv |*.flv |archivo avi |*.avi |archivo wma |*.wma";
            ch.FilterIndex = 1;

            if (ch.ShowDialog()== DialogResult.OK)
            {
                player.URL = ch.FileName;
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado por Eduard Cruz (ThCh!) ID: 2020-9358");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.previous();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.next();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }
    }
}
