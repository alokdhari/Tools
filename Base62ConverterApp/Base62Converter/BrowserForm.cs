namespace Base62Convertor
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    public partial class BrowserForm : Form
    {
        private string FileLocation;

        public BrowserForm()
        {
            InitializeComponent();
        }

        private void BrowserButton_Click(object sender, EventArgs e)
        {
            if (fileBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                FileLocation = folderBrowserDialog1.SelectedPath + fileBrowserDialog.FileName;
            }

            finalOutputTextBox.Text = this.converter(FileLocation);
        }

        private string converter(string file)
        {
            byte[] binaryData;
            string base64 = "NULL";

            var fileInfo = new FileInfo(file);

            if (string.IsNullOrEmpty(file))
            {
                return "Please do select a file.";
            }

            if (fileInfo.Length > 200000)
            {
                return "File is too big to be converted.";
            }

            try
            {
                var fs = new FileStream(file, FileMode.Open, FileAccess.Read);
                binaryData = new byte[fs.Length];
                var bytesRead = fs.Read(binaryData, 0, (int)fs.Length);
                fs.Close();
            }
            catch (System.Exception ex)
            {
                base64 = ex.ToString();
                return base64;
            }

            try
            {
                base64 = System.Convert.ToBase64String(binaryData, 0, binaryData.Length);
            }
            catch(System.ArgumentNullException)
            {
                base64 = "Binary Data Null";
            }

            return base64;
        }
    }
}
