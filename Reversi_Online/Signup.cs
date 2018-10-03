using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using ReversiSerializableTypes.UserData;

namespace Reversi_Online
{
    public partial class Signup : ReversiForm
    {
        private Regex name_scheme = new Regex("^[A-Za-z]+$");
        private Regex email_address_scheme = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");//source: https://stackoverflow.com/questions/5342375/regex-email-validation
        private Regex username_scheme = new Regex("^.{3,21}$");
        private Regex password_scheme = new Regex("^.{3,21}$");

        public Signup()
        {
            InitializeComponent();
        }

        private void goto_login_button_Click(object sender, EventArgs e)
        {

            Login login_form = new Login();
            login_form.Show(this.Owner);
            this.Close();

        }

        private void name_textbox_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(ref name_textbox, name_scheme);
        }

        private void surname_textbox_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(ref surname_textbox, name_scheme);
        }

        private void email_textbox_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(ref email_textbox, email_address_scheme);
        }
        
        private void username_textbox_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(ref username_textbox, username_scheme);
        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {
            if (repeated_password_textbox.Text.Length > 0)
            {
                if (password_textbox.Text == repeated_password_textbox.Text)
                {
                    password_textbox.BackColor = Color.Green;
                    password_textbox.ForeColor = Color.White;
                    repeated_password_textbox.BackColor = Color.Green;
                    repeated_password_textbox.ForeColor = Color.White;
                }
                else
                {
                    password_textbox.BackColor = Color.Red;
                    password_textbox.ForeColor = Color.Black;
                }
                ValidateForm(); 
            }
            else
            {
                ValidateTextBox(ref password_textbox, password_scheme);
            }
        }



        private void ValidateTextBox(ref TextBox textbox, Regex scheme)
        {
            if (scheme.IsMatch(textbox.Text))
            {
                textbox.BackColor = Color.Green;
                textbox.ForeColor = Color.White;
            }
            else
            {
                textbox.BackColor = Color.Red;
                textbox.ForeColor = Color.Black;
            }
            ValidateForm();
        }

        private void repeated_password_textbox_TextChanged(object sender, EventArgs e)
        {
            if (password_textbox.Text.Length > 0)
            {
                if (password_textbox.Text == repeated_password_textbox.Text)
                {
                    repeated_password_textbox.BackColor = Color.Green;
                    repeated_password_textbox.ForeColor = Color.White;
                    password_textbox.BackColor = Color.Green;
                    password_textbox.ForeColor = Color.White;
                }
                else
                {
                    repeated_password_textbox.BackColor = Color.Red;
                    repeated_password_textbox.ForeColor = Color.Black;
                }
                ValidateForm();
            }
            else
            {
                ValidateTextBox(ref repeated_password_textbox, password_scheme);
            }
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            ProfileUserData profile = new ProfileUserData()
            {
                Username = username_textbox.Text,
                ProfilePhoto = profile_image_picturebox.Image
            };
            PrivateUserData @private = new PrivateUserData()
            {
                Name = name_textbox.Text,
                Surname = surname_textbox.Text,
                Password = password_textbox.Text,
                Email = email_textbox.Text
            };
            EditableUserData data = new EditableUserData { Profile = profile, Private = @private };
            #region rubbish
            /*if (DataServerDialog.Dialog.State != ConnectionState.Connected)
            {
                MessageBox.Show("No connection");
            }
            else if (DataServerDialog.Dialog.SendMessage("SIGNUP", ("EditableData", editable)))
            {
                this.Invoke((MethodInvoker)delegate
                {
                    signup_button.Text = "Connecting...";
                    signup_button.Enabled = false;
                    ReversiSerializableTypes.Message message = DataServerDialog.Dialog.ReceiveMessage();
                    signup_button.Text = "Register";
                    signup_button.Enabled = true;

                    MessageBox.Show((string)message.Payload["description"], message.Title);
                    if (message.Title == "SUCCESS")
                    {
                        this.Close();
                    }
                });
                
            }*/
            #endregion
            void unmark_waiting()
            {
                this.signup_button.Invoke((MethodInvoker)(() =>
                {
                    signup_button.Text = "Register";
                    signup_button.Enabled = true;
                    this.Cursor = Cursors.Default;
                }));
            }
            Servers.DataServer.SignUp(data, new ServerDialog.Reactions
            {
                RequestSentCallback = () =>
                {
                    signup_button.Invoke((MethodInvoker)(() =>
                    {
                        signup_button.Text = "Waiting...";
                        signup_button.Enabled = false;
                    }));
                    
                },
                MessageReceivedCallback = (message) =>
                {
                    unmark_waiting();
                    this.Invoke((MethodInvoker)(() =>
                    {
                        
                        if (message.Title=="SUCCESS")
                        {
                            
                            this.Close();
                        }
                        else
                        {
                            info1.Show();
                            info1.Text = (string)message.Payload["description"];
                        }
                    }));
                    
                },
                DisconnectionErrorCallback = () =>
                {
                    unmark_waiting();
                    this.Invoke((MethodInvoker)(() =>
                    {
                        info1.Show();
                        info1.Text = "Connection error";
                    }));
                    
                }
            });
            
        }

        private void agreement_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }
        private void ValidateForm()
        {
            bool enable_signup = true;
            foreach(Control control in signup_groupbox.Controls)
            {
                if (control is TextBox)
                {
                    if (control.BackColor != Color.Green)
                    {
                        enable_signup = false;
                    }
                }
            }
            if (!agreement_checkbox.Checked)
            {
                enable_signup = false;
            }

            signup_button.Enabled = enable_signup;
        }

        private void profile_image_picturebox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "Choose your profile photo",
                Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
            };
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                profile_image_picturebox.Image = new Bitmap(openFileDialog.FileName);
            }
        }
    }
}
