using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;

namespace BlendHub {
    [Serializable]
    public struct Project {
        public string name;
        public DateTime lastModified;
        public string path;
        public string versionName;
    }
    [Serializable]
    public struct BlenderVersion {
        public string label;
        public string path;
    }

    public partial class MainWindow : Form {

        public static MainWindow instance;

        public static string InstallationsPath;
        public static string ConfigPath;
        public static string ProjectsPath;

        public static List<Project> projects = new List<Project>();
        public static Dictionary<string, BlenderVersion> blenderVersions = new Dictionary<string, BlenderVersion>();
        
        public VersionManager versionManager = new VersionManager();
        public CreateProjectWindow createProjectWindow = new CreateProjectWindow();

        [Serializable] public struct Config {
            public int lastVersion;
        }

        public static Config configs = new Config();

        private static bool lockEditing = false;

        public MainWindow() {
            InitializeComponent();

            CreateFolderSetup();

            LoadConfigs();
            SortProjectList();
            RefreshProjectList();

            instance = this;

            
        }

        private void RefreshProjectList() {
            lbx_ProjectList.Items.Clear();
            foreach (var item in projects) {
                lbx_ProjectList.Items.Add(new ListViewItem(new string[] { item.name, item.versionName, item.lastModified.ToString() }));
            }
        }

        public void SortProjectList() {
            for (int i = 0; i < projects.Count; i++) {
                for (int j = 1; j < projects.Count; j++) {
                    if(DateTime.Compare(projects[j - 1].lastModified, projects[j].lastModified) < 0) {
                        var tmp = projects[j];
                        projects[j] = projects[j - 1];
                        projects[j - 1] = tmp;
                    }
                }
            }
        }

        private void btn_AddProject_Click(object sender, EventArgs e) {
            if (createProjectWindow == null || createProjectWindow.IsDisposed) createProjectWindow = new CreateProjectWindow();
            createProjectWindow.Show();
        }

        private void btn_OpenVersionManager_Click(object sender, EventArgs e) {
            if (versionManager == null || versionManager.IsDisposed) versionManager = new VersionManager();
            versionManager.Show();
        }

        public static void CreateFolderSetup() {
            InstallationsPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/BlendHub/Installations";
            ConfigPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/BlendHub/";
            ProjectsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Blender Projects/";

            Directory.CreateDirectory(InstallationsPath); 
            Directory.CreateDirectory(ConfigPath); 
            Directory.CreateDirectory(ProjectsPath);
        }

        public static void SaveConfigs() {
            string projectJson = JsonConvert.SerializeObject(projects.ToArray());
            string versionJson = JsonConvert.SerializeObject(blenderVersions);
            string configJson = JsonConvert.SerializeObject(configs);

            File.WriteAllText(ConfigPath + "/versions.json", versionJson);
            File.WriteAllText(ProjectsPath + "/projects.json", projectJson);
            File.WriteAllText(ConfigPath + "/config.json", configJson);
        }

        public static void LoadConfigs() {
            string projectJson; 
            string versionJson;
            string configJson;

            if (File.Exists(ProjectsPath + "/projects.json")) {
                projectJson = File.ReadAllText(ProjectsPath + "/projects.json");
                projects = JsonConvert.DeserializeObject<Project[]>(projectJson).ToList();
            }
            if (File.Exists(ConfigPath + "/versions.json")) {
                versionJson = File.ReadAllText(ConfigPath + "/versions.json");
                blenderVersions = JsonConvert.DeserializeObject<Dictionary<string, BlenderVersion>>(versionJson);
            }
            if (File.Exists(ConfigPath + "/config.json")) {
                configJson = File.ReadAllText(ConfigPath + "/config.json");
                MainWindow.configs = JsonConvert.DeserializeObject<Config>(configJson);
            }
        }

        public static int CreateProject(string name, string template, int version) {
            if (!IsPathLegal(name)) return -1;
            
            string pth = Path.Combine(ProjectsPath, name);
            if (Directory.Exists(pth)) return -2;
            
            Directory.CreateDirectory(pth);
            File.WriteAllText(Path.Combine(pth, name + ".blend"),"");
            
            string versionlabel = blenderVersions.Keys.ToArray()[version];
            
            projects.Add(new Project() {
                name = name,
                path = pth,
                lastModified = DateTime.Now,
                versionName = versionlabel
            });

            SaveConfigs();
            instance.SortProjectList();
            instance.RefreshProjectList();
            

            return 1;
        }

        public Project StartProject(int indx) {

            Project project = projects[indx];

            project.lastModified = DateTime.Now;
            string filePath = Path.Combine(project.path, project.name + ".blend").Replace("\\","/");

            if(!blenderVersions.ContainsKey(project.versionName)) {
                MessageBox.Show("The version does not exist. Please select a different one.");
                EditVersion(indx);

                return new Project() { name = "CON" };
            }

            string blenderPath = blenderVersions[project.versionName].path;
            var info = new ProcessStartInfo(blenderPath);
            info.UseShellExecute = false;
            info.WorkingDirectory = Path.GetDirectoryName(blenderPath);
            info.Arguments = '"' + filePath + '"';
            Process.Start('"' + project.path + '"');
            Process.Start(info);
            configs.lastVersion = blenderVersions.Keys.ToList().IndexOf(project.versionName);
            return project;
        }

        public static bool IsPathLegal(string path) {
            foreach (var item in Path.GetInvalidPathChars()) {
                if (path.Contains(item)) return false;
            }
            foreach (var item in Path.GetInvalidFileNameChars()) {
                if (path.Contains(item)) return false;
            }
            return true;
        }

        private void lbx_ProjectList_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (lbx_ProjectList.SelectedIndices.Count <= 0) return;
            var p = StartProject(lbx_ProjectList.SelectedIndices[0]);
            if (p.name == "CON") return;
            projects[lbx_ProjectList.SelectedIndices[0]] = p;
            SaveConfigs();
            SortProjectList();
            RefreshProjectList();
        }

        private void btn_OpenProjectFolder_Click(object sender, EventArgs e) {
            if (lbx_ProjectList.SelectedIndices.Count <= 0) return;
            Process.Start('"' + projects[lbx_ProjectList.SelectedIndices[0]].path + '"'); 
        }

        private void btn_RemoveProject_Click(object sender, EventArgs e) {
            if (lbx_ProjectList.SelectedIndices.Count <= 0) return;
            EditVersion(lbx_ProjectList.SelectedIndices[0]);
        }

        private void EditVersion(int of) {
            if (lockEditing) return;

            VersionEdit edit = new VersionEdit(of);

            edit.Show();
            lockEditing = true;

            edit.FormClosing += Edit_FormClosing;
        }

        private void Edit_FormClosing(object sender, FormClosingEventArgs e) {
            lockEditing = false;
            SaveConfigs();
            SortProjectList();
            RefreshProjectList();
        }

        private void btn_Quit_Click(object sender, EventArgs e) {
            Close();
        }

        private void btn_OpenProjectsFolder_Click(object sender, EventArgs e) {
            Process.Start(ProjectsPath);
        }

        private void btn_OpenAbout_Click(object sender, EventArgs e) {
            new About().Show();
        }

        private void MainWindow_Load(object sender, EventArgs e) {
            if (Environment.GetCommandLineArgs().Length > 1) {
                string pp = Environment.GetCommandLineArgs()[1];
                if (!pp.EndsWith(".blend")) {
                    if (pp.Contains("-l")) /*dumb dumb*/ {
                        Visible = false; // Hide form window.
                        ShowInTaskbar = false; // Remove from taskbar.
                        new OpenWithBlender("").Show();
                    }
                    return;
                }
                

                Visible = false; // Hide form window.
                ShowInTaskbar = false; // Remove from taskbar.
                new OpenWithBlender(pp).Show();

            }
        }
    }
}
