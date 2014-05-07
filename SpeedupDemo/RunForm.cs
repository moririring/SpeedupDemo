using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
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
