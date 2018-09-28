namespace Belpre
{
    partial class frmMASTER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMASTER));
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.picAdmin = new System.Windows.Forms.PictureBox();
            this.lblIntro = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblOP = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.mskNascm = new System.Windows.Forms.MaskedTextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.mskCell = new System.Windows.Forms.MaskedTextBox();
            this.radMasc = new System.Windows.Forms.RadioButton();
            this.radFem = new System.Windows.Forms.RadioButton();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtSobren = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblCell = new System.Windows.Forms.Label();
            this.lblNascm = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblSobren = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.picReload = new System.Windows.Forms.PictureBox();
            this.tabAltPesq = new System.Windows.Forms.TabPage();
            this.tabAdmin.SuspendLayout();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).BeginInit();
            this.tabCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReload)).BeginInit();
            this.SuspendLayout();
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabHome);
            this.tabAdmin.Controls.Add(this.tabCadastro);
            this.tabAdmin.Controls.Add(this.tabConsulta);
            this.tabAdmin.Controls.Add(this.tabAltPesq);
            this.tabAdmin.Location = new System.Drawing.Point(13, 12);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(458, 450);
            this.tabAdmin.TabIndex = 20;
            this.tabAdmin.SelectedIndexChanged += new System.EventHandler(this.tabAdmin_SelectedIndexChanged);
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.lblConsulta);
            this.tabHome.Controls.Add(this.picAdmin);
            this.tabHome.Controls.Add(this.lblIntro);
            this.tabHome.Controls.Add(this.lblCadastro);
            this.tabHome.Controls.Add(this.lblOP);
            this.tabHome.Controls.Add(this.btnReturn);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(450, 424);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = " Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // lblConsulta
            // 
            this.lblConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.Location = new System.Drawing.Point(328, 191);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(100, 41);
            this.lblConsulta.TabIndex = 8;
            this.lblConsulta.Text = "Consulta de Médicos";
            this.lblConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConsulta.Click += new System.EventHandler(this.lblConsulta_Click);
            // 
            // picAdmin
            // 
            this.picAdmin.Image = ((System.Drawing.Image)(resources.GetObject("picAdmin.Image")));
            this.picAdmin.Location = new System.Drawing.Point(8, 56);
            this.picAdmin.Name = "picAdmin";
            this.picAdmin.Size = new System.Drawing.Size(301, 241);
            this.picAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdmin.TabIndex = 7;
            this.picAdmin.TabStop = false;
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.Location = new System.Drawing.Point(3, 3);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(435, 50);
            this.lblIntro.TabIndex = 6;
            this.lblIntro.Text = "Bem-vindo(a) à pagina de Administrador\r\n!";
            this.lblIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCadastro
            // 
            this.lblCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.Location = new System.Drawing.Point(328, 133);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(100, 41);
            this.lblCadastro.TabIndex = 5;
            this.lblCadastro.Text = "Cadastro de Médicos";
            this.lblCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCadastro.Click += new System.EventHandler(this.lblCadastro_Click);
            // 
            // lblOP
            // 
            this.lblOP.AutoSize = true;
            this.lblOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOP.Location = new System.Drawing.Point(339, 80);
            this.lblOP.Name = "lblOP";
            this.lblOP.Size = new System.Drawing.Size(89, 24);
            this.lblOP.TabIndex = 4;
            this.lblOP.Text = "Opções:";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(117, 346);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(210, 56);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "&Voltar ao Login";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.btnLimpar);
            this.tabCadastro.Controls.Add(this.btnCadastrar);
            this.tabCadastro.Controls.Add(this.mskNascm);
            this.tabCadastro.Controls.Add(this.txtSenha);
            this.tabCadastro.Controls.Add(this.mskCell);
            this.tabCadastro.Controls.Add(this.radMasc);
            this.tabCadastro.Controls.Add(this.radFem);
            this.tabCadastro.Controls.Add(this.mskCPF);
            this.tabCadastro.Controls.Add(this.txtSobren);
            this.tabCadastro.Controls.Add(this.txtNome);
            this.tabCadastro.Controls.Add(this.lblSenha);
            this.tabCadastro.Controls.Add(this.lblCell);
            this.tabCadastro.Controls.Add(this.lblNascm);
            this.tabCadastro.Controls.Add(this.lblSexo);
            this.tabCadastro.Controls.Add(this.lblCPF);
            this.tabCadastro.Controls.Add(this.lblSobren);
            this.tabCadastro.Controls.Add(this.lblNome);
            this.tabCadastro.Controls.Add(this.pictureBox2);
            this.tabCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(450, 424);
            this.tabCadastro.TabIndex = 1;
            this.tabCadastro.Text = "Cadastro";
            this.tabCadastro.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(234, 360);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(91, 33);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(123, 361);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(91, 32);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // mskNascm
            // 
            this.mskNascm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNascm.Location = new System.Drawing.Point(274, 217);
            this.mskNascm.Mask = "00/00/0000";
            this.mskNascm.Name = "mskNascm";
            this.mskNascm.Size = new System.Drawing.Size(100, 31);
            this.mskNascm.TabIndex = 6;
            this.mskNascm.ValidatingType = typeof(System.DateTime);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(274, 296);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(141, 31);
            this.txtSenha.TabIndex = 8;
            // 
            // mskCell
            // 
            this.mskCell.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCell.Location = new System.Drawing.Point(274, 255);
            this.mskCell.Mask = "(99) 00000-0000";
            this.mskCell.Name = "mskCell";
            this.mskCell.Size = new System.Drawing.Size(141, 31);
            this.mskCell.TabIndex = 7;
            // 
            // radMasc
            // 
            this.radMasc.AutoSize = true;
            this.radMasc.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMasc.Location = new System.Drawing.Point(281, 184);
            this.radMasc.Name = "radMasc";
            this.radMasc.Size = new System.Drawing.Size(89, 22);
            this.radMasc.TabIndex = 5;
            this.radMasc.Text = "&Masculino";
            this.radMasc.UseVisualStyleBackColor = true;
            // 
            // radFem
            // 
            this.radFem.AutoSize = true;
            this.radFem.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFem.Location = new System.Drawing.Point(281, 156);
            this.radFem.Name = "radFem";
            this.radFem.Size = new System.Drawing.Size(85, 22);
            this.radFem.TabIndex = 4;
            this.radFem.Text = "&Feminino";
            this.radFem.UseVisualStyleBackColor = true;
            // 
            // mskCPF
            // 
            this.mskCPF.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCPF.Location = new System.Drawing.Point(274, 117);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(141, 31);
            this.mskCPF.TabIndex = 3;
            this.mskCPF.ValidatingType = typeof(int);
            // 
            // txtSobren
            // 
            this.txtSobren.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobren.Location = new System.Drawing.Point(274, 72);
            this.txtSobren.Name = "txtSobren";
            this.txtSobren.Size = new System.Drawing.Size(141, 31);
            this.txtSobren.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(274, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(141, 31);
            this.txtNome.TabIndex = 1;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(199, 297);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(63, 23);
            this.lblSenha.TabIndex = 44;
            this.lblSenha.Text = "Senha:";
            // 
            // lblCell
            // 
            this.lblCell.AutoSize = true;
            this.lblCell.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCell.Location = new System.Drawing.Point(191, 258);
            this.lblCell.Name = "lblCell";
            this.lblCell.Size = new System.Drawing.Size(71, 23);
            this.lblCell.TabIndex = 43;
            this.lblCell.Text = "Celular:";
            // 
            // lblNascm
            // 
            this.lblNascm.AutoSize = true;
            this.lblNascm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascm.Location = new System.Drawing.Point(90, 220);
            this.lblNascm.Name = "lblNascm";
            this.lblNascm.Size = new System.Drawing.Size(172, 23);
            this.lblNascm.TabIndex = 42;
            this.lblNascm.Text = "Data de nascimento:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(209, 172);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(53, 23);
            this.lblSexo.TabIndex = 41;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(218, 121);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(44, 23);
            this.lblCPF.TabIndex = 40;
            this.lblCPF.Text = "CPF:";
            // 
            // lblSobren
            // 
            this.lblSobren.AutoSize = true;
            this.lblSobren.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobren.Location = new System.Drawing.Point(156, 75);
            this.lblSobren.Name = "lblSobren";
            this.lblSobren.Size = new System.Drawing.Size(106, 23);
            this.lblSobren.TabIndex = 39;
            this.lblSobren.Text = "Sobrenome:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(199, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(63, 23);
            this.lblNome.TabIndex = 38;
            this.lblNome.Text = "Nome:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(148, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.picReload);
            this.tabConsulta.Controls.Add(this.label1);
            this.tabConsulta.Controls.Add(this.dgvConsulta);
            this.tabConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Size = new System.Drawing.Size(450, 424);
            this.tabConsulta.TabIndex = 2;
            this.tabConsulta.Text = "Consulta Geral";
            this.tabConsulta.UseVisualStyleBackColor = true;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.AllowUserToOrderColumns = true;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(3, 3);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.Size = new System.Drawing.Size(444, 388);
            this.dgvConsulta.TabIndex = 0;
            this.dgvConsulta.DoubleClick += new System.EventHandler(this.dgvConsulta_DoubleClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Para mais informações, duplo clique na linha desejada";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picReload
            // 
            this.picReload.Image = ((System.Drawing.Image)(resources.GetObject("picReload.Image")));
            this.picReload.Location = new System.Drawing.Point(392, 394);
            this.picReload.Name = "picReload";
            this.picReload.Size = new System.Drawing.Size(55, 27);
            this.picReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReload.TabIndex = 7;
            this.picReload.TabStop = false;
            this.picReload.Click += new System.EventHandler(this.picReload_Click);
            // 
            // tabAltPesq
            // 
            this.tabAltPesq.Location = new System.Drawing.Point(4, 22);
            this.tabAltPesq.Name = "tabAltPesq";
            this.tabAltPesq.Size = new System.Drawing.Size(450, 424);
            this.tabAltPesq.TabIndex = 3;
            this.tabAltPesq.Text = "Alteração/Pesquisa";
            this.tabAltPesq.UseVisualStyleBackColor = true;
            // 
            // frmMASTER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 474);
            this.Controls.Add(this.tabAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMASTER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.tabAdmin.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).EndInit();
            this.tabCadastro.ResumeLayout(false);
            this.tabCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReload)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.MaskedTextBox mskNascm;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.MaskedTextBox mskCell;
        private System.Windows.Forms.RadioButton radMasc;
        private System.Windows.Forms.RadioButton radFem;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.TextBox txtSobren;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblCell;
        private System.Windows.Forms.Label lblNascm;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblSobren;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.PictureBox picAdmin;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label lblOP;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picReload;
        private System.Windows.Forms.TabPage tabAltPesq;
    }
}