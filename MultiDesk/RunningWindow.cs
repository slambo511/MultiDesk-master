using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace MultiDesk
{
    public partial class RunningWindow : Form
    {
        RegEdit EditRegistry = new RegEdit();
        private int[] menuPosition = new int[2];
        private bool _mouseDown;
        private Point _lastLocation;
        // public string _currentDesktop = Desktops.DesktopName(Desktops.DesktopOpenInput());
        private static int _idNumber;

        public RunningWindow(int count)
        {
            InitializeComponent();
            // MessageBox.Show(_currentDesktop, @"_currentDesktop", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            _idNumber = count;
            EditRegistry._subKey = "SOFTWARE\\MULTIDESK\\MENUCOUNT";
            EditRegistry._showError = true;
            int noDesktops = Convert.ToInt32(EditRegistry.ReadKey("count"));

            EditRegistry._subKey = "SOFTWARE\\MULTIDESK\\MENUPOS";
            EditRegistry._showError = true;
            int numValues = EditRegistry.ValueCount();
            for (int i = 0; i < numValues; i++)
            {
                menuPosition[i] = Convert.ToInt32(EditRegistry.ReadKey(i.ToString()));
            }
            if (ActiveForm != null)
            {
                ActiveForm.Left = menuPosition[0];
                ActiveForm.Top = menuPosition[1];
            }
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
            
            // Handles the removal of superflous buttons and resizes form accordingly
            if (Globals.NoDesktops == 2)
            {
                btnTen.Hide(); btnNine.Hide(); btnEight.Hide(); btnSeven.Hide(); btnSix.Hide(); btnFive.Hide(); btnFour.Hide(); btnThree.Hide();
                Width = Width - (41 * 8);
            }
            else if (Globals.NoDesktops == 3)
            {
                btnTen.Hide(); btnNine.Hide(); btnEight.Hide(); btnSeven.Hide(); btnSix.Hide(); btnFive.Hide(); btnFour.Hide();
                Width = Width - (41 * 7);
            }
            else if (Globals.NoDesktops == 4)
            {
                btnTen.Hide(); btnNine.Hide(); btnEight.Hide(); btnSeven.Hide(); btnSix.Hide(); btnFive.Hide();
                Width = Width - (41 * 6);
            }
            else if (Globals.NoDesktops == 5)
            {
                btnTen.Hide(); btnNine.Hide(); btnEight.Hide(); btnSeven.Hide(); btnSix.Hide();
                Width = Width - (41 * 5);
            }
            else if (Globals.NoDesktops == 6)
            {
                btnTen.Hide(); btnNine.Hide(); btnEight.Hide(); btnSeven.Hide();
                Width = Width - (41 * 4);
            }
            else if (Globals.NoDesktops == 7)
            {
                btnTen.Hide(); btnNine.Hide(); btnEight.Hide();
                Width = Width - (41 * 3);
            }
            else if (Globals.NoDesktops == 8)
            {
                btnTen.Hide(); btnNine.Hide();
                Width = Width - (41 * 2);
            }
            else if (Globals.NoDesktops == 9)
            {
                btnTen.Hide();
                Width = Width - 41;
            }

            switch (_idNumber)
            {
                case 1:
                    btnOne.BackColor = Color.Aqua;
                    //btnOne.Select();
                    //btnOne.Focus();
                    break;
                case 2:
                    btnTwo.BackColor = Color.Aqua;
                    //btnTwo.Select();
                    //btnTwo.Focus();
                    break;
                case 3:
                    btnThree.BackColor = Color.Aqua;
                    //btnThree.Select();
                    //btnThree.Focus();
                    break;
                case 4:
                    btnFour.BackColor = Color.Aqua;
                    //btnFour.Select();
                    //btnFour.Focus();
                    break;
                case 5:
                    btnFive.BackColor = Color.Aqua;
                    //btnFive.Select();
                    //btnFive.Focus();
                    break;
                case 6:
                    btnSix.BackColor = Color.Aqua;
                    //btnSix.Select();
                    //btnSix.Focus();
                    break;
                case 7:
                    btnSeven.BackColor = Color.Aqua;
                    //btnSeven.Select();
                    //btnSeven.Focus();
                    break;
                case 8:
                    btnEight.BackColor = Color.Aqua;
                    //btnEight.Select();
                    //btnEight.Focus();
                    break;
                case 9:
                    btnNine.BackColor = Color.Aqua;
                    break;
                case 10:
                    btnTen.BackColor = Color.Aqua;
                    break;


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
            Program.Arguments[2] = "1";
            Desktops.DesktopSwitch("default");                    
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            Program.Arguments[2] = "2";
            Desktops.DesktopSwitch("desktop2");                     
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            Program.Arguments[2] = "3";
            Desktops.DesktopSwitch("desktop3");                     
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            Program.Arguments[2] = "4";
            Desktops.DesktopSwitch("desktop4");                        
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            Desktops.DesktopSwitch("desktop5");
            Program.Arguments[2] = "5";            
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            Program.Arguments[2] = "6";
            Desktops.DesktopSwitch("desktop6");                       
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            Program.Arguments[2] = "7";
            Desktops.DesktopSwitch("desktop7");                        
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            Program.Arguments[2] = "8";
            Desktops.DesktopSwitch("desktop8");                       
        }
        #endregion

        private void PositionMenu()
        {
            Location = new Point(menuPosition[0], menuPosition[1]);
        }
     
        private void RunningWindow_Activated(object sender, EventArgs e)
        {
            //test
            //MessageBox.Show(_currentDesktop, "_currentDesktop", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show("Refresh _Activated");

        }

        private void RunningWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void RunningWindow_Move(object sender, EventArgs e)
        {
            if (ActiveForm != null)
            {
                menuPosition[0] = ActiveForm.Left;
                menuPosition[1] = ActiveForm.Top;
            }
            EditRegistry._subKey = "SOFTWARE\\MULTIDESK\\MENUPOS";
            EditRegistry._showError = true;
            for (int i = 0; i < 2; i++)
            {
                EditRegistry.WriteKey(i.ToString(), menuPosition[i]);
            }
        }

        private void loadPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditRegistry._subKey = "SOFTWARE\\MULTIDESK\\MENUPOS";
            EditRegistry._showError = true;
            int numValues = EditRegistry.ValueCount();
            for (int i = 0; i < numValues; i++)
            {
                menuPosition[i] = Convert.ToInt32(EditRegistry.ReadKey(i.ToString()));
                //MessageBox.Show(menuPosition[i].ToString());
            }
            if (ActiveForm != null)
            {
                DesktopLocation = new Point(menuPosition[0], menuPosition[1]);
                //ActiveForm.Left = menuPosition[0];
                //ActiveForm.Top = menuPosition[1];
            }
            //PositionMenu();
        }

        private void createNewDesktopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(Program.Arguments[2]);
            if (count == 10)
            {
                MessageBox.Show(
                    @"This software currently only supports ten desktops, should you need more use the Help menu on the opening window to contact us.",
                    @"Ten Windows Maximum", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                count++;
                // Program.Arguments[2] = count.ToString();
                string name = "desktop" + count.ToString();
                if (!Desktops.DesktopExists(name))
                {
                    string[] args = {"running", Globals.NoDesktops.ToString(), count.ToString()};
                    Desktops.DesktopCreate(name);
                    Processes.ProcessCreate(name, Application.ExecutablePath, String.Join(" ", args));
                }
                Desktops.DesktopSwitch(name);
            }

        }
    }
}
