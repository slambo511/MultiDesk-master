using System;
using System.Drawing;
using System.Drawing.Text;
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

        }
        public sealed override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; }
        }

        private void RunningWindow_Load(object sender, System.EventArgs e)
        {
            if (!Globals.IsFloating)
            {
                this.Location = new Point(Globals.ScreenPosition[0],
                    Globals.ScreenPosition[1]);
            }
            
        }

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
            if (_mouseDown)
            {
                this.Location = new Point((this.Location.X - _lastLocation.X) + e.X,
                    (this.Location.Y - _lastLocation.Y) + e.Y);
                this.Update();
            }
        }

    }
}
