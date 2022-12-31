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
            this.carregarTextBox = new System.Windows.Forms.TextBox();
            this.carregarButton = new System.Windows.Forms.Button();
            this.abrirButton = new System.Windows.Forms.Button();
            this.abrirTextBox = new System.Windows.Forms.TextBox();
            this.converterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // carregarTextBox
            // 
            this.carregarTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carregarTextBox.Location = new System.Drawing.Point(12, 40);
            this.carregarTextBox.Multiline = true;
            this.carregarTextBox.Name = "carregarTextBox";
            this.carregarTextBox.Size = new System.Drawing.Size(456, 36);
            this.carregarTextBox.TabIndex = 0;
            this.carregarTextBox.TextChanged += new System.EventHandler(this.carregarTextBox_TextChanged);
            // 
            // carregarButton
            // 
            this.carregarButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carregarButton.Location = new System.Drawing.Point(486, 40);
            this.carregarButton.Name = "carregarButton";
            this.carregarButton.Size = new System.Drawing.Size(92, 36);
            this.carregarButton.TabIndex = 1;
            this.carregarButton.Text = "Carregar";
            this.carregarButton.UseVisualStyleBackColor = true;
            this.carregarButton.Click += new System.EventHandler(this.carregarButton_Click);
            // 
            // abrirButton
            // 
            this.abrirButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.abrirButton.Location = new System.Drawing.Point(486, 97);
            this.abrirButton.Name = "abrirButton";
            this.abrirButton.Size = new System.Drawing.Size(92, 36);
            this.abrirButton.TabIndex = 3;
            this.abrirButton.Text = "Abrir";
            this.abrirButton.UseVisualStyleBackColor = true;
            this.abrirButton.Click += new System.EventHandler(this.abrirButton_Click);
            // 
            // abrirTextBox
            // 
            this.abrirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.abrirTextBox.Location = new System.Drawing.Point(12, 97);
            this.abrirTextBox.Multiline = true;
            this.abrirTextBox.Name = "abrirTextBox";
            this.abrirTextBox.Size = new System.Drawing.Size(456, 36);
            this.abrirTextBox.TabIndex = 2;
            this.abrirTextBox.TextChanged += new System.EventHandler(this.abrirTextBox_TextChanged);
            // 
            // converterButton
            // 
            this.converterButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.converterButton.Location = new System.Drawing.Point(250, 163);
            this.converterButton.Name = "converterButton";
            this.converterButton.Size = new System.Drawing.Size(92, 36);
            this.converterButton.TabIndex = 4;
            this.converterButton.Text = "Converter";
            this.converterButton.UseVisualStyleBackColor = true;
            this.converterButton.Click += new System.EventHandler(this.converterButton_Click);
            // 
            // InicioForm
            // 
            this.ClientSize = new System.Drawing.Size(590, 211);
            this.Controls.Add(this.converterButton);
            this.Controls.Add(this.abrirButton);
            this.Controls.Add(this.abrirTextBox);
            this.Controls.Add(this.carregarButton);
            this.Controls.Add(this.carregarTextBox);
            this.Name = "InicioForm";
            this.Text = "Converter DBF Excel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox carregarTextBox;
        private System.Windows.Forms.Button carregarButton;
        private System.Windows.Forms.Button abrirButton;
        private System.Windows.Forms.TextBox abrirTextBox;
        private System.Windows.Forms.Button converterButton;
    }
}