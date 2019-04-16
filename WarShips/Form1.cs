using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.AudioVideoPlayback;



namespace WarShips
{
    public partial class Form1 : Form
    {
        public bool isMouseDown = false;
        public Point mouseOffset;
        private options chOption;
        private SetUpShips chStart;
        public Audio mnSnd;
        public Audio sndSelect;
        public Audio sndEnter;
        public string[] backrPath = { "bckgrSnd2.mp3",
                                      "bckgrSnd3.mp3", 
                                      "bckgrSnd4.mp3"};

        public string[] marks = { "АБВГДЕЖЗИК", 
                                  "АГРОТЕХНИК", 
                                  "БЛАЖЕНСТВО", 
                                  "ГИПОТЕНУЗА", 
                                  "ДЕМОКРАТИЯ", 
                                  "МУРАВЕЙНИК", 
                                  "ПРАВОСУДИЕ", 
                                  "РЕСПУБЛИКА", 
                                  "СНЕГУРОЧКА", 
                                  "СПРАВОЧНИК", 
                                  "ТРУДОЛЮБИЕ", 
                                  "ЦЕНТРИФУГА", 
                                  "ЭКСПЕРТИЗА"};
        public Image[] ships = new Image[20];
        public int[] playerShips = new int[100];
        public int bckSndVolume = -3000;
        public int sndVolume = -3000;
        public int curMark = 7;

        public Form1()
        {
            InitializeComponent();
            sndEnter = new Audio("sndEnter.mp3");
            sndSelect = new Audio("sndSelect.mp3");
            mnSnd = new Audio("mnSnd1.mp3");
            mnSnd.Ending += new EventHandler(mnSnd_Ending);
            mnSnd.Play();
            chOption = new options(this);
            chStart = new SetUpShips(this);
            ships[0] = Image.FromFile("4xShip1v.png"); // 1x1v
            ships[1] = Image.FromFile("4xShip1v.png"); // 2x1v
            ships[2] = Image.FromFile("4xShip4v.png"); // 2x2v
            ships[3] = Image.FromFile("4xShip1v.png"); // 3x1v
            ships[4] = Image.FromFile("4xShip2v.png"); // 3x2v
            ships[5] = Image.FromFile("4xShip4v.png"); // 3x3v
            ships[6] = Image.FromFile("4xShip1v.png"); // 4x1v
            ships[7] = Image.FromFile("4xShip2v.png"); // 4x2v
            ships[8] = Image.FromFile("4xShip3v.png"); // 4x3v
            ships[9] = Image.FromFile("4xShip4v.png"); // 4x4v
            ships[10] = Image.FromFile("4xShip1h.png"); // 1x1h
            ships[11] = Image.FromFile("4xShip1h.png"); // 2x1h
            ships[12] = Image.FromFile("4xShip4h.png"); // 2x2h
            ships[13] = Image.FromFile("4xShip1h.png"); // 3x1h
            ships[14] = Image.FromFile("4xShip2h.png"); // 3x2h
            ships[15] = Image.FromFile("4xShip4h.png"); // 3x3h
            ships[16] = Image.FromFile("4xShip1h.png"); // 4x1h
            ships[17] = Image.FromFile("4xShip2h.png"); // 4x2h
            ships[18] = Image.FromFile("4xShip3h.png"); // 4x3h
            ships[19] = Image.FromFile("4xShip4h.png"); // 4x4h
            for (int i = 0; i < playerShips.Length; i++)
                playerShips[i] = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void mnSnd_Ending(object sender, EventArgs e)
        {
            mnSnd.CurrentPosition = 0;
            mnSnd.Play();
        }

        private void label_mouse_enter(object sender, EventArgs e)
        {
            sndEnter.CurrentPosition = 0;
            sndEnter.Play();
            ((Label)sender).BackColor = Color.FromArgb(98, 98, 98);
            ((Label)sender).ForeColor = Color.FromArgb(255, 0, 0);
        }

        private void label_mouse_leave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.FromArgb(210, 210, 210);
            ((Label)sender).ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void optionBut_Click(object sender, EventArgs e)
        {
            sndSelect.CurrentPosition = 0;
            sndSelect.Play();
            chOption.Show();
            chOption.Location = this.Location;
            this.Hide();
        }

        private void exitBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startBut_Click(object sender, EventArgs e)
        {
            mnSnd.Stop();
            mnSnd.CurrentPosition = 0;
            chStart.bckSnd.Volume = this.bckSndVolume;
            chStart.bckSnd.Play();
            chStart.chFildMark();
            sndSelect.CurrentPosition = 0;
            sndSelect.Play();
            chStart.Show();
            chStart.Location = this.Location;
            this.Hide();
        }
    }
}
