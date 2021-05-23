
namespace BlendHub {
    partial class VersionManager {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VersionManager));
            this.lbx_Versions = new System.Windows.Forms.ListBox();
            this.btn_InstallZip = new System.Windows.Forms.Button();
            this.dlg_openArchive = new System.Windows.Forms.OpenFileDialog();
            this.btn_LocateInstall = new System.Windows.Forms.Button();
            this.btn_InstallWeb = new System.Windows.Forms.Button();
            this.btn_RemoveVersion = new System.Windows.Forms.Button();
            this.dlg_openExe = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lbx_Versions
            // 
            this.lbx_Versions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.lbx_Versions.ForeColor = System.Drawing.SystemColors.Control;
            this.lbx_Versions.FormattingEnabled = true;
            this.lbx_Versions.Location = new System.Drawing.Point(12, 12);
            this.lbx_Versions.Name = "lbx_Versions";
            this.lbx_Versions.Size = new System.Drawing.Size(290, 199);
            this.lbx_Versions.TabIndex = 0;
            // 
            // btn_InstallZip
            // 
            this.btn_InstallZip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btn_InstallZip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_InstallZip.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_InstallZip.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_InstallZip.Location = new System.Drawing.Point(308, 78);
            this.btn_InstallZip.Name = "btn_InstallZip";
            this.btn_InstallZip.Size = new System.Drawing.Size(215, 27);
            this.btn_InstallZip.TabIndex = 6;
            this.btn_InstallZip.Text = "Version from ZIP";
            this.btn_InstallZip.UseVisualStyleBackColor = false;
            this.btn_InstallZip.Click += new System.EventHandler(this.btn_InstallZip_Click);
            // 
            // dlg_openArchive
            // 
            this.dlg_openArchive.FileName = "Archive";
            this.dlg_openArchive.Filter = "ZIP Archives |*.zip";
            this.dlg_openArchive.Title = "Open Blender";
            // 
            // btn_LocateInstall
            // 
            this.btn_LocateInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btn_LocateInstall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_LocateInstall.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_LocateInstall.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_LocateInstall.Location = new System.Drawing.Point(308, 111);
            this.btn_LocateInstall.Name = "btn_LocateInstall";
            this.btn_LocateInstall.Size = new System.Drawing.Size(215, 27);
            this.btn_LocateInstall.TabIndex = 7;
            this.btn_LocateInstall.Text = "Locate version";
            this.btn_LocateInstall.UseVisualStyleBackColor = false;
            this.btn_LocateInstall.Click += new System.EventHandler(this.btn_LocateInstall_Click);
            // 
            // btn_InstallWeb
            // 
            this.btn_InstallWeb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btn_InstallWeb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_InstallWeb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_InstallWeb.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_InstallWeb.Location = new System.Drawing.Point(308, 19);
            this.btn_InstallWeb.Name = "btn_InstallWeb";
            this.btn_InstallWeb.Size = new System.Drawing.Size(215, 34);
            this.btn_InstallWeb.TabIndex = 8;
            this.btn_InstallWeb.Text = "Download version";
            this.btn_InstallWeb.UseVisualStyleBackColor = false;
            this.btn_InstallWeb.Click += new System.EventHandler(this.btn_InstallWeb_Click);
            // 
            // btn_RemoveVersion
            // 
            this.btn_RemoveVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btn_RemoveVersion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RemoveVersion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_RemoveVersion.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_RemoveVersion.Location = new System.Drawing.Point(308, 177);
            this.btn_RemoveVersion.Name = "btn_RemoveVersion";
            this.btn_RemoveVersion.Size = new System.Drawing.Size(215, 34);
            this.btn_RemoveVersion.TabIndex = 9;
            this.btn_RemoveVersion.Text = "Remove version";
            this.btn_RemoveVersion.UseVisualStyleBackColor = false;
            this.btn_RemoveVersion.Click += new System.EventHandler(this.btn_RemoveVersion_Click);
            // 
            // dlg_openExe
            // 
            this.dlg_openExe.FileName = "blender.exe";
            this.dlg_openExe.Filter = "Blender Executables | blender.exe";
            this.dlg_openExe.Title = "Open Blender";
            // 
            // VersionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(535, 224);
            this.Controls.Add(this.btn_RemoveVersion);
            this.Controls.Add(this.btn_InstallZip);
            this.Controls.Add(this.btn_LocateInstall);
            this.Controls.Add(this.btn_InstallWeb);
            this.Controls.Add(this.lbx_Versions);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VersionManager";
            this.Text = "Version Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_Versions;
        private System.Windows.Forms.Button btn_InstallZip;
        private System.Windows.Forms.OpenFileDialog dlg_openArchive;
        private System.Windows.Forms.Button btn_LocateInstall;
        private System.Windows.Forms.Button btn_InstallWeb;
        private System.Windows.Forms.Button btn_RemoveVersion;
        private System.Windows.Forms.OpenFileDialog dlg_openExe;
    }
}