
namespace BlendHub {
    partial class CreateProjectWindow {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProjectWindow));
            this.cbx_VersionSelect = new System.Windows.Forms.ComboBox();
            this.tbx_ProjectName = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_CreateProject = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbx_VersionSelect
            // 
            this.cbx_VersionSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbx_VersionSelect.Font = new System.Drawing.Font("Arial", 11F);
            this.cbx_VersionSelect.ForeColor = System.Drawing.SystemColors.Control;
            this.cbx_VersionSelect.FormattingEnabled = true;
            this.cbx_VersionSelect.Location = new System.Drawing.Point(370, 115);
            this.cbx_VersionSelect.Name = "cbx_VersionSelect";
            this.cbx_VersionSelect.Size = new System.Drawing.Size(213, 25);
            this.cbx_VersionSelect.TabIndex = 0;
            // 
            // tbx_ProjectName
            // 
            this.tbx_ProjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.tbx_ProjectName.Font = new System.Drawing.Font("Arial", 18F);
            this.tbx_ProjectName.ForeColor = System.Drawing.SystemColors.Control;
            this.tbx_ProjectName.Location = new System.Drawing.Point(245, 74);
            this.tbx_ProjectName.Name = "tbx_ProjectName";
            this.tbx_ProjectName.Size = new System.Drawing.Size(338, 35);
            this.tbx_ProjectName.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(222, 251);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btn_CreateProject
            // 
            this.btn_CreateProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btn_CreateProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CreateProject.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_CreateProject.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_CreateProject.Location = new System.Drawing.Point(370, 229);
            this.btn_CreateProject.Name = "btn_CreateProject";
            this.btn_CreateProject.Size = new System.Drawing.Size(213, 34);
            this.btn_CreateProject.TabIndex = 9;
            this.btn_CreateProject.Text = "Let\'s go!";
            this.btn_CreateProject.UseVisualStyleBackColor = false;
            this.btn_CreateProject.Click += new System.EventHandler(this.btn_CreateProject_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Cancel.Location = new System.Drawing.Point(245, 229);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(119, 34);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_1.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_1.Location = new System.Drawing.Point(242, 118);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(122, 18);
            this.lbl_1.TabIndex = 11;
            this.lbl_1.Text = "Blender Version";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_2.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_2.Location = new System.Drawing.Point(242, 53);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(103, 18);
            this.lbl_2.TabIndex = 12;
            this.lbl_2.Text = "Project Name";
            // 
            // CreateProjectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(595, 275);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_CreateProject);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tbx_ProjectName);
            this.Controls.Add(this.cbx_VersionSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateProjectWindow";
            this.Text = "Create Project";
            this.Load += new System.EventHandler(this.CreateProjectWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_VersionSelect;
        private System.Windows.Forms.TextBox tbx_ProjectName;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_CreateProject;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
    }
}