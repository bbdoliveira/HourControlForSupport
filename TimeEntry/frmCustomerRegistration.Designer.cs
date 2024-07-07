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
            this.btnCadCustRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCustBase
            // 
            this.lblCustBase.AutoSize = true;
            this.lblCustBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustBase.Location = new System.Drawing.Point(35, 47);
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
            this.mskTxtBoxCadProject.Location = new System.Drawing.Point(460, 146);
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
            this.lblCustProject.Location = new System.Drawing.Point(466, 114);
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
            this.lblCustCompany.Location = new System.Drawing.Point(37, 114);
            this.lblCustCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustCompany.Name = "lblCustCompany";
            this.lblCustCompany.Size = new System.Drawing.Size(97, 25);
            this.lblCustCompany.TabIndex = 41;
            this.lblCustCompany.Text = "Empresa";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(42, 218);
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
            this.txtBoxCadCompany.Location = new System.Drawing.Point(42, 146);
            this.txtBoxCadCompany.MaxLength = 100;
            this.txtBoxCadCompany.Name = "txtBoxCadCompany";
            this.txtBoxCadCompany.Size = new System.Drawing.Size(411, 32);
            this.txtBoxCadCompany.TabIndex = 44;
            this.txtBoxCadCompany.TextChanged += new System.EventHandler(this.txtBoxCadCompany_TextChanged);
            // 
            // btnCadCancel
            // 
            this.btnCadCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadCancel.Location = new System.Drawing.Point(471, 218);
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
            this.btnCadClear.Location = new System.Drawing.Point(328, 218);
            this.btnCadClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadClear.Name = "btnCadClear";
            this.btnCadClear.Size = new System.Drawing.Size(135, 48);
            this.btnCadClear.TabIndex = 48;
            this.btnCadClear.Text = "Limpar";
            this.btnCadClear.UseVisualStyleBackColor = true;
            this.btnCadClear.Click += new System.EventHandler(this.btnCadClear_Click);
            // 
            // btnCadCustRemove
            // 
            this.btnCadCustRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadCustRemove.Location = new System.Drawing.Point(185, 218);
            this.btnCadCustRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadCustRemove.Name = "btnCadCustRemove";
            this.btnCadCustRemove.Size = new System.Drawing.Size(135, 48);
            this.btnCadCustRemove.TabIndex = 47;
            this.btnCadCustRemove.Text = "Remover";
            this.btnCadCustRemove.UseVisualStyleBackColor = true;
            this.btnCadCustRemove.Click += new System.EventHandler(this.btnCadCustRemove_Click);
            // 
            // frmCustomerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 378);
            this.Controls.Add(this.btnCadCustRemove);
            this.Controls.Add(this.btnCadClear);
            this.Controls.Add(this.btnCadCancel);
            this.Controls.Add(this.txtBoxCadCompany);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.mskTxtBoxCadProject);
            this.Controls.Add(this.lblCustProject);
            this.Controls.Add(this.lblCustCompany);
            this.Controls.Add(this.lblCustBase);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCustomerRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCustomerRegistration";
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
        private System.Windows.Forms.Button btnCadCustRemove;
    }
}