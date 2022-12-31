using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterDBFExcel.Forms
{
    public partial class InicioForm : Form
    {
        public InicioForm()
        {
            InitializeComponent();
        }

        private void carregarButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog carregarDialog = new OpenFileDialog();
                carregarDialog.Title = "Selecionar arquivo";
                carregarDialog.InitialDirectory = @"C:\\";
                carregarDialog.Filter = "All Files (*.*)|*.*|Database File(*.dbf)|*.dbf";
                carregarDialog.FilterIndex = 2;
                carregarDialog.RestoreDirectory = true;

                if (carregarDialog.ShowDialog() == DialogResult.OK)
                {
                    if (carregarDialog.FileName != "")
                    {
                        carregarTextBox.Text = carregarDialog.FileName;
                    }
                    else
                    {
                        carregarTextBox.Text = "";
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Erro: " + error.Message);            
            }
        }

        private void abrirButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog abrirDialog = new OpenFileDialog();
                abrirDialog.Title = "Selecionar arquivo";
                abrirDialog.InitialDirectory = @"C:\\";
                abrirDialog.Filter = "All Files (*.*)|*.*|Excel File(*.xlsx)|*.xlsx|Excel Legacy File(*.xls)|*.xls";
                abrirDialog.FilterIndex = 2;
                abrirDialog.RestoreDirectory = true;

                if (abrirDialog.ShowDialog() == DialogResult.OK)
                {
                    if (abrirDialog.FileName != "")
                    {
                        abrirTextBox.Text = abrirDialog.FileName;
                    }
                    else
                    {
                        abrirTextBox.Text = "";
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Erro: " + error.Message);
            }
        }

        private void converterButton_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception error)
            {
                Console.WriteLine("Erro: " + error.Message);
            }
        }

        private void carregarTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void abrirTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
