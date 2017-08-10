using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamMarketHelper {
    public partial class InputURL : Form {

        public bool pronto = false;
        public string url;

        public InputURL() {
            InitializeComponent();
            this.ShowDialog();
        }

        private void buttonOK_Click(object sender, EventArgs e) {
            if (textBoxURL.Text.Length>0) {
                pronto = true;
                url = textBoxURL.Text;
                this.Close();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e) {
            pronto = false;
            this.Close();
        }
    }
}
