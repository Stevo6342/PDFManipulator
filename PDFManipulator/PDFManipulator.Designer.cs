namespace PDFManipulator
{
    partial class PDFManipulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDFManipulator));
            this.extractButton = new System.Windows.Forms.Button();
            this.existingSourceFile = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.extractOptions = new System.Windows.Forms.GroupBox();
            this.individualPagesCheckbox = new System.Windows.Forms.CheckBox();
            this.extractFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.extractPathButton = new System.Windows.Forms.Button();
            this.extractPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.extractEndingPage = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.extractStartPage = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.insertPagesControls = new System.Windows.Forms.GroupBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.insertAfterPage = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.insertEndPage = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.insertPageStart = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.selectInsertFileButton = new System.Windows.Forms.Button();
            this.insertFile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.removePagesControls = new System.Windows.Forms.GroupBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.currentPageCount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.removeEndPage = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.removeStartPage = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.existingFileRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.sourceFileOptions = new System.Windows.Forms.GroupBox();
            this.selectNewSourceFileButton = new System.Windows.Forms.Button();
            this.newSourceFile = new System.Windows.Forms.TextBox();
            this.extractOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extractEndingPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extractStartPage)).BeginInit();
            this.insertPagesControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insertAfterPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertEndPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertPageStart)).BeginInit();
            this.removePagesControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeEndPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeStartPage)).BeginInit();
            this.sourceFileOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // extractButton
            // 
            this.extractButton.Location = new System.Drawing.Point(486, 82);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new System.Drawing.Size(75, 23);
            this.extractButton.TabIndex = 0;
            this.extractButton.Text = "Extract";
            this.extractButton.UseVisualStyleBackColor = true;
            this.extractButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // existingSourceFile
            // 
            this.existingSourceFile.Location = new System.Drawing.Point(103, 65);
            this.existingSourceFile.Name = "existingSourceFile";
            this.existingSourceFile.ReadOnly = true;
            this.existingSourceFile.Size = new System.Drawing.Size(377, 20);
            this.existingSourceFile.TabIndex = 2;
            this.existingSourceFile.TextChanged += new System.EventHandler(this.sourceFile_TextChanged);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(486, 63);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 3;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // extractOptions
            // 
            this.extractOptions.Controls.Add(this.individualPagesCheckbox);
            this.extractOptions.Controls.Add(this.extractFile);
            this.extractOptions.Controls.Add(this.label5);
            this.extractOptions.Controls.Add(this.extractPathButton);
            this.extractOptions.Controls.Add(this.extractPath);
            this.extractOptions.Controls.Add(this.label4);
            this.extractOptions.Controls.Add(this.extractEndingPage);
            this.extractOptions.Controls.Add(this.label3);
            this.extractOptions.Controls.Add(this.extractStartPage);
            this.extractOptions.Controls.Add(this.label2);
            this.extractOptions.Controls.Add(this.extractButton);
            this.extractOptions.Enabled = false;
            this.extractOptions.Location = new System.Drawing.Point(26, 130);
            this.extractOptions.Name = "extractOptions";
            this.extractOptions.Size = new System.Drawing.Size(567, 113);
            this.extractOptions.TabIndex = 4;
            this.extractOptions.TabStop = false;
            this.extractOptions.Text = "Extract Section";
            // 
            // individualPagesCheckbox
            // 
            this.individualPagesCheckbox.AutoSize = true;
            this.individualPagesCheckbox.Location = new System.Drawing.Point(294, 25);
            this.individualPagesCheckbox.Name = "individualPagesCheckbox";
            this.individualPagesCheckbox.Size = new System.Drawing.Size(104, 17);
            this.individualPagesCheckbox.TabIndex = 10;
            this.individualPagesCheckbox.Text = "Individual Pages";
            this.individualPagesCheckbox.UseVisualStyleBackColor = true;
            // 
            // extractFile
            // 
            this.extractFile.Location = new System.Drawing.Point(66, 84);
            this.extractFile.Name = "extractFile";
            this.extractFile.Size = new System.Drawing.Size(414, 20);
            this.extractFile.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Save As:";
            // 
            // extractPathButton
            // 
            this.extractPathButton.Location = new System.Drawing.Point(486, 53);
            this.extractPathButton.Name = "extractPathButton";
            this.extractPathButton.Size = new System.Drawing.Size(75, 23);
            this.extractPathButton.TabIndex = 7;
            this.extractPathButton.Text = "Select Path";
            this.extractPathButton.UseVisualStyleBackColor = true;
            this.extractPathButton.Click += new System.EventHandler(this.extractPathButton_Click);
            // 
            // extractPath
            // 
            this.extractPath.Location = new System.Drawing.Point(66, 55);
            this.extractPath.Name = "extractPath";
            this.extractPath.Size = new System.Drawing.Size(414, 20);
            this.extractPath.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Save In:";
            // 
            // extractEndingPage
            // 
            this.extractEndingPage.Location = new System.Drawing.Point(225, 24);
            this.extractEndingPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.extractEndingPage.Name = "extractEndingPage";
            this.extractEndingPage.Size = new System.Drawing.Size(49, 20);
            this.extractEndingPage.TabIndex = 4;
            this.extractEndingPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ending Page:";
            // 
            // extractStartPage
            // 
            this.extractStartPage.Location = new System.Drawing.Point(93, 24);
            this.extractStartPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.extractStartPage.Name = "extractStartPage";
            this.extractStartPage.Size = new System.Drawing.Size(49, 20);
            this.extractStartPage.TabIndex = 2;
            this.extractStartPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Starting Page:";
            // 
            // insertPagesControls
            // 
            this.insertPagesControls.Controls.Add(this.insertButton);
            this.insertPagesControls.Controls.Add(this.label10);
            this.insertPagesControls.Controls.Add(this.insertAfterPage);
            this.insertPagesControls.Controls.Add(this.label9);
            this.insertPagesControls.Controls.Add(this.insertEndPage);
            this.insertPagesControls.Controls.Add(this.label8);
            this.insertPagesControls.Controls.Add(this.insertPageStart);
            this.insertPagesControls.Controls.Add(this.label7);
            this.insertPagesControls.Controls.Add(this.selectInsertFileButton);
            this.insertPagesControls.Controls.Add(this.insertFile);
            this.insertPagesControls.Controls.Add(this.label6);
            this.insertPagesControls.Enabled = false;
            this.insertPagesControls.Location = new System.Drawing.Point(26, 253);
            this.insertPagesControls.Name = "insertPagesControls";
            this.insertPagesControls.Size = new System.Drawing.Size(567, 121);
            this.insertPagesControls.TabIndex = 5;
            this.insertPagesControls.TabStop = false;
            this.insertPagesControls.Text = "Insert Pages";
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(486, 91);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 10;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(138, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "in source file";
            // 
            // insertAfterPage
            // 
            this.insertAfterPage.Location = new System.Drawing.Point(80, 94);
            this.insertAfterPage.Name = "insertAfterPage";
            this.insertAfterPage.Size = new System.Drawing.Size(52, 20);
            this.insertAfterPage.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "After Page:";
            // 
            // insertEndPage
            // 
            this.insertEndPage.Location = new System.Drawing.Point(169, 61);
            this.insertEndPage.Name = "insertEndPage";
            this.insertEndPage.Size = new System.Drawing.Size(48, 20);
            this.insertEndPage.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "through";
            // 
            // insertPageStart
            // 
            this.insertPageStart.Location = new System.Drawing.Point(66, 61);
            this.insertPageStart.Name = "insertPageStart";
            this.insertPageStart.Size = new System.Drawing.Size(48, 20);
            this.insertPageStart.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Pages:";
            // 
            // selectInsertFileButton
            // 
            this.selectInsertFileButton.Location = new System.Drawing.Point(486, 25);
            this.selectInsertFileButton.Name = "selectInsertFileButton";
            this.selectInsertFileButton.Size = new System.Drawing.Size(75, 23);
            this.selectInsertFileButton.TabIndex = 2;
            this.selectInsertFileButton.Text = "Browse";
            this.selectInsertFileButton.UseVisualStyleBackColor = true;
            this.selectInsertFileButton.Click += new System.EventHandler(this.selectInsertFileButton_Click);
            // 
            // insertFile
            // 
            this.insertFile.Location = new System.Drawing.Point(66, 27);
            this.insertFile.Name = "insertFile";
            this.insertFile.Size = new System.Drawing.Size(414, 20);
            this.insertFile.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Insert:";
            // 
            // removePagesControls
            // 
            this.removePagesControls.Controls.Add(this.removeButton);
            this.removePagesControls.Controls.Add(this.currentPageCount);
            this.removePagesControls.Controls.Add(this.label13);
            this.removePagesControls.Controls.Add(this.removeEndPage);
            this.removePagesControls.Controls.Add(this.label12);
            this.removePagesControls.Controls.Add(this.removeStartPage);
            this.removePagesControls.Controls.Add(this.label11);
            this.removePagesControls.Enabled = false;
            this.removePagesControls.Location = new System.Drawing.Point(26, 384);
            this.removePagesControls.Name = "removePagesControls";
            this.removePagesControls.Size = new System.Drawing.Size(567, 96);
            this.removePagesControls.TabIndex = 6;
            this.removePagesControls.TabStop = false;
            this.removePagesControls.Text = "Remove Pages";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(486, 66);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // currentPageCount
            // 
            this.currentPageCount.AutoSize = true;
            this.currentPageCount.Location = new System.Drawing.Point(123, 71);
            this.currentPageCount.Name = "currentPageCount";
            this.currentPageCount.Size = new System.Drawing.Size(13, 13);
            this.currentPageCount.TabIndex = 5;
            this.currentPageCount.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Current Page Count:";
            // 
            // removeEndPage
            // 
            this.removeEndPage.Location = new System.Drawing.Point(206, 24);
            this.removeEndPage.Name = "removeEndPage";
            this.removeEndPage.Size = new System.Drawing.Size(48, 20);
            this.removeEndPage.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(157, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "through";
            // 
            // removeStartPage
            // 
            this.removeStartPage.Location = new System.Drawing.Point(103, 24);
            this.removeStartPage.Name = "removeStartPage";
            this.removeStartPage.Size = new System.Drawing.Size(48, 20);
            this.removeStartPage.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Remove Pages:";
            // 
            // existingFileRadioButton
            // 
            this.existingFileRadioButton.AutoSize = true;
            this.existingFileRadioButton.Location = new System.Drawing.Point(17, 66);
            this.existingFileRadioButton.Name = "existingFileRadioButton";
            this.existingFileRadioButton.Size = new System.Drawing.Size(83, 17);
            this.existingFileRadioButton.TabIndex = 7;
            this.existingFileRadioButton.Text = "Existing File:";
            this.existingFileRadioButton.UseVisualStyleBackColor = true;
            this.existingFileRadioButton.CheckedChanged += new System.EventHandler(this.existingFileRadioButton_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "New File:";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // sourceFileOptions
            // 
            this.sourceFileOptions.Controls.Add(this.selectNewSourceFileButton);
            this.sourceFileOptions.Controls.Add(this.newSourceFile);
            this.sourceFileOptions.Controls.Add(this.existingSourceFile);
            this.sourceFileOptions.Controls.Add(this.radioButton1);
            this.sourceFileOptions.Controls.Add(this.browseButton);
            this.sourceFileOptions.Controls.Add(this.existingFileRadioButton);
            this.sourceFileOptions.Location = new System.Drawing.Point(26, 24);
            this.sourceFileOptions.Name = "sourceFileOptions";
            this.sourceFileOptions.Size = new System.Drawing.Size(567, 96);
            this.sourceFileOptions.TabIndex = 9;
            this.sourceFileOptions.TabStop = false;
            this.sourceFileOptions.Text = "Working File";
            // 
            // selectNewSourceFileButton
            // 
            this.selectNewSourceFileButton.Location = new System.Drawing.Point(486, 28);
            this.selectNewSourceFileButton.Name = "selectNewSourceFileButton";
            this.selectNewSourceFileButton.Size = new System.Drawing.Size(75, 23);
            this.selectNewSourceFileButton.TabIndex = 10;
            this.selectNewSourceFileButton.Text = "Select";
            this.selectNewSourceFileButton.UseVisualStyleBackColor = true;
            this.selectNewSourceFileButton.Click += new System.EventHandler(this.selectNewSourceFileButton_Click);
            // 
            // newSourceFile
            // 
            this.newSourceFile.Location = new System.Drawing.Point(103, 30);
            this.newSourceFile.Name = "newSourceFile";
            this.newSourceFile.ReadOnly = true;
            this.newSourceFile.Size = new System.Drawing.Size(377, 20);
            this.newSourceFile.TabIndex = 9;
            this.newSourceFile.TextChanged += new System.EventHandler(this.newSourceFile_TextChanged);
            // 
            // PDFManipulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 500);
            this.Controls.Add(this.sourceFileOptions);
            this.Controls.Add(this.removePagesControls);
            this.Controls.Add(this.insertPagesControls);
            this.Controls.Add(this.extractOptions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PDFManipulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF Utility";
            this.extractOptions.ResumeLayout(false);
            this.extractOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extractEndingPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extractStartPage)).EndInit();
            this.insertPagesControls.ResumeLayout(false);
            this.insertPagesControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insertAfterPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertEndPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertPageStart)).EndInit();
            this.removePagesControls.ResumeLayout(false);
            this.removePagesControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeEndPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeStartPage)).EndInit();
            this.sourceFileOptions.ResumeLayout(false);
            this.sourceFileOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button extractButton;
        private System.Windows.Forms.TextBox existingSourceFile;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.GroupBox extractOptions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown extractEndingPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown extractStartPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox extractFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button extractPathButton;
        private System.Windows.Forms.TextBox extractPath;
        private System.Windows.Forms.CheckBox individualPagesCheckbox;
        private System.Windows.Forms.GroupBox insertPagesControls;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown insertAfterPage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown insertEndPage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown insertPageStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button selectInsertFileButton;
        private System.Windows.Forms.TextBox insertFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox removePagesControls;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label currentPageCount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown removeEndPage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown removeStartPage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton existingFileRadioButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox sourceFileOptions;
        private System.Windows.Forms.Button selectNewSourceFileButton;
        private System.Windows.Forms.TextBox newSourceFile;
    }
}

