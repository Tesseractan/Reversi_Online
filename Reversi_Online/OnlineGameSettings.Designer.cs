namespace Reversi_Online
{
    partial class OnlineGameSettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rating_range_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.opponents_username_combobox = new System.Windows.Forms.ComboBox();
            this.opponents_photo_picturebox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.playing_color_combobox = new System.Windows.Forms.ComboBox();
            this.timeControlsPicker1 = new Reversi_Online.TimeControlsPicker();
            this.playing_color_picturebox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.create_challenge_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opponents_photo_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playing_color_picturebox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opponents_username_combobox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rating_range_combobox);
            this.groupBox1.Controls.Add(this.opponents_photo_picturebox);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 119);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select opponent";
            // 
            // rating_range_combobox
            // 
            this.rating_range_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rating_range_combobox.FormattingEnabled = true;
            this.rating_range_combobox.Items.AddRange(new object[] {
            "Open",
            "<800",
            "800-1200",
            "1200-1600",
            "1600-2000",
            ">2000"});
            this.rating_range_combobox.Location = new System.Drawing.Point(324, 56);
            this.rating_range_combobox.Name = "rating_range_combobox";
            this.rating_range_combobox.Size = new System.Drawing.Size(94, 27);
            this.rating_range_combobox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(321, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rating:";
            // 
            // opponents_username_combobox
            // 
            this.opponents_username_combobox.BackColor = System.Drawing.Color.DarkKhaki;
            this.opponents_username_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.opponents_username_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.opponents_username_combobox.ForeColor = System.Drawing.Color.Black;
            this.opponents_username_combobox.FormattingEnabled = true;
            this.opponents_username_combobox.Items.AddRange(new object[] {
            "Random",
            "TESTER"});
            this.opponents_username_combobox.Location = new System.Drawing.Point(87, 56);
            this.opponents_username_combobox.Name = "opponents_username_combobox";
            this.opponents_username_combobox.Size = new System.Drawing.Size(231, 27);
            this.opponents_username_combobox.TabIndex = 5;
            this.opponents_username_combobox.SelectedIndexChanged += new System.EventHandler(this.opponents_username_combobox_SelectedIndexChanged);
            // 
            // opponents_photo_picturebox
            // 
            this.opponents_photo_picturebox.Image = global::Reversi_Online.Properties.Resources.question_mark;
            this.opponents_photo_picturebox.Location = new System.Drawing.Point(21, 38);
            this.opponents_photo_picturebox.Name = "opponents_photo_picturebox";
            this.opponents_photo_picturebox.Size = new System.Drawing.Size(60, 60);
            this.opponents_photo_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opponents_photo_picturebox.TabIndex = 1;
            this.opponents_photo_picturebox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(20, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select playing color:";
            // 
            // playing_color_combobox
            // 
            this.playing_color_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playing_color_combobox.FormattingEnabled = true;
            this.playing_color_combobox.Items.AddRange(new object[] {
            "Random",
            "Black",
            "White"});
            this.playing_color_combobox.Location = new System.Drawing.Point(173, 259);
            this.playing_color_combobox.Name = "playing_color_combobox";
            this.playing_color_combobox.Size = new System.Drawing.Size(121, 21);
            this.playing_color_combobox.TabIndex = 7;
            this.playing_color_combobox.SelectedIndexChanged += new System.EventHandler(this.playing_color_combobox_SelectedIndexChanged);
            // 
            // timeControlsPicker1
            // 
            this.timeControlsPicker1.Location = new System.Drawing.Point(13, 147);
            this.timeControlsPicker1.MaximumSize = new System.Drawing.Size(423, 82);
            this.timeControlsPicker1.MinimumSize = new System.Drawing.Size(423, 82);
            this.timeControlsPicker1.Name = "timeControlsPicker1";
            this.timeControlsPicker1.Size = new System.Drawing.Size(423, 82);
            this.timeControlsPicker1.TabIndex = 5;
            // 
            // playing_color_picturebox
            // 
            this.playing_color_picturebox.Image = global::Reversi_Online.Properties.Resources.unknown;
            this.playing_color_picturebox.Location = new System.Drawing.Point(309, 251);
            this.playing_color_picturebox.Name = "playing_color_picturebox";
            this.playing_color_picturebox.Size = new System.Drawing.Size(40, 40);
            this.playing_color_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playing_color_picturebox.TabIndex = 8;
            this.playing_color_picturebox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(13, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select board size mode";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(20, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 18);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Classical (8x8)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton2.ForeColor = System.Drawing.Color.Black;
            this.radioButton2.Location = new System.Drawing.Point(20, 50);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(202, 18);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Custom (choosed in board settings)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // create_challenge_button
            // 
            this.create_challenge_button.BackColor = System.Drawing.Color.Gold;
            this.create_challenge_button.Font = new System.Drawing.Font("News706 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_challenge_button.Location = new System.Drawing.Point(86, 428);
            this.create_challenge_button.Name = "create_challenge_button";
            this.create_challenge_button.Size = new System.Drawing.Size(263, 45);
            this.create_challenge_button.TabIndex = 9;
            this.create_challenge_button.Text = "Create challenge";
            this.create_challenge_button.UseVisualStyleBackColor = false;
            this.create_challenge_button.Click += new System.EventHandler(this.create_challenge_button_Click);
            // 
            // OnlineGameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 485);
            this.Controls.Add(this.create_challenge_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.playing_color_picturebox);
            this.Controls.Add(this.playing_color_combobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeControlsPicker1);
            this.Controls.Add(this.groupBox1);
            this.Name = "OnlineGameSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OnlineGameSettings";
            this.Load += new System.EventHandler(this.OnlineGameSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opponents_photo_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playing_color_picturebox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox opponents_photo_picturebox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox rating_range_combobox;
        private System.Windows.Forms.ComboBox opponents_username_combobox;
        private TimeControlsPicker timeControlsPicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox playing_color_combobox;
        private System.Windows.Forms.PictureBox playing_color_picturebox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button create_challenge_button;
    }
}