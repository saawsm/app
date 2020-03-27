using System;
using System.Windows.Forms;

namespace Saawsm.App {

    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Text = $"{Application.ProductName} v{Application.ProductVersion}";
        }

        private void button1_Click(object sender, EventArgs e) {
            MessageBox.Show("Hello World", "Basic MSG Box");
        }
    }

}
