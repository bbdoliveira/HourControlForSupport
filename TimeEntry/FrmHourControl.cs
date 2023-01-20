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
using TimeEntry.Enums;

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

        //Aqui acontece o carregamento do Form Principal.
        private void formHourControl_Load(object sender, EventArgs e)
        {
            txtBoxDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
            chkBoxServiceEndFirstOcurrence.Enabled = false;
            chkBoxServiceEndSecondOcurrence.Enabled = false;
            chkBoxServiceEndThirdOcurrence.Enabled = false;
        }

        //Verifica se houve mudança na CheckBox Inicio do Trabalho.
        private void chkBoxServiceStart_CheckedChanged(object sender, EventArgs e)
        {
            //Se ela estiver marcada então ele realiza a tarefa.
            if (chkBoxServiceStartFirstOcurrence.Checked == true)
            {
                txtBoxServiceStartFirstOcurrence.Text = DateTime.Now.ToString("HH:mm:ss");
                StartServiceFirst = DateTime.Now;
                chkBoxServiceEndFirstOcurrence.Enabled = true;
            }
            else
            {
                txtBoxServiceStartFirstOcurrence.Text = "00:00:00";
            }
        }

        //Verifica se houve mudança na ChekBox de final do trabalho.
        private void chkBoxServiceEnd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxServiceEndFirstOcurrence.Checked == true)
            {
                //Preenche a txtBox e a variável.
                txtBoxServiceEndFirstOcurrence.Text = DateTime.Now.ToString("HH:mm:ss");
                EndServiceFirst = DateTime.Now;
                
                //Calcula o tempo de horas trabalhadas subtraindo uma pela outra.
                TimeSpan horasTrabalhadas = EndServiceFirst.Subtract(StartServiceFirst);
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", horasTrabalhadas.Hours, horasTrabalhadas.Minutes, horasTrabalhadas.Seconds, horasTrabalhadas.Milliseconds / 10);
                
                //Mostra na tela o resultado formatado para String.
                txtBoxTotalHoursFirstOcurrence.Text = elapsedTime;
            }
            else if(chkBoxServiceEndFirstOcurrence.Checked == false)
            {
                DateTime Pause = new DateTime();
                DateTime TempoTrabalhado = new DateTime();

                //Zera a caixa de EndService caso esteja desmarcado.
                txtBoxServiceEndFirstOcurrence.Text = "00:00:00";
                
                //txtBoxTotalHoursFirstOcurrence.Text = "00:00:00";
                //MessageBox.Show("O Atendimento precisa ser iniciado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                //chkBoxServiceEndFirstOcurrence.Checked = false;
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
                var dirCompanyName = cmbBoxCompany.Text;
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
                string[] lines = { txtBoxDate.Text + " - " + cmbBoxCompany.Text + " - " + mskTextBoxProject.Text + " - " + txtBoxOccurrence.Text + " - Total Horas: " + txtBoxTotalHoursFirstOcurrence.Text + " - " + txtBoxServiceDescription.Text };

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Company = cmbBoxCompany.Text;

            switch (Company)
            {
                case "ACESSO":
                    mskTextBoxProject.Text = "0497.003";
                    break;
                case "ADIPRENE":
                    mskTextBoxProject.Text = "0033.001";
                    break;
                case "AQUAGENETICS":
                    mskTextBoxProject.Text = "0616.004";
                    break;
                case "IGR. DE JESUS CRISTO":
                    mskTextBoxProject.Text = "0445.004";
                    break;
                case "B3 SOCIAL":
                    mskTextBoxProject.Text = "0501.004";
                    break;
                case "B3":
                    mskTextBoxProject.Text = "0501.001";
                    break;
                case "BIZERBA":
                    mskTextBoxProject.Text = "0140.005";
                    break;
                case "BOTOCLINIC":
                    mskTextBoxProject.Text = "0473.004";
                    break;
                case "BUSCHLE & LEPPER":
                    mskTextBoxProject.Text = "0042.008";
                    break;
                case "CELLTRION":
                    mskTextBoxProject.Text = "0482.005";
                    break;
                case "CHARLES RIVER":
                    mskTextBoxProject.Text = "0169.004.001";
                    break;
                case "COLLIERS":
                    mskTextBoxProject.Text = "0481.003";
                    break;
                case "COOABRIEL":
                    mskTextBoxProject.Text = "0563.003";
                    break;
                case "DANNEMANN":
                    mskTextBoxProject.Text = "0011.004";
                    break;
                case "ENESA":
                    mskTextBoxProject.Text = "0010.001";
                    break;
                case "EPHARMA":
                    mskTextBoxProject.Text = "0568.004";
                    break;
                case "FAGRON TECH":
                    mskTextBoxProject.Text = "0431.004";
                    break;
                case "FAGRON":
                    mskTextBoxProject.Text = "0431.006";
                    break;
                case "FERSA":
                    mskTextBoxProject.Text = "0520.006";
                    break;
                case "FIEA":
                    mskTextBoxProject.Text = "0694.001";
                    break;
                case "FOODOLOGY":
                    mskTextBoxProject.Text = "0629.003";
                    break;
                case "GS1 BRASIL":
                    mskTextBoxProject.Text = "0366.001";
                    break;
                case "GTM":
                    mskTextBoxProject.Text = "0515.002";
                    break;
                case "HAWS-AVLIS":
                    mskTextBoxProject.Text = "0186.001";
                    break;
                case "HERSHEY":
                    mskTextBoxProject.Text = "0623.001";
                    break;
                case "HSO INT MUSTAD":
                    mskTextBoxProject.Text = "0015.006";
                    break;
                case "HSO INT ON RUNNING":
                    mskTextBoxProject.Text = "0015.004";
                    break;
                case "IIMAK":
                    mskTextBoxProject.Text = "0012.005";
                    break;
                case "ITERIS":
                    mskTextBoxProject.Text = "0278.002";
                    break;
                case "JOHNSON":
                    mskTextBoxProject.Text = "0590.001";
                    break;
                case "MAPEI":
                    mskTextBoxProject.Text = "0032.004";
                    break;
                case "MARTIN":
                    mskTextBoxProject.Text = "0025.001";
                    break;
                case "MIMAKI":
                    mskTextBoxProject.Text = "0014.001";
                    break;
                case "MINASUL UCOM":
                    mskTextBoxProject.Text = "0129.016";
                    break;
                case "Nexer AB":
                    mskTextBoxProject.Text = "0649.001";
                    break;
                case "NISSHA METALLIZING":
                    mskTextBoxProject.Text = "0471.003";
                    break;
                case "NORMA DO BRASIL":
                    mskTextBoxProject.Text = "0571.002";
                    break;
                case "OMYA":
                    mskTextBoxProject.Text = "0624.001";
                    break;
                case "RECOVERY":
                    mskTextBoxProject.Text = "0161.008";
                    break;
                case "ROADCARD":
                    mskTextBoxProject.Text = "0083.001";
                    break;
                case "SAENG":
                    mskTextBoxProject.Text = "0068.002";
                    break;
                case "SCANIA":
                    mskTextBoxProject.Text = "0043.009.001";
                    break;
                case "SERILON":
                    mskTextBoxProject.Text = "0049.001";
                    break;
                case "SIGMA NEXER SUÉCIA":
                    mskTextBoxProject.Text = "0043.009.003";
                    break;
                case "SINCLAIR":
                    mskTextBoxProject.Text = "0506.003";
                    break;
                case "SIRONA":
                    mskTextBoxProject.Text = "0016.003";
                    break;
                case "SUPORTE":
                    mskTextBoxProject.Text = "9916.003";
                    break;
                case "STECK":
                    mskTextBoxProject.Text = "0703.001";
                    break;
                case "STERICYCLE":
                    mskTextBoxProject.Text = "0045.003";
                    break;
                case "SUPERIOR ENERGY":
                    mskTextBoxProject.Text = "0020.001";
                    break;
                case "SYSCOM KUMON":
                    mskTextBoxProject.Text = "0389.019";
                    break;
                case "SYSCOM":
                    mskTextBoxProject.Text = "0389.014";
                    break;
                case "UNIVERSAL LEAF":
                    mskTextBoxProject.Text = "0369.009";
                    break;
                case "VOLCAFE":
                    mskTextBoxProject.Text = "0516.002";
                    break;
                case "VÓRTX":
                    mskTextBoxProject.Text = "0323.004";
                    break;
                case "ZANINI":
                    mskTextBoxProject.Text = "0391.007";
                    break;
                default:
                    mskTextBoxProject.Text = "";
                    break;
            }
        }

        private void btnDirectorySearch_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            string path;
            folderBrowserDialog1.ShowDialog();
            path = folderBrowserDialog1.SelectedPath;
            Console.WriteLine(path);
            txtBoxDefaultDirectoryPath.Text = path + "\\";
        }
    }
}
