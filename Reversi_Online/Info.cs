using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reversi_Online
{
    public partial class Info : UserControl
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Resize(object sender, EventArgs e)
        {
            message_label.Width = Convert.ToInt32(this.Width * 0.8);
            message_label.Height = this.Height;
            x_label.Width = Convert.ToInt32(this.Width * 0.2);
            x_label.Height = this.Height;
            x_label.Left = Convert.ToInt32(this.Width * 0.8);
        }

        [Browsable(true)]
        public override string Text
        {
            get => message_label.Text;
            set { message_label.Text = value; }
        }

        private void x_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Dispose(true);
        }
        private void x_label_MouseHover(object sender, EventArgs e)
        {
            x_label.ForeColor = Color.Red;
        }
        private void x_label_MouseLeave(object sender, EventArgs e)
        {
            x_label.ForeColor = Color.White;
        }
    }
}
