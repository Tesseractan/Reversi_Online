namespace Reversi_Online
{
    partial class Signup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.signup_groupbox = new System.Windows.Forms.GroupBox();
            this.remember_checkbox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.goto_login_button = new System.Windows.Forms.Button();
            this.profile_image_picturebox = new System.Windows.Forms.PictureBox();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.signup_button = new System.Windows.Forms.Button();
            this.agreement_checkbox = new System.Windows.Forms.CheckBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.repeated_password_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.surname_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.info1 = new Reversi_Online.Info();
            this.signup_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_image_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // signup_groupbox
            // 
            this.signup_groupbox.Controls.Add(this.info1);
            this.signup_groupbox.Controls.Add(this.remember_checkbox);
            this.signup_groupbox.Controls.Add(this.label7);
            this.signup_groupbox.Controls.Add(this.goto_login_button);
            this.signup_groupbox.Controls.Add(this.profile_image_picturebox);
            this.signup_groupbox.Controls.Add(this.email_textbox);
            this.signup_groupbox.Controls.Add(this.label6);
            this.signup_groupbox.Controls.Add(this.signup_button);
            this.signup_groupbox.Controls.Add(this.agreement_checkbox);
            this.signup_groupbox.Controls.Add(this.name_textbox);
            this.signup_groupbox.Controls.Add(this.repeated_password_textbox);
            this.signup_groupbox.Controls.Add(this.password_textbox);
            this.signup_groupbox.Controls.Add(this.username_textbox);
            this.signup_groupbox.Controls.Add(this.surname_textbox);
            this.signup_groupbox.Controls.Add(this.label5);
            this.signup_groupbox.Controls.Add(this.label4);
            this.signup_groupbox.Controls.Add(this.label3);
            this.signup_groupbox.Controls.Add(this.label2);
            this.signup_groupbox.Controls.Add(this.label1);
            this.signup_groupbox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signup_groupbox.Location = new System.Drawing.Point(13, 13);
            this.signup_groupbox.Name = "signup_groupbox";
            this.signup_groupbox.Size = new System.Drawing.Size(401, 500);
            this.signup_groupbox.TabIndex = 0;
            this.signup_groupbox.TabStop = false;
            this.signup_groupbox.Text = "Sign up to Morilla";
            // 
            // remember_checkbox
            // 
            this.remember_checkbox.AutoSize = true;
            this.remember_checkbox.Checked = true;
            this.remember_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.remember_checkbox.Location = new System.Drawing.Point(11, 432);
            this.remember_checkbox.Name = "remember_checkbox";
            this.remember_checkbox.Size = new System.Drawing.Size(114, 23);
            this.remember_checkbox.TabIndex = 17;
            this.remember_checkbox.Text = "Remember me";
            this.remember_checkbox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Profile image:";
            // 
            // goto_login_button
            // 
            this.goto_login_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.goto_login_button.ForeColor = System.Drawing.Color.White;
            this.goto_login_button.Location = new System.Drawing.Point(10, 466);
            this.goto_login_button.Name = "goto_login_button";
            this.goto_login_button.Size = new System.Drawing.Size(362, 28);
            this.goto_login_button.TabIndex = 15;
            this.goto_login_button.Text = "I already have an account";
            this.goto_login_button.UseVisualStyleBackColor = false;
            this.goto_login_button.Click += new System.EventHandler(this.goto_login_button_Click);
            // 
            // profile_image_picturebox
            // 
            this.profile_image_picturebox.Image = global::Reversi_Online.Properties.Resources.homeguy;
            this.profile_image_picturebox.Location = new System.Drawing.Point(132, 286);
            this.profile_image_picturebox.Name = "profile_image_picturebox";
            this.profile_image_picturebox.Size = new System.Drawing.Size(119, 111);
            this.profile_image_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profile_image_picturebox.TabIndex = 12;
            this.profile_image_picturebox.TabStop = false;
            this.profile_image_picturebox.Click += new System.EventHandler(this.profile_image_picturebox_Click);
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(130, 139);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(212, 26);
            this.email_textbox.TabIndex = 14;
            this.email_textbox.TextChanged += new System.EventHandler(this.email_textbox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Username:";
            // 
            // signup_button
            // 
            this.signup_button.BackColor = System.Drawing.Color.Red;
            this.signup_button.Enabled = false;
            this.signup_button.ForeColor = System.Drawing.Color.White;
            this.signup_button.Location = new System.Drawing.Point(288, 425);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(84, 35);
            this.signup_button.TabIndex = 11;
            this.signup_button.Text = "Register";
            this.signup_button.UseVisualStyleBackColor = false;
            this.signup_button.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // agreement_checkbox
            // 
            this.agreement_checkbox.AutoSize = true;
            this.agreement_checkbox.Location = new System.Drawing.Point(11, 403);
            this.agreement_checkbox.Name = "agreement_checkbox";
            this.agreement_checkbox.Size = new System.Drawing.Size(255, 23);
            this.agreement_checkbox.TabIndex = 10;
            this.agreement_checkbox.Text = "I agree with terms of using Morilla";
            this.agreement_checkbox.UseVisualStyleBackColor = true;
            this.agreement_checkbox.CheckedChanged += new System.EventHandler(this.agreement_checkbox_CheckedChanged);
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(130, 68);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(212, 26);
            this.name_textbox.TabIndex = 9;
            this.name_textbox.TextChanged += new System.EventHandler(this.name_textbox_TextChanged);
            // 
            // repeated_password_textbox
            // 
            this.repeated_password_textbox.Location = new System.Drawing.Point(132, 247);
            this.repeated_password_textbox.Name = "repeated_password_textbox";
            this.repeated_password_textbox.Size = new System.Drawing.Size(210, 26);
            this.repeated_password_textbox.TabIndex = 8;
            this.repeated_password_textbox.UseSystemPasswordChar = true;
            this.repeated_password_textbox.TextChanged += new System.EventHandler(this.repeated_password_textbox_TextChanged);
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(130, 211);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(212, 26);
            this.password_textbox.TabIndex = 7;
            this.password_textbox.UseSystemPasswordChar = true;
            this.password_textbox.TextChanged += new System.EventHandler(this.password_textbox_TextChanged);
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(130, 176);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(212, 26);
            this.username_textbox.TabIndex = 6;
            this.username_textbox.TextChanged += new System.EventHandler(this.username_textbox_TextChanged);
            // 
            // surname_textbox
            // 
            this.surname_textbox.Location = new System.Drawing.Point(130, 104);
            this.surname_textbox.Name = "surname_textbox";
            this.surname_textbox.Size = new System.Drawing.Size(212, 26);
            this.surname_textbox.TabIndex = 5;
            this.surname_textbox.TextChanged += new System.EventHandler(this.surname_textbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Repeat password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // info1
            // 
            this.info1.Location = new System.Drawing.Point(10, 26);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(332, 30);
            this.info1.TabIndex = 18;
            this.info1.Visible = false;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(426, 525);
            this.Controls.Add(this.signup_groupbox);
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.signup_groupbox.ResumeLayout(false);
            this.signup_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_image_picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox signup_groupbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox repeated_password_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox surname_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signup_button;
        private System.Windows.Forms.CheckBox agreement_checkbox;
        private System.Windows.Forms.PictureBox profile_image_picturebox;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button goto_login_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox remember_checkbox;
        private Info info1;
    }
}