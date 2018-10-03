namespace Reversi_Online
{
    partial class BoardSizeSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoardSizeSettings));
            this.demo_chessboard_panel = new System.Windows.Forms.Panel();
            this.board_width_trackbar = new System.Windows.Forms.TrackBar();
            this.board_height_trackbar = new System.Windows.Forms.TrackBar();
            this.board_size_indicator_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.goback1 = new Reversi_Online.Goback();
            ((System.ComponentModel.ISupportInitialize)(this.board_width_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.board_height_trackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // demo_chessboard_panel
            // 
            this.demo_chessboard_panel.Location = new System.Drawing.Point(103, 12);
            this.demo_chessboard_panel.Name = "demo_chessboard_panel";
            this.demo_chessboard_panel.Size = new System.Drawing.Size(200, 200);
            this.demo_chessboard_panel.TabIndex = 0;
            // 
            // board_width_trackbar
            // 
            this.board_width_trackbar.Location = new System.Drawing.Point(107, 312);
            this.board_width_trackbar.Maximum = 8;
            this.board_width_trackbar.Name = "board_width_trackbar";
            this.board_width_trackbar.Size = new System.Drawing.Size(196, 45);
            this.board_width_trackbar.TabIndex = 1;
            this.board_width_trackbar.Value = 2;
            this.board_width_trackbar.Scroll += new System.EventHandler(this.board_width_trackbar_Scroll);
            // 
            // board_height_trackbar
            // 
            this.board_height_trackbar.Location = new System.Drawing.Point(107, 366);
            this.board_height_trackbar.Maximum = 8;
            this.board_height_trackbar.Name = "board_height_trackbar";
            this.board_height_trackbar.Size = new System.Drawing.Size(196, 45);
            this.board_height_trackbar.TabIndex = 2;
            this.board_height_trackbar.Value = 2;
            this.board_height_trackbar.Scroll += new System.EventHandler(this.board_height_trackbar_Scroll);
            // 
            // board_size_indicator_label
            // 
            this.board_size_indicator_label.AutoSize = true;
            this.board_size_indicator_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.board_size_indicator_label.Location = new System.Drawing.Point(246, 272);
            this.board_size_indicator_label.Name = "board_size_indicator_label";
            this.board_size_indicator_label.Size = new System.Drawing.Size(47, 20);
            this.board_size_indicator_label.TabIndex = 3;
            this.board_size_indicator_label.Text = "8 x 8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selected board size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Height:";
            // 
            // goback1
            // 
            this.goback1.BackColor = System.Drawing.Color.White;
            this.goback1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goback1.BackgroundImage")));
            this.goback1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goback1.Location = new System.Drawing.Point(132, 451);
            this.goback1.Name = "goback1";
            this.goback1.Size = new System.Drawing.Size(141, 41);
            this.goback1.TabIndex = 7;
            // 
            // BoardSizeSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 517);
            this.Controls.Add(this.goback1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.board_size_indicator_label);
            this.Controls.Add(this.board_height_trackbar);
            this.Controls.Add(this.board_width_trackbar);
            this.Controls.Add(this.demo_chessboard_panel);
            this.Name = "BoardSizeSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoardSizeSettings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BoardSizeSettings_FormClosed);
            this.Load += new System.EventHandler(this.BoardSizeSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.board_width_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.board_height_trackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel demo_chessboard_panel;
        private System.Windows.Forms.TrackBar board_width_trackbar;
        private System.Windows.Forms.TrackBar board_height_trackbar;
        private System.Windows.Forms.Label board_size_indicator_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Goback goback1;
    }
}