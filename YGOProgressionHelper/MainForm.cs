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

            if (!File.Exists(ydkTextBox.Text)) 
            {
                setOutput("YDK File Does Not Exist!");
                return;
            }
            if (string.IsNullOrEmpty(csvTextBox.Text))
            {
                setOutput("CSV File Not Set!");
                return;
            }

            //Create CSV File if doesn't exist.
            if (!File.Exists(csvTextBox.Text))
            {
                StreamWriter writer = File.CreateText(csvTextBox.Text);
                writer.Close();
            }

            Dictionary<int, YGOCard> cardDict;
            try
            {
                cardDict = CSVReader.readCSVFile(csvTextBox.Text);
            }
            catch
            {
                setOutput("Failed to read CSV File!");
                return;
            }

            List<YDKEntry> ydkList;
            try
            {
                ydkList = YDKReader.readYDKFile(ydkTextBox.Text);
            } catch
            {
                setOutput("Failed to read YDK File!");
                return;
            }

            // For each entry in ydklist, if in dictionary add to count, else add to list to look up with api.
            Dictionary<int, int> lookupDict = new Dictionary<int, int>();
            foreach(YDKEntry entry in ydkList)
            {
                if (cardDict.ContainsKey(entry.ID))
                {
                    cardDict[entry.ID].count++;
                }
                else if (lookupDict.ContainsKey(entry.ID))
                {
                    lookupDict[entry.ID]++;
                }
                else
                {
                    lookupDict.Add(entry.ID, 1);
                }
            }

            CardList lookupList = YGOAPI.lookupCards(lookupDict.Keys.ToList());
            // Set the count of each of the cards that was just looked up.
            // And add to the card dictionary
            foreach(YGOCard card in lookupList.data)
            {
                card.count = lookupDict[card.id];
                cardDict.Add(card.id, card);
            }

            try
            {
                CSVWriter.writeCSV(cardDict.Values.ToList(), csvTextBox.Text);
            } catch
            {
                setOutput("Failed to Write CSV File!");
                return;
            }

            setOutput("Import Successful!");
        }
    }
}
