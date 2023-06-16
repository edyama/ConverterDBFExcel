namespace ConverterDBFExcel.Forms
{
    partial class InicioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioForm));
            this.converterTextBox = new System.Windows.Forms.TextBox();
            this.converterButton = new System.Windows.Forms.Button();
            this.excelButton = new System.Windows.Forms.RadioButton();
            this.libreButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // converterTextBox
            // 
            this.converterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.converterTextBox.Location = new System.Drawing.Point(12, 40);
            this.converterTextBox.Multiline = true;
            this.converterTextBox.Name = "converterTextBox";
            this.converterTextBox.Size = new System.Drawing.Size(465, 117);
            this.converterTextBox.TabIndex = 0;
            this.converterTextBox.TextChanged += new System.EventHandler(this.converterTextBox_TextChanged);
            // 
            // converterButton
            // 
            this.converterButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.converterButton.Location = new System.Drawing.Point(12, 163);
            this.converterButton.Name = "converterButton";
            this.converterButton.Size = new System.Drawing.Size(128, 36);
            this.converterButton.TabIndex = 1;
            this.converterButton.Text = "Converter";
            this.converterButton.UseVisualStyleBackColor = true;
            this.converterButton.Click += new System.EventHandler(this.carregarButton_Click);
            // 
            // excelButton
            // 
            this.excelButton.AutoSize = true;
            this.excelButton.Location = new System.Drawing.Point(300, 164);
            this.excelButton.Name = "excelButton";
            this.excelButton.Size = new System.Drawing.Size(61, 20);
            this.excelButton.TabIndex = 2;
            this.excelButton.TabStop = true;
            this.excelButton.Text = "Excel";
            this.excelButton.UseVisualStyleBackColor = true;
            // 
            // libreButton
            // 
            this.libreButton.AutoSize = true;
            this.libreButton.Location = new System.Drawing.Point(300, 190);
            this.libreButton.Name = "libreButton";
            this.libreButton.Size = new System.Drawing.Size(92, 20);
            this.libreButton.TabIndex = 3;
            this.libreButton.TabStop = true;
            this.libreButton.Text = "LibreOffice";
            this.libreButton.UseVisualStyleBackColor = true;
            // 
            // InicioForm
            // 
            this.ClientSize = new System.Drawing.Size(489, 238);
            this.Controls.Add(this.libreButton);
            this.Controls.Add(this.excelButton);
            this.Controls.Add(this.converterButton);
            this.Controls.Add(this.converterTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InicioForm";
            this.Text = "Converter DBF Excel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox converterTextBox;
        private System.Windows.Forms.Button converterButton;
        private System.Windows.Forms.RadioButton excelButton;
        private System.Windows.Forms.RadioButton libreButton;
    }
}