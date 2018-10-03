using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reversi_Online
{
    public partial class Settings : ReversiForm
    {
        public Settings()
        {
            InitializeComponent();
        }
        private void Setting_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void board_settings_button_Click(object sender, EventArgs e)
        {
            new BoardSettings().Show(this);
            this.Hide();
        }
        

        /*private void machine_settings_button_Click(object sender, EventArgs e)
        {
            new MachineSettings().Show(this);
            this.Hide();
        }*/
    }
}
