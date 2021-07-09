using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlendHub {
    public partial class CreateProjectWindow : Form {
        public CreateProjectWindow() {
            InitializeComponent();

            
        }

        protected override void OnShown(EventArgs e) {
            base.OnShown(e);
            LoadVersions();
        }


        private void LoadVersions() {
            foreach (var item in MainWindow.blenderVersions.Keys) {
                cbx_VersionSelect.Items.Add(item);
            }
            if (cbx_VersionSelect.Items.Count > MainWindow.configs.lastVersion)
                cbx_VersionSelect.SelectedIndex = MainWindow.configs.lastVersion;
        }

        private void btn_Cancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void btn_CreateProject_Click(object sender, EventArgs e) {

            if(cbx_VersionSelect.SelectedIndex < 0) {
                MessageBox.Show("Please select a version!");
                return;
            }

            var success = MainWindow.CreateProject(tbx_ProjectName.Text, 
                null,
                cbx_VersionSelect.SelectedIndex
                );

            switch (success) {
                case -1:
                    MessageBox.Show("Illegal Name");
                    break;
                case -2:
                    MessageBox.Show("Path Exists");
                    break;
                case 1:
                    MainWindow.instance.StartProject(0); // forgot that it sorts it by date. The first one is the newest.
                    Close();
                    break;
            }
        }

        private void CreateProjectWindow_Load(object sender, EventArgs e) {

        }
    }
}
