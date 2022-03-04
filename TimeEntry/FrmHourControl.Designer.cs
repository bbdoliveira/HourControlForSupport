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
            this.lblData.Location = new System.Drawing.Point(12, 66);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(66, 29);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data";
            this.lblData.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(190, 66);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(117, 29);
            this.lblCompany.TabIndex = 2;
            this.lblCompany.Text = "Empresa";
            // 
            // txtBoxCompany
            // 
            this.txtBoxCompany.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCompany.Location = new System.Drawing.Point(195, 108);
            this.txtBoxCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxCompany.MaxLength = 17;
            this.txtBoxCompany.Name = "txtBoxCompany";
            this.txtBoxCompany.Size = new System.Drawing.Size(248, 35);
            this.txtBoxCompany.TabIndex = 3;
            this.txtBoxCompany.TextChanged += new System.EventHandler(this.txtBoxCompany_TextChanged);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(462, 66);
            this.lblProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(98, 29);
            this.lblProject.TabIndex = 5;
            this.lblProject.Text = "Projeto";
            // 
            // txtBoxServiceDescription
            // 
            this.txtBoxServiceDescription.Location = new System.Drawing.Point(28, 483);
            this.txtBoxServiceDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxServiceDescription.Multiline = true;
            this.txtBoxServiceDescription.Name = "txtBoxServiceDescription";
            this.txtBoxServiceDescription.Size = new System.Drawing.Size(716, 196);
            this.txtBoxServiceDescription.TabIndex = 8;
            // 
            // lblStartService
            // 
            this.lblStartService.AutoSize = true;
            this.lblStartService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartService.Location = new System.Drawing.Point(92, 242);
            this.lblStartService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartService.Name = "lblStartService";
            this.lblStartService.Size = new System.Drawing.Size(159, 29);
            this.lblStartService.TabIndex = 7;
            this.lblStartService.Text = "Atendimento";
            // 
            // chkBoxServiceStart
            // 
            this.chkBoxServiceStart.AutoSize = true;
            this.chkBoxServiceStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxServiceStart.Location = new System.Drawing.Point(26, 334);
            this.chkBoxServiceStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkBoxServiceStart.Name = "chkBoxServiceStart";
            this.chkBoxServiceStart.Size = new System.Drawing.Size(22, 21);
            this.chkBoxServiceStart.TabIndex = 7;
            this.chkBoxServiceStart.UseVisualStyleBackColor = true;
            this.chkBoxServiceStart.CheckedChanged += new System.EventHandler(this.chkBoxServiceStart_CheckedChanged);
            // 
            // chkBoxServiceEnd
            // 
            this.chkBoxServiceEnd.AutoSize = true;
            this.chkBoxServiceEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxServiceEnd.Location = new System.Drawing.Point(174, 334);
            this.chkBoxServiceEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkBoxServiceEnd.Name = "chkBoxServiceEnd";
            this.chkBoxServiceEnd.Size = new System.Drawing.Size(22, 21);
            this.chkBoxServiceEnd.TabIndex = 9;
            this.chkBoxServiceEnd.UseVisualStyleBackColor = true;
            this.chkBoxServiceEnd.CheckedChanged += new System.EventHandler(this.chkBoxServiceEnd_CheckedChanged);
            // 
            // lblServiceDescription
            // 
            this.lblServiceDescription.AutoSize = true;
            this.lblServiceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceDescription.Location = new System.Drawing.Point(22, 448);
            this.lblServiceDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceDescription.Name = "lblServiceDescription";
            this.lblServiceDescription.Size = new System.Drawing.Size(327, 29);
            this.lblServiceDescription.TabIndex = 11;
            this.lblServiceDescription.Text = "Descrição do Atendimento:";
            // 
            // lblTotalHour
            // 
            this.lblTotalHour.AutoSize = true;
            this.lblTotalHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHour.Location = new System.Drawing.Point(339, 242);
            this.lblTotalHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalHour.Name = "lblTotalHour";
            this.lblTotalHour.Size = new System.Drawing.Size(149, 29);
            this.lblTotalHour.TabIndex = 14;
            this.lblTotalHour.Text = "Total Horas";
            // 
            // lblOccurrence
            // 
            this.lblOccurrence.AutoSize = true;
            this.lblOccurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccurrence.Location = new System.Drawing.Point(650, 66);
            this.lblOccurrence.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOccurrence.Name = "lblOccurrence";
            this.lblOccurrence.Size = new System.Drawing.Size(142, 29);
            this.lblOccurrence.TabIndex = 19;
            this.lblOccurrence.Text = "Ocorrência";
            // 
            // txtBoxOccurrence
            // 
            this.txtBoxOccurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOccurrence.Location = new System.Drawing.Point(591, 108);
            this.txtBoxOccurrence.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxOccurrence.Name = "txtBoxOccurrence";
            this.txtBoxOccurrence.Size = new System.Drawing.Size(276, 35);
            this.txtBoxOccurrence.TabIndex = 5;
            this.txtBoxOccurrence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxServiceStart
            // 
            this.txtBoxServiceStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxServiceStart.Location = new System.Drawing.Point(57, 326);
            this.txtBoxServiceStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxServiceStart.Name = "txtBoxServiceStart";
            this.txtBoxServiceStart.Size = new System.Drawing.Size(106, 35);
            this.txtBoxServiceStart.TabIndex = 22;
            this.txtBoxServiceStart.Text = "00:00:00";
            // 
            // txtBoxServiceEnd
            // 
            this.txtBoxServiceEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxServiceEnd.Location = new System.Drawing.Point(200, 326);
            this.txtBoxServiceEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxServiceEnd.Name = "txtBoxServiceEnd";
            this.txtBoxServiceEnd.Size = new System.Drawing.Size(106, 35);
            this.txtBoxServiceEnd.TabIndex = 23;
            this.txtBoxServiceEnd.Text = "00:00:00";
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDate.Location = new System.Drawing.Point(18, 108);
            this.txtBoxDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(163, 35);
            this.txtBoxDate.TabIndex = 24;
            this.txtBoxDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxTesteTotalHours
            // 
            this.txtBoxTesteTotalHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTesteTotalHours.Location = new System.Drawing.Point(360, 326);
            this.txtBoxTesteTotalHours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxTesteTotalHours.Name = "txtBoxTesteTotalHours";
            this.txtBoxTesteTotalHours.Size = new System.Drawing.Size(120, 35);
            this.txtBoxTesteTotalHours.TabIndex = 25;
            this.txtBoxTesteTotalHours.Text = "00:00:00";
            this.txtBoxTesteTotalHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 331);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "=";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(80, 302);
            this.lblStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(46, 20);
            this.lblStart.TabIndex = 27;
            this.lblStart.Text = "Início";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(234, 302);
            this.lblEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(35, 20);
            this.lblEnd.TabIndex = 28;
            this.lblEnd.Text = "Fim";
            // 
            // btnFinished
            // 
            this.btnFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinished.Location = new System.Drawing.Point(522, 318);
            this.btnFinished.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(152, 60);
            this.btnFinished.TabIndex = 10;
            this.btnFinished.Text = "Finalizar";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // chkBoxCreateFolder
            // 
            this.chkBoxCreateFolder.AutoSize = true;
            this.chkBoxCreateFolder.Location = new System.Drawing.Point(18, 171);
            this.chkBoxCreateFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkBoxCreateFolder.Name = "chkBoxCreateFolder";
            this.chkBoxCreateFolder.Size = new System.Drawing.Size(221, 24);
            this.chkBoxCreateFolder.TabIndex = 6;
            this.chkBoxCreateFolder.Text = "Criar pasta da ocorrência?";
            this.chkBoxCreateFolder.UseVisualStyleBackColor = true;
            this.chkBoxCreateFolder.CheckedChanged += new System.EventHandler(this.chkBoxCreateFolder_CheckedChanged);
            // 
            // txtBoxDefaultDirectoryPath
            // 
            this.txtBoxDefaultDirectoryPath.Enabled = false;
            this.txtBoxDefaultDirectoryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDefaultDirectoryPath.Location = new System.Drawing.Point(249, 162);
            this.txtBoxDefaultDirectoryPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxDefaultDirectoryPath.Name = "txtBoxDefaultDirectoryPath";
            this.txtBoxDefaultDirectoryPath.Size = new System.Drawing.Size(194, 35);
            this.txtBoxDefaultDirectoryPath.TabIndex = 29;
            this.txtBoxDefaultDirectoryPath.Text = "C:\\temp\\";
            // 
            // btnDirectorySearch
            // 
            this.btnDirectorySearch.Enabled = false;
            this.btnDirectorySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectorySearch.Location = new System.Drawing.Point(454, 162);
            this.btnDirectorySearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDirectorySearch.Name = "btnDirectorySearch";
            this.btnDirectorySearch.Size = new System.Drawing.Size(128, 40);
            this.btnDirectorySearch.TabIndex = 30;
            this.btnDirectorySearch.Text = "Procurar";
            this.btnDirectorySearch.UseVisualStyleBackColor = true;
            // 
            // mskTextBoxProject
            // 
            this.mskTextBoxProject.Culture = new System.Globalization.CultureInfo("");
            this.mskTextBoxProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTextBoxProject.Location = new System.Drawing.Point(454, 106);
            this.mskTextBoxProject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskTextBoxProject.Mask = "0000.000";
            this.mskTextBoxProject.Name = "mskTextBoxProject";
            this.mskTextBoxProject.Size = new System.Drawing.Size(126, 36);
            this.mskTextBoxProject.TabIndex = 4;
            this.mskTextBoxProject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmHourControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 714);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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

