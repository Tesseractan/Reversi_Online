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
    public partial class LoginRequiredBanner : ReversiForm
    {
        private Form form;
        public LoginRequiredBanner()
        {
            InitializeComponent();
        }
        public LoginRequiredBanner(Form form) : this()
        {
            this.form = form;
            Servers.DataServer.Authenticated += this.Proceed;

        }
        private void Proceed(object sender, EventArgs e)
        {
            Servers.DataServer.Authenticated -= this.Proceed;
            this.Owner.Invoke((Action)(() => this.form.Show()));

            this.Invoke((Action)(() => this.Close()));
        }
        private void ok_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show(this.Owner);
            //this.Close();
            this.Hide();
           // login.FormClosed += (s, ea) => this.Close();
            //this.Close();
        }
        public Form Form => this.form;

        private void LoginRequiredBanner_FormClosed(object sender, EventArgs e)
        {
            //Servers.DataServer.Authenticated -= this.Proceed;
        }
    }
}
