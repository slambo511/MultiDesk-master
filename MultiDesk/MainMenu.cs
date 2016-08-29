using System.Windows.Forms;

namespace MultiDesk
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

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

        private void makeRunningMenuFloatToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!Globals.IsFloating)
            {
                Globals.IsFloating = true;
                makeRunningMenuFloatToolStripMenuItem.Text = @"Make Running Menu Docked";
            }
            else
            {
                Globals.IsFloating = false;
                makeRunningMenuFloatToolStripMenuItem.Text = @"Make Running Menu Float";
            }
        }
    }
}
