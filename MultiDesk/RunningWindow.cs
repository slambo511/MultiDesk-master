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
            //TransparencyKey = Color.Aquamarine;
            //BackColor = Color.Aquamarine;

            string _currentDesktop = Desktops.DesktopName(Desktops.DesktopOpenInput());

            //test
            MessageBox.Show(_currentDesktop, "_currentDesktop", MessageBoxButtons.OK, MessageBoxIcon.Information);

            switch (_currentDesktop)
            {
                case "default":
                    btnOne.Focus();
                    break;
                case "desktop2":
                    btnTwo.Focus();
                    break;
                case "desktop3":
                    btnThree.Focus();
                    break;
                case "desktop4":
                    btnFour.Focus();
                    break;
                case "desktop5":
                    btnFive.Focus();
                    break;
                case "desktop6":
                    btnSix.Focus();
                    break;
                case "desktop7":
                    btnSeven.Focus();
                    break;
                case "desktop8":
                    btnEight.Focus();
                    break;
            }

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

        private void RunningWindow_Activated(object sender, EventArgs e)
        {
            
        }
    }
}
