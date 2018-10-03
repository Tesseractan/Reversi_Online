namespace Reversi_Online
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.friends_button = new System.Windows.Forms.Button();
            this.profile_button = new System.Windows.Forms.Button();
            this.board_settings_button = new System.Windows.Forms.Button();
            this.online_game_settings_button = new System.Windows.Forms.Button();
            this.goback1 = new Reversi_Online.Goback();
            this.SuspendLayout();
            // 
            // friends_button
            // 
            this.friends_button.BackColor = System.Drawing.Color.Black;
            this.friends_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.friends_button.ForeColor = System.Drawing.Color.White;
            this.friends_button.Location = new System.Drawing.Point(138, 329);
            this.friends_button.Name = "friends_button";
            this.friends_button.Size = new System.Drawing.Size(207, 57);
            this.friends_button.TabIndex = 9;
            this.friends_button.Text = "Friends";
            this.friends_button.UseVisualStyleBackColor = false;
            // 
            // profile_button
            // 
            this.profile_button.BackColor = System.Drawing.Color.Black;
            this.profile_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.profile_button.ForeColor = System.Drawing.Color.White;
            this.profile_button.Location = new System.Drawing.Point(138, 255);
            this.profile_button.Name = "profile_button";
            this.profile_button.Size = new System.Drawing.Size(207, 57);
            this.profile_button.TabIndex = 8;
            this.profile_button.Text = "Profile";
            this.profile_button.UseVisualStyleBackColor = false;
            // 
            // board_settings_button
            // 
            this.board_settings_button.BackColor = System.Drawing.Color.Black;
            this.board_settings_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.board_settings_button.ForeColor = System.Drawing.Color.White;
            this.board_settings_button.Location = new System.Drawing.Point(138, 95);
            this.board_settings_button.Name = "board_settings_button";
            this.board_settings_button.Size = new System.Drawing.Size(207, 57);
            this.board_settings_button.TabIndex = 7;
            this.board_settings_button.Text = "Board settings";
            this.board_settings_button.UseVisualStyleBackColor = false;
            this.board_settings_button.Click += new System.EventHandler(this.board_settings_button_Click);
            // 
            // online_game_settings_button
            // 
            this.online_game_settings_button.BackColor = System.Drawing.Color.Black;
            this.online_game_settings_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.online_game_settings_button.ForeColor = System.Drawing.Color.White;
            this.online_game_settings_button.Location = new System.Drawing.Point(138, 175);
            this.online_game_settings_button.Name = "online_game_settings_button";
            this.online_game_settings_button.Size = new System.Drawing.Size(207, 57);
            this.online_game_settings_button.TabIndex = 6;
            this.online_game_settings_button.Text = "Online game settings";
            this.online_game_settings_button.UseVisualStyleBackColor = false;
            // 
            // goback1
            // 
            this.goback1.BackColor = System.Drawing.Color.White;
            this.goback1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goback1.BackgroundImage")));
            this.goback1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goback1.Location = new System.Drawing.Point(169, 416);
            this.goback1.Name = "goback1";
            this.goback1.Size = new System.Drawing.Size(141, 38);
            this.goback1.TabIndex = 10;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 519);
            this.Controls.Add(this.goback1);
            this.Controls.Add(this.friends_button);
            this.Controls.Add(this.profile_button);
            this.Controls.Add(this.board_settings_button);
            this.Controls.Add(this.online_game_settings_button);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Setting_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button friends_button;
        private System.Windows.Forms.Button profile_button;
        private System.Windows.Forms.Button board_settings_button;
        private System.Windows.Forms.Button online_game_settings_button;
        private Goback goback1;
    }
}