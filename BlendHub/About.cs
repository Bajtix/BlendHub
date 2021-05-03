using BlendHub.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlendHub {
    public partial class About : Form {
        public About() {
            InitializeComponent();

            File.WriteAllText("desc.rtf",Resources.desc);
            // trickery to change the text color
            txb_about.LoadFile("desc.rtf");
            txb_about.SelectAll();
            txb_about.SelectionColor = Color.White;
            txb_about.DeselectAll();

            
        }

        private void btn_Cancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
