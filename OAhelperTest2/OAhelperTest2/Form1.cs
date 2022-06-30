using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OAhelperTest2
{
    public partial class Form1 : Form
    {
        private Point mousePoint; //current window location
        //int screenWidth = Screen.AllScreens.Sum(s => s.Bounds.Width);
        int screenWidth = Screen.PrimaryScreen.Bounds.Size.Width;
        int screenHeigth = Screen.AllScreens.Sum(s => s.Bounds.Height);
        private bool _Win = false;

        public Form1()
        {
            InitializeComponent();
        }

        //Mouse Event
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y); //save current window location
        }

        private void From1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = mousePoint.X - e.X;
                int y = mousePoint.Y - e.Y;
                Location = new Point(this.Left - x, this.Top - y);
            }
        }

        //KeyBoard Event
        private void From1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.LWin || e.KeyCode == Keys.RWin) _Win = true;

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (_Win && e.KeyCode == Keys.Left)
            {
                //Location = new Point(0, this.Location.Y);
            }
            else if (_Win && e.KeyCode == Keys.Right)
            {
                int x = screenWidth - this.Size.Width;
                Location = new Point(x, this.Location.Y);
            }
            else if (_Win && e.KeyCode == Keys.Up)
            {
                Location = new Point(this.Location.X, 0);
            }
            else if (_Win && e.KeyCode == Keys.Down)
            {
                int y = screenHeigth - this.Size.Height;
                Location = new Point(this.Location.X, y);
            }

            if (_Win && e.KeyCode == Keys.LWin)
            {
                _Win = false;
            }
        }


    }
}
