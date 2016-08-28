using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Text;

namespace MultiDesk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DesktopInitialise(string name)
        {
            DesktopSave();

            if (!Desktops.DesktopExists(name))
            {
                Desktops.DesktopCreate(name);
                Processes.ProcessCreate(name, Application.ExecutablePath, "running");
            }
            Desktops.DesktopSwitch(name);
        }

        private void DesktopSave()
        {
            string path = Application.UserAppDataPath = "\\";
            string desktop = currentDesktop;
            if (desktop == "Default")
            {
                desktop = "Desktop1";
            }
            path = path + desktop;
            Thread.Sleep(500);
            ScreenShots.ScreenSave(path, ImageFormat.Jpeg, this);
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
                    ((PictureBox) tableLayoutPanel1.Controls[pictureBox]).Image = Bitmap.FromStream(stream);
                }
            }

        }

        private void ScreenshotLoad()
        {
            switch (currentDesktop)
            {
                case "Default":
                    pictureBox1.Image = Screenshots.ScreenCapture(this);
                    break;
                
            }
        }

    }
}
