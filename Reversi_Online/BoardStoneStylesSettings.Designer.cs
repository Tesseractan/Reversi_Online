namespace Reversi_Online
{
    partial class BoardStoneStylesSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoardStoneStylesSettings));
            this.demo_board_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.goback1 = new Reversi_Online.Goback();
            this.black_stone_style_picturebox = new System.Windows.Forms.PictureBox();
            this.white_stone_style_picturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.black_stone_style_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.white_stone_style_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // demo_board_panel
            // 
            this.demo_board_panel.Location = new System.Drawing.Point(111, 26);
            this.demo_board_panel.Name = "demo_board_panel";
            this.demo_board_panel.Size = new System.Drawing.Size(200, 200);
            this.demo_board_panel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "White stone style:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Black stone style:";
            // 
            // goback1
            // 
            this.goback1.BackColor = System.Drawing.Color.White;
            this.goback1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goback1.BackgroundImage")));
            this.goback1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goback1.Location = new System.Drawing.Point(162, 406);
            this.goback1.Name = "goback1";
            this.goback1.Size = new System.Drawing.Size(98, 27);
            this.goback1.TabIndex = 5;
            // 
            // black_stone_style_picturebox
            // 
            this.black_stone_style_picturebox.Location = new System.Drawing.Point(267, 325);
            this.black_stone_style_picturebox.Name = "black_stone_style_picturebox";
            this.black_stone_style_picturebox.Size = new System.Drawing.Size(30, 30);
            this.black_stone_style_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.black_stone_style_picturebox.TabIndex = 4;
            this.black_stone_style_picturebox.TabStop = false;
            this.black_stone_style_picturebox.Click += new System.EventHandler(this.black_stone_style_picturebox_Click);
            // 
            // white_stone_style_picturebox
            // 
            this.white_stone_style_picturebox.Location = new System.Drawing.Point(267, 276);
            this.white_stone_style_picturebox.Name = "white_stone_style_picturebox";
            this.white_stone_style_picturebox.Size = new System.Drawing.Size(30, 30);
            this.white_stone_style_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.white_stone_style_picturebox.TabIndex = 3;
            this.white_stone_style_picturebox.TabStop = false;
            this.white_stone_style_picturebox.Click += new System.EventHandler(this.white_stone_style_picturebox_Click);
            // 
            // BoardStoneStylesSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 481);
            this.Controls.Add(this.goback1);
            this.Controls.Add(this.black_stone_style_picturebox);
            this.Controls.Add(this.white_stone_style_picturebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.demo_board_panel);
            this.Name = "BoardStoneStylesSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoardStoneStylesSettings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BoardStoneStylesSettings_FormClosed);
            this.Load += new System.EventHandler(this.BoardStoneStylesSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.black_stone_style_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.white_stone_style_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel demo_board_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox white_stone_style_picturebox;
        private System.Windows.Forms.PictureBox black_stone_style_picturebox;
        private Goback goback1;
    }
}