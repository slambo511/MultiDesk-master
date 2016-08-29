using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Threading;

namespace MultiDesk
{
    public partial class Form1 : Form
    {
        private string currentDesktop = "";
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
                case "Desktop2":
                    pictureBox2.Image = Screenshots.ScreenCapture(this);
                    break;
                case "Desktop3":
                    pictureBox3.Image = Screenshots.ScreenCapture(this);
                    break;
                case "Desktop4":
                    pictureBox4.Image = Screenshots.ScreenCapture(this);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!true)//(Program.Running == "running")
            {
                Process.Start("explorer.exe");
                Thread.Sleep(500);
                this.Opacity = 0;
                this.WindowState = FormWindowState.Normal;
                this.WindowState = FormWindowState.Minimized;
                Thread.Sleep(500);
                this.Opacity = 100;
            }
            currentDesktop = Desktops.DesktopName(Desktops.DesktopOpenInput());
            ScreenshotsDelete();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            ScreenshotsLoad();
            ScreenshotLoad();
            string caption = currentDesktop;
            if (caption == "Default")
            {
                caption = "Desktop1";
            }
            this.Text = "MultiDesk: " + caption;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            DesktopInitialise("Default");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            DesktopInitialise("Desktop2");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            DesktopInitialise("Desktop3");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            DesktopInitialise("Desktop4");
        }
    }
}
