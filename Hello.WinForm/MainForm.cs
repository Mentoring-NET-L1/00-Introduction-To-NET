using System;
using System.Windows.Forms;
using Hello.Library;

namespace Hello.WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnShowHelllo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                HelloHelper.SayHello(txbInput.Text),
                "Hello!",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
        }
    }
}
