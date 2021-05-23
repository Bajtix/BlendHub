using BlendHub.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlendHub {
    public partial class WebInstaller : Form {
        public WebInstaller() {
            InitializeComponent();
        }

        private void LoadVersions() {
            var vers = ListFiles();
            vers.Reverse();
            listView1.LargeImageList = new ImageList();
            listView1.LargeImageList.Images.Add(Resources.blenderlogo);
            foreach (var i in vers) {
                if (i.Contains("Blender") && !i.Contains("Bench"))
                    listView1.Items.Add(new ListViewItem(i, 0));
            }
        }

        private void btn_LoadVersions_Click(object sender, EventArgs e) {
            WebClient wc = new WebClient();
            
            var selected = listView1.SelectedItems[0].Text;
            var identifier = selected.Substring(7);

            MessageBox.Show("Are you sure you want to download " + identifier);
            new Task(() => { MessageBox.Show("The app will freeze for a few minutes/seconds. This is to be patched in a future version"); }).Start();
            try {
                wc.DownloadFile($"http://ftp.nluug.nl/pub/graphics/blender/release/{selected}/blender-{identifier}.0-windows64.zip", identifier + ".zip");
            } catch(WebException we) {
                wc.DownloadFile($"http://ftp.nluug.nl/pub/graphics/blender/release/{selected}/blender-{identifier}-windows64.zip", identifier + ".zip");
            }
            MessageBox.Show("Download finished. Installing");
            MainWindow.instance.versionManager.InstallZip(identifier + ".zip");

            File.Delete(identifier + ".zip");
        }

        private List<string> ListFiles() {
            try {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://ftp.nluug.nl/pub/graphics/blender/release/");
                request.Method = WebRequestMethods.Ftp.ListDirectory;

                //request.Credentials = new NetworkCredential("username", "password");
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                string names = reader.ReadToEnd();

                reader.Close();
                response.Close();

                return names.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            catch (Exception) {
                throw;
            }
        }

        private void WebInstaller_Load(object sender, EventArgs e) {
            LoadVersions();
            MessageBox.Show("This function is EVEN MORE WIP than the rest of this program. Continue with caution; Expect crashes/errors.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_Cancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
