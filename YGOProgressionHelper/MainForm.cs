using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void setOutput(string text)
        {
            outputTextBox.Text = text;
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            setOutput("");

            if (!System.IO.File.Exists(ydkTextBox.Text)) 
            {
                setOutput("YDK File Does Not Exist!");
                return;
            }
            List<YDKEntry> ydkList = null;
            try
            {
                ydkList = YDKReader.readYDKFile(ydkTextBox.Text);
            } catch
            {
                setOutput("Failed to read YDK File!");
                return;
            }
            setOutput("Import Successful!");
        }
    }
}
