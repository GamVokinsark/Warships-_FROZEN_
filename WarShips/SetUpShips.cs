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
    public partial class SetUpShips : Form
    {
        public bool isMouseDown = false;
        private bool rotate = true;
        public Point mouseOffset;
        private Form1 root;
        private PictureBox[] cells = new PictureBox[100];
        private int curX;
        private int curY;
        private Label[] markLetters = new Label[10];
        private Label[] markNumbers = new Label[10];
        public Audio bckSnd;
        private int curSnd = 0;
        private int shipLength = 4;

        public SetUpShips()
        {
            InitializeComponent();
        }

        public SetUpShips(Form1 r)
        {
            InitializeComponent();
            root = r;
            bckSnd = new Audio(root.backrPath[curSnd]);
            bckSnd.Ending += new EventHandler(bckSnd_Ending);
            
            string  cellName = "cell";
            for (int i = 0; i < cells.Length; i++)
            {
                cells[i] = new PictureBox();
                cells[i].BackgroundImage = Image.FromFile("seaCell.png");
                cells[i].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                cells[i].Location = new System.Drawing.Point(32 + 30 * (i % 10), 32 + 30 * (i / 10));
                cells[i].Name = cellName + (i + 1).ToString();
                cells[i].Size = new System.Drawing.Size(30, 30);
                cells[i].TabIndex = 6;
                cells[i].TabStop = false;
                //cells[i].BorderStyle = BorderStyle.FixedSingle;
                
                cells[i].Click += new System.EventHandler(this.pictureBox_Click);
                cells[i].MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
                cells[i].MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
                this.fieldPanel.Controls.Add(cells[i]);
            }
            markLetters[0] = LtMrk1; markLetters[1] = LtMrk2; markLetters[2] = LtMrk3; markLetters[3] = LtMrk4; markLetters[4] = LtMrk5; 
            markLetters[5] = LtMrk6; markLetters[6] = LtMrk7; markLetters[7] = LtMrk8; markLetters[8] = LtMrk9; markLetters[9] = LtMrk10;
            
            markNumbers[0] = NmMrk1; markNumbers[1] = NmMrk2; markNumbers[2] = NmMrk3; markNumbers[3] = NmMrk4; markNumbers[4] = NmMrk5;
            markNumbers[5] = NmMrk6; markNumbers[6] = NmMrk7; markNumbers[7] = NmMrk8; markNumbers[8] = NmMrk9; markNumbers[9] = NmMrk10;


        }

        public void chFildMark()
        {
            for (int i = 0; i < markLetters.Length; i++)
                markLetters[i].Text = root.marks[root.curMark][i].ToString();
        }

        private bool checkPlace(int x, int y, int num)
        {
            bool result = true;
            if (rotate)
            {
                if (y <= 10 - num)
                {
                    for (int i = 0; i < num; i++)
                        if (root.playerShips[10 * (y + i) + x] >= 0)
                            return false;
                }
                else
                {
                    for (int i = 0; i < num; i++)
                    {
                        if (root.playerShips[10 * (10 - num + i) + x] >= 0)
                            return false;
                    }
                }
            }
            else
            {
                if (x <= 10 - num)
                {
                    for (int i = 0; i < num; i++)
                        if (root.playerShips[10 * y + x + i] >= 0)
                            return false;
                }
                else
                {
                    for (int i = 0; i < num; i++)
                        if (root.playerShips[10 * y + (10 - num + i)] >= 0)
                            return false;
                }
            }
            return result;
        }

        private void showShips(int x, int y, int num)
        {
            if (!checkPlace(x, y, num)) return;
            if (rotate)
            {
                markLetters[x].BackColor = Color.FromArgb(40, 40, 40);
                markLetters[x].ForeColor = Color.FromArgb(255, 255, 255);
                if (y <= 10 - num)
                    for (int i = 0; i < num; i++)
                    {
                        markNumbers[y + i].BackColor = Color.FromArgb(40, 40, 40);
                        markNumbers[y + i].ForeColor = Color.FromArgb(255, 255, 255);
                        cells[10 * (y + i) + x].BackgroundImage = root.ships[6 + i];
                    }
                else
                {
                    for (int i = 0; i < num; i++)
                    {
                        markNumbers[10 - num + i].BackColor = Color.FromArgb(40, 40, 40);
                        markNumbers[10 - num + i].ForeColor = Color.FromArgb(255, 255, 255);
                        cells[10 * (10 - num + i) + x].BackgroundImage = root.ships[6 + i];
                    }
                }
            }
            else
            {
                markNumbers[y].BackColor = Color.FromArgb(40, 40, 40);
                markNumbers[y].ForeColor = Color.FromArgb(255, 255, 255);
                if (x <= 10 - num)
                    for (int i = 0; i < num; i++)
                    {
                        markLetters[x + i].BackColor = Color.FromArgb(40, 40, 40);
                        markLetters[x + i].ForeColor = Color.FromArgb(255, 255, 255);
                        cells[10 * y + x + i].BackgroundImage = root.ships[16 + i];
                    }
                else
                {
                    for (int i = 0; i < num; i++)
                    {
                        markLetters[10 - num + i].BackColor = Color.FromArgb(40, 40, 40);
                        markLetters[10 - num + i].ForeColor = Color.FromArgb(255, 255, 255);
                        cells[10 * y + (10 - num + i)].BackgroundImage = root.ships[16 + i];
                    }
                }
            }
        }

        private void hideShips(int x, int y, int num)
        {
            if (rotate)
            {
                markLetters[x].BackColor = Color.FromArgb(210, 210, 210);
                markLetters[x].ForeColor = Color.FromArgb(0, 0, 0);
                if (y <= 10 - num)
                    for (int i = 0; i < num; i++)
                    {
                        markNumbers[y + i].BackColor = Color.FromArgb(210, 210, 210);
                        markNumbers[y + i].ForeColor = Color.FromArgb(0, 0, 0);
                        if (checkPlace(x, y, num))
                            cells[10 * (y + i) + x].BackgroundImage = Image.FromFile("seaCell.png");
                    }
                else
                {
                    for (int i = 0; i < num; i++)
                    {
                        markNumbers[10 - num + i].BackColor = Color.FromArgb(210, 210, 210);
                        markNumbers[10 - num + i].ForeColor = Color.FromArgb(0, 0, 0);
                        if (checkPlace(x, y, num))
                            cells[10 * (10 - num + i) + x].BackgroundImage = Image.FromFile("seaCell.png");
                    }
                }
            }
            else
            {
                markNumbers[y].BackColor = Color.FromArgb(210, 210, 210);
                markNumbers[y].ForeColor = Color.FromArgb(0, 0, 0);
                if (x <= 10 - num)
                    for (int i = 0; i < num; i++)
                    {
                        markLetters[x + i].BackColor = Color.FromArgb(210, 210, 210);
                        markLetters[x + i].ForeColor = Color.FromArgb(0, 0, 0);
                        if (checkPlace(x, y, num))
                            cells[10 * y + x + i].BackgroundImage = Image.FromFile("seaCell.png");
                    }
                else
                {
                    for (int i = 0; i < num; i++)
                    {
                        markLetters[10 - num + i].BackColor = Color.FromArgb(210, 210, 210);
                        markLetters[10 - num + i].ForeColor = Color.FromArgb(0, 0, 0);
                        if (checkPlace(x, y, num))
                            cells[10 * y + (10 - num + i)].BackgroundImage = Image.FromFile("seaCell.png");
                    }
                }
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            root.Close();
        }

        private void escapeBut_Click(object sender, EventArgs e)
        {
            bckSnd.Stop();
            bckSnd.CurrentPosition = 0;
            root.mnSnd.Play();
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

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            curX = (((PictureBox)sender).Location.X - 32) / 30;
            curY = (((PictureBox)sender).Location.Y - 32) / 30;
            showShips(curX, curY, shipLength);
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            curX = (((PictureBox)sender).Location.X - 32) / 30;
            curY = (((PictureBox)sender).Location.Y - 32) / 30;
            hideShips(curX, curY, shipLength);
        }

        private void setShip(int x, int y, int num)
        {
            if (!checkPlace(x, y, num)) return;
            if (rotate)
            {
                if (y <= 10 - num)
                    for (int i = 0; i < num; i++)
                    {
                        cells[10 * (y + i) + x].BackgroundImage = root.ships[6 + i];
                        root.playerShips[10 * (y + i) + x] = 6 + i;
                    }
                else
                    for (int i = 0; i < num; i++)
                    {
                        cells[10 * (10 - num + i) + x].BackgroundImage = root.ships[6 + i];
                        root.playerShips[10 * (10 - num + i) + x] = 6 + i;
                    }
            }
            else
            {
                if (x <= 10 - num)
                    for (int i = 0; i < num; i++)
                    {
                        cells[10 * y + x + i].BackgroundImage = root.ships[16 + i];
                        root.playerShips[10 * y + x + i] = 16 + i;
                    }
                else
                    for (int i = 0; i < num; i++)
                    {
                        cells[10 * y + (10 - num + i)].BackgroundImage = root.ships[16 + i];
                        root.playerShips[10 * y + (10 - num + i)] = 16 + i;
                    }
            }
            pictureBox_MouseLeave(cells[10 * y + x], null);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if(((MouseEventArgs)e).Button == System.Windows.Forms.MouseButtons.Right)
            {
                pictureBox_MouseLeave(sender, e);
                if (rotate) rotate = false;
                else rotate = true;
                pictureBox_MouseEnter(sender, e);                
            }
            else if (((MouseEventArgs)e).Button == System.Windows.Forms.MouseButtons.Left)
            {
                curX = (((PictureBox)sender).Location.X - 32) / 30;
                curY = (((PictureBox)sender).Location.Y - 32) / 30;
                setShip(curX, curY, shipLength);
            }
        }

        private void bckSnd_Ending(object sender, EventArgs e)
        {
            bckSnd = new Audio(root.backrPath[(curSnd + 1) % 3]);
            bckSnd.Play();
        }
    }
}
