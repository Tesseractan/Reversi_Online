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
    public partial class Closer : UserControl
    {
        public Closer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ShowOwnerForm) this.ParentForm.Owner.Show();
            this.ParentForm.Close();
        }

        [Browsable(true)]
        public bool ShowOwnerForm { get; set; }
        [Browsable(true)]
        public override string Text
        {
            get => button1.Text;
            set { button1.Text = value; }
        }

        private void Closer_Resize(object sender, EventArgs e)
        {
            button1.Size = this.Size;
        }
    }
}
