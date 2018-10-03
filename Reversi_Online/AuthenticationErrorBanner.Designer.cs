namespace Reversi_Online
{
    partial class AuthenticationErrorBanner
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
            this.error_message_label = new System.Windows.Forms.Label();
            this.error_picturebox = new System.Windows.Forms.PictureBox();
            this.closer1 = new Reversi_Online.Closer();
            ((System.ComponentModel.ISupportInitialize)(this.error_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // error_message_label
            // 
            this.error_message_label.BackColor = System.Drawing.SystemColors.Control;
            this.error_message_label.Font = new System.Drawing.Font("News701 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_message_label.ForeColor = System.Drawing.Color.Red;
            this.error_message_label.Location = new System.Drawing.Point(40, 27);
            this.error_message_label.Name = "error_message_label";
            this.error_message_label.Size = new System.Drawing.Size(311, 58);
            this.error_message_label.TabIndex = 1;
            this.error_message_label.Text = "closer1";
            // 
            // error_picturebox
            // 
            this.error_picturebox.Image = global::Reversi_Online.Properties.Resources.noconnection;
            this.error_picturebox.Location = new System.Drawing.Point(44, 134);
            this.error_picturebox.Name = "error_picturebox";
            this.error_picturebox.Size = new System.Drawing.Size(321, 212);
            this.error_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.error_picturebox.TabIndex = 0;
            this.error_picturebox.TabStop = false;
            // 
            // closer1
            // 
            this.closer1.Location = new System.Drawing.Point(134, 384);
            this.closer1.Name = "closer1";
            this.closer1.ShowOwnerForm = false;
            this.closer1.Size = new System.Drawing.Size(150, 47);
            this.closer1.TabIndex = 2;
            // 
            // AuthenticationErrorBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 447);
            this.Controls.Add(this.closer1);
            this.Controls.Add(this.error_message_label);
            this.Controls.Add(this.error_picturebox);
            this.Name = "AuthenticationErrorBanner";
            this.Text = "AuthenticationErrorBanner";
            this.Load += new System.EventHandler(this.AuthenticationErrorBanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error_picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox error_picturebox;
        private System.Windows.Forms.Label error_message_label;
        private Closer closer1;
    }
}