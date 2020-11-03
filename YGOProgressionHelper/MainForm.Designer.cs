namespace YGOProgressionHelper
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ydkTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.csvTextBox = new System.Windows.Forms.TextBox();
            this.ydkButton = new System.Windows.Forms.Button();
            this.csvButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.importButton = new System.Windows.Forms.Button();
            this.ydkDialog = new System.Windows.Forms.OpenFileDialog();
            this.csvDialog = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.34951F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.65049F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ydkTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.csvTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ydkButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.csvButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.outputTextBox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.importButton, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.80952F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.19048F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(511, 162);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "YDK File:";
            // 
            // ydkTextBox
            // 
            this.ydkTextBox.AllowDrop = true;
            this.ydkTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.ydkTextBox, 2);
            this.ydkTextBox.Location = new System.Drawing.Point(67, 20);
            this.ydkTextBox.Name = "ydkTextBox";
            this.ydkTextBox.ReadOnly = true;
            this.ydkTextBox.Size = new System.Drawing.Size(326, 20);
            this.ydkTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CSV File:";
            // 
            // csvTextBox
            // 
            this.csvTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.csvTextBox, 2);
            this.csvTextBox.Location = new System.Drawing.Point(67, 83);
            this.csvTextBox.Name = "csvTextBox";
            this.csvTextBox.ReadOnly = true;
            this.csvTextBox.Size = new System.Drawing.Size(326, 20);
            this.csvTextBox.TabIndex = 4;
            // 
            // ydkButton
            // 
            this.ydkButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ydkButton.Location = new System.Drawing.Point(399, 19);
            this.ydkButton.Name = "ydkButton";
            this.ydkButton.Size = new System.Drawing.Size(75, 23);
            this.ydkButton.TabIndex = 2;
            this.ydkButton.Text = "Open File";
            this.ydkButton.UseVisualStyleBackColor = true;
            this.ydkButton.Click += new System.EventHandler(this.ydkButton_Click);
            // 
            // csvButton
            // 
            this.csvButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.csvButton.Location = new System.Drawing.Point(399, 82);
            this.csvButton.Name = "csvButton";
            this.csvButton.Size = new System.Drawing.Size(75, 23);
            this.csvButton.TabIndex = 5;
            this.csvButton.Text = "Open File";
            this.csvButton.UseVisualStyleBackColor = true;
            this.csvButton.Click += new System.EventHandler(this.csvButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTextBox.Location = new System.Drawing.Point(171, 134);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(222, 20);
            this.outputTextBox.TabIndex = 7;
            // 
            // importButton
            // 
            this.importButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.importButton.Location = new System.Drawing.Point(67, 132);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(98, 23);
            this.importButton.TabIndex = 6;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // ydkDialog
            // 
            this.ydkDialog.DefaultExt = "ydk";
            this.ydkDialog.FileName = "openFileDialog1";
            this.ydkDialog.Filter = "YDK files|*.ydk";
            // 
            // csvDialog
            // 
            this.csvDialog.CreatePrompt = true;
            this.csvDialog.DefaultExt = "csv";
            this.csvDialog.Filter = "CSV files|*.csv";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 162);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "YGO Progression Helper";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ydkTextBox;
        private System.Windows.Forms.Button ydkButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox csvTextBox;
        private System.Windows.Forms.Button csvButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.OpenFileDialog ydkDialog;
        private System.Windows.Forms.SaveFileDialog csvDialog;
        private System.Windows.Forms.TextBox outputTextBox;
    }
}

