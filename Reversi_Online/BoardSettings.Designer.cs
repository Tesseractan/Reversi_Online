namespace Reversi_Online
{
    partial class BoardSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoardSettings));
            this.set_size_button = new System.Windows.Forms.Button();
            this.set_colors_button = new System.Windows.Forms.Button();
            this.set_stone_styles_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.goback1 = new Reversi_Online.Goback();
            this.reset_board_settings_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // set_size_button
            // 
            this.set_size_button.BackColor = System.Drawing.Color.Goldenrod;
            this.set_size_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.set_size_button.ForeColor = System.Drawing.Color.White;
            this.set_size_button.Location = new System.Drawing.Point(149, 208);
            this.set_size_button.Name = "set_size_button";
            this.set_size_button.Size = new System.Drawing.Size(200, 52);
            this.set_size_button.TabIndex = 0;
            this.set_size_button.Text = "Set size";
            this.set_size_button.UseVisualStyleBackColor = false;
            this.set_size_button.Click += new System.EventHandler(this.set_size_button_Click);
            // 
            // set_colors_button
            // 
            this.set_colors_button.BackColor = System.Drawing.Color.Goldenrod;
            this.set_colors_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.set_colors_button.ForeColor = System.Drawing.Color.White;
            this.set_colors_button.Location = new System.Drawing.Point(149, 266);
            this.set_colors_button.Name = "set_colors_button";
            this.set_colors_button.Size = new System.Drawing.Size(200, 53);
            this.set_colors_button.TabIndex = 2;
            this.set_colors_button.Text = "Set colors";
            this.set_colors_button.UseVisualStyleBackColor = false;
            this.set_colors_button.Click += new System.EventHandler(this.set_colors_button_Click);
            // 
            // set_stone_styles_button
            // 
            this.set_stone_styles_button.BackColor = System.Drawing.Color.Goldenrod;
            this.set_stone_styles_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.set_stone_styles_button.ForeColor = System.Drawing.Color.White;
            this.set_stone_styles_button.Location = new System.Drawing.Point(149, 325);
            this.set_stone_styles_button.Name = "set_stone_styles_button";
            this.set_stone_styles_button.Size = new System.Drawing.Size(200, 53);
            this.set_stone_styles_button.TabIndex = 3;
            this.set_stone_styles_button.Text = "Set stone styles";
            this.set_stone_styles_button.UseVisualStyleBackColor = false;
            this.set_stone_styles_button.Click += new System.EventHandler(this.set_stone_styles_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Reversi_Online.Properties.Resources.chessboard_settings;
            this.pictureBox1.Location = new System.Drawing.Point(149, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // goback1
            // 
            this.goback1.BackColor = System.Drawing.Color.White;
            this.goback1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goback1.BackgroundImage")));
            this.goback1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goback1.Location = new System.Drawing.Point(188, 408);
            this.goback1.Name = "goback1";
            this.goback1.Size = new System.Drawing.Size(122, 34);
            this.goback1.TabIndex = 5;
            // 
            // reset_board_settings_button
            // 
            this.reset_board_settings_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.reset_board_settings_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reset_board_settings_button.ForeColor = System.Drawing.Color.White;
            this.reset_board_settings_button.Location = new System.Drawing.Point(74, 462);
            this.reset_board_settings_button.Name = "reset_board_settings_button";
            this.reset_board_settings_button.Size = new System.Drawing.Size(348, 38);
            this.reset_board_settings_button.TabIndex = 6;
            this.reset_board_settings_button.Text = "RESET board settings";
            this.reset_board_settings_button.UseVisualStyleBackColor = false;
            this.reset_board_settings_button.Click += new System.EventHandler(this.reset_board_settings_button_Click);
            // 
            // BoardSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 512);
            this.Controls.Add(this.reset_board_settings_button);
            this.Controls.Add(this.goback1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.set_stone_styles_button);
            this.Controls.Add(this.set_colors_button);
            this.Controls.Add(this.set_size_button);
            this.Name = "BoardSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoardSettings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BoardSettings_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button set_size_button;
        private System.Windows.Forms.Button set_colors_button;
        private System.Windows.Forms.Button set_stone_styles_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Goback goback1;
        private System.Windows.Forms.Button reset_board_settings_button;
    }
}