using PlayGames.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayGames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.BackgroundImage = Properties.Resources.super_mario_world_2;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer tm = new Timer();
            tm.Interval = 3000;
            tm.Tick += new EventHandler(changeImage);
            tm.Start();
        }

        private void changeImage(object sender, EventArgs e)
        {
            List<Bitmap> b1 = new List<Bitmap>();
            b1.Add(Resources.super_mario_world_2);
            b1.Add(Resources.maxresdefault_9);
            b1.Add(Resources.super_mario_all_stars___super_mario_world_hd_wallpapers_33717_794428);
            b1.Add(Resources._1407976_mario_kart_8);

            int index = DateTime.Now.Second % 4;
            this.BackgroundImage = b1[index];
        }
    }
}
