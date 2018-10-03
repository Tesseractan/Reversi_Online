using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using ReversiSerializableTypes;
using ReversiSerializableTypes.UserData;

namespace Reversi_Online
{
    public partial class Login : ReversiForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void sign_up_button_Click(object sender, EventArgs e)
        {
            Signup signup_form = new Signup();
            signup_form.Show(this.Owner);
            this.Close();

        }

        private void login_button_Click(object sender, EventArgs e)
        {

            /* if (DataServerDialog.Dialog.State != ConnectionState.Connected)
             {
                 MessageBox.Show("No connection!");
             }
             else if (DataServerDialog.Dialog.SendMessage("LOGIN", ("username", username_textbox.Text), ("password", password_textbox.Text)))
             {
                 Thread receiving = new Thread(() =>
                 {
                     this.Invoke((MethodInvoker)delegate
                     {
                         login_button.Text = "Connecting...";
                         login_button.Enabled = false;

                         ReversiSerializableTypes.Message message = DataServerDialog.Dialog.ReceiveMessage();

                         login_button.Text = "Login";
                         login_button.Enabled = true;

                         MessageBox.Show((string)message.Payload["description"], message.Title);
                         if (message.Title == "SUCCESS")
                         {
                             DataServerDialog.Dialog.State = ConnectionState.Authenticated;
                             this.Close();
                         }
                     });

                 });
                 receiving.Start();
             }*/
            void unmark_waiting()
            {
                this.login_button.Invoke((MethodInvoker)(() =>
                {
                    login_button.Text = "Login";
                    login_button.Enabled = true;
                    this.Cursor = Cursors.Default;
                }));
            }
            LoginUserData loginUserData = new LoginUserData() { Username = username_textbox.Text, Password = password_textbox.Text };
            Servers.DataServer.LogIn(loginUserData, new ServerDialog.Reactions
            {
                RequestSentCallback = ()=>
                {
                    this.login_button.Invoke((MethodInvoker)(() =>
                    {
                        this.Cursor = Cursors.WaitCursor;
                        login_button.Text = "Waiting...";
                        login_button.Enabled = false;
                    }));
                },
                MessageReceivedCallback = (message)=>
                {
                    unmark_waiting();
                    this.Invoke((MethodInvoker)(() =>
                    {
                        //MessageBox.Show((string)message.Payload["description"], message.Title);
                        if (message.Title == "SUCCESS")
                        {
                           /* if (this.Owner is Menu) {
                                this.Owner.Invoke((MethodInvoker)(() =>
                                {
                                    (this.Owner as Menu).Info.Text = (string)message.Payload["description"];
                                    (this.Owner as Menu).Info.Show();
                                }));
                            }*/
                            this.Close();
                        }
                        else
                        {
                            this.ShowInfo((string)message.Payload["description"]);
                            username_textbox.BackColor = Color.Tomato;
                            password_textbox.BackColor = Color.Tomato;
                        }
                    }));
                    
                },
                DisconnectionErrorCallback = ()=>
                {
                    unmark_waiting();

                    this.InvokeShowInfo("A connection error occured.");
                    
                }
            });
        }
        private void InvokeShowInfo(string message)
        {
            info.Invoke((MethodInvoker)(() =>
            {
                this.ShowInfo(message);
            }));
           
        }
        private void ShowInfo(string message)
        {
            info.Show();
            info.Text = message;
        }
        private void Login_FormClosed(object sender, EventArgs e)
        {
            
        }


    }
}
