namespace Base64Convertor
{
    partial class BrowserForm
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
            this.BrowserButton = new System.Windows.Forms.Button();
            this.fileBrowserDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.finalOutputTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BrowserButton
            // 
            this.BrowserButton.Location = new System.Drawing.Point(28, 54);
            this.BrowserButton.Name = "BrowserButton";
            this.BrowserButton.Size = new System.Drawing.Size(110, 23);
            this.BrowserButton.TabIndex = 0;
            this.BrowserButton.Text = "Select File";
            this.BrowserButton.UseVisualStyleBackColor = true;
            this.BrowserButton.Click += new System.EventHandler(this.BrowserButton_Click);
            // 
            // fileBrowserDialog
            // 
            this.fileBrowserDialog.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Designed by ALOK DHARI SINGH";
            // 
            // finalOutputTextBox
            // 
            this.finalOutputTextBox.Location = new System.Drawing.Point(28, 99);
            this.finalOutputTextBox.Name = "finalOutputTextBox";
            this.finalOutputTextBox.Size = new System.Drawing.Size(454, 248);
            this.finalOutputTextBox.TabIndex = 4;
            this.finalOutputTextBox.Text = "Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Please select files below 2 MB. ";
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 395);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.finalOutputTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BrowserButton);
            this.Name = "BrowserForm";
            this.Text = "Any file to BASE64 converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowserButton;
        private System.Windows.Forms.OpenFileDialog fileBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox finalOutputTextBox;
        private System.Windows.Forms.Label label3;
    }
}

