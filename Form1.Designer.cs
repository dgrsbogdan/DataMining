namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.PragBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FileChoiceBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valoare Prag";
            // 
            // PragBox
            // 
            this.PragBox.Location = new System.Drawing.Point(95, 57);
            this.PragBox.Name = "PragBox";
            this.PragBox.ReadOnly = true;
            this.PragBox.Size = new System.Drawing.Size(160, 20);
            this.PragBox.TabIndex = 1;
            this.PragBox.Text = "Introduceti o valoare numerica";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // FileChoiceBtn
            // 
            this.FileChoiceBtn.Location = new System.Drawing.Point(16, 112);
            this.FileChoiceBtn.Name = "FileChoiceBtn";
            this.FileChoiceBtn.Size = new System.Drawing.Size(73, 30);
            this.FileChoiceBtn.TabIndex = 2;
            this.FileChoiceBtn.Text = "File Choice";
            this.FileChoiceBtn.UseVisualStyleBackColor = true;
            this.FileChoiceBtn.Click += new System.EventHandler(this.FileChoiceBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FileChoiceBtn);
            this.Controls.Add(this.PragBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PragBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button FileChoiceBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

