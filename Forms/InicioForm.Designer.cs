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
            this.appComboBox = new System.Windows.Forms.ComboBox();
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
            // appComboBox
            // 
            this.appComboBox.FormattingEnabled = true;
            this.appComboBox.Items.AddRange(new object[] {
            "Excel",
            "LibreOffice",
            "LibreOffice 32-bits"});
            this.appComboBox.Location = new System.Drawing.Point(264, 163);
            this.appComboBox.Name = "appComboBox";
            this.appComboBox.Size = new System.Drawing.Size(168, 24);
            this.appComboBox.TabIndex = 2;
            this.appComboBox.SelectedIndexChanged += new System.EventHandler(this.appComboBox_SelectedIndexChanged);
            // 
            // InicioForm
            // 
            this.ClientSize = new System.Drawing.Size(489, 246);
            this.Controls.Add(this.appComboBox);
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
        private System.Windows.Forms.ComboBox appComboBox;
    }
}