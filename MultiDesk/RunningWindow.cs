using System.Drawing;
using System.Windows.Forms;

namespace MultiDesk
{
    public partial class RunningWindow : Form
    {
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
    }
}
