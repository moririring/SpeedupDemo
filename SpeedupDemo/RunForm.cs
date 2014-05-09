using System;
using System.Drawing;
using System.Windows.Forms;

namespace SpeedupDemo
{
    public partial class RunForm : Form
    {
        public RunForm()
        {
            InitializeComponent();
        }

        private void RunForm_Load(object sender, EventArgs e)
        {
            Location = new Point(Owner.Location.X + (Owner.Width - Width) / 2, Owner.Location.Y + (Owner.Height - Height) / 2);
        }
    }
}
