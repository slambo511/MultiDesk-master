using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace MultiDesk
{
    public partial class RunningWindow : Form
    {

        private bool _mouseDown;
        private Point _lastLocation;

        public RunningWindow()
        {
            InitializeComponent();

            TransparencyKey = Color.Aquamarine;
            BackColor = Color.Aquamarine;

            PositionMenu();

        }

        public sealed override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; }
        }

        #region HandleFloatingMovementAndPositionOfWindow
        private void RunningWindow_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void RunningWindow_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        private void RunningWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_mouseDown) return;
            Location = new Point((Location.X - _lastLocation.X) + e.X,
                (Location.Y - _lastLocation.Y) + e.Y);
            Update();
        }
        #endregion

        private void RunningWindow_Load_1(object sender, EventArgs e)
        {
            // Handles the removal of superflous buttons and resizes form accordingly
            if (Globals.NoDesktops == 2)
            {
                btnEight.Hide(); btnSeven.Hide(); btnSix.Hide(); btnFive.Hide(); btnFour.Hide(); btnThree.Hide();
                Width = Width - (46 * 6);
            }
            else if (Globals.NoDesktops == 3)
            {
                btnEight.Hide(); btnSeven.Hide(); btnSix.Hide(); btnFive.Hide(); btnFour.Hide();
                Width = Width - (46 * 5);
            }
            else if (Globals.NoDesktops == 4)
            {
                btnEight.Hide(); btnSeven.Hide(); btnSix.Hide(); btnFive.Hide();
                Width = Width - (46 * 4);
            }
            else if (Globals.NoDesktops == 5)
            {
                btnEight.Hide(); btnSeven.Hide(); btnSix.Hide();
                Width = Width - (46 * 3);
            }
            else if (Globals.NoDesktops == 6)
            {
                btnEight.Hide(); btnSeven.Hide();
                Width = Width - (46 * 2);
            }
            else if (Globals.NoDesktops == 7)
            {
                btnEight.Hide();
                Width = Width - 46;
            }

            if (Program.Arguments[0] == "running")
            {
                Process.Start("explorer.exe");
                Thread.Sleep(500);
                Opacity = 0;
                WindowState = FormWindowState.Normal;
                //this.WindowState = FormWindowState.Minimized;
                Thread.Sleep(500);
                Opacity = 100;
            }
            //currentDesktop = Desktops.DesktopName(Desktops.DesktopOpenInput());
            //ScreenshotsDelete();


            // Find current desktop number and set button nuber to match
            int currentDT;
            try
            {
                currentDT = Convert.ToInt32(Program.Arguments[1]);
            }
            catch
            {
                currentDT = 1;
            }


            if (currentDT == 1)
            {
                btnOne.Focus();
            }
            if (currentDT == 2)
            {
                btnTwo.Focus();
            }
            if (currentDT == 3)
            {
                btnThree.Focus();
            }
            if (currentDT == 4)
            {
                btnFour.Focus();
            }
            if (currentDT == 5)
            {
                btnFive.Focus();
            }
            if (currentDT == 6)
            {
                btnSix.Focus();
            }
            if (currentDT == 7)
            {
                btnSeven.Focus();
            }
            if (currentDT == 8)
            {
                btnEight.Focus();
            }

            PositionMenu();

        }

        #region ButtonHandlers
        private void btnOne_Click(object sender, EventArgs e)
        {
            Desktops.DesktopSwitch("default");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            Desktops.DesktopSwitch("desktop2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            Desktops.DesktopSwitch("desktop3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            Desktops.DesktopSwitch("desktop4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            Desktops.DesktopSwitch("desktop5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            Desktops.DesktopSwitch("desktop6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            Desktops.DesktopSwitch("desktop7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            Desktops.DesktopSwitch("desktop8");
        }
        #endregion

        private void PositionMenu()
        {
             Location = new Point(10, 10);
        }

    }
}
