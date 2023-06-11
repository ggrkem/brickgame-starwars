using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreaker
{
    public partial class HowToPlayScreen : UserControl
    {
        public HowToPlayScreen()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            OptionsScreen os = new OptionsScreen();
            Form form = this.FindForm();

            form.Controls.Add(os);
            form.Controls.Remove(this);

            os.Location = new Point((form.Width - os.Width) / 2, (form.Height - os.Height) / 2);
        }

        private void liveslabel_Click(object sender, EventArgs e)
        {

        }
    }
}
