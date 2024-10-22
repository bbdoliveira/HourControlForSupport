namespace TimeEntry
{
    partial class frmHourControl
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
            this.lblData = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.txtBoxServiceDescription = new System.Windows.Forms.TextBox();
            this.lblStartService = new System.Windows.Forms.Label();
            this.chkBoxServiceStartFirstOcurrence = new System.Windows.Forms.CheckBox();
            this.chkBoxServiceEndFirstOcurrence = new System.Windows.Forms.CheckBox();
            this.lblServiceDescription = new System.Windows.Forms.Label();
            this.lblTotalHour = new System.Windows.Forms.Label();
            this.lblOccurrence = new System.Windows.Forms.Label();
            this.txtBoxOccurrence = new System.Windows.Forms.TextBox();
            this.txtBoxServiceStartFirstOcurrence = new System.Windows.Forms.TextBox();
            this.txtBoxServiceEndFirstOcurrence = new System.Windows.Forms.TextBox();
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.txtBoxTotalHoursFirstOcurrence = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.btnFinishedFirstOcurrence = new System.Windows.Forms.Button();
            this.chkBoxCreateFolder = new System.Windows.Forms.CheckBox();
            this.txtBoxDefaultDirectoryPath = new System.Windows.Forms.TextBox();
            this.btnDirectorySearch = new System.Windows.Forms.Button();
            this.mskTextBoxProject = new System.Windows.Forms.MaskedTextBox();
            this.btnFinishedSecondOcurrence = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxTotalHoursSecondOcurrence = new System.Windows.Forms.TextBox();
            this.txtBoxServiceEndSecondOcurrence = new System.Windows.Forms.TextBox();
            this.txtBoxServiceStartSecondOcurrence = new System.Windows.Forms.TextBox();
            this.chkBoxServiceEndSecondOcurrence = new System.Windows.Forms.CheckBox();
            this.chkBoxServiceStartSecondOcurrence = new System.Windows.Forms.CheckBox();
            this.btnFinishedThirdOcurrence = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxTotalHoursThirdOcurrence = new System.Windows.Forms.TextBox();
            this.txtBoxServiceEndThirdOcurrence = new System.Windows.Forms.TextBox();
            this.txtBoxServiceStartThirdOcurrence = new System.Windows.Forms.TextBox();
            this.chkBoxServiceEndThirdOcurrence = new System.Windows.Forms.CheckBox();
            this.chkBoxServiceStartThirdOcurrence = new System.Windows.Forms.CheckBox();
            this.cmbBoxCompany = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnHourFormRegister = new System.Windows.Forms.Button();
            this.gboxService = new System.Windows.Forms.GroupBox();
            this.gboxClient = new System.Windows.Forms.GroupBox();
            this.gboxService.SuspendLayout();
            this.gboxClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(18, 32);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(57, 25);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(158, 32);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(97, 25);
            this.lblCompany.TabIndex = 2;
            this.lblCompany.Text = "Empresa";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(455, 31);
            this.lblProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(80, 25);
            this.lblProject.TabIndex = 5;
            this.lblProject.Text = "Projeto";
            // 
            // txtBoxServiceDescription
            // 
            this.txtBoxServiceDescription.Location = new System.Drawing.Point(26, 288);
            this.txtBoxServiceDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxServiceDescription.Multiline = true;
            this.txtBoxServiceDescription.Name = "txtBoxServiceDescription";
            this.txtBoxServiceDescription.Size = new System.Drawing.Size(637, 96);
            this.txtBoxServiceDescription.TabIndex = 8;
            // 
            // lblStartService
            // 
            this.lblStartService.AutoSize = true;
            this.lblStartService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartService.Location = new System.Drawing.Point(91, 35);
            this.lblStartService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartService.Name = "lblStartService";
            this.lblStartService.Size = new System.Drawing.Size(133, 25);
            this.lblStartService.TabIndex = 7;
            this.lblStartService.Text = "Atendimento";
            // 
            // chkBoxServiceStartFirstOcurrence
            // 
            this.chkBoxServiceStartFirstOcurrence.AutoSize = true;
            this.chkBoxServiceStartFirstOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxServiceStartFirstOcurrence.Location = new System.Drawing.Point(24, 102);
            this.chkBoxServiceStartFirstOcurrence.Margin = new System.Windows.Forms.Padding(4);
            this.chkBoxServiceStartFirstOcurrence.Name = "chkBoxServiceStartFirstOcurrence";
            this.chkBoxServiceStartFirstOcurrence.Size = new System.Drawing.Size(18, 17);
            this.chkBoxServiceStartFirstOcurrence.TabIndex = 7;
            this.chkBoxServiceStartFirstOcurrence.UseVisualStyleBackColor = true;
            this.chkBoxServiceStartFirstOcurrence.CheckedChanged += new System.EventHandler(this.chkBoxServiceStart_CheckedChanged);
            // 
            // chkBoxServiceEndFirstOcurrence
            // 
            this.chkBoxServiceEndFirstOcurrence.AutoSize = true;
            this.chkBoxServiceEndFirstOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxServiceEndFirstOcurrence.Location = new System.Drawing.Point(158, 102);
            this.chkBoxServiceEndFirstOcurrence.Margin = new System.Windows.Forms.Padding(4);
            this.chkBoxServiceEndFirstOcurrence.Name = "chkBoxServiceEndFirstOcurrence";
            this.chkBoxServiceEndFirstOcurrence.Size = new System.Drawing.Size(18, 17);
            this.chkBoxServiceEndFirstOcurrence.TabIndex = 9;
            this.chkBoxServiceEndFirstOcurrence.UseVisualStyleBackColor = true;
            this.chkBoxServiceEndFirstOcurrence.CheckedChanged += new System.EventHandler(this.chkBoxServiceEnd_CheckedChanged);
            // 
            // lblServiceDescription
            // 
            this.lblServiceDescription.AutoSize = true;
            this.lblServiceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceDescription.Location = new System.Drawing.Point(21, 261);
            this.lblServiceDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceDescription.Name = "lblServiceDescription";
            this.lblServiceDescription.Size = new System.Drawing.Size(272, 25);
            this.lblServiceDescription.TabIndex = 11;
            this.lblServiceDescription.Text = "Descrição do Atendimento:";
            // 
            // lblTotalHour
            // 
            this.lblTotalHour.AutoSize = true;
            this.lblTotalHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHour.Location = new System.Drawing.Point(322, 35);
            this.lblTotalHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalHour.Name = "lblTotalHour";
            this.lblTotalHour.Size = new System.Drawing.Size(124, 25);
            this.lblTotalHour.TabIndex = 14;
            this.lblTotalHour.Text = "Total Horas";
            // 
            // lblOccurrence
            // 
            this.lblOccurrence.AutoSize = true;
            this.lblOccurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccurrence.Location = new System.Drawing.Point(622, 32);
            this.lblOccurrence.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOccurrence.Name = "lblOccurrence";
            this.lblOccurrence.Size = new System.Drawing.Size(118, 25);
            this.lblOccurrence.TabIndex = 19;
            this.lblOccurrence.Text = "Ocorrência";
            // 
            // txtBoxOccurrence
            // 
            this.txtBoxOccurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOccurrence.Location = new System.Drawing.Point(570, 65);
            this.txtBoxOccurrence.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxOccurrence.Name = "txtBoxOccurrence";
            this.txtBoxOccurrence.Size = new System.Drawing.Size(245, 30);
            this.txtBoxOccurrence.TabIndex = 4;
            this.txtBoxOccurrence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxServiceStartFirstOcurrence
            // 
            this.txtBoxServiceStartFirstOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxServiceStartFirstOcurrence.Location = new System.Drawing.Point(52, 96);
            this.txtBoxServiceStartFirstOcurrence.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxServiceStartFirstOcurrence.Name = "txtBoxServiceStartFirstOcurrence";
            this.txtBoxServiceStartFirstOcurrence.Size = new System.Drawing.Size(95, 30);
            this.txtBoxServiceStartFirstOcurrence.TabIndex = 22;
            this.txtBoxServiceStartFirstOcurrence.Text = "00:00:00";
            // 
            // txtBoxServiceEndFirstOcurrence
            // 
            this.txtBoxServiceEndFirstOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxServiceEndFirstOcurrence.Location = new System.Drawing.Point(180, 96);
            this.txtBoxServiceEndFirstOcurrence.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxServiceEndFirstOcurrence.Name = "txtBoxServiceEndFirstOcurrence";
            this.txtBoxServiceEndFirstOcurrence.Size = new System.Drawing.Size(95, 30);
            this.txtBoxServiceEndFirstOcurrence.TabIndex = 23;
            this.txtBoxServiceEndFirstOcurrence.Text = "00:00:00";
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDate.Location = new System.Drawing.Point(23, 65);
            this.txtBoxDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(129, 30);
            this.txtBoxDate.TabIndex = 24;
            this.txtBoxDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxTotalHoursFirstOcurrence
            // 
            this.txtBoxTotalHoursFirstOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTotalHoursFirstOcurrence.Location = new System.Drawing.Point(334, 96);
            this.txtBoxTotalHoursFirstOcurrence.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxTotalHoursFirstOcurrence.Name = "txtBoxTotalHoursFirstOcurrence";
            this.txtBoxTotalHoursFirstOcurrence.Size = new System.Drawing.Size(107, 30);
            this.txtBoxTotalHoursFirstOcurrence.TabIndex = 25;
            this.txtBoxTotalHoursFirstOcurrence.Text = "00:00:00";
            this.txtBoxTotalHoursFirstOcurrence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "=";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(72, 76);
            this.lblStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(38, 16);
            this.lblStart.TabIndex = 27;
            this.lblStart.Text = "Início";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(211, 76);
            this.lblEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(29, 16);
            this.lblEnd.TabIndex = 28;
            this.lblEnd.Text = "Fim";
            // 
            // btnFinishedFirstOcurrence
            // 
            this.btnFinishedFirstOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishedFirstOcurrence.Location = new System.Drawing.Point(465, 89);
            this.btnFinishedFirstOcurrence.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinishedFirstOcurrence.Name = "btnFinishedFirstOcurrence";
            this.btnFinishedFirstOcurrence.Size = new System.Drawing.Size(135, 48);
            this.btnFinishedFirstOcurrence.TabIndex = 10;
            this.btnFinishedFirstOcurrence.Text = "Finalizar";
            this.btnFinishedFirstOcurrence.UseVisualStyleBackColor = true;
            this.btnFinishedFirstOcurrence.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // chkBoxCreateFolder
            // 
            this.chkBoxCreateFolder.AutoSize = true;
            this.chkBoxCreateFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxCreateFolder.Location = new System.Drawing.Point(27, 114);
            this.chkBoxCreateFolder.Margin = new System.Windows.Forms.Padding(4);
            this.chkBoxCreateFolder.Name = "chkBoxCreateFolder";
            this.chkBoxCreateFolder.Size = new System.Drawing.Size(263, 29);
            this.chkBoxCreateFolder.TabIndex = 6;
            this.chkBoxCreateFolder.Text = "Criar pasta da ocorrência?";
            this.chkBoxCreateFolder.UseVisualStyleBackColor = true;
            this.chkBoxCreateFolder.CheckedChanged += new System.EventHandler(this.chkBoxCreateFolder_CheckedChanged);
            // 
            // txtBoxDefaultDirectoryPath
            // 
            this.txtBoxDefaultDirectoryPath.Enabled = false;
            this.txtBoxDefaultDirectoryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDefaultDirectoryPath.Location = new System.Drawing.Point(23, 151);
            this.txtBoxDefaultDirectoryPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxDefaultDirectoryPath.Name = "txtBoxDefaultDirectoryPath";
            this.txtBoxDefaultDirectoryPath.Size = new System.Drawing.Size(522, 30);
            this.txtBoxDefaultDirectoryPath.TabIndex = 29;
            this.txtBoxDefaultDirectoryPath.Text = "C:\\temp\\";
            // 
            // btnDirectorySearch
            // 
            this.btnDirectorySearch.Enabled = false;
            this.btnDirectorySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectorySearch.Location = new System.Drawing.Point(553, 149);
            this.btnDirectorySearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnDirectorySearch.Name = "btnDirectorySearch";
            this.btnDirectorySearch.Size = new System.Drawing.Size(113, 32);
            this.btnDirectorySearch.TabIndex = 30;
            this.btnDirectorySearch.Text = "Procurar";
            this.btnDirectorySearch.UseVisualStyleBackColor = true;
            this.btnDirectorySearch.Click += new System.EventHandler(this.btnDirectorySearch_Click);
            // 
            // mskTextBoxProject
            // 
            this.mskTextBoxProject.Culture = new System.Globalization.CultureInfo("");
            this.mskTextBoxProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTextBoxProject.Location = new System.Drawing.Point(448, 63);
            this.mskTextBoxProject.Margin = new System.Windows.Forms.Padding(4);
            this.mskTextBoxProject.Mask = "0000.000";
            this.mskTextBoxProject.Name = "mskTextBoxProject";
            this.mskTextBoxProject.Size = new System.Drawing.Size(115, 32);
            this.mskTextBoxProject.TabIndex = 40;
            this.mskTextBoxProject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFinishedSecondOcurrence
            // 
            this.btnFinishedSecondOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishedSecondOcurrence.Location = new System.Drawing.Point(465, 145);
            this.btnFinishedSecondOcurrence.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinishedSecondOcurrence.Name = "btnFinishedSecondOcurrence";
            this.btnFinishedSecondOcurrence.Size = new System.Drawing.Size(135, 48);
            this.btnFinishedSecondOcurrence.TabIndex = 33;
            this.btnFinishedSecondOcurrence.Text = "Finalizar";
            this.btnFinishedSecondOcurrence.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Fim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Início";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(294, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "=";
            // 
            // txtBoxTotalHoursSecondOcurrence
            // 
            this.txtBoxTotalHoursSecondOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTotalHoursSecondOcurrence.Location = new System.Drawing.Point(334, 151);
            this.txtBoxTotalHoursSecondOcurrence.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxTotalHoursSecondOcurrence.Name = "txtBoxTotalHoursSecondOcurrence";
            this.txtBoxTotalHoursSecondOcurrence.Size = new System.Drawing.Size(107, 30);
            this.txtBoxTotalHoursSecondOcurrence.TabIndex = 36;
            this.txtBoxTotalHoursSecondOcurrence.Text = "00:00:00";
            this.txtBoxTotalHoursSecondOcurrence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxServiceEndSecondOcurrence
            // 
            this.txtBoxServiceEndSecondOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxServiceEndSecondOcurrence.Location = new System.Drawing.Point(180, 151);
            this.txtBoxServiceEndSecondOcurrence.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxServiceEndSecondOcurrence.Name = "txtBoxServiceEndSecondOcurrence";
            this.txtBoxServiceEndSecondOcurrence.Size = new System.Drawing.Size(95, 30);
            this.txtBoxServiceEndSecondOcurrence.TabIndex = 35;
            this.txtBoxServiceEndSecondOcurrence.Text = "00:00:00";
            // 
            // txtBoxServiceStartSecondOcurrence
            // 
            this.txtBoxServiceStartSecondOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxServiceStartSecondOcurrence.Location = new System.Drawing.Point(52, 151);
            this.txtBoxServiceStartSecondOcurrence.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxServiceStartSecondOcurrence.Name = "txtBoxServiceStartSecondOcurrence";
            this.txtBoxServiceStartSecondOcurrence.Size = new System.Drawing.Size(95, 30);
            this.txtBoxServiceStartSecondOcurrence.TabIndex = 34;
            this.txtBoxServiceStartSecondOcurrence.Text = "00:00:00";
            // 
            // chkBoxServiceEndSecondOcurrence
            // 
            this.chkBoxServiceEndSecondOcurrence.AutoSize = true;
            this.chkBoxServiceEndSecondOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxServiceEndSecondOcurrence.Location = new System.Drawing.Point(158, 157);
            this.chkBoxServiceEndSecondOcurrence.Margin = new System.Windows.Forms.Padding(4);
            this.chkBoxServiceEndSecondOcurrence.Name = "chkBoxServiceEndSecondOcurrence";
            this.chkBoxServiceEndSecondOcurrence.Size = new System.Drawing.Size(18, 17);
            this.chkBoxServiceEndSecondOcurrence.TabIndex = 32;
            this.chkBoxServiceEndSecondOcurrence.UseVisualStyleBackColor = true;
            this.chkBoxServiceEndSecondOcurrence.CheckedChanged += new System.EventHandler(this.chkBoxServiceEndSecondOcurrence_CheckedChanged);
            // 
            // chkBoxServiceStartSecondOcurrence
            // 
            this.chkBoxServiceStartSecondOcurrence.AutoSize = true;
            this.chkBoxServiceStartSecondOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxServiceStartSecondOcurrence.Location = new System.Drawing.Point(24, 157);
            this.chkBoxServiceStartSecondOcurrence.Margin = new System.Windows.Forms.Padding(4);
            this.chkBoxServiceStartSecondOcurrence.Name = "chkBoxServiceStartSecondOcurrence";
            this.chkBoxServiceStartSecondOcurrence.Size = new System.Drawing.Size(18, 17);
            this.chkBoxServiceStartSecondOcurrence.TabIndex = 31;
            this.chkBoxServiceStartSecondOcurrence.UseVisualStyleBackColor = true;
            this.chkBoxServiceStartSecondOcurrence.CheckedChanged += new System.EventHandler(this.chkBoxServiceStartSecondOcurrence_CheckedChanged);
            // 
            // btnFinishedThirdOcurrence
            // 
            this.btnFinishedThirdOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishedThirdOcurrence.Location = new System.Drawing.Point(465, 200);
            this.btnFinishedThirdOcurrence.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinishedThirdOcurrence.Name = "btnFinishedThirdOcurrence";
            this.btnFinishedThirdOcurrence.Size = new System.Drawing.Size(135, 48);
            this.btnFinishedThirdOcurrence.TabIndex = 42;
            this.btnFinishedThirdOcurrence.Text = "Finalizar";
            this.btnFinishedThirdOcurrence.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "Fim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "Início";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(294, 210);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 25);
            this.label7.TabIndex = 46;
            this.label7.Text = "=";
            // 
            // txtBoxTotalHoursThirdOcurrence
            // 
            this.txtBoxTotalHoursThirdOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTotalHoursThirdOcurrence.Location = new System.Drawing.Point(334, 206);
            this.txtBoxTotalHoursThirdOcurrence.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxTotalHoursThirdOcurrence.Name = "txtBoxTotalHoursThirdOcurrence";
            this.txtBoxTotalHoursThirdOcurrence.Size = new System.Drawing.Size(107, 30);
            this.txtBoxTotalHoursThirdOcurrence.TabIndex = 45;
            this.txtBoxTotalHoursThirdOcurrence.Text = "00:00:00";
            this.txtBoxTotalHoursThirdOcurrence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxServiceEndThirdOcurrence
            // 
            this.txtBoxServiceEndThirdOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxServiceEndThirdOcurrence.Location = new System.Drawing.Point(180, 206);
            this.txtBoxServiceEndThirdOcurrence.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxServiceEndThirdOcurrence.Name = "txtBoxServiceEndThirdOcurrence";
            this.txtBoxServiceEndThirdOcurrence.Size = new System.Drawing.Size(95, 30);
            this.txtBoxServiceEndThirdOcurrence.TabIndex = 44;
            this.txtBoxServiceEndThirdOcurrence.Text = "00:00:00";
            // 
            // txtBoxServiceStartThirdOcurrence
            // 
            this.txtBoxServiceStartThirdOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxServiceStartThirdOcurrence.Location = new System.Drawing.Point(52, 206);
            this.txtBoxServiceStartThirdOcurrence.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxServiceStartThirdOcurrence.Name = "txtBoxServiceStartThirdOcurrence";
            this.txtBoxServiceStartThirdOcurrence.Size = new System.Drawing.Size(95, 30);
            this.txtBoxServiceStartThirdOcurrence.TabIndex = 43;
            this.txtBoxServiceStartThirdOcurrence.Text = "00:00:00";
            // 
            // chkBoxServiceEndThirdOcurrence
            // 
            this.chkBoxServiceEndThirdOcurrence.AutoSize = true;
            this.chkBoxServiceEndThirdOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxServiceEndThirdOcurrence.Location = new System.Drawing.Point(158, 213);
            this.chkBoxServiceEndThirdOcurrence.Margin = new System.Windows.Forms.Padding(4);
            this.chkBoxServiceEndThirdOcurrence.Name = "chkBoxServiceEndThirdOcurrence";
            this.chkBoxServiceEndThirdOcurrence.Size = new System.Drawing.Size(18, 17);
            this.chkBoxServiceEndThirdOcurrence.TabIndex = 41;
            this.chkBoxServiceEndThirdOcurrence.UseVisualStyleBackColor = true;
            this.chkBoxServiceEndThirdOcurrence.CheckedChanged += new System.EventHandler(this.chkBoxServiceEndThirdOcurrence_CheckedChanged);
            // 
            // chkBoxServiceStartThirdOcurrence
            // 
            this.chkBoxServiceStartThirdOcurrence.AutoSize = true;
            this.chkBoxServiceStartThirdOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxServiceStartThirdOcurrence.Location = new System.Drawing.Point(24, 213);
            this.chkBoxServiceStartThirdOcurrence.Margin = new System.Windows.Forms.Padding(4);
            this.chkBoxServiceStartThirdOcurrence.Name = "chkBoxServiceStartThirdOcurrence";
            this.chkBoxServiceStartThirdOcurrence.Size = new System.Drawing.Size(18, 17);
            this.chkBoxServiceStartThirdOcurrence.TabIndex = 40;
            this.chkBoxServiceStartThirdOcurrence.UseVisualStyleBackColor = true;
            this.chkBoxServiceStartThirdOcurrence.CheckedChanged += new System.EventHandler(this.chkBoxServiceStartThirdOcurrence_CheckedChanged);
            // 
            // cmbBoxCompany
            // 
            this.cmbBoxCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbBoxCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBoxCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxCompany.FormattingEnabled = true;
            this.cmbBoxCompany.Items.AddRange(new object[] {
            "",
            "ACESSO",
            "ADIPRENE",
            "APM",
            "AQUAGENETICS",
            "IGR. DE JESUS CRISTO",
            "B3",
            "B3 SOCIAL",
            "BIOMEDICAL",
            "BIZERBA",
            "BOBINEX",
            "BOTOCLINIC",
            "BUSCHLE & LEPPER",
            "CELLTRION",
            "CHARLES RIVER",
            "COLLIERS",
            "COOABRIEL",
            "DANNEMANN",
            "ENESA",
            "EPHARMA",
            "FAGRON TECH",
            "FAGRON",
            "FERSA",
            "FIBERTEX",
            "FIEA",
            "FIEAP",
            "FIEMA",
            "FIEPA",
            "FIEPB",
            "FOODOLOGY",
            "GS1 BRASIL",
            "GTM",
            "HAWS-AVLIS",
            "HERSHEY",
            "HSO INT MUSTAD",
            "HSO INT ON RUNNING",
            "IIMAK",
            "IRRITEC",
            "ITERIS",
            "JOHNSON",
            "MAPEI",
            "MARTIN",
            "MIMAKI",
            "MINASUL UCOM",
            "Nexer AB",
            "NEXER - IMP. CRM",
            "NISSHA METALLIZING",
            "NORMA DO BRASIL",
            "OMYA BRASIL",
            "OMYA CHILE",
            "OMYA COLOMBIA",
            "RECOVERY",
            "ROADCARD",
            "SAENG",
            "SCANIA",
            "SERILON",
            "SIGMA NEXER SUÉCIA",
            "SINCLAIR",
            "SIRONA",
            "SUPORTE",
            "STECK",
            "STERICYCLE",
            "SUPERIOR ENERGY",
            "SYSCOM KUMON",
            "UNIVERSAL LEAF",
            "VOLCAFE",
            "VÓRTX",
            "ZANINI"});
            this.cmbBoxCompany.Location = new System.Drawing.Point(160, 65);
            this.cmbBoxCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBoxCompany.Name = "cmbBoxCompany";
            this.cmbBoxCompany.Size = new System.Drawing.Size(281, 30);
            this.cmbBoxCompany.TabIndex = 3;
            this.cmbBoxCompany.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnHourFormRegister
            // 
            this.btnHourFormRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHourFormRegister.Location = new System.Drawing.Point(674, 133);
            this.btnHourFormRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnHourFormRegister.Name = "btnHourFormRegister";
            this.btnHourFormRegister.Size = new System.Drawing.Size(135, 48);
            this.btnHourFormRegister.TabIndex = 49;
            this.btnHourFormRegister.Text = "Cadastrar";
            this.btnHourFormRegister.UseVisualStyleBackColor = true;
            this.btnHourFormRegister.Click += new System.EventHandler(this.btnHourFormRegister_Click);
            // 
            // gboxService
            // 
            this.gboxService.Controls.Add(this.lblTotalHour);
            this.gboxService.Controls.Add(this.txtBoxServiceDescription);
            this.gboxService.Controls.Add(this.lblStartService);
            this.gboxService.Controls.Add(this.btnFinishedThirdOcurrence);
            this.gboxService.Controls.Add(this.chkBoxServiceStartFirstOcurrence);
            this.gboxService.Controls.Add(this.label5);
            this.gboxService.Controls.Add(this.chkBoxServiceEndFirstOcurrence);
            this.gboxService.Controls.Add(this.label6);
            this.gboxService.Controls.Add(this.lblServiceDescription);
            this.gboxService.Controls.Add(this.label7);
            this.gboxService.Controls.Add(this.txtBoxServiceStartFirstOcurrence);
            this.gboxService.Controls.Add(this.txtBoxTotalHoursThirdOcurrence);
            this.gboxService.Controls.Add(this.txtBoxServiceEndFirstOcurrence);
            this.gboxService.Controls.Add(this.txtBoxServiceEndThirdOcurrence);
            this.gboxService.Controls.Add(this.txtBoxTotalHoursFirstOcurrence);
            this.gboxService.Controls.Add(this.txtBoxServiceStartThirdOcurrence);
            this.gboxService.Controls.Add(this.label2);
            this.gboxService.Controls.Add(this.chkBoxServiceEndThirdOcurrence);
            this.gboxService.Controls.Add(this.lblStart);
            this.gboxService.Controls.Add(this.chkBoxServiceStartThirdOcurrence);
            this.gboxService.Controls.Add(this.lblEnd);
            this.gboxService.Controls.Add(this.btnFinishedSecondOcurrence);
            this.gboxService.Controls.Add(this.btnFinishedFirstOcurrence);
            this.gboxService.Controls.Add(this.label1);
            this.gboxService.Controls.Add(this.chkBoxServiceStartSecondOcurrence);
            this.gboxService.Controls.Add(this.label3);
            this.gboxService.Controls.Add(this.chkBoxServiceEndSecondOcurrence);
            this.gboxService.Controls.Add(this.label4);
            this.gboxService.Controls.Add(this.txtBoxServiceStartSecondOcurrence);
            this.gboxService.Controls.Add(this.txtBoxTotalHoursSecondOcurrence);
            this.gboxService.Controls.Add(this.txtBoxServiceEndSecondOcurrence);
            this.gboxService.Location = new System.Drawing.Point(23, 242);
            this.gboxService.Name = "gboxService";
            this.gboxService.Size = new System.Drawing.Size(692, 406);
            this.gboxService.TabIndex = 50;
            this.gboxService.TabStop = false;
            this.gboxService.Text = "Controle de Horas";
            // 
            // gboxClient
            // 
            this.gboxClient.Controls.Add(this.lblData);
            this.gboxClient.Controls.Add(this.lblCompany);
            this.gboxClient.Controls.Add(this.btnHourFormRegister);
            this.gboxClient.Controls.Add(this.lblProject);
            this.gboxClient.Controls.Add(this.cmbBoxCompany);
            this.gboxClient.Controls.Add(this.lblOccurrence);
            this.gboxClient.Controls.Add(this.mskTextBoxProject);
            this.gboxClient.Controls.Add(this.txtBoxOccurrence);
            this.gboxClient.Controls.Add(this.btnDirectorySearch);
            this.gboxClient.Controls.Add(this.txtBoxDate);
            this.gboxClient.Controls.Add(this.txtBoxDefaultDirectoryPath);
            this.gboxClient.Controls.Add(this.chkBoxCreateFolder);
            this.gboxClient.Location = new System.Drawing.Point(23, 11);
            this.gboxClient.Name = "gboxClient";
            this.gboxClient.Size = new System.Drawing.Size(836, 197);
            this.gboxClient.TabIndex = 51;
            this.gboxClient.TabStop = false;
            this.gboxClient.Text = "Cliente";
            // 
            // frmHourControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 672);
            this.Controls.Add(this.gboxClient);
            this.Controls.Add(this.gboxService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmHourControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Horas";
            this.Load += new System.EventHandler(this.formHourControl_Load);
            this.gboxService.ResumeLayout(false);
            this.gboxService.PerformLayout();
            this.gboxClient.ResumeLayout(false);
            this.gboxClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.TextBox txtBoxServiceDescription;
        private System.Windows.Forms.Label lblStartService;
        private System.Windows.Forms.CheckBox chkBoxServiceStartFirstOcurrence;
        private System.Windows.Forms.CheckBox chkBoxServiceEndFirstOcurrence;
        private System.Windows.Forms.Label lblServiceDescription;
        private System.Windows.Forms.Label lblTotalHour;
        private System.Windows.Forms.Label lblOccurrence;
        private System.Windows.Forms.TextBox txtBoxOccurrence;
        private System.Windows.Forms.TextBox txtBoxServiceStartFirstOcurrence;
        private System.Windows.Forms.TextBox txtBoxServiceEndFirstOcurrence;
        private System.Windows.Forms.TextBox txtBoxDate;
        private System.Windows.Forms.TextBox txtBoxTotalHoursFirstOcurrence;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Button btnFinishedFirstOcurrence;
        private System.Windows.Forms.CheckBox chkBoxCreateFolder;
        private System.Windows.Forms.TextBox txtBoxDefaultDirectoryPath;
        private System.Windows.Forms.Button btnDirectorySearch;
        private System.Windows.Forms.MaskedTextBox mskTextBoxProject;
        private System.Windows.Forms.Button btnFinishedSecondOcurrence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxTotalHoursSecondOcurrence;
        private System.Windows.Forms.TextBox txtBoxServiceEndSecondOcurrence;
        private System.Windows.Forms.TextBox txtBoxServiceStartSecondOcurrence;
        private System.Windows.Forms.CheckBox chkBoxServiceEndSecondOcurrence;
        private System.Windows.Forms.CheckBox chkBoxServiceStartSecondOcurrence;
        private System.Windows.Forms.Button btnFinishedThirdOcurrence;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxTotalHoursThirdOcurrence;
        private System.Windows.Forms.TextBox txtBoxServiceEndThirdOcurrence;
        private System.Windows.Forms.TextBox txtBoxServiceStartThirdOcurrence;
        private System.Windows.Forms.CheckBox chkBoxServiceEndThirdOcurrence;
        private System.Windows.Forms.CheckBox chkBoxServiceStartThirdOcurrence;
        private System.Windows.Forms.ComboBox cmbBoxCompany;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnHourFormRegister;
        private System.Windows.Forms.GroupBox gboxService;
        private System.Windows.Forms.GroupBox gboxClient;
    }
}

