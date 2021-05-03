
namespace BlendHub {
    partial class About {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.txb_about = new System.Windows.Forms.RichTextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_logo
            // 
            this.pic_logo.Image = global::BlendHub.Properties.Resources.blendhublogo;
            this.pic_logo.Location = new System.Drawing.Point(12, 12);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(343, 166);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 10;
            this.pic_logo.TabStop = false;
            // 
            // txb_about
            // 
            this.txb_about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.txb_about.ForeColor = System.Drawing.SystemColors.Control;
            this.txb_about.Location = new System.Drawing.Point(12, 184);
            this.txb_about.Name = "txb_about";
            this.txb_about.ReadOnly = true;
            this.txb_about.Size = new System.Drawing.Size(343, 173);
            this.txb_about.TabIndex = 11;
            this.txb_about.Text = "LOAD HERE";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Cancel.Location = new System.Drawing.Point(12, 363);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(343, 34);
            this.btn_Cancel.TabIndex = 17;
            this.btn_Cancel.Text = "Poggers";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(374, 409);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.txb_about);
            this.Controls.Add(this.pic_logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.RichTextBox txb_about;
        private System.Windows.Forms.Button btn_Cancel;
    }
}