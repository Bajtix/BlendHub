using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;
using Microsoft.VisualBasic;

namespace BlendHub {
    public partial class VersionManager : Form {
        
        public VersionManager() {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e) {
            base.OnShown(e); 
            LoadVersions();
        }

        private void LoadVersions() {
            lbx_Versions.Items.Clear();
            foreach (var item in MainWindow.blenderVersions) {
                lbx_Versions.Items.Add(item.Key);
            }
        }

        private void btn_InstallZip_Click(object sender, EventArgs e) {
            if (dlg_openArchive.ShowDialog() != DialogResult.OK) return;

            string labelName = SimplifyBlenderName(Path.GetFileNameWithoutExtension(dlg_openArchive.FileName));
            string n = MainWindow.InstallationsPath + "/" + Path.GetFileNameWithoutExtension(dlg_openArchive.FileName);
            if (Directory.Exists(n)) return;
            
            ZipFile.ExtractToDirectory(dlg_openArchive.FileName, MainWindow.InstallationsPath);

            MainWindow.blenderVersions.Add(labelName, new BlenderVersion() {
                label = labelName,
                path = n + "/blender.exe"
            });

            LoadVersions();
            MainWindow.SaveConfigs();
        }

        private void btn_LocateInstall_Click(object sender, EventArgs e) {
            if (dlg_openExe.ShowDialog() != DialogResult.OK) return;
            string directory = Path.GetDirectoryName(dlg_openExe.FileName);
            string labelName = Interaction.InputBox("Name the version", "Version name", new DirectoryInfo(directory).Name, 0, 0);
            string n = MainWindow.InstallationsPath + "/" + Directory.GetParent(directory).Name;
            if (Directory.Exists(n)) return;
            CopyFilesRecursively(directory, n);

            MainWindow.blenderVersions.Add(labelName, new BlenderVersion() {
                label = labelName,
                path = n + "/blender.exe"
            });

            LoadVersions();
            MainWindow.SaveConfigs();
        }

        private string SimplifyBlenderName(string name) {
            string result = name.Replace("blender-", "").Replace("-windows64", "").Replace("-windows32", "");
            return result;
        }

        private void btn_RemoveVersion_Click(object sender, EventArgs e) {
            BlenderVersion toremove = MainWindow.blenderVersions.Values.ToArray()[lbx_Versions.SelectedIndex];
            
            Directory.Delete(Path.GetDirectoryName(toremove.path), true);
            MainWindow.blenderVersions.Remove(MainWindow.blenderVersions.Keys.ToArray()[lbx_Versions.SelectedIndex]);

            LoadVersions();
            MainWindow.SaveConfigs();
        }

        // yoinked from https://stackoverflow.com/a/3822913/13208996
        private static void CopyFilesRecursively(string sourcePath, string targetPath) {
            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories)) {
                Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
            }

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories)) {
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
            }
        }

    }
}
