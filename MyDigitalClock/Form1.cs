using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDigitalClock
{
    public partial class Form1 : Form
    {
        decimal timer = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           label1.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\scorp\Downloads\SpongeBobProductionMusicTomfoolery.wav");
            sp.Play();

        }

        private void muteButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\scorp\Downloads\SpongeBobProductionMusicTomfoolery.wav");
            sp.Stop();
            playButton.Enabled = true;
        }
    }
}
