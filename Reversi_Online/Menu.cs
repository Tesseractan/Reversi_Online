using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reversi = ReversiSerializableTypes;

namespace Reversi_Online
{
    public partial class Menu : ReversiForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //DataServerDialog.Connect();
            /*DataServer.Dialog.Connected += (s, ea) =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    login_button.Text = "Sign in";
                    login_button.Enabled = true;
                });
                
            };*/
            Servers.DataServer.Disconnected += (s, ea) =>
            {
                //MessageBox.Show("dis");
                this.Invoke((MethodInvoker)delegate
                {
                    //login_button.Text = "No connection";
                    //login_button.Enabled = false;
                    login_button.Text = "Sign in";
                });
                
            };
            Servers.DataServer.Authenticated += (s, ea) =>
            {
                info.Invoke((MethodInvoker)(() =>
                {
                    info.Show();
                    info.Text = (string)((Reversi.Message)ea.PayloadData["message"]).Payload["description"];
                    login_button.Text = "Resign";
                }));
                
            };
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            new Settings().Show(this);
            this.Hide();
        }

        private void play_vs_machine_button_Click(object sender, EventArgs e)
        {
            new MachineSettings().Show(this);
            this.Hide();
        }

        private void play_live_online_button_Click(object sender, EventArgs e)
        {
            OnlineGameSettings onlineGameSettings = new OnlineGameSettings();
            if (Servers.DataServer.IsAuthenticated) onlineGameSettings.Show(this);
            else new LoginRequiredBanner(onlineGameSettings).Show(this);
        }

        private void play_over_the_board_button_Click(object sender, EventArgs e)
        {
            new OverTheBoardSettings().Show(this);
            this.Hide();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            new Login().Show(this);
        }

        private void Menu_FormClosed(object sender, EventArgs e)
        {
            Servers.DisconnectAll();
        }

        public Info Info => info;
    } 
}
