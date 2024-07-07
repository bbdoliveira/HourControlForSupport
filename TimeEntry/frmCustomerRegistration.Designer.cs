namespace TimeEntry
{
    partial class frmCustomerRegistration
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
            this.lblCustBase = new System.Windows.Forms.Label();
            this.mskTxtBoxCadProject = new System.Windows.Forms.MaskedTextBox();
            this.lblCustProject = new System.Windows.Forms.Label();
            this.lblCustCompany = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtBoxCadCompany = new System.Windows.Forms.TextBox();
            this.btnCadCancel = new System.Windows.Forms.Button();
            this.btnCadClear = new System.Windows.Forms.Button();
            this.btnCustRemove = new System.Windows.Forms.Button();
            this.btnCustEdit = new System.Windows.Forms.Button();
            this.btnCustSearch = new System.Windows.Forms.Button();
            this.gboxCustProject = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gboxCustTable = new System.Windows.Forms.GroupBox();
            this.lblTablePath = new System.Windows.Forms.Label();
            this.gboxCustProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gboxCustTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustBase
            // 
            this.lblCustBase.AutoSize = true;
            this.lblCustBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustBase.Location = new System.Drawing.Point(296, 9);
            this.lblCustBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustBase.Name = "lblCustBase";
            this.lblCustBase.Size = new System.Drawing.Size(215, 25);
            this.lblCustBase.TabIndex = 3;
            this.lblCustBase.Text = "Cadastro de Clientes";
            // 
            // mskTxtBoxCadProject
            // 
            this.mskTxtBoxCadProject.Culture = new System.Globalization.CultureInfo("");
            this.mskTxtBoxCadProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTxtBoxCadProject.Location = new System.Drawing.Point(589, 63);
            this.mskTxtBoxCadProject.Margin = new System.Windows.Forms.Padding(4);
            this.mskTxtBoxCadProject.Mask = "0000.000.000";
            this.mskTxtBoxCadProject.Name = "mskTxtBoxCadProject";
            this.mskTxtBoxCadProject.Size = new System.Drawing.Size(144, 32);
            this.mskTxtBoxCadProject.TabIndex = 45;
            this.mskTxtBoxCadProject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskTxtBoxCadProject.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTxtBoxCadProject_MaskInputRejected);
            // 
            // lblCustProject
            // 
            this.lblCustProject.AutoSize = true;
            this.lblCustProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustProject.Location = new System.Drawing.Point(595, 31);
            this.lblCustProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustProject.Name = "lblCustProject";
            this.lblCustProject.Size = new System.Drawing.Size(80, 25);
            this.lblCustProject.TabIndex = 43;
            this.lblCustProject.Text = "Projeto";
            // 
            // lblCustCompany
            // 
            this.lblCustCompany.AutoSize = true;
            this.lblCustCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustCompany.Location = new System.Drawing.Point(21, 31);
            this.lblCustCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustCompany.Name = "lblCustCompany";
            this.lblCustCompany.Size = new System.Drawing.Size(97, 25);
            this.lblCustCompany.TabIndex = 41;
            this.lblCustCompany.Text = "Empresa";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(26, 135);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(135, 48);
            this.btnRegister.TabIndex = 46;
            this.btnRegister.Text = "Cadastrar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtBoxCadCompany
            // 
            this.txtBoxCadCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.txtBoxCadCompany.Location = new System.Drawing.Point(26, 63);
            this.txtBoxCadCompany.MaxLength = 100;
            this.txtBoxCadCompany.Name = "txtBoxCadCompany";
            this.txtBoxCadCompany.Size = new System.Drawing.Size(556, 32);
            this.txtBoxCadCompany.TabIndex = 44;
            this.txtBoxCadCompany.TextChanged += new System.EventHandler(this.txtBoxCadCompany_TextChanged);
            // 
            // btnCadCancel
            // 
            this.btnCadCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadCancel.Location = new System.Drawing.Point(376, 615);
            this.btnCadCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadCancel.Name = "btnCadCancel";
            this.btnCadCancel.Size = new System.Drawing.Size(135, 48);
            this.btnCadCancel.TabIndex = 49;
            this.btnCadCancel.Text = "Cancelar";
            this.btnCadCancel.UseVisualStyleBackColor = true;
            this.btnCadCancel.Click += new System.EventHandler(this.btnCadCancel_Click);
            // 
            // btnCadClear
            // 
            this.btnCadClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadClear.Location = new System.Drawing.Point(598, 135);
            this.btnCadClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadClear.Name = "btnCadClear";
            this.btnCadClear.Size = new System.Drawing.Size(135, 48);
            this.btnCadClear.TabIndex = 48;
            this.btnCadClear.Text = "Limpar";
            this.btnCadClear.UseVisualStyleBackColor = true;
            this.btnCadClear.Click += new System.EventHandler(this.btnCadClear_Click);
            // 
            // btnCustRemove
            // 
            this.btnCustRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustRemove.Location = new System.Drawing.Point(455, 135);
            this.btnCustRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustRemove.Name = "btnCustRemove";
            this.btnCustRemove.Size = new System.Drawing.Size(135, 48);
            this.btnCustRemove.TabIndex = 47;
            this.btnCustRemove.Text = "Remover";
            this.btnCustRemove.UseVisualStyleBackColor = true;
            this.btnCustRemove.Click += new System.EventHandler(this.btnCadCustRemove_Click);
            // 
            // btnCustEdit
            // 
            this.btnCustEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustEdit.Location = new System.Drawing.Point(169, 135);
            this.btnCustEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustEdit.Name = "btnCustEdit";
            this.btnCustEdit.Size = new System.Drawing.Size(135, 48);
            this.btnCustEdit.TabIndex = 50;
            this.btnCustEdit.Text = "Editar";
            this.btnCustEdit.UseVisualStyleBackColor = true;
            // 
            // btnCustSearch
            // 
            this.btnCustSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustSearch.Location = new System.Drawing.Point(312, 135);
            this.btnCustSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustSearch.Name = "btnCustSearch";
            this.btnCustSearch.Size = new System.Drawing.Size(135, 48);
            this.btnCustSearch.TabIndex = 51;
            this.btnCustSearch.Text = "Localizar";
            this.btnCustSearch.UseVisualStyleBackColor = true;
            // 
            // gboxCustProject
            // 
            this.gboxCustProject.Controls.Add(this.txtBoxCadCompany);
            this.gboxCustProject.Controls.Add(this.btnCustEdit);
            this.gboxCustProject.Controls.Add(this.lblCustCompany);
            this.gboxCustProject.Controls.Add(this.btnCustSearch);
            this.gboxCustProject.Controls.Add(this.lblCustProject);
            this.gboxCustProject.Controls.Add(this.btnCustRemove);
            this.gboxCustProject.Controls.Add(this.mskTxtBoxCadProject);
            this.gboxCustProject.Controls.Add(this.btnCadClear);
            this.gboxCustProject.Controls.Add(this.btnRegister);
            this.gboxCustProject.Location = new System.Drawing.Point(12, 55);
            this.gboxCustProject.Name = "gboxCustProject";
            this.gboxCustProject.Size = new System.Drawing.Size(769, 210);
            this.gboxCustProject.TabIndex = 52;
            this.gboxCustProject.TabStop = false;
            this.gboxCustProject.Text = "Cadastro Projetos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(732, 241);
            this.dataGridView1.TabIndex = 53;
            // 
            // gboxCustTable
            // 
            this.gboxCustTable.Controls.Add(this.lblTablePath);
            this.gboxCustTable.Controls.Add(this.dataGridView1);
            this.gboxCustTable.Location = new System.Drawing.Point(12, 281);
            this.gboxCustTable.Name = "gboxCustTable";
            this.gboxCustTable.Size = new System.Drawing.Size(769, 327);
            this.gboxCustTable.TabIndex = 54;
            this.gboxCustTable.TabStop = false;
            this.gboxCustTable.Text = "Tabela Clientes";
            // 
            // lblTablePath
            // 
            this.lblTablePath.AutoSize = true;
            this.lblTablePath.Location = new System.Drawing.Point(7, 298);
            this.lblTablePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTablePath.Name = "lblTablePath";
            this.lblTablePath.Size = new System.Drawing.Size(38, 16);
            this.lblTablePath.TabIndex = 54;
            this.lblTablePath.Text = "Início";
            // 
            // frmCustomerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 676);
            this.Controls.Add(this.gboxCustTable);
            this.Controls.Add(this.gboxCustProject);
            this.Controls.Add(this.btnCadCancel);
            this.Controls.Add(this.lblCustBase);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCustomerRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.gboxCustProject.ResumeLayout(false);
            this.gboxCustProject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gboxCustTable.ResumeLayout(false);
            this.gboxCustTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustBase;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxCadProject;
        private System.Windows.Forms.Label lblCustProject;
        private System.Windows.Forms.Label lblCustCompany;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtBoxCadCompany;
        private System.Windows.Forms.Button btnCadCancel;
        private System.Windows.Forms.Button btnCadClear;
        private System.Windows.Forms.Button btnCustRemove;
        private System.Windows.Forms.Button btnCustEdit;
        private System.Windows.Forms.Button btnCustSearch;
        private System.Windows.Forms.GroupBox gboxCustProject;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gboxCustTable;
        private System.Windows.Forms.Label lblTablePath;
    }
}