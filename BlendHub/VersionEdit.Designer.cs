
namespace BlendHub {
    partial class VersionEdit {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VersionEdit));
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_CreateProject = new System.Windows.Forms.Button();
            this.tbx_ProjectName = new System.Windows.Forms.TextBox();
            this.cbx_VersionSelect = new System.Windows.Forms.ComboBox();
            this.btn_RemoveProject = new System.Windows.Forms.Button();
            this.btn_OpenFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_2.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_2.Location = new System.Drawing.Point(15, 19);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(103, 18);
            this.lbl_2.TabIndex = 18;
            this.lbl_2.Text = "Project Name";
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_1.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_1.Location = new System.Drawing.Point(15, 84);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(122, 18);
            this.lbl_1.TabIndex = 17;
            this.lbl_1.Text = "Blender Version";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Cancel.Location = new System.Drawing.Point(18, 195);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(119, 34);
            this.btn_Cancel.TabIndex = 16;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_CreateProject
            // 
            this.btn_CreateProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btn_CreateProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CreateProject.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_CreateProject.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_CreateProject.Location = new System.Drawing.Point(143, 195);
            this.btn_CreateProject.Name = "btn_CreateProject";
            this.btn_CreateProject.Size = new System.Drawing.Size(213, 34);
            this.btn_CreateProject.TabIndex = 15;
            this.btn_CreateProject.Text = "Save";
            this.btn_CreateProject.UseVisualStyleBackColor = false;
            this.btn_CreateProject.Click += new System.EventHandler(this.btn_CreateProject_Click);
            // 
            // tbx_ProjectName
            // 
            this.tbx_ProjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.tbx_ProjectName.Enabled = false;
            this.tbx_ProjectName.Font = new System.Drawing.Font("Arial", 18F);
            this.tbx_ProjectName.ForeColor = System.Drawing.SystemColors.Control;
            this.tbx_ProjectName.Location = new System.Drawing.Point(18, 40);
            this.tbx_ProjectName.Name = "tbx_ProjectName";
            this.tbx_ProjectName.Size = new System.Drawing.Size(338, 35);
            this.tbx_ProjectName.TabIndex = 14;
            // 
            // cbx_VersionSelect
            // 
            this.cbx_VersionSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbx_VersionSelect.Font = new System.Drawing.Font("Arial", 11F);
            this.cbx_VersionSelect.ForeColor = System.Drawing.SystemColors.Control;
            this.cbx_VersionSelect.FormattingEnabled = true;
            this.cbx_VersionSelect.Location = new System.Drawing.Point(143, 81);
            this.cbx_VersionSelect.Name = "cbx_VersionSelect";
            this.cbx_VersionSelect.Size = new System.Drawing.Size(213, 25);
            this.cbx_VersionSelect.TabIndex = 13;
            // 
            // btn_RemoveProject
            // 
            this.btn_RemoveProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btn_RemoveProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RemoveProject.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_RemoveProject.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_RemoveProject.Location = new System.Drawing.Point(237, 127);
            this.btn_RemoveProject.Name = "btn_RemoveProject";
            this.btn_RemoveProject.Size = new System.Drawing.Size(119, 22);
            this.btn_RemoveProject.TabIndex = 19;
            this.btn_RemoveProject.Text = "Remove";
            this.btn_RemoveProject.UseVisualStyleBackColor = false;
            this.btn_RemoveProject.Click += new System.EventHandler(this.btn_RemoveProject_Click);
            // 
            // btn_OpenFolder
            // 
            this.btn_OpenFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btn_OpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OpenFolder.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_OpenFolder.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_OpenFolder.Location = new System.Drawing.Point(18, 127);
            this.btn_OpenFolder.Name = "btn_OpenFolder";
            this.btn_OpenFolder.Size = new System.Drawing.Size(213, 22);
            this.btn_OpenFolder.TabIndex = 20;
            this.btn_OpenFolder.Text = "Open Folder";
            this.btn_OpenFolder.UseVisualStyleBackColor = false;
            this.btn_OpenFolder.Click += new System.EventHandler(this.btn_OpenFolder_Click);
            // 
            // VersionEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(373, 252);
            this.Controls.Add(this.btn_OpenFolder);
            this.Controls.Add(this.btn_RemoveProject);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_CreateProject);
            this.Controls.Add(this.tbx_ProjectName);
            this.Controls.Add(this.cbx_VersionSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VersionEdit";
            this.Text = "Edit Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_CreateProject;
        private System.Windows.Forms.TextBox tbx_ProjectName;
        private System.Windows.Forms.ComboBox cbx_VersionSelect;
        private System.Windows.Forms.Button btn_RemoveProject;
        private System.Windows.Forms.Button btn_OpenFolder;
    }
}