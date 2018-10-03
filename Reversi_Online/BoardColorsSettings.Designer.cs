namespace Reversi_Online
{
    partial class BoardColorsSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoardColorsSettings));
            this.demo_board_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.color_b_picturebox = new System.Windows.Forms.PictureBox();
            this.color_a_picturebox = new System.Windows.Forms.PictureBox();
            this.goback1 = new Reversi_Online.Goback();
            ((System.ComponentModel.ISupportInitialize)(this.color_b_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_a_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // demo_board_panel
            // 
            this.demo_board_panel.Location = new System.Drawing.Point(100, 36);
            this.demo_board_panel.Name = "demo_board_panel";
            this.demo_board_panel.Size = new System.Drawing.Size(200, 200);
            this.demo_board_panel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Color A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Color B:";
            // 
            // color_b_picturebox
            // 
            this.color_b_picturebox.Location = new System.Drawing.Point(250, 315);
            this.color_b_picturebox.Name = "color_b_picturebox";
            this.color_b_picturebox.Size = new System.Drawing.Size(25, 25);
            this.color_b_picturebox.TabIndex = 4;
            this.color_b_picturebox.TabStop = false;
            this.color_b_picturebox.Click += new System.EventHandler(this.color_b_picturebox_Click);
            // 
            // color_a_picturebox
            // 
            this.color_a_picturebox.Location = new System.Drawing.Point(250, 266);
            this.color_a_picturebox.Name = "color_a_picturebox";
            this.color_a_picturebox.Size = new System.Drawing.Size(25, 25);
            this.color_a_picturebox.TabIndex = 3;
            this.color_a_picturebox.TabStop = false;
            this.color_a_picturebox.Click += new System.EventHandler(this.color_a_picturebox_Click);
            // 
            // goback1
            // 
            this.goback1.BackColor = System.Drawing.Color.White;
            this.goback1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goback1.BackgroundImage")));
            this.goback1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goback1.Location = new System.Drawing.Point(142, 379);
            this.goback1.Name = "goback1";
            this.goback1.Size = new System.Drawing.Size(111, 33);
            this.goback1.TabIndex = 5;
            // 
            // BoardColorsSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 498);
            this.Controls.Add(this.goback1);
            this.Controls.Add(this.color_b_picturebox);
            this.Controls.Add(this.color_a_picturebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.demo_board_panel);
            this.Name = "BoardColorsSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoardColorsSettings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BoardColorsSettings_FormClosed);
            this.Load += new System.EventHandler(this.BoardColorsSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.color_b_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_a_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel demo_board_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox color_a_picturebox;
        private System.Windows.Forms.PictureBox color_b_picturebox;
        private Goback goback1;
    }
}