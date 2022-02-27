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

namespace TimeEntry
{
    public partial class formHourControl : Form
    {
        DateTime StartService = new DateTime();
        DateTime EndService = new DateTime();

        public formHourControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chkBoxServiceStart_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxServiceStart.Checked == true)
            {
                DateTime start = DateTime.Now;
                txtBoxServiceStart.Text = DateTime.Now.ToString("HH:mm:ss");
                StartService = DateTime.Now;
            }
        }

        private void dtpTotalHour_ValueChanged(object sender, EventArgs e)
        {
            //dtpTotalHour.Text = dtpServiceEnd.Text - dtpServiceStart.Text;
        }

        private void formHourControl_Load(object sender, EventArgs e)
        {
            txtBoxDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void chkBoxServiceEnd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxServiceEnd.Checked == true)
            {
                //stopwatch.Stop();
                txtBoxServiceEnd.Text = DateTime.Now.ToString("HH:mm:ss");
                //txtEndService.Text = DateTime.Now.ToString("HH:mm:ss");
                EndService = DateTime.Now;
                TimeSpan horasTrabalhadas = EndService.Subtract(StartService);
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", horasTrabalhadas.Hours,
                    horasTrabalhadas.Minutes, horasTrabalhadas.Seconds, horasTrabalhadas.Milliseconds / 10);
                txtBoxTesteTotalHours.Text = elapsedTime;
            }
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            var dirCompanyName = txtBoxCompany.Text;
            string dirOccurenceName = txtBoxOccurrence.Text;
            
            //Passa o caminho usando o Nome da Empresa + Nº Ocorrência;
            string directoryPath = @"c:\temp\" + dirCompanyName + @"\" + dirOccurenceName; 

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
                    MessageBox.Show("Created a folder for your ocurrence.", "Hour Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("The process failed", error.ToString());
            }

            try
            {
                string[] lines = { txtBoxDate.Text + " - " + txtBoxCompany.Text + " - " + txtBoxProject.Text + " - " + 
                        txtBoxOccurrence.Text + " - Total Horas: " + txtBoxTesteTotalHours.Text};

                //string filePath = @"c:\temp\";
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string fileName = "20-02-2022.txt";

                if (File.Exists(fileName))
                {
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "20-02-2022.txt"), true))
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
    }
}
