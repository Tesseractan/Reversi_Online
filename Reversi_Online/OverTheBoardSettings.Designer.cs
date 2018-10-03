namespace Reversi_Online
{
    partial class OverTheBoardSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverTheBoardSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user_name_textbox = new System.Windows.Forms.TextBox();
            this.opponents_name_textbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.game_duration_combobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.user_stone_picturebox = new System.Windows.Forms.PictureBox();
            this.opponents_stone_picturebox = new System.Windows.Forms.PictureBox();
            this.goback1 = new Reversi_Online.Goback();
            this.start_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_stone_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opponents_stone_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opponent\'s name:";
            // 
            // user_name_textbox
            // 
            this.user_name_textbox.Location = new System.Drawing.Point(185, 32);
            this.user_name_textbox.Name = "user_name_textbox";
            this.user_name_textbox.Size = new System.Drawing.Size(151, 20);
            this.user_name_textbox.TabIndex = 2;
            this.user_name_textbox.Text = "You";
            // 
            // opponents_name_textbox
            // 
            this.opponents_name_textbox.Location = new System.Drawing.Point(185, 67);
            this.opponents_name_textbox.Name = "opponents_name_textbox";
            this.opponents_name_textbox.Size = new System.Drawing.Size(151, 20);
            this.opponents_name_textbox.TabIndex = 3;
            this.opponents_name_textbox.Text = "Opponent";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Reversi_Online.Properties.Resources.person;
            this.pictureBox1.Location = new System.Drawing.Point(40, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Reversi_Online.Properties.Resources.clock;
            this.pictureBox2.Location = new System.Drawing.Point(40, 151);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // game_duration_combobox
            // 
            this.game_duration_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.game_duration_combobox.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.game_duration_combobox.FormattingEnabled = true;
            this.game_duration_combobox.Items.AddRange(new object[] {
            "1",
            "10",
            "15",
            "20",
            "3",
            "30",
            "5",
            "60",
            "∞"});
            this.game_duration_combobox.Location = new System.Drawing.Point(185, 162);
            this.game_duration_combobox.Name = "game_duration_combobox";
            this.game_duration_combobox.Size = new System.Drawing.Size(69, 53);
            this.game_duration_combobox.Sorted = true;
            this.game_duration_combobox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(270, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "min";
            // 
            // user_stone_picturebox
            // 
            this.user_stone_picturebox.Location = new System.Drawing.Point(343, 32);
            this.user_stone_picturebox.Name = "user_stone_picturebox";
            this.user_stone_picturebox.Size = new System.Drawing.Size(23, 20);
            this.user_stone_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_stone_picturebox.TabIndex = 9;
            this.user_stone_picturebox.TabStop = false;
            this.user_stone_picturebox.Click += new System.EventHandler(this.user_stone_picturebox_Click);
            // 
            // opponents_stone_picturebox
            // 
            this.opponents_stone_picturebox.Location = new System.Drawing.Point(343, 68);
            this.opponents_stone_picturebox.Name = "opponents_stone_picturebox";
            this.opponents_stone_picturebox.Size = new System.Drawing.Size(23, 20);
            this.opponents_stone_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opponents_stone_picturebox.TabIndex = 10;
            this.opponents_stone_picturebox.TabStop = false;
            this.opponents_stone_picturebox.Click += new System.EventHandler(this.opponents_stone_picturebox_Click);
            // 
            // goback1
            // 
            this.goback1.BackColor = System.Drawing.Color.White;
            this.goback1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goback1.BackgroundImage")));
            this.goback1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goback1.Location = new System.Drawing.Point(40, 302);
            this.goback1.Name = "goback1";
            this.goback1.Size = new System.Drawing.Size(98, 27);
            this.goback1.TabIndex = 11;
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.YellowGreen;
            this.start_button.ForeColor = System.Drawing.Color.White;
            this.start_button.Location = new System.Drawing.Point(219, 299);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(104, 33);
            this.start_button.TabIndex = 12;
            this.start_button.Text = "START";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // OverTheBoardSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 389);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.goback1);
            this.Controls.Add(this.opponents_stone_picturebox);
            this.Controls.Add(this.user_stone_picturebox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.game_duration_combobox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.opponents_name_textbox);
            this.Controls.Add(this.user_name_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OverTheBoardSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OverTheBoardSettings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OverTheBoardSettings_FormClosed);
            this.Load += new System.EventHandler(this.OverTheBoardSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_stone_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opponents_stone_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_name_textbox;
        private System.Windows.Forms.TextBox opponents_name_textbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox game_duration_combobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox user_stone_picturebox;
        private System.Windows.Forms.PictureBox opponents_stone_picturebox;
        private Goback goback1;
        private System.Windows.Forms.Button start_button;
    }
}