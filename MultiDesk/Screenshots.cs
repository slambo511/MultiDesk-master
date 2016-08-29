using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace MultiDesk
{
    public class Screenshots
    {
        public static Bitmap ScreenCapture(Control control)
        {
            try
            {
                Rectangle bounds = Screen.FromControl(control).Bounds;
                Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height);
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                }
                return bitmap;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return new Bitmap(0,0);
            }
        }

        public static void ScreenSave(string filename, ImageFormat format, Control control)
        {
            try
            {
                File.Delete(filename);
                using (Bitmap screenShot = ScreenCapture(control))
                {
                    screenShot.Save(filename, format);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

    }
}
