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
    public partial class AuthenticationErrorBanner : ReversiForm
    {
        private string errorMessage;
        public AuthenticationErrorBanner(string errorMessage)
        {
            this.errorMessage = errorMessage;
            InitializeComponent();
        }

        private void AuthenticationErrorBanner_Load(object sender, EventArgs e)
        {
            error_message_label.Text = this.errorMessage;
        }
    }
}
