
namespace BlendHub {
    partial class MainWindow {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "NAME",
            "VERSION",
            "DATE"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btn_AddProject = new System.Windows.Forms.Button();
            this.lbx_ProjectList = new System.Windows.Forms.ListView();
            this.lbx_col_ProjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbx_col_BlenderVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbx_col_Modified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_OpenProjectsFolder = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_OpenVersionManager = new System.Windows.Forms.Button();
            this.btn_OpenSettings = new System.Windows.Forms.Button();
            this.btn_OpenAbout = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.btn_EditProject = new System.Windows.Forms.Button();
            this.lbl_version = new System.Windows.Forms.Label();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AddProject
            // 
            this.btn_AddProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btn_AddProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddProject.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_AddProject.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_AddProject.Location = new System.Drawing.Point(239, 404);
            this.btn_AddProject.Name = "btn_AddProject";
            this.btn_AddProject.Size = new System.Drawing.Size(318, 34);
            this.btn_AddProject.TabIndex = 2;
            this.btn_AddProject.Text = "New Project";
            this.btn_AddProject.UseVisualStyleBackColor = false;
            this.btn_AddProject.Click += new System.EventHandler(this.btn_AddProject_Click);
            // 
            // lbx_ProjectList
            // 
            this.lbx_ProjectList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.lbx_ProjectList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lbx_col_ProjectName,
            this.lbx_col_BlenderVersion,
            this.lbx_col_Modified});
            this.lbx_ProjectList.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbx_ProjectList.ForeColor = System.Drawing.SystemColors.Window;
            this.lbx_ProjectList.HideSelection = false;
            this.lbx_ProjectList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
            this.lbx_ProjectList.Location = new System.Drawing.Point(239, 12);
            this.lbx_ProjectList.Name = "lbx_ProjectList";
            this.lbx_ProjectList.Size = new System.Drawing.Size(469, 389);
            this.lbx_ProjectList.TabIndex = 3;
            this.lbx_ProjectList.UseCompatibleStateImageBehavior = false;
            this.lbx_ProjectList.View = System.Windows.Forms.View.Details;
            this.lbx_ProjectList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbx_ProjectList_MouseDoubleClick);
            // 
            // lbx_col_ProjectName
            // 
            this.lbx_col_ProjectName.Text = "Name";
            this.lbx_col_ProjectName.Width = 178;
            // 
            // lbx_col_BlenderVersion
            // 
            this.lbx_col_BlenderVersion.Text = "Blender Version";
            this.lbx_col_BlenderVersion.Width = 133;
            // 
            // lbx_col_Modified
            // 
            this.lbx_col_Modified.Text = "Last Modified";
            this.lbx_col_Modified.Width = 152;
            // 
            // btn_OpenProjectsFolder
            // 
            this.btn_OpenProjectsFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btn_OpenProjectsFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OpenProjectsFolder.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_OpenProjectsFolder.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_OpenProjectsFolder.Location = new System.Drawing.Point(3, 43);
            this.btn_OpenProjectsFolder.Name = "btn_OpenProjectsFolder";
            this.btn_OpenProjectsFolder.Size = new System.Drawing.Size(226, 34);
            this.btn_OpenProjectsFolder.TabIndex = 4;
            this.btn_OpenProjectsFolder.Text = "Open Folder";
            this.btn_OpenProjectsFolder.UseVisualStyleBackColor = false;
            this.btn_OpenProjectsFolder.Click += new System.EventHandler(this.btn_OpenProjectsFolder_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_OpenVersionManager);
            this.flowLayoutPanel1.Controls.Add(this.btn_OpenProjectsFolder);
            this.flowLayoutPanel1.Controls.Add(this.btn_OpenSettings);
            this.flowLayoutPanel1.Controls.Add(this.btn_OpenAbout);
            this.flowLayoutPanel1.Controls.Add(this.btn_Quit);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 150);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(229, 251);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btn_OpenVersionManager
            // 
            this.btn_OpenVersionManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btn_OpenVersionManager.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OpenVersionManager.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_OpenVersionManager.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_OpenVersionManager.Location = new System.Drawing.Point(3, 3);
            this.btn_OpenVersionManager.Name = "btn_OpenVersionManager";
            this.btn_OpenVersionManager.Size = new System.Drawing.Size(226, 34);
            this.btn_OpenVersionManager.TabIndex = 5;
            this.btn_OpenVersionManager.Text = "Manage Versions";
            this.btn_OpenVersionManager.UseVisualStyleBackColor = false;
            this.btn_OpenVersionManager.Click += new System.EventHandler(this.btn_OpenVersionManager_Click);
            // 
            // btn_OpenSettings
            // 
            this.btn_OpenSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btn_OpenSettings.Enabled = false;
            this.btn_OpenSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OpenSettings.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_OpenSettings.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_OpenSettings.Location = new System.Drawing.Point(3, 83);
            this.btn_OpenSettings.Name = "btn_OpenSettings";
            this.btn_OpenSettings.Size = new System.Drawing.Size(226, 34);
            this.btn_OpenSettings.TabIndex = 6;
            this.btn_OpenSettings.Text = "Settings";
            this.btn_OpenSettings.UseVisualStyleBackColor = false;
            // 
            // btn_OpenAbout
            // 
            this.btn_OpenAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btn_OpenAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OpenAbout.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_OpenAbout.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_OpenAbout.Location = new System.Drawing.Point(3, 123);
            this.btn_OpenAbout.Name = "btn_OpenAbout";
            this.btn_OpenAbout.Size = new System.Drawing.Size(226, 34);
            this.btn_OpenAbout.TabIndex = 8;
            this.btn_OpenAbout.Text = "About";
            this.btn_OpenAbout.UseVisualStyleBackColor = false;
            this.btn_OpenAbout.Click += new System.EventHandler(this.btn_OpenAbout_Click);
            // 
            // btn_Quit
            // 
            this.btn_Quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btn_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Quit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Quit.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Quit.Location = new System.Drawing.Point(3, 163);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(226, 34);
            this.btn_Quit.TabIndex = 7;
            this.btn_Quit.Text = "Exit";
            this.btn_Quit.UseVisualStyleBackColor = false;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // btn_EditProject
            // 
            this.btn_EditProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btn_EditProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EditProject.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_EditProject.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_EditProject.Location = new System.Drawing.Point(563, 404);
            this.btn_EditProject.Name = "btn_EditProject";
            this.btn_EditProject.Size = new System.Drawing.Size(145, 34);
            this.btn_EditProject.TabIndex = 7;
            this.btn_EditProject.Text = "Edit Project";
            this.btn_EditProject.UseVisualStyleBackColor = false;
            this.btn_EditProject.Click += new System.EventHandler(this.btn_RemoveProject_Click);
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_version.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_version.Location = new System.Drawing.Point(35, 411);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(159, 18);
            this.lbl_version.TabIndex = 8;
            this.lbl_version.Text = "BlendHub v0.1.0 Beta";
            this.lbl_version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_logo
            // 
            this.pic_logo.Image = global::BlendHub.Properties.Resources.blendhublogo;
            this.pic_logo.Location = new System.Drawing.Point(4, 12);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(229, 135);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 9;
            this.pic_logo.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.btn_EditProject);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbx_ProjectList);
            this.Controls.Add(this.btn_AddProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "BlendHub";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_AddProject;
        private System.Windows.Forms.ListView lbx_ProjectList;
        private System.Windows.Forms.ColumnHeader lbx_col_ProjectName;
        private System.Windows.Forms.ColumnHeader lbx_col_BlenderVersion;
        private System.Windows.Forms.ColumnHeader lbx_col_Modified;
        private System.Windows.Forms.Button btn_OpenProjectsFolder;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_OpenVersionManager;
        private System.Windows.Forms.Button btn_OpenSettings;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.Button btn_OpenAbout;
        private System.Windows.Forms.Button btn_EditProject;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.PictureBox pic_logo;
    }
}

