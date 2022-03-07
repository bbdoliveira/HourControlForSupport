using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeEntry.Entities;

namespace TimeEntry
{
    public partial class frmHourControl : Form
    {
        DateTime StartService = new DateTime();
        DateTime EndService = new DateTime();
        HoraDia hora = new HoraDia();

        public frmHourControl()
        {
            InitializeComponent();
        }

        private void chkBoxServiceStart_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxServiceStart.Checked == true)
            {
                DateTime start = DateTime.Now;
                txtBoxServiceStart.Text = DateTime.Now.ToString("HH:mm:ss");
                StartService = DateTime.Now;
                //hora = 10;
            }
            else
            {
                txtBoxServiceStart.Text = "00:00:00";
            }
        }

        private void formHourControl_Load(object sender, EventArgs e)
        {
            txtBoxDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void chkBoxServiceEnd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxServiceEnd.Checked == true)
            {
                txtBoxServiceEnd.Text = DateTime.Now.ToString("HH:mm:ss");
                EndService = DateTime.Now;
                TimeSpan horasTrabalhadas = EndService.Subtract(StartService);
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", horasTrabalhadas.Hours,
                    horasTrabalhadas.Minutes, horasTrabalhadas.Seconds, horasTrabalhadas.Milliseconds / 10);
                txtBoxTesteTotalHours.Text = elapsedTime;


            }
            else
            {
                //Zera a caixa de EndService caso esteja desmarcado.
                txtBoxServiceEnd.Text = "00:00:00";
            }
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            if (chkBoxCreateFolder.Checked)
            {
                var dirCompanyName = txtBoxCompany.Text;
                string dirOccurenceName = txtBoxOccurrence.Text;
                var newDirectoryPatch = txtBoxDefaultDirectoryPath.Text;

                //Passa o caminho usando o Nome da Empresa + Nº Ocorrência;
                //string directoryPath = @"c:\temp\" + dirCompanyName + @"\" + dirOccurenceName;
                string directoryPath = newDirectoryPatch + dirCompanyName + @"\" + dirOccurenceName;

                try
                {
                    //Teste se o diretório exite! Caso exista ele apresenta uma mensagem de erro.
                    if (Directory.Exists(directoryPath))
                    {
                        MessageBox.Show("That path axists already.", "Hour Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //Cria a pasta e mostra uma mensagem confirmando.
                        DirectoryInfo di = Directory.CreateDirectory(directoryPath);
                        MessageBox.Show("Pasta Criada!", "Hour Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine("The process failed", error.ToString());
                }
            }

            try
            {
                string[] lines = { txtBoxDate.Text + " - " + txtBoxCompany.Text + " - " + mskTextBoxProject.Text + " - " + txtBoxOccurrence.Text + " - Total Horas: " + txtBoxTesteTotalHours.Text + " - " + txtBoxServiceDescription.Text };

                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string fileName = "Marco";

                FileInfo fileInfo = new FileInfo(@"c:\temp\" + fileName + ".txt");

                if (!fileInfo.Exists)
                {
                    using (StreamWriter sw = fileInfo.CreateText())
                    {
                        foreach (string line in lines)
                        {
                            sw.WriteLine(line);
                            MessageBox.Show("Criado arquivo com registro de horas!", "Contorle de Horas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    using (StreamWriter sw = fileInfo.AppendText())
                    {
                        foreach (string line in lines)
                        {
                            sw.WriteLine(line);
                            MessageBox.Show("Seu arquivo de controle de horas foi atualizado!", "Controle de Horas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (File.Exists(fileName))
                {
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "20 -02-2022.txt"), true))
                    {
                        outputFile.WriteLine(lines);
                    }      
                }
                else
                {
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "20-02-2022.txt")))
                    {
                        foreach (string line in lines)
                        {
                            outputFile.WriteLine(line);
                        }
                    }

                }
            }
            catch (Exception fileError)
            {
                MessageBox.Show(fileError.ToString(), "Hour Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBoxCompany_TextChanged(object sender, EventArgs e)
        {
            txtBoxCompany.Focus();
        }

        private void chkBoxCreateFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxCreateFolder.Checked)
            {
                txtBoxDefaultDirectoryPath.Enabled = true;
                btnDirectorySearch.Enabled = true;
            }
            else
            {
                txtBoxDefaultDirectoryPath.Enabled = false;
                btnDirectorySearch.Enabled = false;
            }
        }
    }
}
