﻿using System;
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
        }

        private void ydkButton_Click(object sender, EventArgs e)
        {
            DialogResult result = ydkDialog.ShowDialog();
        }

        private void csvButton_Click(object sender, EventArgs e)
        {
            DialogResult result = csvDialog.ShowDialog();
        }

    }
}
