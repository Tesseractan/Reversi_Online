namespace Reversi_Online
{
    partial class OverTheBoardGame
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
            this.board_panel = new System.Windows.Forms.Panel();
            this.opponents_name_label = new System.Windows.Forms.Label();
            this.user_name_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.opponents_timer_label = new System.Windows.Forms.Label();
            this.user_timer_label = new System.Windows.Forms.Label();
            this.opponents_stone_picturebox = new System.Windows.Forms.PictureBox();
            this.user_stone_picturebox = new System.Windows.Forms.PictureBox();
            this.opponents_stones_amount_label = new System.Windows.Forms.Label();
            this.user_stones_amount_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opponents_stone_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_stone_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // board_panel
            // 
            this.board_panel.Location = new System.Drawing.Point(74, 71);
            this.board_panel.Name = "board_panel";
            this.board_panel.Size = new System.Drawing.Size(350, 350);
            this.board_panel.TabIndex = 0;
            // 
            // opponents_name_label
            // 
            this.opponents_name_label.AutoSize = true;
            this.opponents_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.opponents_name_label.Location = new System.Drawing.Point(133, 29);
            this.opponents_name_label.Name = "opponents_name_label";
            this.opponents_name_label.Size = new System.Drawing.Size(129, 16);
            this.opponents_name_label.TabIndex = 1;
            this.opponents_name_label.Text = "Opponent\'s name";
            // 
            // user_name_label
            // 
            this.user_name_label.AutoSize = true;
            this.user_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.user_name_label.Location = new System.Drawing.Point(133, 448);
            this.user_name_label.Name = "user_name_label";
            this.user_name_label.Size = new System.Drawing.Size(79, 16);
            this.user_name_label.TabIndex = 2;
            this.user_name_label.Text = "Username";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Reversi_Online.Properties.Resources.person;
            this.pictureBox2.Location = new System.Drawing.Point(76, 438);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Reversi_Online.Properties.Resources.person1;
            this.pictureBox1.Location = new System.Drawing.Point(76, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // opponents_timer_label
            // 
            this.opponents_timer_label.AutoSize = true;
            this.opponents_timer_label.BackColor = System.Drawing.Color.Black;
            this.opponents_timer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.opponents_timer_label.ForeColor = System.Drawing.Color.White;
            this.opponents_timer_label.Location = new System.Drawing.Point(344, 29);
            this.opponents_timer_label.Name = "opponents_timer_label";
            this.opponents_timer_label.Size = new System.Drawing.Size(54, 25);
            this.opponents_timer_label.TabIndex = 5;
            this.opponents_timer_label.Text = "0:00";
            // 
            // user_timer_label
            // 
            this.user_timer_label.AutoSize = true;
            this.user_timer_label.BackColor = System.Drawing.Color.Black;
            this.user_timer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.user_timer_label.ForeColor = System.Drawing.Color.White;
            this.user_timer_label.Location = new System.Drawing.Point(344, 451);
            this.user_timer_label.Name = "user_timer_label";
            this.user_timer_label.Size = new System.Drawing.Size(54, 25);
            this.user_timer_label.TabIndex = 6;
            this.user_timer_label.Text = "0:00";
            // 
            // opponents_stone_picturebox
            // 
            this.opponents_stone_picturebox.Location = new System.Drawing.Point(437, 20);
            this.opponents_stone_picturebox.Name = "opponents_stone_picturebox";
            this.opponents_stone_picturebox.Size = new System.Drawing.Size(40, 40);
            this.opponents_stone_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opponents_stone_picturebox.TabIndex = 7;
            this.opponents_stone_picturebox.TabStop = false;
            // 
            // user_stone_picturebox
            // 
            this.user_stone_picturebox.Location = new System.Drawing.Point(437, 438);
            this.user_stone_picturebox.Name = "user_stone_picturebox";
            this.user_stone_picturebox.Size = new System.Drawing.Size(40, 40);
            this.user_stone_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_stone_picturebox.TabIndex = 8;
            this.user_stone_picturebox.TabStop = false;
            // 
            // opponents_stones_amount_label
            // 
            this.opponents_stones_amount_label.AutoSize = true;
            this.opponents_stones_amount_label.Location = new System.Drawing.Point(494, 32);
            this.opponents_stones_amount_label.Name = "opponents_stones_amount_label";
            this.opponents_stones_amount_label.Size = new System.Drawing.Size(35, 13);
            this.opponents_stones_amount_label.TabIndex = 9;
            this.opponents_stones_amount_label.Text = "label1";
            // 
            // user_stones_amount_label
            // 
            this.user_stones_amount_label.AutoSize = true;
            this.user_stones_amount_label.Location = new System.Drawing.Point(494, 451);
            this.user_stones_amount_label.Name = "user_stones_amount_label";
            this.user_stones_amount_label.Size = new System.Drawing.Size(35, 13);
            this.user_stones_amount_label.TabIndex = 10;
            this.user_stones_amount_label.Text = "label2";
            // 
            // OverTheBoardGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 496);
            this.Controls.Add(this.user_stones_amount_label);
            this.Controls.Add(this.opponents_stones_amount_label);
            this.Controls.Add(this.user_stone_picturebox);
            this.Controls.Add(this.opponents_stone_picturebox);
            this.Controls.Add(this.user_timer_label);
            this.Controls.Add(this.opponents_timer_label);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.user_name_label);
            this.Controls.Add(this.opponents_name_label);
            this.Controls.Add(this.board_panel);
            this.Name = "OverTheBoardGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OverTheBoardGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OverTheBoardGame_FormClosed);
            this.Load += new System.EventHandler(this.OverTheBoardGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opponents_stone_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_stone_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel board_panel;
        private System.Windows.Forms.Label opponents_name_label;
        private System.Windows.Forms.Label user_name_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label opponents_timer_label;
        private System.Windows.Forms.Label user_timer_label;
        private System.Windows.Forms.PictureBox opponents_stone_picturebox;
        private System.Windows.Forms.PictureBox user_stone_picturebox;
        private System.Windows.Forms.Label opponents_stones_amount_label;
        private System.Windows.Forms.Label user_stones_amount_label;
    }
}