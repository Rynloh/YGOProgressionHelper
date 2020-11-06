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

namespace YGOProgressionHelper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            setInitialDirectories();
        }

        private void setInitialDirectories()
        {
            ydkDialog.InitialDirectory = Application.StartupPath;
            csvDialog.InitialDirectory = Application.StartupPath;
        }

        private void ydkButton_Click(object sender, EventArgs e)
        {
            DialogResult result = ydkDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                ydkTextBox.Text = ydkDialog.FileName;
            } else
            {
                ydkTextBox.Text = "";
            }
            enableImport();
        }

        private void csvButton_Click(object sender, EventArgs e)
        {
            DialogResult result = csvDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                csvTextBox.Text = csvDialog.FileName;
            } else
            {
                csvTextBox.Text = "";
            }
            enableImport();
        }

        private void enableImport()
        {
            if(!string.IsNullOrEmpty(ydkTextBox.Text) && !string.IsNullOrEmpty(csvTextBox.Text))
            {
                importButton.Enabled = true;
            }
        }

        private void setOutput(string text)
        {
            outputTextBox.Text = text;
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            setOutput("");

            Importer importer = new Importer(ydkTextBox.Text, csvTextBox.Text);

            if (!importer.verifyYDKPath())
            {
                setOutput("YDK File Does Not Exist!");
                return;
            }

            setOutput(importer.import());
            importButton.Enabled = false;
        }
    }
}
