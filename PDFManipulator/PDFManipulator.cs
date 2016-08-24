using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Acrobat;

namespace PDFManipulator
{
    public partial class PDFManipulator : Form
    {
        private PdfSharp.Pdf.PdfDocument sourceDocument;
        private PdfSharp.Pdf.PdfDocument insertDocument;

        public PDFManipulator()
        {
            InitializeComponent();
            extractPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            extractFile.Text = "NewExtractFile.pdf";
        }

        private void OnSourceFileChange(SourceFileChangedEventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (sourceDocument == null || sourceDocument.FullPath != newSourceFile.Text)
                {
                    if (File.Exists(newSourceFile.Text)) sourceDocument = PdfSharp.Pdf.IO.PdfReader.Open(newSourceFile.Text, PdfSharp.Pdf.IO.PdfDocumentOpenMode.Import);
                    else
                    {
                        sourceDocument = new PdfSharp.Pdf.PdfDocument();
                    }
                }
            }
            else if (existingFileRadioButton.Checked)
            {
                if (sourceDocument == null || sourceDocument.FullPath != existingSourceFile.Text)
                {
                    sourceDocument = PdfSharp.Pdf.IO.PdfReader.Open(existingSourceFile.Text, PdfSharp.Pdf.IO.PdfDocumentOpenMode.Import);
                }
            }
            if (sourceDocument.PageCount > 0)
            {
                extractStartPage.Minimum = 1;
                extractStartPage.Maximum = sourceDocument.PageCount;
                extractStartPage.Value = 1;
                extractEndingPage.Minimum = 1;
                extractEndingPage.Maximum = sourceDocument.PageCount;
                extractEndingPage.Value = 1;
                insertAfterPage.Minimum = 1;
                insertAfterPage.Maximum = sourceDocument.PageCount;
                if (e.ChangeType == SourceFileChangedEventArgs.ChangeTypes.Insert && insertAfterPage.Value < insertAfterPage.Maximum) insertAfterPage.Value += 1;
                currentPageCount.Text = sourceDocument.PageCount.ToString();
                removeStartPage.Minimum = 1;
                removeStartPage.Maximum = sourceDocument.PageCount;
                removeStartPage.Value = 1;
                removeEndPage.Minimum = 1;
                removeEndPage.Maximum = sourceDocument.PageCount;
                removeEndPage.Value = 1;

                // Draw preview
                
            }
            extractOptions.Enabled = sourceDocument.PageCount > 0;
            insertPagesControls.Enabled = true;
            removePagesControls.Enabled = sourceDocument.PageCount > 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sourceDocument != null && sourceDocument.PageCount > 0)
            {
                PdfSharp.Pdf.PdfDocument splitDoc = new PdfSharp.Pdf.PdfDocument();
                for (int i = (int)(extractStartPage.Value - 1); i < (int)extractEndingPage.Value; i++)
                {
                    splitDoc.AddPage(sourceDocument.Pages[i]);
                    if (individualPagesCheckbox.Checked)
                    {
                        splitDoc.Save(extractPath.Text + "\\" + extractFile.Text.Replace(".pdf", "_Page" + (i + 1).ToString() + ".pdf"));
                        splitDoc = new PdfSharp.Pdf.PdfDocument();
                    }
                }
                if (!individualPagesCheckbox.Checked) splitDoc.Save(extractPath.Text + "\\" + extractFile.Text);
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openSource = new OpenFileDialog();
            openSource.Filter = "PDF Files (*.pdf) | *.pdf";
            openSource.Title = "Open Source File";
            if (openSource.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                existingSourceFile.Text = openSource.FileName;
                OnSourceFileChange(new SourceFileChangedEventArgs(openSource.FileName, SourceFileChangedEventArgs.ChangeTypes.FileChange));
            }
        }

        private void sourceFile_TextChanged(object sender, EventArgs e)
        {
            if (existingFileRadioButton.Checked)
            {
                selectNewSourceFileButton.Enabled = false;
                browseButton.Enabled = true;
            }
        }

        private void extractPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog extractPathSelect = new FolderBrowserDialog();
            if (Directory.Exists(extractPath.Text)) extractPathSelect.SelectedPath = extractPath.Text;
            else extractPathSelect.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (extractPathSelect.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                extractPath.Text = extractPathSelect.SelectedPath;
            }
        }

        private void selectInsertFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openInsertFile = new OpenFileDialog();
            openInsertFile.Title = "Select Insert File";
            openInsertFile.Filter = "PDF Files (*.pdf) | *.pdf";
            openInsertFile.AddExtension = true;
            openInsertFile.DefaultExt = "pdf";
            openInsertFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openInsertFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                insertFile.Text = openInsertFile.FileName;
                insertDocument = PdfSharp.Pdf.IO.PdfReader.Open(openInsertFile.FileName, PdfSharp.Pdf.IO.PdfDocumentOpenMode.Import);
                if (insertDocument.PageCount > 0)
                {
                    insertPageStart.Minimum = 1;
                    insertPageStart.Maximum = insertDocument.PageCount;
                    insertPageStart.Value = 1;
                    insertEndPage.Minimum = 1;
                    insertEndPage.Maximum = insertDocument.PageCount;
                    insertEndPage.Value = insertDocument.PageCount;
                }
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (insertDocument != null && sourceDocument != null && insertDocument.PageCount > 0)
            {
                for (int i = (int)insertPageStart.Value - 1; i < (int)insertEndPage.Value; i++)
                {
                    sourceDocument.Pages.Insert((int)insertAfterPage.Value, insertDocument.Pages[i]);
                }
                if (radioButton1.Checked) sourceDocument.Save(newSourceFile.Text);
                else if (existingFileRadioButton.Checked) sourceDocument.Save(existingSourceFile.Text);
                OnSourceFileChange(new SourceFileChangedEventArgs(sourceDocument.FullPath, SourceFileChangedEventArgs.ChangeTypes.Insert));
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int removeIndex = (int)removeStartPage.Value - 1;
            int removeCount = (int)removeEndPage.Value - (int)removeStartPage.Value + 1;
            for (int i = 0; i < removeCount; i++)
            {
                if (removeIndex < sourceDocument.PageCount) sourceDocument.Pages.RemoveAt(removeIndex);
            }
            if (radioButton1.Checked) sourceDocument.Save(newSourceFile.Text);
            else if (existingFileRadioButton.Checked) sourceDocument.Save(existingSourceFile.Text);
            OnSourceFileChange(new SourceFileChangedEventArgs(sourceDocument.FullPath, SourceFileChangedEventArgs.ChangeTypes.Remove));
            //currentPageCount.Text = sourceDocument.PageCount.ToString();
            //if (removeStartPage.Value > sourceDocument.PageCount) removeStartPage.Value = sourceDocument.PageCount;
            //if (removeEndPage.Value > sourceDocument.PageCount) removeEndPage.Value = sourceDocument.PageCount;
        }

        private void selectNewSourceFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog selectFile = new SaveFileDialog();
            selectFile.Filter = "PDF Files (*.pdf)|*.pdf";
            selectFile.Title = "Select New File";
            selectFile.FileName = "NewFile.pdf";
            selectFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (selectFile.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                newSourceFile.Text = selectFile.FileName;
                OnSourceFileChange(new SourceFileChangedEventArgs(newSourceFile.Text, SourceFileChangedEventArgs.ChangeTypes.FileChange));
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (!File.Exists(newSourceFile.Text))
                {
                    SaveFileDialog selectFile = new SaveFileDialog();
                    selectFile.Filter = "PDF Files (*.pdf)|*.pdf";
                    selectFile.Title = "Select New File";
                    selectFile.FileName = "NewFile.pdf";
                    selectFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    if (selectFile.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    {
                        newSourceFile.Text = selectFile.FileName;
                    }
                }
                OnSourceFileChange(new SourceFileChangedEventArgs(newSourceFile.Text, SourceFileChangedEventArgs.ChangeTypes.FileChange));
            }
        }

        private void existingFileRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (existingFileRadioButton.Checked)
            {
                if (!File.Exists(existingSourceFile.Text))
                {
                    OpenFileDialog openSource = new OpenFileDialog();
                    openSource.Filter = "PDF Files (*.pdf) | *.pdf";
                    openSource.Title = "Open Source File";
                    if (openSource.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        existingSourceFile.Text = openSource.FileName;
                    }
                }
                OnSourceFileChange(new SourceFileChangedEventArgs(existingSourceFile.Text, SourceFileChangedEventArgs.ChangeTypes.FileChange));
            }
        }

        private void newSourceFile_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                selectNewSourceFileButton.Enabled = true;
                browseButton.Enabled = false;
            }
        }
    }

    public class SourceFileChangedEventArgs : EventArgs
    {
        public enum ChangeTypes
        {
            FileChange,
            Insert,
            Remove
        }

        public String FileName { get; set; }
        public ChangeTypes ChangeType { get; set; }

        public SourceFileChangedEventArgs(String filename, ChangeTypes changeType)
        {
            FileName = filename;
            ChangeType = changeType;
        }
    }
}
