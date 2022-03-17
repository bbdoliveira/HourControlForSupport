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
            this.txtBoxCompany = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(8, 43);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(48, 20);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(127, 43);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(80, 20);
            this.lblCompany.TabIndex = 2;
            this.lblCompany.Text = "Empresa";
            // 
            // txtBoxCompany
            // 
            this.txtBoxCompany.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCompany.Location = new System.Drawing.Point(130, 70);
            this.txtBoxCompany.MaxLength = 17;
            this.txtBoxCompany.Name = "txtBoxCompany";
            this.txtBoxCompany.Size = new System.Drawing.Size(167, 26);
            this.txtBoxCompany.TabIndex = 3;
            this.txtBoxCompany.TextChanged += new System.EventHandler(this.txtBoxCompany_TextChanged);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(308, 43);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(66, 20);
            this.lblProject.TabIndex = 5;
            this.lblProject.Text = "Projeto";
            // 
            // txtBoxServiceDescription
            // 
            this.txtBoxServiceDescription.Location = new System.Drawing.Point(19, 374);
            this.txtBoxServiceDescription.Multiline = true;
            this.txtBoxServiceDescription.Name = "txtBoxServiceDescription";
            this.txtBoxServiceDescription.Size = new System.Drawing.Size(479, 129);
            this.txtBoxServiceDescription.TabIndex = 8;
            // 
            // lblStartService
            // 
            this.lblStartService.AutoSize = true;
            this.lblStartService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartService.Location = new System.Drawing.Point(61, 157);
            this.lblStartService.Name = "lblStartService";
            this.lblStartService.Size = new System.Drawing.Size(111, 20);
            this.lblStartService.TabIndex = 7;
            this.lblStartService.Text = "Atendimento";
            // 
            // chkBoxServiceStartFirstOcurrence
            // 
            this.chkBoxServiceStartFirstOcurrence.AutoSize = true;
            this.chkBoxServiceStartFirstOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxServiceStartFirstOcurrence.Location = new System.Drawing.Point(17, 211);
            this.chkBoxServiceStartFirstOcurrence.Name = "chkBoxServiceStartFirstOcurrence";
            this.chkBoxServiceStartFirstOcurrence.Size = new System.Drawing.Size(15, 14);
            this.chkBoxServiceStartFirstOcurrence.TabIndex = 7;
            this.chkBoxServiceStartFirstOcurrence.UseVisualStyleBackColor = true;
            this.chkBoxServiceStartFirstOcurrence.CheckedChanged += new System.EventHandler(this.chkBoxServiceStart_CheckedChanged);
            // 
            // chkBoxServiceEndFirstOcurrence
            // 
            this.chkBoxServiceEndFirstOcurrence.AutoSize = true;
            this.chkBoxServiceEndFirstOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxServiceEndFirstOcurrence.Location = new System.Drawing.Point(116, 211);
            this.chkBoxServiceEndFirstOcurrence.Name = "chkBoxServiceEndFirstOcurrence";
            this.chkBoxServiceEndFirstOcurrence.Size = new System.Drawing.Size(15, 14);
            this.chkBoxServiceEndFirstOcurrence.TabIndex = 9;
            this.chkBoxServiceEndFirstOcurrence.UseVisualStyleBackColor = true;
            this.chkBoxServiceEndFirstOcurrence.CheckedChanged += new System.EventHandler(this.chkBoxServiceEnd_CheckedChanged);
            // 
            // lblServiceDescription
            // 
            this.lblServiceDescription.AutoSize = true;
            this.lblServiceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceDescription.Location = new System.Drawing.Point(15, 351);
            this.lblServiceDescription.Name = "lblServiceDescription";
            this.lblServiceDescription.Size = new System.Drawing.Size(226, 20);
            this.lblServiceDescription.TabIndex = 11;
            this.lblServiceDescription.Text = "Descrição do Atendimento:";
            // 
            // lblTotalHour
            // 
            this.lblTotalHour.AutoSize = true;
            this.lblTotalHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHour.Location = new System.Drawing.Point(226, 157);
            this.lblTotalHour.Name = "lblTotalHour";
            this.lblTotalHour.Size = new System.Drawing.Size(102, 20);
            this.lblTotalHour.TabIndex = 14;
            this.lblTotalHour.Text = "Total Horas";
            // 
            // lblOccurrence
            // 
            this.lblOccurrence.AutoSize = true;
            this.lblOccurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccurrence.Location = new System.Drawing.Point(433, 43);
            this.lblOccurrence.Name = "lblOccurrence";
            this.lblOccurrence.Size = new System.Drawing.Size(96, 20);
            this.lblOccurrence.TabIndex = 19;
            this.lblOccurrence.Text = "Ocorrência";
            // 
            // txtBoxOccurrence
            // 
            this.txtBoxOccurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOccurrence.Location = new System.Drawing.Point(394, 70);
            this.txtBoxOccurrence.Name = "txtBoxOccurrence";
            this.txtBoxOccurrence.Size = new System.Drawing.Size(185, 26);
            this.txtBoxOccurrence.TabIndex = 5;
            this.txtBoxOccurrence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxServiceStartFirstOcurrence
            // 
            this.txtBoxServiceStartFirstOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxServiceStartFirstOcurrence.Location = new System.Drawing.Point(38, 206);
            this.txtBoxServiceStartFirstOcurrence.Name = "txtBoxServiceStartFirstOcurrence";
            this.txtBoxServiceStartFirstOcurrence.Size = new System.Drawing.Size(72, 26);
            this.txtBoxServiceStartFirstOcurrence.TabIndex = 22;
            this.txtBoxServiceStartFirstOcurrence.Text = "00:00:00";
            // 
            // txtBoxServiceEndFirstOcurrence
            // 
            this.txtBoxServiceEndFirstOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxServiceEndFirstOcurrence.Location = new System.Drawing.Point(133, 206);
            this.txtBoxServiceEndFirstOcurrence.Name = "txtBoxServiceEndFirstOcurrence";
            this.txtBoxServiceEndFirstOcurrence.Size = new System.Drawing.Size(72, 26);
            this.txtBoxServiceEndFirstOcurrence.TabIndex = 23;
            this.txtBoxServiceEndFirstOcurrence.Text = "00:00:00";
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDate.Location = new System.Drawing.Point(12, 70);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(110, 26);
            this.txtBoxDate.TabIndex = 24;
            this.txtBoxDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxTotalHoursFirstOcurrence
            // 
            this.txtBoxTotalHoursFirstOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTotalHoursFirstOcurrence.Location = new System.Drawing.Point(240, 206);
            this.txtBoxTotalHoursFirstOcurrence.Name = "txtBoxTotalHoursFirstOcurrence";
            this.txtBoxTotalHoursFirstOcurrence.Size = new System.Drawing.Size(81, 26);
            this.txtBoxTotalHoursFirstOcurrence.TabIndex = 25;
            this.txtBoxTotalHoursFirstOcurrence.Text = "00:00:00";
            this.txtBoxTotalHoursFirstOcurrence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "=";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(53, 190);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(34, 13);
            this.lblStart.TabIndex = 27;
            this.lblStart.Text = "Início";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(156, 190);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(23, 13);
            this.lblEnd.TabIndex = 28;
            this.lblEnd.Text = "Fim";
            // 
            // btnFinishedFirstOcurrence
            // 
            this.btnFinishedFirstOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishedFirstOcurrence.Location = new System.Drawing.Point(348, 201);
            this.btnFinishedFirstOcurrence.Name = "btnFinishedFirstOcurrence";
            this.btnFinishedFirstOcurrence.Size = new System.Drawing.Size(101, 39);
            this.btnFinishedFirstOcurrence.TabIndex = 10;
            this.btnFinishedFirstOcurrence.Text = "Finalizar";
            this.btnFinishedFirstOcurrence.UseVisualStyleBackColor = true;
            this.btnFinishedFirstOcurrence.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // chkBoxCreateFolder
            // 
            this.chkBoxCreateFolder.AutoSize = true;
            this.chkBoxCreateFolder.Location = new System.Drawing.Point(12, 111);
            this.chkBoxCreateFolder.Name = "chkBoxCreateFolder";
            this.chkBoxCreateFolder.Size = new System.Drawing.Size(150, 17);
            this.chkBoxCreateFolder.TabIndex = 6;
            this.chkBoxCreateFolder.Text = "Criar pasta da ocorrência?";
            this.chkBoxCreateFolder.UseVisualStyleBackColor = true;
            this.chkBoxCreateFolder.CheckedChanged += new System.EventHandler(this.chkBoxCreateFolder_CheckedChanged);
            // 
            // txtBoxDefaultDirectoryPath
            // 
            this.txtBoxDefaultDirectoryPath.Enabled = false;
            this.txtBoxDefaultDirectoryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDefaultDirectoryPath.Location = new System.Drawing.Point(166, 105);
            this.txtBoxDefaultDirectoryPath.Name = "txtBoxDefaultDirectoryPath";
            this.txtBoxDefaultDirectoryPath.Size = new System.Drawing.Size(131, 26);
            this.txtBoxDefaultDirectoryPath.TabIndex = 29;
            this.txtBoxDefaultDirectoryPath.Text = "C:\\temp\\";
            // 
            // btnDirectorySearch
            // 
            this.btnDirectorySearch.Enabled = false;
            this.btnDirectorySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectorySearch.Location = new System.Drawing.Point(303, 105);
            this.btnDirectorySearch.Name = "btnDirectorySearch";
            this.btnDirectorySearch.Size = new System.Drawing.Size(85, 26);
            this.btnDirectorySearch.TabIndex = 30;
            this.btnDirectorySearch.Text = "Procurar";
            this.btnDirectorySearch.UseVisualStyleBackColor = true;
            // 
            // mskTextBoxProject
            // 
            this.mskTextBoxProject.Culture = new System.Globalization.CultureInfo("");
            this.mskTextBoxProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTextBoxProject.Location = new System.Drawing.Point(303, 69);
            this.mskTextBoxProject.Mask = "0000.000";
            this.mskTextBoxProject.Name = "mskTextBoxProject";
            this.mskTextBoxProject.Size = new System.Drawing.Size(85, 27);
            this.mskTextBoxProject.TabIndex = 4;
            this.mskTextBoxProject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFinishedSecondOcurrence
            // 
            this.btnFinishedSecondOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishedSecondOcurrence.Location = new System.Drawing.Point(348, 246);
            this.btnFinishedSecondOcurrence.Name = "btnFinishedSecondOcurrence";
            this.btnFinishedSecondOcurrence.Size = new System.Drawing.Size(101, 39);
            this.btnFinishedSecondOcurrence.TabIndex = 33;
            this.btnFinishedSecondOcurrence.Text = "Finalizar";
            this.btnFinishedSecondOcurrence.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Fim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Início";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "=";
            // 
            // txtBoxTotalHoursSecondOcurrence
            // 
            this.txtBoxTotalHoursSecondOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTotalHoursSecondOcurrence.Location = new System.Drawing.Point(240, 251);
            this.txtBoxTotalHoursSecondOcurrence.Name = "txtBoxTotalHoursSecondOcurrence";
            this.txtBoxTotalHoursSecondOcurrence.Size = new System.Drawing.Size(81, 26);
            this.txtBoxTotalHoursSecondOcurrence.TabIndex = 36;
            this.txtBoxTotalHoursSecondOcurrence.Text = "00:00:00";
            this.txtBoxTotalHoursSecondOcurrence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxServiceEndSecondOcurrence
            // 
            this.txtBoxServiceEndSecondOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxServiceEndSecondOcurrence.Location = new System.Drawing.Point(133, 251);
            this.txtBoxServiceEndSecondOcurrence.Name = "txtBoxServiceEndSecondOcurrence";
            this.txtBoxServiceEndSecondOcurrence.Size = new System.Drawing.Size(72, 26);
            this.txtBoxServiceEndSecondOcurrence.TabIndex = 35;
            this.txtBoxServiceEndSecondOcurrence.Text = "00:00:00";
            // 
            // txtBoxServiceStartSecondOcurrence
            // 
            this.txtBoxServiceStartSecondOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxServiceStartSecondOcurrence.Location = new System.Drawing.Point(38, 251);
            this.txtBoxServiceStartSecondOcurrence.Name = "txtBoxServiceStartSecondOcurrence";
            this.txtBoxServiceStartSecondOcurrence.Size = new System.Drawing.Size(72, 26);
            this.txtBoxServiceStartSecondOcurrence.TabIndex = 34;
            this.txtBoxServiceStartSecondOcurrence.Text = "00:00:00";
            // 
            // chkBoxServiceEndSecondOcurrence
            // 
            this.chkBoxServiceEndSecondOcurrence.AutoSize = true;
            this.chkBoxServiceEndSecondOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxServiceEndSecondOcurrence.Location = new System.Drawing.Point(116, 256);
            this.chkBoxServiceEndSecondOcurrence.Name = "chkBoxServiceEndSecondOcurrence";
            this.chkBoxServiceEndSecondOcurrence.Size = new System.Drawing.Size(15, 14);
            this.chkBoxServiceEndSecondOcurrence.TabIndex = 32;
            this.chkBoxServiceEndSecondOcurrence.UseVisualStyleBackColor = true;
            this.chkBoxServiceEndSecondOcurrence.CheckedChanged += new System.EventHandler(this.chkBoxServiceEndSecondOcurrence_CheckedChanged);
            // 
            // chkBoxServiceStartSecondOcurrence
            // 
            this.chkBoxServiceStartSecondOcurrence.AutoSize = true;
            this.chkBoxServiceStartSecondOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxServiceStartSecondOcurrence.Location = new System.Drawing.Point(17, 256);
            this.chkBoxServiceStartSecondOcurrence.Name = "chkBoxServiceStartSecondOcurrence";
            this.chkBoxServiceStartSecondOcurrence.Size = new System.Drawing.Size(15, 14);
            this.chkBoxServiceStartSecondOcurrence.TabIndex = 31;
            this.chkBoxServiceStartSecondOcurrence.UseVisualStyleBackColor = true;
            this.chkBoxServiceStartSecondOcurrence.CheckedChanged += new System.EventHandler(this.chkBoxServiceStartSecondOcurrence_CheckedChanged);
            // 
            // btnFinishedThirdOcurrence
            // 
            this.btnFinishedThirdOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishedThirdOcurrence.Location = new System.Drawing.Point(348, 291);
            this.btnFinishedThirdOcurrence.Name = "btnFinishedThirdOcurrence";
            this.btnFinishedThirdOcurrence.Size = new System.Drawing.Size(101, 39);
            this.btnFinishedThirdOcurrence.TabIndex = 42;
            this.btnFinishedThirdOcurrence.Text = "Finalizar";
            this.btnFinishedThirdOcurrence.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Fim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Início";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(214, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "=";
            // 
            // txtBoxTotalHoursThirdOcurrence
            // 
            this.txtBoxTotalHoursThirdOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTotalHoursThirdOcurrence.Location = new System.Drawing.Point(240, 296);
            this.txtBoxTotalHoursThirdOcurrence.Name = "txtBoxTotalHoursThirdOcurrence";
            this.txtBoxTotalHoursThirdOcurrence.Size = new System.Drawing.Size(81, 26);
            this.txtBoxTotalHoursThirdOcurrence.TabIndex = 45;
            this.txtBoxTotalHoursThirdOcurrence.Text = "00:00:00";
            this.txtBoxTotalHoursThirdOcurrence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxServiceEndThirdOcurrence
            // 
            this.txtBoxServiceEndThirdOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxServiceEndThirdOcurrence.Location = new System.Drawing.Point(133, 296);
            this.txtBoxServiceEndThirdOcurrence.Name = "txtBoxServiceEndThirdOcurrence";
            this.txtBoxServiceEndThirdOcurrence.Size = new System.Drawing.Size(72, 26);
            this.txtBoxServiceEndThirdOcurrence.TabIndex = 44;
            this.txtBoxServiceEndThirdOcurrence.Text = "00:00:00";
            // 
            // txtBoxServiceStartThirdOcurrence
            // 
            this.txtBoxServiceStartThirdOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxServiceStartThirdOcurrence.Location = new System.Drawing.Point(38, 296);
            this.txtBoxServiceStartThirdOcurrence.Name = "txtBoxServiceStartThirdOcurrence";
            this.txtBoxServiceStartThirdOcurrence.Size = new System.Drawing.Size(72, 26);
            this.txtBoxServiceStartThirdOcurrence.TabIndex = 43;
            this.txtBoxServiceStartThirdOcurrence.Text = "00:00:00";
            // 
            // chkBoxServiceEndThirdOcurrence
            // 
            this.chkBoxServiceEndThirdOcurrence.AutoSize = true;
            this.chkBoxServiceEndThirdOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxServiceEndThirdOcurrence.Location = new System.Drawing.Point(116, 301);
            this.chkBoxServiceEndThirdOcurrence.Name = "chkBoxServiceEndThirdOcurrence";
            this.chkBoxServiceEndThirdOcurrence.Size = new System.Drawing.Size(15, 14);
            this.chkBoxServiceEndThirdOcurrence.TabIndex = 41;
            this.chkBoxServiceEndThirdOcurrence.UseVisualStyleBackColor = true;
            this.chkBoxServiceEndThirdOcurrence.CheckedChanged += new System.EventHandler(this.chkBoxServiceEndThirdOcurrence_CheckedChanged);
            // 
            // chkBoxServiceStartThirdOcurrence
            // 
            this.chkBoxServiceStartThirdOcurrence.AutoSize = true;
            this.chkBoxServiceStartThirdOcurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxServiceStartThirdOcurrence.Location = new System.Drawing.Point(17, 301);
            this.chkBoxServiceStartThirdOcurrence.Name = "chkBoxServiceStartThirdOcurrence";
            this.chkBoxServiceStartThirdOcurrence.Size = new System.Drawing.Size(15, 14);
            this.chkBoxServiceStartThirdOcurrence.TabIndex = 40;
            this.chkBoxServiceStartThirdOcurrence.UseVisualStyleBackColor = true;
            this.chkBoxServiceStartThirdOcurrence.CheckedChanged += new System.EventHandler(this.chkBoxServiceStartThirdOcurrence_CheckedChanged);
            // 
            // frmHourControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 529);
            this.Controls.Add(this.btnFinishedThirdOcurrence);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxTotalHoursThirdOcurrence);
            this.Controls.Add(this.txtBoxServiceEndThirdOcurrence);
            this.Controls.Add(this.txtBoxServiceStartThirdOcurrence);
            this.Controls.Add(this.chkBoxServiceEndThirdOcurrence);
            this.Controls.Add(this.chkBoxServiceStartThirdOcurrence);
            this.Controls.Add(this.btnFinishedSecondOcurrence);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxTotalHoursSecondOcurrence);
            this.Controls.Add(this.txtBoxServiceEndSecondOcurrence);
            this.Controls.Add(this.txtBoxServiceStartSecondOcurrence);
            this.Controls.Add(this.chkBoxServiceEndSecondOcurrence);
            this.Controls.Add(this.chkBoxServiceStartSecondOcurrence);
            this.Controls.Add(this.mskTextBoxProject);
            this.Controls.Add(this.btnDirectorySearch);
            this.Controls.Add(this.txtBoxDefaultDirectoryPath);
            this.Controls.Add(this.chkBoxCreateFolder);
            this.Controls.Add(this.btnFinishedFirstOcurrence);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxTotalHoursFirstOcurrence);
            this.Controls.Add(this.txtBoxDate);
            this.Controls.Add(this.txtBoxServiceEndFirstOcurrence);
            this.Controls.Add(this.txtBoxServiceStartFirstOcurrence);
            this.Controls.Add(this.txtBoxOccurrence);
            this.Controls.Add(this.lblOccurrence);
            this.Controls.Add(this.lblTotalHour);
            this.Controls.Add(this.lblServiceDescription);
            this.Controls.Add(this.chkBoxServiceEndFirstOcurrence);
            this.Controls.Add(this.chkBoxServiceStartFirstOcurrence);
            this.Controls.Add(this.lblStartService);
            this.Controls.Add(this.txtBoxServiceDescription);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.txtBoxCompany);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmHourControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Horas";
            this.Load += new System.EventHandler(this.formHourControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtBoxCompany;
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
    }
}

