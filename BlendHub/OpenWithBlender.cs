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
    public partial class OpenWithBlender : Form {
        private string projectPath;
        public OpenWithBlender(string projectPath) {
            InitializeComponent();
            this.projectPath = projectPath;
            this.Left = Cursor.Position.X;
            this.Top = Cursor.Position.Y;
        }

        private void OpenWithBlender_Load(object sender, EventArgs e) {
            foreach (var item in MainWindow.blenderVersions.Keys) {
                cbx_VersionSelect.Items.Add(item);
            }
            if (cbx_VersionSelect.Items.Count > MainWindow.configs.lastVersion)
                cbx_VersionSelect.SelectedIndex = MainWindow.configs.lastVersion;
        }

        private void btn_Cancel_Click(object sender, EventArgs e) {
            MainWindow.instance.Close();
        }

        private void btn_Ok_Click(object sender, EventArgs e) {
            if (cbx_VersionSelect.SelectedIndex < 0) {
                MessageBox.Show("Please select a version!");
                return;
            }

            string path = MainWindow.blenderVersions.Values.ToArray()[cbx_VersionSelect.SelectedIndex].path; // open blender
            var info = new ProcessStartInfo(path);
            info.UseShellExecute = false;
            info.WorkingDirectory = Path.GetDirectoryName(path);
            if(projectPath != "")
                info.Arguments = '"' + projectPath + '"';
            MainWindow.configs.lastVersion = cbx_VersionSelect.SelectedIndex;
            MainWindow.SaveConfigs();

            Process.Start(info);

            MainWindow.instance.Close();
        }
    }
}
