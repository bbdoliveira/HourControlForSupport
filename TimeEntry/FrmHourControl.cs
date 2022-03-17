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
        DateTime StartServiceFirst = new DateTime();
        DateTime StartServiceSecond = new DateTime();
        DateTime StartServiceThird = new DateTime();

        DateTime EndServiceFirst = new DateTime();
        DateTime EndServiceSecond = new DateTime();
        DateTime EndServiceThird = new DateTime();

        public frmHourControl()
        {
            InitializeComponent();
        }

        private void chkBoxServiceStart_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxServiceStartFirstOcurrence.Checked == true)
            {
                txtBoxServiceStartFirstOcurrence.Text = DateTime.Now.ToString("HH:mm:ss");
                StartServiceFirst = DateTime.Now;
            }
            else
            {
                txtBoxServiceStartFirstOcurrence.Text = "00:00:00";
            }
        }

        private void formHourControl_Load(object sender, EventArgs e)
        {
            txtBoxDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void chkBoxServiceEnd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxServiceEndFirstOcurrence.Checked == true)
            {
                txtBoxServiceEndFirstOcurrence.Text = DateTime.Now.ToString("HH:mm:ss");
                EndServiceFirst = DateTime.Now;
                TimeSpan horasTrabalhadas = EndServiceFirst.Subtract(StartServiceFirst);
                //TimeControl teste = new TimeControl();
                //teste.TimeWorked(StartService, EndService);
                //TimeSpan juju = teste.TimeWorked(StartService, EndService);
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", horasTrabalhadas.Hours,
                    horasTrabalhadas.Minutes, horasTrabalhadas.Seconds, horasTrabalhadas.Milliseconds / 10);
                txtBoxTotalHoursFirstOcurrence.Text = elapsedTime;
                //string elapsedTime = $"{teste:hh\\:mm\\:ss}";
                txtBoxTotalHoursFirstOcurrence.Text = elapsedTime;
            }
            else
            {
                //Zera a caixa de EndService caso esteja desmarcado.
                txtBoxServiceEndFirstOcurrence.Text = "00:00:00";
            }
        }

        private void chkBoxServiceStartSecondOcurrence_CheckedChanged(object sender, EventArgs e)
        {
            //Quando marcada Checkbox ele pega a hora atual e coloca do inicio da Segunda ocorrência.
            if (chkBoxServiceStartSecondOcurrence.Checked == true)
            {
                txtBoxServiceStartSecondOcurrence.Text = DateTime.Now.ToString("HH:mm:ss");
                StartServiceSecond = DateTime.Now;
            }
            else
            {
                txtBoxServiceStartSecondOcurrence.Text = "00:00:00";
            }
        }

        private void chkBoxServiceEndSecondOcurrence_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxServiceEndSecondOcurrence.Checked == true)
            {
                txtBoxServiceEndSecondOcurrence.Text = DateTime.Now.ToString("HH:mm:ss");
                EndServiceSecond = DateTime.Now;
                TimeSpan horasTrabalhadas = EndServiceSecond.Subtract(StartServiceSecond);
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", horasTrabalhadas.Hours,
                    horasTrabalhadas.Minutes, horasTrabalhadas.Seconds, horasTrabalhadas.Milliseconds / 10);
                txtBoxTotalHoursSecondOcurrence.Text = elapsedTime;
            }
            else
            {
                //Zera a caixa de EndService caso esteja desmarcado.
                txtBoxServiceEndSecondOcurrence.Text = "00:00:00";
            }
        }

        private void chkBoxServiceStartThirdOcurrence_CheckedChanged(object sender, EventArgs e)
        {
            //Quando marcada Checkbox ele pega a hora atual e coloca do inicio da Segunda ocorrência.
            if (chkBoxServiceStartThirdOcurrence.Checked == true)
            {
                txtBoxServiceStartThirdOcurrence.Text = DateTime.Now.ToString("HH:mm:ss");
                StartServiceThird = DateTime.Now;
            }
            else
            {
                txtBoxServiceStartThirdOcurrence.Text = "00:00:00";
            }
        }

        private void chkBoxServiceEndThirdOcurrence_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxServiceEndThirdOcurrence.Checked == true)
            {
                txtBoxServiceEndThirdOcurrence.Text = DateTime.Now.ToString("HH:mm:ss");
                EndServiceThird = DateTime.Now;
                TimeSpan horasTrabalhadas = EndServiceThird.Subtract(StartServiceThird);
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", horasTrabalhadas.Hours,
                    horasTrabalhadas.Minutes, horasTrabalhadas.Seconds, horasTrabalhadas.Milliseconds / 10);
                txtBoxTotalHoursThirdOcurrence.Text = elapsedTime;
            }
            else
            {
                //Zera a caixa de EndService caso esteja desmarcado.
                txtBoxServiceEndThirdOcurrence.Text = "00:00:00";
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
                        MessageBox.Show("That path axists already.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //Cria a pasta e mostra uma mensagem confirmando.
                        DirectoryInfo di = Directory.CreateDirectory(directoryPath);
                        MessageBox.Show("Pasta Criada!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine("The process failed", error.ToString());
                }
            }

            try
            {
                string[] lines = { txtBoxDate.Text + " - " + txtBoxCompany.Text + " - " + mskTextBoxProject.Text + " - " + txtBoxOccurrence.Text + " - Total Horas: " + txtBoxTotalHoursFirstOcurrence.Text + " - " + txtBoxServiceDescription.Text };

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
                            MessageBox.Show("Criado arquivo com registro de horas!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            MessageBox.Show("Seu arquivo de controle de horas foi atualizado!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
