using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reversi_Online
{
    public partial class Goback : UserControl
    {
        public Goback()
        {
            InitializeComponent();
        }

        private void Goback_Load(object sender, EventArgs e)
        {
            this.ParentForm.FormClosed += (s, ea) =>
            {
                if (this.ParentForm.Owner is Form)
                {
                    this.ParentForm.Owner.Show();
                }
            };
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void Goback_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void Goback_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
