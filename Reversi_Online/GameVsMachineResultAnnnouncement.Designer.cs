namespace Reversi_Online
{
    partial class GameVsMachineResultAnnnouncement
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
            this.game_result_label = new System.Windows.Forms.Label();
            this.description_label = new System.Windows.Forms.Label();
            this.black_name_and_score_label = new System.Windows.Forms.Label();
            this.white_name_and_score_label = new System.Windows.Forms.Label();
            this.white_stone_picturebox = new System.Windows.Forms.PictureBox();
            this.black_stone_picturebox = new System.Windows.Forms.PictureBox();
            this.game_result_picturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.white_stone_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.black_stone_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_result_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // game_result_label
            // 
            this.game_result_label.AutoSize = true;
            this.game_result_label.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.game_result_label.Location = new System.Drawing.Point(24, 13);
            this.game_result_label.Name = "game_result_label";
            this.game_result_label.Size = new System.Drawing.Size(136, 29);
            this.game_result_label.TabIndex = 0;
            this.game_result_label.Text = "game_result";
            // 
            // description_label
            // 
            this.description_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.description_label.ForeColor = System.Drawing.Color.DimGray;
            this.description_label.Location = new System.Drawing.Point(26, 42);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(377, 49);
            this.description_label.TabIndex = 1;
            this.description_label.Text = "description";
            // 
            // black_name_and_score_label
            // 
            this.black_name_and_score_label.AutoSize = true;
            this.black_name_and_score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.black_name_and_score_label.ForeColor = System.Drawing.Color.Maroon;
            this.black_name_and_score_label.Location = new System.Drawing.Point(129, 427);
            this.black_name_and_score_label.Name = "black_name_and_score_label";
            this.black_name_and_score_label.Size = new System.Drawing.Size(51, 16);
            this.black_name_and_score_label.TabIndex = 5;
            this.black_name_and_score_label.Text = "label1";
            // 
            // white_name_and_score_label
            // 
            this.white_name_and_score_label.AutoSize = true;
            this.white_name_and_score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.white_name_and_score_label.ForeColor = System.Drawing.Color.Maroon;
            this.white_name_and_score_label.Location = new System.Drawing.Point(129, 474);
            this.white_name_and_score_label.Name = "white_name_and_score_label";
            this.white_name_and_score_label.Size = new System.Drawing.Size(51, 16);
            this.white_name_and_score_label.TabIndex = 6;
            this.white_name_and_score_label.Text = "label2";
            // 
            // white_stone_picturebox
            // 
            this.white_stone_picturebox.Location = new System.Drawing.Point(72, 464);
            this.white_stone_picturebox.Name = "white_stone_picturebox";
            this.white_stone_picturebox.Size = new System.Drawing.Size(40, 40);
            this.white_stone_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.white_stone_picturebox.TabIndex = 4;
            this.white_stone_picturebox.TabStop = false;
            // 
            // black_stone_picturebox
            // 
            this.black_stone_picturebox.Location = new System.Drawing.Point(72, 414);
            this.black_stone_picturebox.Name = "black_stone_picturebox";
            this.black_stone_picturebox.Size = new System.Drawing.Size(40, 40);
            this.black_stone_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.black_stone_picturebox.TabIndex = 3;
            this.black_stone_picturebox.TabStop = false;
            // 
            // game_result_picturebox
            // 
            this.game_result_picturebox.BackColor = System.Drawing.SystemColors.Control;
            this.game_result_picturebox.Location = new System.Drawing.Point(29, 112);
            this.game_result_picturebox.Name = "game_result_picturebox";
            this.game_result_picturebox.Size = new System.Drawing.Size(374, 296);
            this.game_result_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.game_result_picturebox.TabIndex = 2;
            this.game_result_picturebox.TabStop = false;
            // 
            // GameVsMachineResultAnnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 516);
            this.Controls.Add(this.white_name_and_score_label);
            this.Controls.Add(this.black_name_and_score_label);
            this.Controls.Add(this.white_stone_picturebox);
            this.Controls.Add(this.black_stone_picturebox);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.game_result_label);
            this.Controls.Add(this.game_result_picturebox);
            this.Name = "GameVsMachineResultAnnnouncement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The game is over!";
            this.Load += new System.EventHandler(this.GameVsMachineResultAnnnouncement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.white_stone_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.black_stone_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_result_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label game_result_label;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.PictureBox game_result_picturebox;
        private System.Windows.Forms.PictureBox black_stone_picturebox;
        private System.Windows.Forms.PictureBox white_stone_picturebox;
        private System.Windows.Forms.Label black_name_and_score_label;
        private System.Windows.Forms.Label white_name_and_score_label;
    }
}