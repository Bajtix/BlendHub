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
            if (Cursor.Position.Y > Screen.GetBounds(Cursor.Position).Height)
                this.Top = Screen.GetBounds(Cursor.Position).Height / 2;
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
            info.UseShellExecute = true;
            info.WorkingDirectory = Path.GetDirectoryName(path);
            if (projectPath != "") {
                if (projectPath.ToLower().EndsWith(".blend"))
                    info.Arguments = '"' + projectPath + '"';
                else if (projectPath.ToLower().EndsWith(".fbx")) {
                    info.Arguments = $"--python-expr \"import bpy; bpy.data.objects.remove(bpy.data.objects['Cube'], do_unlink = True); bpy.ops.import_scene.fbx(filepath = '{projectPath.Replace('\\','/')}')\"";
                }
            }
            MainWindow.configs.lastVersion = cbx_VersionSelect.SelectedIndex;
            MainWindow.SaveConfigs();
            MessageBox.Show(info.Arguments);
            Process.Start(info);

            MainWindow.instance.Close();
        }
    }
}
