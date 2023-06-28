using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
                // Abre a janela que solicita a escolha do arquivo a ser convertido
                OpenFileDialog carregarDialog = new OpenFileDialog();
                carregarDialog.Title = "Selecionar arquivo";
                carregarDialog.InitialDirectory = @"C:\\";
                carregarDialog.Filter = "All Files (*.*)|*.*|Database File(*.dbf)|*.dbf";
                carregarDialog.FilterIndex = 2;
                carregarDialog.RestoreDirectory = true;

                if (carregarDialog.ShowDialog() == DialogResult.OK && carregarDialog.FileName != "")
                {
                    if (appComboBox.SelectedIndex == 0)
                    {
                        try
                        {
                            // Converte o arquivo em .xlsx
                            string fileDbf = carregarDialog.FileName;
                            string fileXlsx = "";

                            if (fileDbf.Contains(".DBF"))
                            {
                                fileXlsx = fileDbf.Replace(".DBF", ".xlsx");
                            }
                            else
                            {
                                fileXlsx = fileDbf.Replace(".dbf", ".xlsx");
                            }

                            // Criar uma instância do Excel
                            var excelApp = new Microsoft.Office.Interop.Excel.Application();
                            excelApp.Visible = false;
                            excelApp.DisplayAlerts = false;

                            // Abrir o arquivo DBF
                            var workbook = excelApp.Workbooks.Open(fileDbf, Missing.Value, Missing.Value, Missing.Value,
                                Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                                Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                                Missing.Value, Missing.Value, Missing.Value);

                            // Salvar o arquivo em formato XLSX
                            workbook.SaveAs(fileXlsx, XlFileFormat.xlOpenXMLWorkbook);

                            // Fechar o arquivo e sair do Excel
                            workbook.Close();
                            excelApp.Quit();

                            // O texto que anuncia a conclusão da conversão é escrito
                            converterTextBox.Text = "Banco de dados " + carregarDialog.FileName + " é convertido em " + fileXlsx;
                        }
                        catch (Exception error)
                        {
                            converterTextBox.Text = "Erro: " + error.Message;
                        }
                    }
                    else if (appComboBox.SelectedIndex == 1)
                    {
                        try
                        {
                            // Converte o arquivo em .xlsx
                            string fileDbf = carregarDialog.FileName;
                            string fileXlsx = "";

                            if (fileDbf.Contains(".DBF"))
                            {
                                fileXlsx = fileDbf.Replace(".DBF", ".xlsx");
                            }
                            else
                            {
                                fileXlsx = fileDbf.Replace(".dbf", ".xlsx");
                            }

                            // Criar um novo processo para executar o LibreOffice
                            var processStartInfo = new ProcessStartInfo
                            {
                                FileName = "C:\\Program Files\\LibreOffice\\program\\soffice.exe", // Caminho para o executável do LibreOffice
                                Arguments = $"--convert-to xlsx --outdir \"{Path.GetDirectoryName(fileXlsx)}\" \"{fileDbf}\"",
                                RedirectStandardOutput = true,
                                RedirectStandardError = true,
                                UseShellExecute = false,
                                CreateNoWindow = true
                            };

                            // Executar o processo
                            var process = new Process();
                            process.StartInfo = processStartInfo;
                            process.Start();

                            // Ler e exibir a saída do processo
                            string output = process.StandardOutput.ReadToEnd();
                            string error = process.StandardError.ReadToEnd();
                            process.WaitForExit();

                            // O texto que anuncia a conclusão da conversão é escrito
                            converterTextBox.Text = "Banco de dados " + carregarDialog.FileName + " é convertido em " + fileXlsx;
                        }
                        catch (Exception error)
                        {
                            converterTextBox.Text = "Erro: " + error.Message;
                        }
                    }
                    else if (appComboBox.SelectedIndex == 2)
                    {
                        try
                        {
                            // Converte o arquivo em .xlsx
                            string fileDbf = carregarDialog.FileName;
                            string fileXlsx = "";

                            if (fileDbf.Contains(".DBF"))
                            {
                                fileXlsx = fileDbf.Replace(".DBF", ".xlsx");
                            }
                            else
                            {
                                fileXlsx = fileDbf.Replace(".dbf", ".xlsx");
                            }

                            // Criar um novo processo para executar o LibreOffice
                            var processStartInfo = new ProcessStartInfo
                            {
                                FileName = "C:\\Program Files (x86)\\LibreOffice\\program\\soffice.exe", // Caminho para o executável do LibreOffice
                                Arguments = $"--convert-to xlsx --outdir \"{Path.GetDirectoryName(fileXlsx)}\" \"{fileDbf}\"",
                                RedirectStandardOutput = true,
                                RedirectStandardError = true,
                                UseShellExecute = false,
                                CreateNoWindow = true
                            };

                            // Executar o processo
                            var process = new Process();
                            process.StartInfo = processStartInfo;
                            process.Start();

                            // Ler e exibir a saída do processo
                            string output = process.StandardOutput.ReadToEnd();
                            string error = process.StandardError.ReadToEnd();
                            process.WaitForExit();

                            // O texto que anuncia a conclusão da conversão é escrito
                            converterTextBox.Text = "Banco de dados " + carregarDialog.FileName + " é convertido em " + fileXlsx;
                        }
                        catch (Exception error)
                        {
                            converterTextBox.Text = "Erro: " + error.Message;
                        }
                    }
                    else
                    {
                        converterTextBox.Text = "";
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Erro: " + error.Message);
            }
        }

        private void converterTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void appComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}