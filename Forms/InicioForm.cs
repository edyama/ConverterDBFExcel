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
            excelButton.Checked = true;
            libreButton.Checked = false;
        }

        private void excelButton_Click(object sender, EventArgs e)
        {
            excelButton.Checked = true;
            libreButton.Checked = false;
        }

        private void libreButton_Click(object sender, EventArgs e)
        {
            excelButton.Checked = false;
            libreButton.Checked = true;
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

                if (carregarDialog.ShowDialog() == DialogResult.OK)
                {
                    if (carregarDialog.FileName != "" && excelButton.Checked)
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
                    else if (carregarDialog.FileName != "" && libreButton.Checked)
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
                            FileName = "soffice", // Caminho para o executável do LibreOffice
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
    }
}

/*
using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main()
    {
        string dbfFile = "arquivo.dbf"; // Caminho para o arquivo DBF
        string xlsxFile = "arquivo.xlsx"; // Caminho para o arquivo XLSX de saída

        try
        {
            // Criar um novo processo para executar o LibreOffice
            var processStartInfo = new ProcessStartInfo
            {
                FileName = "soffice", // Caminho para o executável do LibreOffice
                Arguments = $"--convert-to xlsx --outdir \"{Path.GetDirectoryName(xlsxFile)}\" \"{dbfFile}\"",
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

            if (process.ExitCode == 0)
            {
                Console.WriteLine("Conversão concluída com sucesso!");
            }
            else
            {
                Console.WriteLine("Ocorreu um erro durante a conversão:");
                Console.WriteLine(error);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocorreu um erro durante a conversão: " + ex.Message);
        }
    }
}

*/