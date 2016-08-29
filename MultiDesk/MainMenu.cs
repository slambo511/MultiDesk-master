using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace MultiDesk
{
    public partial class MainMenu : Form
    {
        private string currentDesktop = "Default";
        public MainMenu()
        {
            InitializeComponent();
        }

        #region DesktopNumberRadioButtons
        private void rbTwo_CheckedChanged(object sender, System.EventArgs e)
        {
            Globals.NoDesktops = 2;
        }

        private void rbThree_CheckedChanged(object sender, System.EventArgs e)
        {
            Globals.NoDesktops = 3;
        }

        private void rbFour_CheckedChanged(object sender, System.EventArgs e)
        {
            Globals.NoDesktops = 4;
        }

        private void rbFive_CheckedChanged(object sender, System.EventArgs e)
        {
            Globals.NoDesktops = 5;
        }

        private void rbSix_CheckedChanged(object sender, System.EventArgs e)
        {
            Globals.NoDesktops = 6;
        }

        private void rbSeven_CheckedChanged(object sender, System.EventArgs e)
        {
            Globals.NoDesktops = 7;
        }

        private void rbEight_CheckedChanged(object sender, System.EventArgs e)
        {
            Globals.NoDesktops = 8;
        }
        #endregion

        #region DektopPositionRadioButtons
        private void rbTopLeft_CheckedChanged(object sender, System.EventArgs e)
        {
            Globals.ScreenPosition = Globals.TopLeft;
        }

        private void rbTopCentre_CheckedChanged(object sender, System.EventArgs e)
        {
            Globals.ScreenPosition = Globals.TopCentre;
        }

        private void rbTopRight_CheckedChanged(object sender, System.EventArgs e)
        {
            Globals.ScreenPosition = Globals.TopRight;
        }

        private void rbCentreLeft_CheckedChanged(object sender, System.EventArgs e)
        {
            Globals.ScreenPosition = Globals.CentreLeft;
        }

        private void rbCentreRight_CheckedChanged(object sender, System.EventArgs e)
        {
            Globals.ScreenPosition = Globals.CentreRight;
        }

        private void rbBottomLeft_CheckedChanged(object sender, System.EventArgs e)
        {
            Globals.ScreenPosition = Globals.BottomLeft;
        }

        private void rbBottomCentre_CheckedChanged(object sender, System.EventArgs e)
        {
            Globals.ScreenPosition = Globals.BottomCentre;
        }

        private void rbBottomRight_CheckedChanged(object sender, System.EventArgs e)
        {
            Globals.ScreenPosition = Globals.BottomRight;
        }
        #endregion

        #region FloatOrDockRunningMenuHandlers
        private void makeRunningMenuFloatToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!Globals.IsFloating)
            {
                FloatMenu();
            }
            else
            {
                DockMenu();
            }
        }

        private void btnFloatDock_Click(object sender, System.EventArgs e)
        {
            if (!Globals.IsFloating)
            {
                FloatMenu();
            }
            else
            {
                DockMenu();
            }
        }
        #endregion

        #region ExitHandlers    
        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Globals.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Globals.Exit();
        }
        #endregion

        #region CustomMethods
        private void FloatMenu()
        {
            Globals.IsFloating = true;
            makeRunningMenuFloatToolStripMenuItem.Text = @"Make Running Menu Docked";
            gbxPosition.Enabled = false;
            btnFloatDock.Text = @"Dock Menu";
        }

        private void DockMenu()
        {
            Globals.IsFloating = false;
            makeRunningMenuFloatToolStripMenuItem.Text = @"Make Running Menu Float";
            gbxPosition.Enabled = true;
            btnFloatDock.Text = @"Float Menu";
        }
        #endregion

        #region StartHandler
        private void btnStart_Click(object sender, System.EventArgs e)
        {
            Hide();
            for (int b = 0; b < Globals.NoDesktops; b++)
            {
                int c = b + 1;
                DesktopInitialise("desktop" + c.ToString());
            }
            RunningWindow open = new RunningWindow();
            open.ShowDialog();
            Close();
        }
        #endregion

        #region Functions

        private void MainMenu_Load(object sender, System.EventArgs e)
        {
            
            if (Program.Arguments[0] == "running")
            {
                Globals.NoDesktops = Convert.ToInt32(Program.Arguments[1]);
                Hide();
                RunningWindow open = new RunningWindow();
                open.ShowDialog();
                Close();
            }
            
        }

        private void DesktopInitialise(string name)
        {
            DesktopSave();

            if (!Desktops.DesktopExists(name))
            {
                string[] args = {"running", Globals.NoDesktops.ToString()};
                Desktops.DesktopCreate(name);
                Processes.ProcessCreate(name, Application.ExecutablePath, String.Join(" ", args));             
            }
            Desktops.DesktopSwitch(name);
        }

        private void DesktopSave()
        {
            string path = Application.UserAppDataPath + "\\";
            string desktop = currentDesktop;
            if (desktop == "Default")
            {
                desktop = "Desktop1";
            }
            path = path + desktop;
            Thread.Sleep(500);
            Screenshots.ScreenSave(path, ImageFormat.Jpeg, this);
        }

        private void ScreenshotsLoad()
        {
            for (int index = 1; index < 5; index++)
            {
                string path = Application.UserAppDataPath + "\\";
                path += "Desktop" + index.ToString();
                if (File.Exists(path))
                {
                    MemoryStream stream = new MemoryStream();
                    Image image = Bitmap.FromFile(path);
                    image.Save(stream, ImageFormat.Jpeg);
                    image.Dispose();
                    string pictureBox = "pictureBox" + index.ToString();
                }
            }

        }

        private void ScreenshotLoad()
        {
            switch (currentDesktop)
            {
                case "Default":
                    //pictureBox1.Image = Screenshots.ScreenCapture(this);
                    break;
                case "Desktop2":
                    //ictureBox2.Image = Screenshots.ScreenCapture(this);
                    break;
                case "Desktop3":
                    //pictureBox3.Image = Screenshots.ScreenCapture(this);
                    break;
                case "Desktop4":
                    //pictureBox4.Image = Screenshots.ScreenCapture(this);
                    break;
            }
        }

        private void ScreenshotsDelete()
        {
            for (int index = 2; index < 5; index++)
            {
                string desktop = "Desktop" + index.ToString();
                string path = Application.UserAppDataPath + "\\" + desktop;
                if (File.Exists(path) && !Desktops.DesktopExists(desktop))
                {
                    File.Delete(path);
                }
            }
        }
        #endregion

    }
}
