namespace Belpre
{
    partial class frmDadosConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDadosConsulta));
            this.lblConsultaTitulo = new System.Windows.Forms.Label();
            this.lblDataTitulo = new System.Windows.Forms.Label();
            this.lblPacienteTitulo = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCPFTitulo = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblContatoTitulo = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblConsultaTitulo
            // 
            this.lblConsultaTitulo.AutoSize = true;
            this.lblConsultaTitulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblConsultaTitulo.Location = new System.Drawing.Point(104, 208);
            this.lblConsultaTitulo.Name = "lblConsultaTitulo";
            this.lblConsultaTitulo.Size = new System.Drawing.Size(108, 29);
            this.lblConsultaTitulo.TabIndex = 26;
            this.lblConsultaTitulo.Text = "Consulta:";
            // 
            // lblDataTitulo
            // 
            this.lblDataTitulo.AutoSize = true;
            this.lblDataTitulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataTitulo.Location = new System.Drawing.Point(19, 24);
            this.lblDataTitulo.Name = "lblDataTitulo";
            this.lblDataTitulo.Size = new System.Drawing.Size(190, 29);
            this.lblDataTitulo.TabIndex = 24;
            this.lblDataTitulo.Text = "Data da Consulta:";
            // 
            // lblPacienteTitulo
            // 
            this.lblPacienteTitulo.AutoSize = true;
            this.lblPacienteTitulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacienteTitulo.Location = new System.Drawing.Point(101, 93);
            this.lblPacienteTitulo.Name = "lblPacienteTitulo";
            this.lblPacienteTitulo.Size = new System.Drawing.Size(106, 29);
            this.lblPacienteTitulo.TabIndex = 23;
            this.lblPacienteTitulo.Text = "Paciente:";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblDia.Location = new System.Drawing.Point(237, 24);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(175, 29);
            this.lblDia.TabIndex = 35;
            this.lblDia.Text = "xx/xx/xx - aa:aah";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblPaciente.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblPaciente.Location = new System.Drawing.Point(240, 93);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(160, 29);
            this.lblPaciente.TabIndex = 36;
            this.lblPaciente.Text = "Fulano da silva";
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.Location = new System.Drawing.Point(235, 211);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(143, 26);
            this.lblConsulta.TabIndex = 37;
            this.lblConsulta.Text = "(convenio) Tipo";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(15, 278);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(457, 71);
            this.btnExit.TabIndex = 38;
            this.btnExit.Text = "Voltar";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCPFTitulo
            // 
            this.lblCPFTitulo.AutoSize = true;
            this.lblCPFTitulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFTitulo.Location = new System.Drawing.Point(125, 122);
            this.lblCPFTitulo.Name = "lblCPFTitulo";
            this.lblCPFTitulo.Size = new System.Drawing.Size(51, 23);
            this.lblCPFTitulo.TabIndex = 39;
            this.lblCPFTitulo.Text = "(CPF)";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(241, 122);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(148, 23);
            this.lblCPF.TabIndex = 40;
            this.lblCPF.Text = "(111.111.111-66)";
            // 
            // lblContatoTitulo
            // 
            this.lblContatoTitulo.AutoSize = true;
            this.lblContatoTitulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContatoTitulo.Location = new System.Drawing.Point(107, 145);
            this.lblContatoTitulo.Name = "lblContatoTitulo";
            this.lblContatoTitulo.Size = new System.Drawing.Size(85, 23);
            this.lblContatoTitulo.TabIndex = 41;
            this.lblContatoTitulo.Text = "(Contato)";
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContato.Location = new System.Drawing.Point(241, 145);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(142, 23);
            this.lblContato.TabIndex = 42;
            this.lblContato.Text = "(14 99999-9999)";
            // 
            // frmDadosConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.lblContatoTitulo);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblCPFTitulo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblConsultaTitulo);
            this.Controls.Add(this.lblDataTitulo);
            this.Controls.Add(this.lblPacienteTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDadosConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados da Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultaTitulo;
        private System.Windows.Forms.Label lblDataTitulo;
        private System.Windows.Forms.Label lblPacienteTitulo;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCPFTitulo;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblContatoTitulo;
        private System.Windows.Forms.Label lblContato;
    }
}