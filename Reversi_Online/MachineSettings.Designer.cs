namespace Reversi_Online
{
    partial class MachineSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MachineSettings));
            this.machine_level_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.machine_level_trackbar = new System.Windows.Forms.TrackBar();
            this.play_vs_machine_button = new System.Windows.Forms.Button();
            this.robot_picturebox = new System.Windows.Forms.PictureBox();
            this.stone_picturebox = new System.Windows.Forms.PictureBox();
            this.goback1 = new Reversi_Online.Goback();
            ((System.ComponentModel.ISupportInitialize)(this.machine_level_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robot_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // machine_level_label
            // 
            this.machine_level_label.AutoSize = true;
            this.machine_level_label.Font = new System.Drawing.Font("Comic Sans MS", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.machine_level_label.ForeColor = System.Drawing.Color.RoyalBlue;
            this.machine_level_label.Location = new System.Drawing.Point(363, 131);
            this.machine_level_label.Name = "machine_level_label";
            this.machine_level_label.Size = new System.Drawing.Size(77, 90);
            this.machine_level_label.TabIndex = 8;
            this.machine_level_label.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select machine level:";
            // 
            // machine_level_trackbar
            // 
            this.machine_level_trackbar.Location = new System.Drawing.Point(24, 347);
            this.machine_level_trackbar.Maximum = 3;
            this.machine_level_trackbar.Name = "machine_level_trackbar";
            this.machine_level_trackbar.Size = new System.Drawing.Size(299, 45);
            this.machine_level_trackbar.TabIndex = 5;
            this.machine_level_trackbar.ValueChanged += new System.EventHandler(this.machine_level_trackbar_ValueChanged);
            // 
            // play_vs_machine_button
            // 
            this.play_vs_machine_button.BackColor = System.Drawing.Color.DarkGreen;
            this.play_vs_machine_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.play_vs_machine_button.ForeColor = System.Drawing.Color.White;
            this.play_vs_machine_button.Location = new System.Drawing.Point(209, 456);
            this.play_vs_machine_button.Name = "play_vs_machine_button";
            this.play_vs_machine_button.Size = new System.Drawing.Size(114, 37);
            this.play_vs_machine_button.TabIndex = 10;
            this.play_vs_machine_button.Text = "Play";
            this.play_vs_machine_button.UseVisualStyleBackColor = false;
            this.play_vs_machine_button.Click += new System.EventHandler(this.play_vs_machine_button_Click);
            // 
            // robot_picturebox
            // 
            this.robot_picturebox.Image = global::Reversi_Online.Properties.Resources.robot;
            this.robot_picturebox.Location = new System.Drawing.Point(24, 53);
            this.robot_picturebox.Name = "robot_picturebox";
            this.robot_picturebox.Size = new System.Drawing.Size(299, 251);
            this.robot_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.robot_picturebox.TabIndex = 6;
            this.robot_picturebox.TabStop = false;
            // 
            // stone_picturebox
            // 
            this.stone_picturebox.Location = new System.Drawing.Point(342, 456);
            this.stone_picturebox.Name = "stone_picturebox";
            this.stone_picturebox.Size = new System.Drawing.Size(37, 37);
            this.stone_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stone_picturebox.TabIndex = 12;
            this.stone_picturebox.TabStop = false;
            this.stone_picturebox.Click += new System.EventHandler(this.stone_picturebox_Click);
            // 
            // goback1
            // 
            this.goback1.BackColor = System.Drawing.Color.White;
            this.goback1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goback1.BackgroundImage")));
            this.goback1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goback1.Location = new System.Drawing.Point(40, 456);
            this.goback1.Name = "goback1";
            this.goback1.Size = new System.Drawing.Size(111, 37);
            this.goback1.TabIndex = 11;
            // 
            // MachineSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 517);
            this.Controls.Add(this.stone_picturebox);
            this.Controls.Add(this.goback1);
            this.Controls.Add(this.play_vs_machine_button);
            this.Controls.Add(this.machine_level_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.robot_picturebox);
            this.Controls.Add(this.machine_level_trackbar);
            this.Name = "MachineSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MachineSettings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MachineSettings_FormClosed);
            this.Load += new System.EventHandler(this.MachineSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.machine_level_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robot_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label machine_level_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox robot_picturebox;
        private System.Windows.Forms.TrackBar machine_level_trackbar;
        private System.Windows.Forms.Button play_vs_machine_button;
        private Goback goback1;
        private System.Windows.Forms.PictureBox stone_picturebox;
    }
}