namespace Reversi_Online
{
    partial class Info
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.message_label = new System.Windows.Forms.Label();
            this.x_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // message_label
            // 
            this.message_label.BackColor = System.Drawing.Color.Black;
            this.message_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.message_label.ForeColor = System.Drawing.SystemColors.Control;
            this.message_label.Location = new System.Drawing.Point(0, 0);
            this.message_label.Name = "message_label";
            this.message_label.Size = new System.Drawing.Size(150, 30);
            this.message_label.TabIndex = 0;
            this.message_label.Text = "label1";
            this.message_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // x_label
            // 
            this.x_label.BackColor = System.Drawing.Color.Black;
            this.x_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.x_label.ForeColor = System.Drawing.SystemColors.Control;
            this.x_label.Location = new System.Drawing.Point(150, 0);
            this.x_label.Name = "x_label";
            this.x_label.Size = new System.Drawing.Size(30, 30);
            this.x_label.TabIndex = 1;
            this.x_label.Text = "x";
            this.x_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.x_label.MouseHover += new System.EventHandler(this.x_label_MouseHover);
            this.x_label.MouseLeave += new System.EventHandler(this.x_label_MouseLeave);
            this.x_label.Click += new System.EventHandler(this.x_label_Click);

            // 
            // Info
            // 
            this.Controls.Add(this.x_label);
            this.Controls.Add(this.message_label);
            this.Name = "Info";
            this.Size = new System.Drawing.Size(180, 30);
            this.Resize += new System.EventHandler(this.Info_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label message_label;
        private System.Windows.Forms.Label x_label;         
    }
}
