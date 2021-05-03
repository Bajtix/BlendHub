using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlendHub {
    public partial class VersionEdit : Form {
        private int edited;
        private Project project;

        public VersionEdit(int projectIndex) {
            InitializeComponent();
            LoadVersions();
            edited = projectIndex;

            project = MainWindow.projects[edited];

            tbx_ProjectName.Text = project.name;
            if (cbx_VersionSelect.Items.Contains(project.versionName)) {
                cbx_VersionSelect.SelectedIndex = cbx_VersionSelect.Items.IndexOf(project.versionName);
            } else
                cbx_VersionSelect.Text = "Please select";
        }

        private void LoadVersions() {
            foreach (var item in MainWindow.blenderVersions.Keys) {
                cbx_VersionSelect.Items.Add(item);
            }
            if (cbx_VersionSelect.Items.Count > 0)
                cbx_VersionSelect.SelectedIndex = 0;
        }


        private void btn_CreateProject_Click(object sender, EventArgs e) {
            if (cbx_VersionSelect.SelectedIndex < 0) {
                MessageBox.Show("Please select a version!");
                return;
            }
            project.lastModified = DateTime.Now;
            project.versionName = cbx_VersionSelect.Text;

            MainWindow.projects[edited] = project;
            Close();
        }

        private void btn_RemoveProject_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure you want to remove the project from your disk?", "You sure?", MessageBoxButtons.YesNo) == DialogResult.No) return;

            Directory.Delete(MainWindow.projects[edited].path, true);
            MainWindow.projects.RemoveAt(edited);
            Close();

        }

        private void btn_OpenFolder_Click(object sender, EventArgs e) {
            Process.Start('"' + MainWindow.projects[edited].path + '"');
        }

        private void btn_Cancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
