﻿namespace TimeEntry
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
            this.chkBoxServiceStart = new System.Windows.Forms.CheckBox();
            this.chkBoxServiceEnd = new System.Windows.Forms.CheckBox();
            this.lblServiceDescription = new System.Windows.Forms.Label();
            this.lblTotalHour = new System.Windows.Forms.Label();
            this.lblOccurrence = new System.Windows.Forms.Label();
            this.txtBoxOccurrence = new System.Windows.Forms.TextBox();
            this.txtBoxServiceStart = new System.Windows.Forms.TextBox();
            this.txtBoxServiceEnd = new System.Windows.Forms.TextBox();
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.txtBoxTesteTotalHours = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.btnFinished = new System.Windows.Forms.Button();
            this.chkBoxCreateFolder = new System.Windows.Forms.CheckBox();
            this.txtBoxDefaultDirectoryPath = new System.Windows.Forms.TextBox();
            this.btnDirectorySearch = new System.Windows.Forms.Button();
            this.mskTextBoxProject = new System.Windows.Forms.MaskedTextBox();
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
            this.txtBoxServiceDescription.Location = new System.Drawing.Point(19, 314);
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
            // chkBoxServiceStart
            // 
            this.chkBoxServiceStart.AutoSize = true;
            this.chkBoxServiceStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxServiceStart.Location = new System.Drawing.Point(17, 217);
            this.chkBoxServiceStart.Name = "chkBoxServiceStart";
            this.chkBoxServiceStart.Size = new System.Drawing.Size(15, 14);
            this.chkBoxServiceStart.TabIndex = 7;
            this.chkBoxServiceStart.UseVisualStyleBackColor = true;
            this.chkBoxServiceStart.CheckedChanged += new System.EventHandler(this.chkBoxServiceStart_CheckedChanged);
            // 
            // chkBoxServiceEnd
            // 
            this.chkBoxServiceEnd.AutoSize = true;
            this.chkBoxServiceEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxServiceEnd.Location = new System.Drawing.Point(116, 217);
            this.chkBoxServiceEnd.Name = "chkBoxServiceEnd";
            this.chkBoxServiceEnd.Size = new System.Drawing.Size(15, 14);
            this.chkBoxServiceEnd.TabIndex = 9;
            this.chkBoxServiceEnd.UseVisualStyleBackColor = true;
            this.chkBoxServiceEnd.CheckedChanged += new System.EventHandler(this.chkBoxServiceEnd_CheckedChanged);
            // 
            // lblServiceDescription
            // 
            this.lblServiceDescription.AutoSize = true;
            this.lblServiceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceDescription.Location = new System.Drawing.Point(15, 291);
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
            // txtBoxServiceStart
            // 
            this.txtBoxServiceStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxServiceStart.Location = new System.Drawing.Point(38, 212);
            this.txtBoxServiceStart.Name = "txtBoxServiceStart";
            this.txtBoxServiceStart.Size = new System.Drawing.Size(72, 26);
            this.txtBoxServiceStart.TabIndex = 22;
            this.txtBoxServiceStart.Text = "00:00:00";
            // 
            // txtBoxServiceEnd
            // 
            this.txtBoxServiceEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxServiceEnd.Location = new System.Drawing.Point(133, 212);
            this.txtBoxServiceEnd.Name = "txtBoxServiceEnd";
            this.txtBoxServiceEnd.Size = new System.Drawing.Size(72, 26);
            this.txtBoxServiceEnd.TabIndex = 23;
            this.txtBoxServiceEnd.Text = "00:00:00";
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
            // txtBoxTesteTotalHours
            // 
            this.txtBoxTesteTotalHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTesteTotalHours.Location = new System.Drawing.Point(240, 212);
            this.txtBoxTesteTotalHours.Name = "txtBoxTesteTotalHours";
            this.txtBoxTesteTotalHours.Size = new System.Drawing.Size(81, 26);
            this.txtBoxTesteTotalHours.TabIndex = 25;
            this.txtBoxTesteTotalHours.Text = "00:00:00";
            this.txtBoxTesteTotalHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "=";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(53, 196);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(34, 13);
            this.lblStart.TabIndex = 27;
            this.lblStart.Text = "Início";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(156, 196);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(23, 13);
            this.lblEnd.TabIndex = 28;
            this.lblEnd.Text = "Fim";
            // 
            // btnFinished
            // 
            this.btnFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinished.Location = new System.Drawing.Point(348, 207);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(101, 39);
            this.btnFinished.TabIndex = 10;
            this.btnFinished.Text = "Finalizar";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
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
            // frmHourControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 464);
            this.Controls.Add(this.mskTextBoxProject);
            this.Controls.Add(this.btnDirectorySearch);
            this.Controls.Add(this.txtBoxDefaultDirectoryPath);
            this.Controls.Add(this.chkBoxCreateFolder);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxTesteTotalHours);
            this.Controls.Add(this.txtBoxDate);
            this.Controls.Add(this.txtBoxServiceEnd);
            this.Controls.Add(this.txtBoxServiceStart);
            this.Controls.Add(this.txtBoxOccurrence);
            this.Controls.Add(this.lblOccurrence);
            this.Controls.Add(this.lblTotalHour);
            this.Controls.Add(this.lblServiceDescription);
            this.Controls.Add(this.chkBoxServiceEnd);
            this.Controls.Add(this.chkBoxServiceStart);
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
        private System.Windows.Forms.CheckBox chkBoxServiceStart;
        private System.Windows.Forms.CheckBox chkBoxServiceEnd;
        private System.Windows.Forms.Label lblServiceDescription;
        private System.Windows.Forms.Label lblTotalHour;
        private System.Windows.Forms.Label lblOccurrence;
        private System.Windows.Forms.TextBox txtBoxOccurrence;
        private System.Windows.Forms.TextBox txtBoxServiceStart;
        private System.Windows.Forms.TextBox txtBoxServiceEnd;
        private System.Windows.Forms.TextBox txtBoxDate;
        private System.Windows.Forms.TextBox txtBoxTesteTotalHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.CheckBox chkBoxCreateFolder;
        private System.Windows.Forms.TextBox txtBoxDefaultDirectoryPath;
        private System.Windows.Forms.Button btnDirectorySearch;
        private System.Windows.Forms.MaskedTextBox mskTextBoxProject;
    }
}

