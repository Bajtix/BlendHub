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
            if(cbx_VersionSelect.Items.Count > 0)
                cbx_VersionSelect.SelectedIndex = 0;
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
                    MainWindow.instance.StartProject(MainWindow.projects.Count - 1);
                    Close();
                    break;
            }
        }
    }
}
