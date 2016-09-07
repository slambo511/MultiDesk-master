// Commented usings are for Picture handlers. DO NOT REMOVE
using System;
// using System.Drawing;
using System.Drawing.Imaging;
// using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace MultiDesk
{
    public partial class MainMenu : Form
    {
        RegEdit EditRegistry = new RegEdit();
        private string _currentDesktop = "Default";
        private string _passedNumber = "";
        private int _runningWindowCount = Convert.ToInt32(Program.Arguments[2]);
        public MainMenu()
        {
            InitializeComponent();
            if (EditRegistry.ReadKey("SOFTWARE\\MULTIDESK\\MENUPOS") == null)
            {
                SetPos();
            }
        }

        #region DesktopNumberRadioButtons
        private void rbTwo_CheckedChanged(object sender, EventArgs e)
        {
            Globals.NoDesktops = 2;
            Globals.RemainingDesktops = 1;
            _passedNumber = "2";
        }

        private void rbThree_CheckedChanged(object sender, EventArgs e)
        {
            Globals.NoDesktops = 3;
            Globals.RemainingDesktops = 2;
            _passedNumber = "3";
        }

        private void rbFour_CheckedChanged(object sender, EventArgs e)
        {
            Globals.NoDesktops = 4;
            Globals.RemainingDesktops = 3;
            _passedNumber = "4";
        }

        private void rbFive_CheckedChanged(object sender, EventArgs e)
        {
            Globals.NoDesktops = 5;
            Globals.RemainingDesktops = 4;
            _passedNumber = "5";
        }

        private void rbSix_CheckedChanged(object sender, EventArgs e)
        {
            Globals.NoDesktops = 6;
            Globals.RemainingDesktops = 5;
            _passedNumber = "6";
        }

        private void rbSeven_CheckedChanged(object sender, EventArgs e)
        {
            Globals.NoDesktops = 7;
            Globals.RemainingDesktops = 6;
            _passedNumber = "7";
        }

        private void rbEight_CheckedChanged(object sender, EventArgs e)
        {
            Globals.NoDesktops = 8;
            Globals.RemainingDesktops = 7;
            _passedNumber = "8";
        }
        #endregion

        #region ExitHandlers    
        private void btnExit_Click(object sender, EventArgs e)
        {
            Globals.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.Exit();
        }
        #endregion

        #region StartHandler
        private void btnStart_Click(object sender, EventArgs e)
        {
            Hide();
            for (int b = 0; b < Globals.RemainingDesktops; b++)
            {
                int c = b + 2;
                _runningWindowCount++; // try incrementing here
                DesktopInitialise("desktop" + c.ToString());
            }
            RunningWindow open = new RunningWindow(1); //_runningWindowCount); called this form last?
            open.ShowDialog();
            Close();
        }
        #endregion

        #region Functions

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
            if (Program.Arguments[0] == "running")
            {
                Globals.NoDesktops = Convert.ToInt32(Program.Arguments[1]);
                Hide();
                RunningWindow open = new RunningWindow(Convert.ToInt32(Program.Arguments[2]));
                open.ShowDialog();
                Close();
            }
            
        }

        private void DesktopInitialise(string name)
        {
            // DesktopSave();
            
            if (!Desktops.DesktopExists(name))
            {
                string[] args = {"running", Globals.NoDesktops.ToString(), (_runningWindowCount).ToString()};
                Desktops.DesktopCreate(name);
                Processes.ProcessCreate(name, Application.ExecutablePath, String.Join(" ", args));             
            }
            Desktops.DesktopSwitch(name);
        }

        private void DesktopSave()
        {
            string path = Application.UserAppDataPath + "\\";
            string desktop = _currentDesktop;
            if (desktop == "Default")
            {
                desktop = "Desktop1";
            }
            path = path + desktop;
            Thread.Sleep(500);
            Screenshots.ScreenSave(path, ImageFormat.Jpeg, this);
        }

        /*private void ScreenshotsLoad()
        {
            for (int index = 1; index < 5; index++)
            {
                string path = Application.UserAppDataPath + "\\";
                path += "Desktop" + index.ToString();
                if (File.Exists(path))
                {
                    MemoryStream stream = new MemoryStream();
                    Image image = Image.FromFile(path);
                    image.Save(stream, ImageFormat.Jpeg);
                    image.Dispose();
                    string pictureBox = "pictureBox" + index.ToString();
                }
            }

        }*/

        /*private void ScreenshotLoad()
        {
            switch (_currentDesktop)
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
        }*/

        /*private void ScreenshotsDelete()
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
        }*/
        #endregion

        private void resetMenuPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPos();
        }

        private void SetPos()
        {
            int[] menuPos = new int[2];
            menuPos[0] = 10;
            menuPos[1] = 10;
            EditRegistry._subKey = "SOFTWARE\\MULTIDESK\\MENUPOS";
            EditRegistry._showError = true;
            for (int i = 0; i < 2; i++)
            {
                EditRegistry.WriteKey(i.ToString(), menuPos[i]);
            }
        }

        private void deleteRegistryEntriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show(@"Are you sure?", @"Delete registry entries", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (check == DialogResult.Yes)
            {
                EditRegistry.DeleteKey("SOFTWARE\\MULTIDESK\\MENUPOS");
                Globals.Exit();
            }

        }
    }
}
