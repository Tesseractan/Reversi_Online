namespace Reversi_Online
{
    partial class GameVsMachine
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.computer_name_label = new System.Windows.Forms.Label();
            this.user_name_label = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.computer_stone_picturebox = new System.Windows.Forms.PictureBox();
            this.user_stone_picturebox = new System.Windows.Forms.PictureBox();
            this.computer_stones_amount_label = new System.Windows.Forms.Label();
            this.user_stones_amount_label = new System.Windows.Forms.Label();
            this.user_moves_picturebox = new System.Windows.Forms.PictureBox();
            this.computer_moves_picturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer_stone_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_stone_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_moves_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer_moves_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // board_panel
            // 
            this.board_panel.Location = new System.Drawing.Point(55, 92);
            this.board_panel.Name = "board_panel";
            this.board_panel.Size = new System.Drawing.Size(350, 346);
            this.board_panel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Reversi_Online.Properties.Resources.robot;
            this.pictureBox1.Location = new System.Drawing.Point(55, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Reversi_Online.Properties.Resources.person;
            this.pictureBox2.Location = new System.Drawing.Point(55, 461);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // computer_name_label
            // 
            this.computer_name_label.AutoSize = true;
            this.computer_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.computer_name_label.Location = new System.Drawing.Point(140, 44);
            this.computer_name_label.Name = "computer_name_label";
            this.computer_name_label.Size = new System.Drawing.Size(74, 16);
            this.computer_name_label.TabIndex = 3;
            this.computer_name_label.Text = "Computer";
            // 
            // user_name_label
            // 
            this.user_name_label.AutoSize = true;
            this.user_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.user_name_label.Location = new System.Drawing.Point(113, 473);
            this.user_name_label.Name = "user_name_label";
            this.user_name_label.Size = new System.Drawing.Size(35, 16);
            this.user_name_label.TabIndex = 4;
            this.user_name_label.Text = "You";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(-358, -170);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // computer_stone_picturebox
            // 
            this.computer_stone_picturebox.Location = new System.Drawing.Point(365, 29);
            this.computer_stone_picturebox.Name = "computer_stone_picturebox";
            this.computer_stone_picturebox.Size = new System.Drawing.Size(40, 40);
            this.computer_stone_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computer_stone_picturebox.TabIndex = 6;
            this.computer_stone_picturebox.TabStop = false;
            // 
            // user_stone_picturebox
            // 
            this.user_stone_picturebox.Location = new System.Drawing.Point(365, 461);
            this.user_stone_picturebox.Name = "user_stone_picturebox";
            this.user_stone_picturebox.Size = new System.Drawing.Size(40, 40);
            this.user_stone_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_stone_picturebox.TabIndex = 7;
            this.user_stone_picturebox.TabStop = false;
            // 
            // computer_stones_amount_label
            // 
            this.computer_stones_amount_label.AutoSize = true;
            this.computer_stones_amount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.computer_stones_amount_label.Location = new System.Drawing.Point(332, 44);
            this.computer_stones_amount_label.Name = "computer_stones_amount_label";
            this.computer_stones_amount_label.Size = new System.Drawing.Size(16, 16);
            this.computer_stones_amount_label.TabIndex = 8;
            this.computer_stones_amount_label.Text = "0";
            // 
            // user_stones_amount_label
            // 
            this.user_stones_amount_label.AutoSize = true;
            this.user_stones_amount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.user_stones_amount_label.Location = new System.Drawing.Point(332, 473);
            this.user_stones_amount_label.Name = "user_stones_amount_label";
            this.user_stones_amount_label.Size = new System.Drawing.Size(16, 16);
            this.user_stones_amount_label.TabIndex = 9;
            this.user_stones_amount_label.Text = "0";
            // 
            // user_moves_picturebox
            // 
            this.user_moves_picturebox.BackColor = System.Drawing.SystemColors.Control;
            this.user_moves_picturebox.Location = new System.Drawing.Point(430, 461);
            this.user_moves_picturebox.Name = "user_moves_picturebox";
            this.user_moves_picturebox.Size = new System.Drawing.Size(87, 40);
            this.user_moves_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_moves_picturebox.TabIndex = 10;
            this.user_moves_picturebox.TabStop = false;
            // 
            // computer_moves_picturebox
            // 
            this.computer_moves_picturebox.BackColor = System.Drawing.SystemColors.Control;
            this.computer_moves_picturebox.Location = new System.Drawing.Point(430, 29);
            this.computer_moves_picturebox.Name = "computer_moves_picturebox";
            this.computer_moves_picturebox.Size = new System.Drawing.Size(87, 40);
            this.computer_moves_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computer_moves_picturebox.TabIndex = 11;
            this.computer_moves_picturebox.TabStop = false;
            // 
            // GameVsMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(529, 523);
            this.Controls.Add(this.computer_moves_picturebox);
            this.Controls.Add(this.user_moves_picturebox);
            this.Controls.Add(this.user_stones_amount_label);
            this.Controls.Add(this.computer_stones_amount_label);
            this.Controls.Add(this.user_stone_picturebox);
            this.Controls.Add(this.computer_stone_picturebox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.user_name_label);
            this.Controls.Add(this.computer_name_label);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.board_panel);
            this.Name = "GameVsMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameVsMachine";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameVsMachine_FormClosed);
            this.Load += new System.EventHandler(this.GameVsMachine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer_stone_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_stone_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_moves_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer_moves_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel board_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label computer_name_label;
        private System.Windows.Forms.Label user_name_label;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox computer_stone_picturebox;
        private System.Windows.Forms.PictureBox user_stone_picturebox;
        private System.Windows.Forms.Label computer_stones_amount_label;
        private System.Windows.Forms.Label user_stones_amount_label;
        private System.Windows.Forms.PictureBox user_moves_picturebox;
        private System.Windows.Forms.PictureBox computer_moves_picturebox;
    }
}