using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;

namespace WarShips
{
    public partial class options : Form
    {
        private Point mouseOffset;
        private bool isMouseDown = false;
        private Form1 root;
        public int[] mass = new int[20];


        public options()
        {
            InitializeComponent();
        }

        public options(Form1 r)
        {
            InitializeComponent();
            root = r;
            this.markSelect.SelectedIndex = root.curMark;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            root.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;
            Opacity = 0.9;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X;
                yOffset = -e.Y;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
                Opacity = 1;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            root.bckSndVolume = (int)this.bckSndVol.Value;
            root.mnSnd.Volume = root.bckSndVolume;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            root.sndVolume = (int)this.sndVol.Value;
            root.sndEnter.Volume = root.sndVolume;
            root.sndSelect.Volume = root.sndVolume;
            root.sndSelect.CurrentPosition = 0;
            root.sndSelect.Play();
        }

        private void escapeBut_Click(object sender, EventArgs e)
        {
            root.sndSelect.CurrentPosition = 0;
            root.sndSelect.Play();
            root.Location = this.Location;
            root.Show();
            this.Hide();
        }

        private void label_mouse_enter(object sender, EventArgs e)
        {
            root.sndEnter.CurrentPosition = 0;
            root.sndEnter.Play();
            ((Label)sender).BackColor = Color.FromArgb(98, 98, 98);
            ((Label)sender).ForeColor = Color.FromArgb(255, 0, 0);
        }

        private void label_mouse_leave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.FromArgb(210, 210, 210);
            ((Label)sender).ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void comboBox1_GotFocus(object sender, EventArgs e)
        {
            root.curMark = this.markSelect.SelectedIndex;
            this.Label.Focus();
        }
    }
}
